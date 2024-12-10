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
            checkBox1 = new CheckBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // logga
            // 
            logga.FormattingEnabled = true;
            logga.HorizontalScrollbar = true;
            logga.ItemHeight = 15;
            logga.Location = new Point(12, 141);
            logga.Name = "logga";
            logga.ScrollAlwaysVisible = true;
            logga.Size = new Size(633, 349);
            logga.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(196, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 25);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(268, 85);
            label1.Name = "label1";
            label1.Size = new Size(406, 25);
            label1.TabIndex = 3;
            label1.Text = "SET CURSOR POS --> THE LIVE BUTTON PLZ";
            // 
            // skinsListBox
            // 
            skinsListBox.DrawMode = DrawMode.OwnerDrawFixed;
            skinsListBox.FormattingEnabled = true;
            skinsListBox.Location = new Point(651, 141);
            skinsListBox.Name = "skinsListBox";
            skinsListBox.Size = new Size(328, 340);
            skinsListBox.TabIndex = 4;
            skinsListBox.MouseDoubleClick += skinsListBox_MouseDoubleClick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(196, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(730, 79);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 0, 192);
            label2.Location = new Point(196, 60);
            label2.Name = "label2";
            label2.Size = new Size(337, 25);
            label2.TabIndex = 6;
            label2.Text = "USE CHROME BROWSER & 7TV Plugin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(680, 98);
            label3.Name = "label3";
            label3.Size = new Size(205, 15);
            label3.TabIndex = 7;
            label3.Text = "Double click to remove skins streams!\r\n";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(54, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(538, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Check me before press start if you want to test all the streams, make sure the program is working ";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(-4, 113);
            label4.Name = "label4";
            label4.Size = new Size(1042, 25);
            label4.TabIndex = 9;
            label4.Text = "Before starting have a chrome browser open in fullscreen on the prefered monitor (dont have another stream open)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 505);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(skinsListBox);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(logga);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "FARM ALL SKINS";
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
        private CheckBox checkBox1;
        private Label label4;
    }
}
