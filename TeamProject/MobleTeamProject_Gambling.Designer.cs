using System.Collections.Generic;

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
        /// 
        private void InitializeWeapons()
        {

            WeaponUpgrade lv0 = new WeaponUpgrade() //0번 무기 속성
            {
                Level = 0,
                Name = "Black",
                Attack = 0,
                SellPrice = 0,
            };
            weaponsDictionary.Add(0, lv0);

            WeaponUpgrade lv1 = new WeaponUpgrade() //1번 무기 속성
            {
                Level = 1,
                Name = "Red",
                Attack = 1,
                SellPrice = 1,
            };
            weaponsDictionary.Add(1, lv1);

            WeaponUpgrade lv2 = new WeaponUpgrade() //2번 무기 속성
            {
                Level = 2,
                Name = "Blue",
                Attack = 2,
                SellPrice = 2,
            };
            weaponsDictionary.Add(2, lv2);

            WeaponUpgrade lv3 = new WeaponUpgrade() //3번 무기 속성
            {
                Level = 3,
                Name = "Red",
                Attack = 3,
                SellPrice = 3,
            };
            weaponsDictionary.Add(3, lv3);

            WeaponUpgrade lv4 = new WeaponUpgrade() //4번 무기 속성
            {
                Level = 4,
                Name = "Red",
                Attack = 4,
                SellPrice = 4,
            };
            weaponsDictionary.Add(4, lv4);

            WeaponUpgrade lv5 = new WeaponUpgrade() //5번 무기 속성
            {
                Level = 5,
                Name = "Red",
                Attack = 5,
                SellPrice = 5,
            };
            weaponsDictionary.Add(5, lv5);

            WeaponUpgrade lv6 = new WeaponUpgrade() //6번 무기 속성
            {
                Level = 6,
                Name = "Red",
                Attack = 6,
                SellPrice = 6,
            };
            weaponsDictionary.Add(6, lv6);

            WeaponUpgrade lv7 = new WeaponUpgrade() //7번 무기 속성
            {
                Level = 7,
                Name = "Red",
                Attack = 7,
                SellPrice = 7,
            };
            weaponsDictionary.Add(7, lv7);

            WeaponUpgrade lv8 = new WeaponUpgrade() //8번 무기 속성
            {
                Level = 8,
                Name = "Red",
                Attack = 8,
                SellPrice = 8,
            };
            weaponsDictionary.Add(8, lv8);

            WeaponUpgrade lv9 = new WeaponUpgrade() //9번 무기 속성
            {
                Level = 9,
                Name = "Red",
                Attack = 9,
                SellPrice = 9,
            };
            weaponsDictionary.Add(9, lv9);

            WeaponUpgrade lv10 = new WeaponUpgrade() //10번 무기 속성
            {
                Level = 10,
                Name = "Red",
                Attack = 10,
                SellPrice = 10,
            };
            weaponsDictionary.Add(10, lv10);

        }
        private void InitializeComponent()
        {
            lbox_Chat = new System.Windows.Forms.ListBox();
            panel_Upgrade = new System.Windows.Forms.Panel();
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
            pbBuildHP = new System.Windows.Forms.ProgressBar();
            panel6 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel3 = new System.Windows.Forms.Panel();
            tabPage3 = new System.Windows.Forms.TabPage();
            panel_Upgrade.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            // panel_Upgrade
            // 
            panel_Upgrade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel_Upgrade.Controls.Add(label1);
            panel_Upgrade.Location = new System.Drawing.Point(15, 61);
            panel_Upgrade.Name = "panel_Upgrade";
            panel_Upgrade.Size = new System.Drawing.Size(848, 241);
            panel_Upgrade.TabIndex = 1;
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
            panel_Main.Location = new System.Drawing.Point(51, 288);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new System.Drawing.Size(631, 384);
            panel_Main.TabIndex = 3;
            panel_Main.Click += panel_Main_Click_1;
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
            tabPage1.Controls.Add(panel_Upgrade);
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
            tabPage2.Controls.Add(pbBuildHP);
            tabPage2.Controls.Add(panel6);
            tabPage2.Controls.Add(panel5);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(875, 835);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbBuildHP
            // 
            pbBuildHP.Location = new System.Drawing.Point(200, 576);
            pbBuildHP.Name = "pbBuildHP";
            pbBuildHP.Size = new System.Drawing.Size(500, 45);
            pbBuildHP.TabIndex = 4;
            pbBuildHP.Value = 100;
            // 
            // panel6
            // 
            panel6.BackColor = System.Drawing.Color.Gray;
            panel6.Location = new System.Drawing.Point(706, 338);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(50, 50);
            panel6.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.Gray;
            panel5.Location = new System.Drawing.Point(144, 338);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(50, 50);
            panel5.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.Gray;
            panel4.Location = new System.Drawing.Point(424, 114);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(50, 50);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new System.Drawing.Point(200, 170);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(500, 386);
            panel3.TabIndex = 0;
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
            panel_Upgrade.ResumeLayout(false);
            panel_Upgrade.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lbox_Chat;
        private System.Windows.Forms.Panel panel_Upgrade;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ProgressBar pbBuildHP;
    }
}