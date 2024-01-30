namespace TeamProject
{
    partial class MobleTeamProject_Gambling
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
            lbox_Chat = new System.Windows.Forms.ListBox();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            panel_Main = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            lb_Money = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            btn_Test2 = new System.Windows.Forms.Button();
            btn_Test = new System.Windows.Forms.Button();
            tabPage2 = new System.Windows.Forms.TabPage();
            tabPage3 = new System.Windows.Forms.TabPage();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // lbox_Chat
            // 
            lbox_Chat.Font = new System.Drawing.Font("바탕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbox_Chat.FormattingEnabled = true;
            lbox_Chat.ItemHeight = 16;
            lbox_Chat.Location = new System.Drawing.Point(7, 708);
            lbox_Chat.Name = "lbox_Chat";
            lbox_Chat.Size = new System.Drawing.Size(379, 116);
            lbox_Chat.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(15, 61);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(848, 241);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(395, 112);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "강화소";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            panel2.Controls.Add(label2);
            panel2.Location = new System.Drawing.Point(670, 317);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(193, 512);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(70, 203);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "일터";
            // 
            // panel_Main
            // 
            panel_Main.Location = new System.Drawing.Point(45, 353);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new System.Drawing.Size(588, 319);
            panel_Main.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(628, 32);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 15);
            label3.TabIndex = 0;
            label3.Text = "보유 돈 :";
            // 
            // lb_Money
            // 
            lb_Money.AutoSize = true;
            lb_Money.Location = new System.Drawing.Point(688, 32);
            lb_Money.Name = "lb_Money";
            lb_Money.Size = new System.Drawing.Size(59, 15);
            lb_Money.TabIndex = 0;
            lb_Money.Text = "lb_Money";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new System.Drawing.Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(883, 863);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_Test2);
            tabPage1.Controls.Add(btn_Test);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(lbox_Chat);
            tabPage1.Controls.Add(panel_Main);
            tabPage1.Controls.Add(lb_Money);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(875, 835);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "강화소";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Test2
            // 
            btn_Test2.Location = new System.Drawing.Point(487, 762);
            btn_Test2.Name = "btn_Test2";
            btn_Test2.Size = new System.Drawing.Size(119, 23);
            btn_Test2.TabIndex = 4;
            btn_Test2.Text = "1강 5개구매";
            btn_Test2.UseVisualStyleBackColor = true;
            btn_Test2.Click += btn_Test2_Click;
            // 
            // btn_Test
            // 
            btn_Test.Location = new System.Drawing.Point(487, 717);
            btn_Test.Name = "btn_Test";
            btn_Test.Size = new System.Drawing.Size(111, 23);
            btn_Test.TabIndex = 0;
            btn_Test.Text = "0강 5개구매";
            btn_Test.UseVisualStyleBackColor = true;
            btn_Test.Click += btn_Test_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(875, 835);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(875, 835);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // MobleTeamProject_Gambling
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(884, 861);
            Controls.Add(tabControl1);
            Name = "MobleTeamProject_Gambling";
            Text = "MobleTeamProject_Gambling";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lbox_Chat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Money;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button btn_Test2;
    }
}