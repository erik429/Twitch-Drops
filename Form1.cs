using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Twitch_Drops
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, string> skinStatuses = new();
        private readonly List<StreamInfo> streams = new List<StreamInfo>
        {
            new StreamInfo("https://www.twitch.tv/riqqeloff", "MP5A4", new List<string> { "https://www.twitch.tv/Oilrats" }),
            new StreamInfo("https://www.twitch.tv/xXxTheFocuSxXx", "Sheet Metal Double Door", new List<string> { "https://www.twitch.tv/s3kox" }),
            new StreamInfo("https://www.twitch.tv/Willjum", "Jacket", new List<string> { "https://www.twitch.tv/SinksR" }),
            new StreamInfo("https://www.twitch.tv/NoraExplorer", "Garage Door", new List<string> { "https://www.twitch.tv/CoconutB" }),
            new StreamInfo("https://www.twitch.tv/Nikof", "Assault Rifle", new List<string> { "https://www.twitch.tv/ElMamene" }),
            new StreamInfo("https://www.twitch.tv/Mendo", "Rocket Launcher", new List<string> { "https://www.twitch.tv/deathwingua" }),
            new StreamInfo("https://www.twitch.tv/Krolay", "Sheet Metal Door", new List<string> { "https://www.twitch.tv/JLFranklin_" }),
            new StreamInfo("https://www.twitch.tv/dilanzito", "Thompson", new List<string> { "https://www.twitch.tv/IsLautaARG00" }),
            new StreamInfo("https://www.twitch.tv/Dhalucard", "Semi-Automatic Pistol", new List<string> { "https://www.twitch.tv/CaptainMyko" }),
            new StreamInfo("https://www.twitch.tv/Blooprint", "Vending Machine", new List<string> { "https://www.twitch.tv/hJune" }),
            new StreamInfo("https://www.twitch.tv/TwitchRivals", "Special Event Item", new List<string>())
        };

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var startButton = new Button
            {
                Text = "Start Watching",
                Width = 150,
                Height = 40,
                Top = 20,
                Left = 20
            };
            startButton.Click += StartWatching;
            Controls.Add(startButton);

            var setCoordinatesButton = new Button
            {
                Text = "Set Coordinates (click to set)",
                Width = 150,
                Height = 40,
                Top = 70,
                Left = 20
            };
            setCoordinatesButton.Click += SetCoordinates;
            Controls.Add(setCoordinatesButton);
            skinsListBox.DrawMode = DrawMode.OwnerDrawFixed;
            skinsListBox.DrawItem += skinsListBox_DrawItem;
            foreach (var stream in streams)
            {
                skinsListBox.Items.Add(stream.Description);
                skinStatuses[stream.Description] = "Not Watched";
            }
        }

        private async void StartWatching(object sender, EventArgs e)
        {
            Button startButton = sender as Button;
            startButton.Enabled = false;

            foreach (var stream in streams)
            {
                TimeSpan watchTime;
                if (checkBox1.Checked == true)
                {
                    watchTime = TimeSpan.FromSeconds(15);
                }
                else
                {
                    watchTime = stream.Description == "Special Event Item"
                        ? TimeSpan.FromMinutes(241)
                        : TimeSpan.FromMinutes(121);
                }

                bool watched = await TryWatchStream(stream, watchTime);
                if (!watched)
                {
                    LogMessage($"Stream offline or unavailable: {stream.Description}");
                }
            }

            LogMessage("Finished watching all streams.");
            startButton.Enabled = true;
        }

        private void skinsListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            string skin = skinsListBox.Items[e.Index].ToString();
            string status = skinStatuses.ContainsKey(skin) ? skinStatuses[skin] : "Not Watched";

            Color textColor = status switch
            {
                "Watched" => Color.Green,
                "Offline" => Color.Red,
                _ => Color.Gray
            };

            e.DrawBackground();
            using (var brush = new SolidBrush(textColor))
            {
                e.Graphics.DrawString(skin, e.Font, brush, e.Bounds);
            }
            e.DrawFocusRectangle();
        }
        private async Task<bool> TryWatchStream(StreamInfo streamInfo, TimeSpan watchTime)
        {
            LogMessage($"Trying to watch stream: {streamInfo.Description}");

            OpenInChrome(streamInfo.Url);

            await Task.Delay(11000);

            if (IsStreamLive())
            {
                LogMessage($"Stream is live: {streamInfo.Description}. Watching now for {watchTime.TotalMinutes} minutes.");
                skinStatuses[streamInfo.Description] = "Watched";
                skinsListBox.Refresh();
                await Task.Delay(watchTime);
                CloseBrowser();
                LogMessage($"Finished watching {streamInfo.Description}.");
                return true;
            }

            foreach (var alternateUrl in streamInfo.BackupUrls)
            {
                LogMessage($"STREAM OFFLINE... trying alternate URL for {streamInfo.Description}: {alternateUrl}");
                CloseBrowser();
                OpenInChrome(alternateUrl);

                await Task.Delay(11000);

                if (IsStreamLive())
                {
                    LogMessage($"Alternate stream is live: {streamInfo.Description}. Watching now for {watchTime.TotalMinutes} minutes.");
                    skinStatuses[streamInfo.Description] = "Watched";
                    skinsListBox.Refresh();
                    await Task.Delay(watchTime);
                    CloseBrowser();
                    LogMessage($"Finished watching {streamInfo.Description}.");
                    return true;
                }
            }

            LogMessage($"Stream offline: {streamInfo.Description}");
            skinStatuses[streamInfo.Description] = "Offline";
            skinsListBox.Refresh();
            CloseBrowser();
            return false;
        }
        private bool IsStreamLive()
        {
            int x = Properties.Settings.Default.LiveIndicatorX;
            int y = Properties.Settings.Default.LiveIndicatorY;

            int savedR = Properties.Settings.Default.LiveIndicatorR;
            int savedG = Properties.Settings.Default.LiveIndicatorG;
            int savedB = Properties.Settings.Default.LiveIndicatorB;

            LogMessage($"Checking stream live status at X={x}, Y={y}");
            LogMessage($"Saved Color: R={savedR}, G={savedG}, B={savedB}");
            for (int dx = -2; dx <= 2; dx++)
            {
                for (int dy = -2; dy <= 2; dy++)
                {
                    Color currentColor = GetColorAt(x + dx, y + dy);

                    //LogMessage($"Current Color at ({x + dx}, {y + dy}): R={currentColor.R}, G={currentColor.G}, B={currentColor.B}");

                    if (currentColor.R == savedR && currentColor.G == savedG && currentColor.B == savedB)
                    {
                        LogMessage("Stream is live!");
                        return true;
                    }
                }
            }

            LogMessage("Stream is offline.");
            return false;
        }

        private Color GetColorAt(int x, int y)
        {
            Bitmap screenPixel = new Bitmap(1, 1);
            using (Graphics g = Graphics.FromImage(screenPixel))
            {
                g.CopyFromScreen(x, y, 0, 0, new Size(1, 1));
            }
            return screenPixel.GetPixel(0, 0);
        }

        private void OpenInChrome(string url)
        {
            string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = chromePath,
                    Arguments = url,
                    UseShellExecute = true
                });
                LogMessage($"Opened Chrome with URL: {url}");
            }
            catch (Exception ex)
            {
                LogMessage($"Failed to open Chrome: {ex.Message}");
            }
        }

        private void CloseBrowser()
        {
            foreach (var process in Process.GetProcessesByName("chrome"))
            {
                process.Kill();
            }
        }

        private async void SetCoordinates(object sender, EventArgs e)
        {
            LogMessage("CLICK THE LIVE STREAM BUTTON (CLICK THE RED PART OF THE LIVE BUTTON)!!!...");

            this.Hide();
            await Task.Delay(100);

            var coordinates = CaptureMouseClick();

            if (coordinates != null)
            {

                Color pixelColor = GetColorAt(coordinates.Value.X, coordinates.Value.Y);
                Properties.Settings.Default.LiveIndicatorX = coordinates.Value.X;
                Properties.Settings.Default.LiveIndicatorY = coordinates.Value.Y;
                Properties.Settings.Default.LiveIndicatorR = pixelColor.R;
                Properties.Settings.Default.LiveIndicatorG = pixelColor.G;
                Properties.Settings.Default.LiveIndicatorB = pixelColor.B;
                Properties.Settings.Default.Save();
                LogMessage($"Coordinates set: X={coordinates.Value.X}, Y={coordinates.Value.Y}");
                LogMessage($"Color at coordinates: R={pixelColor.R}, G={pixelColor.G}, B={pixelColor.B}");
                this.Show();
            }

            this.Show();
        }

        private Point? CaptureMouseClick()
        {
            Point? clickPosition = null;

            using (var form = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.Black,
                Opacity = 0.01,
                WindowState = FormWindowState.Maximized,
                TopMost = true
            })
            {
                form.MouseClick += (sender, e) =>
                {
                    clickPosition = Cursor.Position;
                    form.Close();
                };

                form.ShowDialog();
            }

            return clickPosition;
        }

        private void LogMessage(string message)
        {
            logga.Items.Add($"{DateTime.Now:HH:mm:ss} - {message}");
            logga.TopIndex = logga.Items.Count - 1;
        }

        public class StreamInfo
        {
            public string Url { get; set; }
            public string Description { get; set; }
            public List<string> BackupUrls { get; set; }

            public StreamInfo(string url, string description, List<string> backupUrls)
            {
                Url = url;
                Description = description;
                BackupUrls = backupUrls;
            }
        }
        private bool IsColorMatch(Color color1, Color color2, int tolerance = 10)
        {
            return Math.Abs(color1.R - color2.R) <= tolerance &&
                   Math.Abs(color1.G - color2.G) <= tolerance &&
                   Math.Abs(color1.B - color2.B) <= tolerance;
        }
        private void skinsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = skinsListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                string selectedItem = skinsListBox.Items[index].ToString();
                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to remove '{selectedItem}' from the list?",
                    "Confirm Removal",
                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    streams.RemoveAll(stream => stream.Description == selectedItem);
                    skinStatuses.Remove(selectedItem);
                    skinsListBox.Items.RemoveAt(index);
                    LogMessage($"Removed '{selectedItem}' from the list.");
                }
            }
        }
    }
}
