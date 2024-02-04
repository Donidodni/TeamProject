namespace TeamProject
{
    partial class main_screen_info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            Main_info_panel = new System.Windows.Forms.Panel();
            lb_info2 = new System.Windows.Forms.Label();
            lb_info1 = new System.Windows.Forms.Label();
            lb_info3 = new System.Windows.Forms.Label();
            lb_info4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Main_info_panel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.main_screen_info;
            pictureBox1.Location = new System.Drawing.Point(352, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(401, 293);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Transparent;
            button1.BackgroundImage = Properties.Resources.message;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(645, 228);
            button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(240, 53);
            button1.TabIndex = 1;
            button1.Text = "돌아가기";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Main_info_panel
            // 
            Main_info_panel.BackgroundImage = Properties.Resources.message_memo;
            Main_info_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Main_info_panel.Controls.Add(lb_info2);
            Main_info_panel.Controls.Add(button1);
            Main_info_panel.Controls.Add(lb_info1);
            Main_info_panel.Controls.Add(lb_info3);
            Main_info_panel.Controls.Add(lb_info4);
            Main_info_panel.Location = new System.Drawing.Point(101, 315);
            Main_info_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Main_info_panel.Name = "Main_info_panel";
            Main_info_panel.Size = new System.Drawing.Size(917, 307);
            Main_info_panel.TabIndex = 2;
            // 
            // lb_info2
            // 
            lb_info2.AutoSize = true;
            lb_info2.BackColor = System.Drawing.Color.Transparent;
            lb_info2.Font = new System.Drawing.Font("Galmuri11 Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_info2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lb_info2.Location = new System.Drawing.Point(26, 104);
            lb_info2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_info2.Name = "lb_info2";
            lb_info2.Size = new System.Drawing.Size(705, 38);
            lb_info2.TabIndex = 3;
            lb_info2.Text = "마을의 주민들을 사고 팔아 전설의 용사로 거듭나도록";
            // 
            // lb_info1
            // 
            lb_info1.AutoSize = true;
            lb_info1.BackColor = System.Drawing.Color.Transparent;
            lb_info1.Font = new System.Drawing.Font("Galmuri11 Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_info1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lb_info1.Location = new System.Drawing.Point(26, 44);
            lb_info1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_info1.Name = "lb_info1";
            lb_info1.Size = new System.Drawing.Size(887, 38);
            lb_info1.TabIndex = 4;
            lb_info1.Text = "당신은 한 마을의 촌장이며, 마을에 전설의 용사가 있었으면 합니다.";
            // 
            // lb_info3
            // 
            lb_info3.AutoSize = true;
            lb_info3.BackColor = System.Drawing.Color.Transparent;
            lb_info3.Font = new System.Drawing.Font("Galmuri11 Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_info3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lb_info3.Location = new System.Drawing.Point(26, 164);
            lb_info3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_info3.Name = "lb_info3";
            lb_info3.Size = new System.Drawing.Size(417, 38);
            lb_info3.TabIndex = 6;
            lb_info3.Text = "던전을 보내 기사로 강화시키고";
            // 
            // lb_info4
            // 
            lb_info4.AutoSize = true;
            lb_info4.BackColor = System.Drawing.Color.Transparent;
            lb_info4.Font = new System.Drawing.Font("Galmuri11 Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_info4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            lb_info4.Location = new System.Drawing.Point(26, 224);
            lb_info4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_info4.Name = "lb_info4";
            lb_info4.Size = new System.Drawing.Size(466, 38);
            lb_info4.TabIndex = 5;
            lb_info4.Text = "광산으로 보내 필요한 돈을 버세요!";
            // 
            // main_screen_info
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(1157, 667);
            Controls.Add(Main_info_panel);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "main_screen_info";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "main_screen_info";
            Load += main_screen_info_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Main_info_panel.ResumeLayout(false);
            Main_info_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Main_info_panel;
        private System.Windows.Forms.Label lb_info2;
        private System.Windows.Forms.Label lb_info1;
        private System.Windows.Forms.Label lb_info3;
        private System.Windows.Forms.Label lb_info4;
    }
}