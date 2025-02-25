namespace Twitch_Drops
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            logga = new ListBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            skinsListBox = new ListBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // logga
            // 
            logga.FormattingEnabled = true;
            logga.HorizontalScrollbar = true;
            logga.ItemHeight = 15;
            logga.Location = new Point(12, 210);
            logga.Name = "logga";
            logga.ScrollAlwaysVisible = true;
            logga.Size = new Size(633, 424);
            logga.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(237, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 49);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(583, 125);
            label1.Name = "label1";
            label1.Size = new Size(486, 25);
            label1.TabIndex = 3;
            label1.Text = "After SET CORDS don't change the window size";
            // 
            // skinsListBox
            // 
            skinsListBox.DrawMode = DrawMode.OwnerDrawFixed;
            skinsListBox.FormattingEnabled = true;
            skinsListBox.Location = new Point(662, 210);
            skinsListBox.Name = "skinsListBox";
            skinsListBox.Size = new Size(391, 420);
            skinsListBox.TabIndex = 4;
            skinsListBox.MouseDoubleClick += skinsListBox_MouseDoubleClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Cursor = Cursors.IBeam;
            pictureBox2.Location = new Point(1, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1086, 77);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(192, 0, 192);
            label2.Location = new Point(583, 100);
            label2.Name = "label2";
            label2.Size = new Size(486, 25);
            label2.TabIndex = 6;
            label2.Text = "USE CHROME BROWSER 7TV Plugin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(712, 192);
            label3.Name = "label3";
            label3.Size = new Size(205, 15);
            label3.TabIndex = 7;
            label3.Text = "Double click to remove skins streams!\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(40, 115);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Fuchsia;
            label5.Location = new Point(12, 192);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 10;
            label5.Text = "LOGS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Fuchsia;
            label6.Location = new Point(662, 193);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 11;
            label6.Text = "SKINS";
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.MediumTurquoise;
            label7.Location = new Point(583, 75);
            label7.Name = "label7";
            label7.Size = new Size(486, 25);
            label7.TabIndex = 12;
            label7.Text = "AFK after start";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 170);
            button1.Name = "button1";
            button1.Size = new Size(219, 37);
            button1.TabIndex = 13;
            button1.Text = "3. START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 115);
            button2.Name = "button2";
            button2.Size = new Size(219, 49);
            button2.TabIndex = 14;
            button2.Text = "2. SET CORDS \r\nLIVE BUTTON (click to set)\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 76);
            button3.Name = "button3";
            button3.Size = new Size(219, 29);
            button3.TabIndex = 15;
            button3.Text = "1. FETCH TWITCH DROPS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(254, 170);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 16;
            button4.Text = "Help";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 664);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(skinsListBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(logga);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "FARM ALL SKINS while sleep";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox logga;
        private PictureBox pictureBox1;
        private Label label1;
        private ListBox skinsListBox;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
