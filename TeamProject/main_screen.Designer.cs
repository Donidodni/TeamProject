namespace WinFormsApp2
{
    partial class main_screen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_screen));
            Main_Title = new System.Windows.Forms.Timer(components);
            pictureBox2 = new System.Windows.Forms.PictureBox();
            imageList1 = new System.Windows.Forms.ImageList(components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            panel3 = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            game_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Main_Title
            // 
            Main_Title.Interval = 18;
            Main_Title.Tick += Main_Title_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(345, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(646, 218);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "opening1.gif");
            imageList1.Images.SetKeyName(1, "opening_sword.png");
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(24, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(115, 240);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.BackgroundImage = TeamProject.Properties.Resources.message;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.Transparent;
            button1.Location = new System.Drawing.Point(209, 334);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(209, 56);
            button1.TabIndex = 6;
            button1.Text = "시작하기";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseMove += button1_MouseMove;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(88, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(115, 240);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new System.Drawing.Point(0, 110);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(903, 210);
            panel3.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.BackgroundImage = TeamProject.Properties.Resources.message;
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.Transparent;
            button2.Location = new System.Drawing.Point(485, 334);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(209, 56);
            button2.TabIndex = 6;
            button2.Text = "게임방법";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseHover += button2_MouseHover;
            // 
            // game_exit
            // 
            game_exit.BackColor = System.Drawing.Color.Transparent;
            game_exit.BackgroundImage = TeamProject.Properties.Resources.exit;
            game_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            game_exit.FlatAppearance.BorderSize = 0;
            game_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            game_exit.Location = new System.Drawing.Point(823, 12);
            game_exit.Name = "game_exit";
            game_exit.Size = new System.Drawing.Size(65, 60);
            game_exit.TabIndex = 9;
            game_exit.UseVisualStyleBackColor = false;
            game_exit.Click += game_exit_Click;
            // 
            // main_screen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            BackgroundImage = TeamProject.Properties.Resources.mine_map;
            ClientSize = new System.Drawing.Size(900, 500);
            Controls.Add(game_exit);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "main_screen";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer Main_Title;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button game_exit;
    }
}
