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
            imageList1 = new System.Windows.Forms.ImageList(components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            panel3 = new System.Windows.Forms.Panel();
            main_panel = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            game_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            main_panel.SuspendLayout();
            SuspendLayout();
            // 
            // Main_Title
            // 
            Main_Title.Interval = 18;
            Main_Title.Tick += Main_Title_Tick;
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
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(-33, -10);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(340, 357);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            button1.Font = new System.Drawing.Font("Galmuri11 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.Transparent;
            button1.Location = new System.Drawing.Point(269, 445);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(269, 75);
            button1.TabIndex = 6;
            button1.Text = "시작하기";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseMove += button1_MouseMove;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(51, -10);
            pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(340, 357);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(main_panel);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new System.Drawing.Point(0, 147);
            panel3.Margin = new System.Windows.Forms.Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(1161, 280);
            panel3.TabIndex = 7;
            // 
            // main_panel
            // 
            main_panel.Controls.Add(label2);
            main_panel.Controls.Add(label1);
            main_panel.Location = new System.Drawing.Point(479, 23);
            main_panel.Name = "main_panel";
            main_panel.Size = new System.Drawing.Size(865, 238);
            main_panel.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Galmuri11 Bold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(60, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(717, 160);
            label2.TabIndex = 6;
            label2.Text = "용사 키우기";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Galmuri11 Regular", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(95, 147);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(609, 80);
            label1.TabIndex = 6;
            label1.Text = ": 황금 용사가 필요해";
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.BackgroundImage = TeamProject.Properties.Resources.message;
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Galmuri11 Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.Transparent;
            button2.Location = new System.Drawing.Point(624, 445);
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(269, 75);
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
            game_exit.Location = new System.Drawing.Point(1058, 16);
            game_exit.Margin = new System.Windows.Forms.Padding(4);
            game_exit.Name = "game_exit";
            game_exit.Size = new System.Drawing.Size(84, 80);
            game_exit.TabIndex = 9;
            game_exit.UseVisualStyleBackColor = false;
            game_exit.Click += game_exit_Click;
            // 
            // main_screen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            BackgroundImage = TeamProject.Properties.Resources.mine_map;
            ClientSize = new System.Drawing.Size(1157, 667);
            Controls.Add(game_exit);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "main_screen";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer Main_Title;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button game_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel main_panel;
    }
}
