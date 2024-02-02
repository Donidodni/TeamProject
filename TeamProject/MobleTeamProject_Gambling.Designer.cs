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
                Name = "하급 농부",
                Attack = 0,
                SellPrice = 10,
            };
            weaponsDictionary.Add(0, lv0);

            WeaponUpgrade lv1 = new WeaponUpgrade() //1번 무기 속성
            {
                Level = 1,
                Name = "상급 농부",
                Attack = 1,
                SellPrice = 12,
            };
            weaponsDictionary.Add(1, lv1);

            WeaponUpgrade lv2 = new WeaponUpgrade() //2번 무기 속성
            {
                Level = 2,
                Name = "하급 일꾼",
                Attack = 2,
                SellPrice = 20,
            };
            weaponsDictionary.Add(2, lv2);

            WeaponUpgrade lv3 = new WeaponUpgrade() //3번 무기 속성
            {
                Level = 3,
                Name = "상급 일꾼",
                Attack = 5,
                SellPrice = 30,
            };
            weaponsDictionary.Add(3, lv3);

            WeaponUpgrade lv4 = new WeaponUpgrade() //4번 무기 속성
            {
                Level = 4,
                Name = "일반 군인",
                Attack = 12,
                SellPrice = 50,
            };
            weaponsDictionary.Add(4, lv4);

            WeaponUpgrade lv5 = new WeaponUpgrade() //5번 무기 속성
            {
                Level = 5,
                Name = "측근 군인",
                Attack = 35,
                SellPrice = 300,
            };
            weaponsDictionary.Add(5, lv5);

            WeaponUpgrade lv6 = new WeaponUpgrade() //6번 무기 속성
            {
                Level = 6,
                Name = "기사",
                Attack = 170,
                SellPrice = 700,
            };
            weaponsDictionary.Add(6, lv6);

            WeaponUpgrade lv7 = new WeaponUpgrade() //7번 무기 속성
            {
                Level = 7,
                Name = "신입 용사",
                Attack = 800,
                SellPrice = 2000,
            };
            weaponsDictionary.Add(7, lv7);

            WeaponUpgrade lv8 = new WeaponUpgrade() //8번 무기 속성
            {
                Level = 8,
                Name = "중급 용사",
                Attack = 6000,
                SellPrice = 5000,
            };
            weaponsDictionary.Add(8, lv8);

            WeaponUpgrade lv9 = new WeaponUpgrade() //9번 무기 속성
            {
                Level = 9,
                Name = "베테랑 용사",
                Attack = 99999,
                SellPrice = 100000,
            };
            weaponsDictionary.Add(9, lv9);

            WeaponUpgrade lv10 = new WeaponUpgrade() //10번 무기 속성
            {
                Level = 10,
                Name = "전설 용사",
                Attack = 10,
                SellPrice = 10,
            };
            weaponsDictionary.Add(10, lv10);

        }

        private void InitializeWeaponsList()
        {
            for (int i = 0; i < 11; i++)
            {
                List<WeaponUpgrade> weaponUpgrades = new List<WeaponUpgrade>();
                weapons.Add(weaponUpgrades); // 0~10강 무기를 담을 리스트 생성
            }
        }
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MobleTeamProject_Gambling));
            lbox_Chat_tab1 = new System.Windows.Forms.ListBox();
            panel_Upgrade = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            flowLayoutPanel2 = new System.Windows.Forms.Panel();
            panel14 = new System.Windows.Forms.Panel();
            pictureBox12 = new System.Windows.Forms.PictureBox();
            label18 = new System.Windows.Forms.Label();
            lb_Puls_8_Count = new System.Windows.Forms.Label();
            lb_Allview8 = new System.Windows.Forms.Label();
            panel13 = new System.Windows.Forms.Panel();
            pictureBox11 = new System.Windows.Forms.PictureBox();
            label17 = new System.Windows.Forms.Label();
            lb_Allview7 = new System.Windows.Forms.Label();
            lb_Puls_7_Count = new System.Windows.Forms.Label();
            panel12 = new System.Windows.Forms.Panel();
            pictureBox10 = new System.Windows.Forms.PictureBox();
            label16 = new System.Windows.Forms.Label();
            lb_Allview6 = new System.Windows.Forms.Label();
            lb_Puls_6_Count = new System.Windows.Forms.Label();
            panel11 = new System.Windows.Forms.Panel();
            pictureBox9 = new System.Windows.Forms.PictureBox();
            label15 = new System.Windows.Forms.Label();
            lb_Allview5 = new System.Windows.Forms.Label();
            lb_Puls_5_Count = new System.Windows.Forms.Label();
            panel10 = new System.Windows.Forms.Panel();
            pictureBox8 = new System.Windows.Forms.PictureBox();
            label14 = new System.Windows.Forms.Label();
            lb_Allview4 = new System.Windows.Forms.Label();
            lb_Puls_4_Count = new System.Windows.Forms.Label();
            panel9 = new System.Windows.Forms.Panel();
            pictureBox7 = new System.Windows.Forms.PictureBox();
            label13 = new System.Windows.Forms.Label();
            lb_Allview3 = new System.Windows.Forms.Label();
            lb_Puls_3_Count = new System.Windows.Forms.Label();
            panel8 = new System.Windows.Forms.Panel();
            pictureBox6 = new System.Windows.Forms.PictureBox();
            label12 = new System.Windows.Forms.Label();
            lb_Allview2 = new System.Windows.Forms.Label();
            lb_Puls_2_Count = new System.Windows.Forms.Label();
            panel7 = new System.Windows.Forms.Panel();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            label11 = new System.Windows.Forms.Label();
            lb_Puls_1_Count = new System.Windows.Forms.Label();
            lb_Allview1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            lb_Allview = new System.Windows.Forms.Label();
            lb_Puls_0_Count = new System.Windows.Forms.Label();
            btn_Refresh = new System.Windows.Forms.Button();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btn_All0 = new System.Windows.Forms.Button();
            characters = new System.Windows.Forms.ImageList(components);
            btn_All1 = new System.Windows.Forms.Button();
            btn_All2 = new System.Windows.Forms.Button();
            btn_All3 = new System.Windows.Forms.Button();
            btn_All4 = new System.Windows.Forms.Button();
            btn_All5 = new System.Windows.Forms.Button();
            btn_All6 = new System.Windows.Forms.Button();
            btn_All7 = new System.Windows.Forms.Button();
            btn_All8 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            lb_Money_tab1 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            button1 = new System.Windows.Forms.Button();
            label10 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            panel_Main = new System.Windows.Forms.Panel();
            btn_ViewUnit = new System.Windows.Forms.Button();
            btn_AllChoice = new System.Windows.Forms.Button();
            btn_Test2 = new System.Windows.Forms.Button();
            btn_Test = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            panel15 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel16 = new System.Windows.Forms.Panel();
            tabPage2 = new System.Windows.Forms.TabPage();
            lb_Money_tab2 = new System.Windows.Forms.Label();
            pictureBox15 = new System.Windows.Forms.PictureBox();
            pictureBox14 = new System.Windows.Forms.PictureBox();
            pictureBox13 = new System.Windows.Forms.PictureBox();
            panel19 = new System.Windows.Forms.Panel();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            lbAttackSum = new System.Windows.Forms.Label();
            panel18 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lbHP = new System.Windows.Forms.Label();
            panel17 = new System.Windows.Forms.Panel();
            lbBuildInfo = new System.Windows.Forms.Label();
            cbSelectBuild = new System.Windows.Forms.ComboBox();
            pbBuildHP = new System.Windows.Forms.ProgressBar();
            panel3 = new System.Windows.Forms.Panel();
            tabPage3 = new System.Windows.Forms.TabPage();
            lbox_Chat_tab3 = new System.Windows.Forms.ListBox();
            lb_Money_tab3 = new System.Windows.Forms.Label();
            pn_Store_6 = new System.Windows.Forms.Panel();
            pn_Store_7 = new System.Windows.Forms.Panel();
            pn_Store_8 = new System.Windows.Forms.Panel();
            pn_Store_5 = new System.Windows.Forms.Panel();
            pn_Store_4 = new System.Windows.Forms.Panel();
            pn_Store_3 = new System.Windows.Forms.Panel();
            pn_Store_2 = new System.Windows.Forms.Panel();
            pn_Store_1 = new System.Windows.Forms.Panel();
            pictstore = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Allview0_value = new System.Windows.Forms.Label();
            timerstore = new System.Windows.Forms.Timer(components);
            timerstorebay = new System.Windows.Forms.Timer(components);
            building = new System.Windows.Forms.ImageList(components);
            label9 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            pictureBox16 = new System.Windows.Forms.PictureBox();
            pictureBox17 = new System.Windows.Forms.PictureBox();
            pictureBox18 = new System.Windows.Forms.PictureBox();
            panel_Upgrade.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel19.SuspendLayout();
            panel18.SuspendLayout();
            panel17.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictstore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            SuspendLayout();
            // 
            // lbox_Chat_tab1
            // 
            lbox_Chat_tab1.Font = new System.Drawing.Font("바탕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbox_Chat_tab1.FormattingEnabled = true;
            lbox_Chat_tab1.ItemHeight = 16;
            lbox_Chat_tab1.Location = new System.Drawing.Point(39, 708);
            lbox_Chat_tab1.Name = "lbox_Chat_tab1";
            lbox_Chat_tab1.Size = new System.Drawing.Size(379, 100);
            lbox_Chat_tab1.TabIndex = 0;
            // 
            // panel_Upgrade
            // 
            panel_Upgrade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel_Upgrade.Controls.Add(label1);
            panel_Upgrade.Location = new System.Drawing.Point(15, 61);
            panel_Upgrade.Name = "panel_Upgrade";
            panel_Upgrade.Size = new System.Drawing.Size(848, 250);
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
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(panel14);
            flowLayoutPanel2.Controls.Add(panel13);
            flowLayoutPanel2.Controls.Add(panel12);
            flowLayoutPanel2.Controls.Add(panel11);
            flowLayoutPanel2.Controls.Add(panel10);
            flowLayoutPanel2.Controls.Add(panel9);
            flowLayoutPanel2.Controls.Add(panel8);
            flowLayoutPanel2.Controls.Add(panel7);
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Controls.Add(btn_Refresh);
            flowLayoutPanel2.Location = new System.Drawing.Point(39, 56);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(582, 256);
            flowLayoutPanel2.TabIndex = 11;
            flowLayoutPanel2.Visible = false;
            // 
            // panel14
            // 
            panel14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panel14.Controls.Add(pictureBox12);
            panel14.Controls.Add(label18);
            panel14.Controls.Add(lb_Puls_8_Count);
            panel14.Controls.Add(lb_Allview8);
            panel14.Location = new System.Drawing.Point(390, 4);
            panel14.Margin = new System.Windows.Forms.Padding(2);
            panel14.Name = "panel14";
            panel14.Size = new System.Drawing.Size(177, 58);
            panel14.TabIndex = 6;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.warrior_high1;
            pictureBox12.Location = new System.Drawing.Point(2, 7);
            pictureBox12.Margin = new System.Windows.Forms.Padding(2);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new System.Drawing.Size(47, 45);
            pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 1;
            pictureBox12.TabStop = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label18.Location = new System.Drawing.Point(54, 11);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(0, 20);
            label18.TabIndex = 0;
            // 
            // lb_Puls_8_Count
            // 
            lb_Puls_8_Count.AutoSize = true;
            lb_Puls_8_Count.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_8_Count.Location = new System.Drawing.Point(95, 27);
            lb_Puls_8_Count.Name = "lb_Puls_8_Count";
            lb_Puls_8_Count.Size = new System.Drawing.Size(20, 28);
            lb_Puls_8_Count.TabIndex = 0;
            lb_Puls_8_Count.Text = "-";
            // 
            // lb_Allview8
            // 
            lb_Allview8.AutoSize = true;
            lb_Allview8.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Allview8.Location = new System.Drawing.Point(54, 9);
            lb_Allview8.Name = "lb_Allview8";
            lb_Allview8.Size = new System.Drawing.Size(113, 20);
            lb_Allview8.TabIndex = 0;
            lb_Allview8.Text = "중급 용사 (8강)";
            // 
            // panel13
            // 
            panel13.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panel13.Controls.Add(pictureBox11);
            panel13.Controls.Add(label17);
            panel13.Controls.Add(lb_Allview7);
            panel13.Controls.Add(lb_Puls_7_Count);
            panel13.Location = new System.Drawing.Point(200, 191);
            panel13.Margin = new System.Windows.Forms.Padding(2);
            panel13.Name = "panel13";
            panel13.Size = new System.Drawing.Size(177, 58);
            panel13.TabIndex = 6;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.warrior_low1;
            pictureBox11.Location = new System.Drawing.Point(2, 7);
            pictureBox11.Margin = new System.Windows.Forms.Padding(2);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new System.Drawing.Size(47, 45);
            pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 1;
            pictureBox11.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.Location = new System.Drawing.Point(54, 11);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(0, 20);
            label17.TabIndex = 0;
            // 
            // lb_Allview7
            // 
            lb_Allview7.AutoSize = true;
            lb_Allview7.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Allview7.Location = new System.Drawing.Point(54, 9);
            lb_Allview7.Name = "lb_Allview7";
            lb_Allview7.Size = new System.Drawing.Size(113, 20);
            lb_Allview7.TabIndex = 0;
            lb_Allview7.Text = "신입 용사 (7강)";
            // 
            // lb_Puls_7_Count
            // 
            lb_Puls_7_Count.AutoSize = true;
            lb_Puls_7_Count.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_7_Count.Location = new System.Drawing.Point(95, 27);
            lb_Puls_7_Count.Name = "lb_Puls_7_Count";
            lb_Puls_7_Count.Size = new System.Drawing.Size(20, 28);
            lb_Puls_7_Count.TabIndex = 0;
            lb_Puls_7_Count.Text = "-";
            // 
            // panel12
            // 
            panel12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panel12.Controls.Add(pictureBox10);
            panel12.Controls.Add(label16);
            panel12.Controls.Add(lb_Allview6);
            panel12.Controls.Add(lb_Puls_6_Count);
            panel12.Location = new System.Drawing.Point(200, 128);
            panel12.Margin = new System.Windows.Forms.Padding(2);
            panel12.Name = "panel12";
            panel12.Size = new System.Drawing.Size(177, 58);
            panel12.TabIndex = 6;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.knight;
            pictureBox10.Location = new System.Drawing.Point(2, 7);
            pictureBox10.Margin = new System.Windows.Forms.Padding(2);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new System.Drawing.Size(47, 45);
            pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 1;
            pictureBox10.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label16.Location = new System.Drawing.Point(54, 11);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(0, 20);
            label16.TabIndex = 0;
            // 
            // lb_Allview6
            // 
            lb_Allview6.AutoSize = true;
            lb_Allview6.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Allview6.Location = new System.Drawing.Point(70, 9);
            lb_Allview6.Name = "lb_Allview6";
            lb_Allview6.Size = new System.Drawing.Size(78, 20);
            lb_Allview6.TabIndex = 0;
            lb_Allview6.Text = "기사 (6강)";
            // 
            // lb_Puls_6_Count
            // 
            lb_Puls_6_Count.AutoSize = true;
            lb_Puls_6_Count.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_6_Count.Location = new System.Drawing.Point(95, 27);
            lb_Puls_6_Count.Name = "lb_Puls_6_Count";
            lb_Puls_6_Count.Size = new System.Drawing.Size(20, 28);
            lb_Puls_6_Count.TabIndex = 0;
            lb_Puls_6_Count.Text = "-";
            // 
            // panel11
            // 
            panel11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panel11.Controls.Add(pictureBox9);
            panel11.Controls.Add(label15);
            panel11.Controls.Add(lb_Allview5);
            panel11.Controls.Add(lb_Puls_5_Count);
            panel11.Location = new System.Drawing.Point(200, 66);
            panel11.Margin = new System.Windows.Forms.Padding(2);
            panel11.Name = "panel11";
            panel11.Size = new System.Drawing.Size(177, 58);
            panel11.TabIndex = 6;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.soldier_high;
            pictureBox9.Location = new System.Drawing.Point(2, 7);
            pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new System.Drawing.Size(47, 45);
            pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 1;
            pictureBox9.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label15.Location = new System.Drawing.Point(54, 11);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(0, 20);
            label15.TabIndex = 0;
            // 
            // lb_Allview5
            // 
            lb_Allview5.AutoSize = true;
            lb_Allview5.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Allview5.Location = new System.Drawing.Point(54, 9);
            lb_Allview5.Name = "lb_Allview5";
            lb_Allview5.Size = new System.Drawing.Size(113, 20);
            lb_Allview5.TabIndex = 0;
            lb_Allview5.Text = "측근 군인 (5강)";
            // 
            // lb_Puls_5_Count
            // 
            lb_Puls_5_Count.AutoSize = true;
            lb_Puls_5_Count.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_5_Count.Location = new System.Drawing.Point(95, 26);
            lb_Puls_5_Count.Name = "lb_Puls_5_Count";
            lb_Puls_5_Count.Size = new System.Drawing.Size(20, 28);
            lb_Puls_5_Count.TabIndex = 0;
            lb_Puls_5_Count.Text = "-";
            // 
            // panel10
            // 
            panel10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panel10.Controls.Add(pictureBox8);
            panel10.Controls.Add(label14);
            panel10.Controls.Add(lb_Allview4);
            panel10.Controls.Add(lb_Puls_4_Count);
            panel10.Location = new System.Drawing.Point(200, 4);
            panel10.Margin = new System.Windows.Forms.Padding(2);
            panel10.Name = "panel10";
            panel10.Size = new System.Drawing.Size(177, 58);
            panel10.TabIndex = 5;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.soldier_low;
            pictureBox8.Location = new System.Drawing.Point(2, 7);
            pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new System.Drawing.Size(47, 45);
            pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 1;
            pictureBox8.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(54, 11);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(0, 20);
            label14.TabIndex = 0;
            // 
            // lb_Allview4
            // 
            lb_Allview4.AutoSize = true;
            lb_Allview4.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Allview4.Location = new System.Drawing.Point(54, 9);
            lb_Allview4.Name = "lb_Allview4";
            lb_Allview4.Size = new System.Drawing.Size(113, 20);
            lb_Allview4.TabIndex = 0;
            lb_Allview4.Text = "일반 군인 (4강)";
            // 
            // lb_Puls_4_Count
            // 
            lb_Puls_4_Count.AutoSize = true;
            lb_Puls_4_Count.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_4_Count.Location = new System.Drawing.Point(95, 26);
            lb_Puls_4_Count.Name = "lb_Puls_4_Count";
            lb_Puls_4_Count.Size = new System.Drawing.Size(20, 28);
            lb_Puls_4_Count.TabIndex = 0;
            lb_Puls_4_Count.Text = "-";
            // 
            // panel9
            // 
            panel9.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panel9.Controls.Add(pictureBox7);
            panel9.Controls.Add(label13);
            panel9.Controls.Add(lb_Allview3);
            panel9.Controls.Add(lb_Puls_3_Count);
            panel9.Location = new System.Drawing.Point(6, 191);
            panel9.Margin = new System.Windows.Forms.Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(177, 58);
            panel9.TabIndex = 5;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.worker_high1;
            pictureBox7.Location = new System.Drawing.Point(2, 7);
            pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new System.Drawing.Size(47, 45);
            pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(54, 11);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(0, 20);
            label13.TabIndex = 0;
            // 
            // lb_Allview3
            // 
            lb_Allview3.AutoSize = true;
            lb_Allview3.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Allview3.Location = new System.Drawing.Point(54, 9);
            lb_Allview3.Name = "lb_Allview3";
            lb_Allview3.Size = new System.Drawing.Size(113, 20);
            lb_Allview3.TabIndex = 0;
            lb_Allview3.Text = "상급 일꾼 (3강)";
            // 
            // lb_Puls_3_Count
            // 
            lb_Puls_3_Count.AutoSize = true;
            lb_Puls_3_Count.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_3_Count.Location = new System.Drawing.Point(95, 26);
            lb_Puls_3_Count.Name = "lb_Puls_3_Count";
            lb_Puls_3_Count.Size = new System.Drawing.Size(20, 28);
            lb_Puls_3_Count.TabIndex = 0;
            lb_Puls_3_Count.Text = "-";
            // 
            // panel8
            // 
            panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panel8.Controls.Add(pictureBox6);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(lb_Allview2);
            panel8.Controls.Add(lb_Puls_2_Count);
            panel8.Location = new System.Drawing.Point(6, 129);
            panel8.Margin = new System.Windows.Forms.Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(177, 58);
            panel8.TabIndex = 4;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.worker_low1;
            pictureBox6.Location = new System.Drawing.Point(2, 7);
            pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(47, 45);
            pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(54, 11);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(0, 20);
            label12.TabIndex = 0;
            // 
            // lb_Allview2
            // 
            lb_Allview2.AutoSize = true;
            lb_Allview2.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Allview2.Location = new System.Drawing.Point(54, 9);
            lb_Allview2.Name = "lb_Allview2";
            lb_Allview2.Size = new System.Drawing.Size(113, 20);
            lb_Allview2.TabIndex = 0;
            lb_Allview2.Text = "하급 일꾼 (2강)";
            // 
            // lb_Puls_2_Count
            // 
            lb_Puls_2_Count.AutoSize = true;
            lb_Puls_2_Count.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_2_Count.Location = new System.Drawing.Point(95, 26);
            lb_Puls_2_Count.Name = "lb_Puls_2_Count";
            lb_Puls_2_Count.Size = new System.Drawing.Size(20, 28);
            lb_Puls_2_Count.TabIndex = 0;
            lb_Puls_2_Count.Text = "-";
            // 
            // panel7
            // 
            panel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panel7.Controls.Add(pictureBox5);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(lb_Puls_1_Count);
            panel7.Controls.Add(lb_Allview1);
            panel7.Location = new System.Drawing.Point(6, 67);
            panel7.Margin = new System.Windows.Forms.Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(177, 58);
            panel7.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.peasent_red_front;
            pictureBox5.Location = new System.Drawing.Point(2, 7);
            pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(47, 45);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(54, 11);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(0, 20);
            label11.TabIndex = 0;
            // 
            // lb_Puls_1_Count
            // 
            lb_Puls_1_Count.AutoSize = true;
            lb_Puls_1_Count.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_1_Count.Location = new System.Drawing.Point(95, 28);
            lb_Puls_1_Count.Name = "lb_Puls_1_Count";
            lb_Puls_1_Count.Size = new System.Drawing.Size(20, 28);
            lb_Puls_1_Count.TabIndex = 0;
            lb_Puls_1_Count.Text = "-";
            // 
            // lb_Allview1
            // 
            lb_Allview1.AutoSize = true;
            lb_Allview1.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Allview1.Location = new System.Drawing.Point(54, 9);
            lb_Allview1.Name = "lb_Allview1";
            lb_Allview1.Size = new System.Drawing.Size(113, 20);
            lb_Allview1.TabIndex = 0;
            lb_Allview1.Text = "상급 농부 (1강)";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(lb_Allview);
            panel2.Controls.Add(lb_Puls_0_Count);
            panel2.Location = new System.Drawing.Point(6, 4);
            panel2.Margin = new System.Windows.Forms.Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(177, 58);
            panel2.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.peasent;
            pictureBox4.Location = new System.Drawing.Point(2, 7);
            pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(47, 45);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // lb_Allview
            // 
            lb_Allview.AutoSize = true;
            lb_Allview.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Allview.Location = new System.Drawing.Point(54, 9);
            lb_Allview.Name = "lb_Allview";
            lb_Allview.Size = new System.Drawing.Size(113, 20);
            lb_Allview.TabIndex = 0;
            lb_Allview.Text = "하급 농부 (0강)";
            // 
            // lb_Puls_0_Count
            // 
            lb_Puls_0_Count.AutoSize = true;
            lb_Puls_0_Count.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_0_Count.Location = new System.Drawing.Point(95, 27);
            lb_Puls_0_Count.Name = "lb_Puls_0_Count";
            lb_Puls_0_Count.Size = new System.Drawing.Size(20, 28);
            lb_Puls_0_Count.TabIndex = 0;
            lb_Puls_0_Count.Text = "-";
            // 
            // btn_Refresh
            // 
            btn_Refresh.BackgroundImage = Properties.Resources.message;
            btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Refresh.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Refresh.ForeColor = System.Drawing.Color.Transparent;
            btn_Refresh.Location = new System.Drawing.Point(423, 195);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new System.Drawing.Size(135, 60);
            btn_Refresh.TabIndex = 1;
            btn_Refresh.Text = "새로 고침";
            btn_Refresh.UseVisualStyleBackColor = true;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            flowLayoutPanel1.Controls.Add(btn_All0);
            flowLayoutPanel1.Controls.Add(btn_All1);
            flowLayoutPanel1.Controls.Add(btn_All2);
            flowLayoutPanel1.Controls.Add(btn_All3);
            flowLayoutPanel1.Controls.Add(btn_All4);
            flowLayoutPanel1.Controls.Add(btn_All5);
            flowLayoutPanel1.Controls.Add(btn_All6);
            flowLayoutPanel1.Controls.Add(btn_All7);
            flowLayoutPanel1.Controls.Add(btn_All8);
            flowLayoutPanel1.Location = new System.Drawing.Point(646, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(211, 254);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Visible = false;
            // 
            // btn_All0
            // 
            btn_All0.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btn_All0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All0.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_All0.ImageIndex = 0;
            btn_All0.ImageList = characters;
            btn_All0.Location = new System.Drawing.Point(3, 3);
            btn_All0.Name = "btn_All0";
            btn_All0.Size = new System.Drawing.Size(64, 64);
            btn_All0.TabIndex = 0;
            btn_All0.Tag = "0";
            btn_All0.Text = "0강";
            btn_All0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All0.UseVisualStyleBackColor = false;
            btn_All0.Click += btn_CreateAllButton;
            // 
            // characters
            // 
            characters.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            characters.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("characters.ImageStream");
            characters.TransparentColor = System.Drawing.Color.Transparent;
            characters.Images.SetKeyName(0, "peasent_front.gif");
            characters.Images.SetKeyName(1, "peasent_red_front.gif");
            characters.Images.SetKeyName(2, "worker_low.png");
            characters.Images.SetKeyName(3, "worker_high.png");
            characters.Images.SetKeyName(4, "soldier.png");
            characters.Images.SetKeyName(5, "soldier_low.png");
            characters.Images.SetKeyName(6, "knight_low.png");
            characters.Images.SetKeyName(7, "warrior_low.png");
            characters.Images.SetKeyName(8, "warrior_high.png");
            // 
            // btn_All1
            // 
            btn_All1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btn_All1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_All1.ImageIndex = 1;
            btn_All1.ImageList = characters;
            btn_All1.Location = new System.Drawing.Point(73, 3);
            btn_All1.Name = "btn_All1";
            btn_All1.Size = new System.Drawing.Size(64, 64);
            btn_All1.TabIndex = 1;
            btn_All1.Tag = "1";
            btn_All1.Text = "1강";
            btn_All1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All1.UseVisualStyleBackColor = false;
            btn_All1.Click += btn_CreateAllButton;
            // 
            // btn_All2
            // 
            btn_All2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btn_All2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_All2.ImageIndex = 2;
            btn_All2.ImageList = characters;
            btn_All2.Location = new System.Drawing.Point(143, 3);
            btn_All2.Name = "btn_All2";
            btn_All2.Size = new System.Drawing.Size(64, 64);
            btn_All2.TabIndex = 2;
            btn_All2.Tag = "2";
            btn_All2.Text = "2강";
            btn_All2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All2.UseVisualStyleBackColor = false;
            btn_All2.Click += btn_CreateAllButton;
            // 
            // btn_All3
            // 
            btn_All3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btn_All3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_All3.ImageIndex = 3;
            btn_All3.ImageList = characters;
            btn_All3.Location = new System.Drawing.Point(3, 73);
            btn_All3.Name = "btn_All3";
            btn_All3.Size = new System.Drawing.Size(64, 64);
            btn_All3.TabIndex = 3;
            btn_All3.Tag = "3";
            btn_All3.Text = "3강";
            btn_All3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All3.UseVisualStyleBackColor = false;
            btn_All3.Click += btn_CreateAllButton;
            // 
            // btn_All4
            // 
            btn_All4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btn_All4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_All4.ImageIndex = 4;
            btn_All4.ImageList = characters;
            btn_All4.Location = new System.Drawing.Point(73, 73);
            btn_All4.Name = "btn_All4";
            btn_All4.Size = new System.Drawing.Size(64, 64);
            btn_All4.TabIndex = 4;
            btn_All4.Tag = "4";
            btn_All4.Text = "4강";
            btn_All4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All4.UseVisualStyleBackColor = false;
            btn_All4.Click += btn_CreateAllButton;
            // 
            // btn_All5
            // 
            btn_All5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btn_All5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_All5.ImageIndex = 5;
            btn_All5.ImageList = characters;
            btn_All5.Location = new System.Drawing.Point(143, 73);
            btn_All5.Name = "btn_All5";
            btn_All5.Size = new System.Drawing.Size(64, 64);
            btn_All5.TabIndex = 5;
            btn_All5.Tag = "5";
            btn_All5.Text = "5강";
            btn_All5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All5.UseVisualStyleBackColor = false;
            btn_All5.Click += btn_CreateAllButton;
            // 
            // btn_All6
            // 
            btn_All6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btn_All6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_All6.ImageIndex = 6;
            btn_All6.ImageList = characters;
            btn_All6.Location = new System.Drawing.Point(3, 143);
            btn_All6.Name = "btn_All6";
            btn_All6.Size = new System.Drawing.Size(64, 64);
            btn_All6.TabIndex = 6;
            btn_All6.Tag = "6";
            btn_All6.Text = "6강";
            btn_All6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All6.UseVisualStyleBackColor = false;
            btn_All6.Click += btn_CreateAllButton;
            // 
            // btn_All7
            // 
            btn_All7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btn_All7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_All7.ImageIndex = 7;
            btn_All7.ImageList = characters;
            btn_All7.Location = new System.Drawing.Point(73, 143);
            btn_All7.Name = "btn_All7";
            btn_All7.Size = new System.Drawing.Size(64, 64);
            btn_All7.TabIndex = 7;
            btn_All7.Tag = "7";
            btn_All7.Text = "7강";
            btn_All7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All7.UseVisualStyleBackColor = false;
            btn_All7.Click += btn_CreateAllButton;
            // 
            // btn_All8
            // 
            btn_All8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            btn_All8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btn_All8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All8.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_All8.ImageIndex = 8;
            btn_All8.ImageList = characters;
            btn_All8.Location = new System.Drawing.Point(143, 143);
            btn_All8.Name = "btn_All8";
            btn_All8.Size = new System.Drawing.Size(64, 64);
            btn_All8.TabIndex = 8;
            btn_All8.Tag = "8";
            btn_All8.Text = "8강";
            btn_All8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All8.UseVisualStyleBackColor = false;
            btn_All8.Click += btn_CreateAllButton;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(77, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(101, 25);
            label3.TabIndex = 0;
            label3.Text = "보유 골드 :";
            // 
            // lb_Money_tab1
            // 
            lb_Money_tab1.AutoSize = true;
            lb_Money_tab1.BackColor = System.Drawing.Color.Transparent;
            lb_Money_tab1.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Money_tab1.ForeColor = System.Drawing.Color.White;
            lb_Money_tab1.Location = new System.Drawing.Point(195, 10);
            lb_Money_tab1.Name = "lb_Money_tab1";
            lb_Money_tab1.Size = new System.Drawing.Size(95, 25);
            lb_Money_tab1.TabIndex = 0;
            lb_Money_tab1.Text = "lb_Money";
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
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            tabControl1.KeyDown += tabControl1_KeyDown;
            tabControl1.KeyUp += tabControl1_KeyUp;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = System.Drawing.Color.LightCyan;
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(flowLayoutPanel2);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Controls.Add(panel_Main);
            tabPage1.Controls.Add(btn_ViewUnit);
            tabPage1.Controls.Add(btn_AllChoice);
            tabPage1.Controls.Add(btn_Test2);
            tabPage1.Controls.Add(btn_Test);
            tabPage1.Controls.Add(lbox_Chat_tab1);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(panel15);
            tabPage1.Controls.Add(panel16);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(875, 835);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "강화소";
            tabPage1.Click += tabPage1_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(715, 713);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(160, 105);
            button1.TabIndex = 24;
            button1.Text = "6강 10명 구매 - 7700원";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.FromArgb(128, 64, 64);
            label10.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.SystemColors.Control;
            label10.Location = new System.Drawing.Point(740, 452);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(71, 37);
            label10.TabIndex = 21;
            label10.Text = "광산";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(756, 348);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(0, 37);
            label8.TabIndex = 16;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.mine;
            pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pictureBox3.Location = new System.Drawing.Point(661, 317);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(219, 382);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // panel_Main
            // 
            panel_Main.BackColor = System.Drawing.Color.Transparent;
            panel_Main.Location = new System.Drawing.Point(38, 317);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new System.Drawing.Size(620, 385);
            panel_Main.TabIndex = 9;
            // 
            // btn_ViewUnit
            // 
            btn_ViewUnit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btn_ViewUnit.BackgroundImage = Properties.Resources.message;
            btn_ViewUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_ViewUnit.FlatAppearance.BorderSize = 0;
            btn_ViewUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_ViewUnit.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_ViewUnit.ForeColor = System.Drawing.Color.White;
            btn_ViewUnit.Location = new System.Drawing.Point(490, 12);
            btn_ViewUnit.Name = "btn_ViewUnit";
            btn_ViewUnit.Size = new System.Drawing.Size(137, 38);
            btn_ViewUnit.TabIndex = 6;
            btn_ViewUnit.Text = "인원 보기";
            btn_ViewUnit.UseVisualStyleBackColor = false;
            btn_ViewUnit.Click += btn_ViewUnit_Click;
            // 
            // btn_AllChoice
            // 
            btn_AllChoice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            btn_AllChoice.BackgroundImage = Properties.Resources.message;
            btn_AllChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_AllChoice.FlatAppearance.BorderSize = 0;
            btn_AllChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_AllChoice.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_AllChoice.ForeColor = System.Drawing.Color.White;
            btn_AllChoice.Location = new System.Drawing.Point(719, 12);
            btn_AllChoice.Name = "btn_AllChoice";
            btn_AllChoice.Size = new System.Drawing.Size(137, 39);
            btn_AllChoice.TabIndex = 5;
            btn_AllChoice.Text = "전체 선택";
            btn_AllChoice.UseVisualStyleBackColor = false;
            btn_AllChoice.Click += btn_AllChoice_Click;
            // 
            // btn_Test2
            // 
            btn_Test2.BackColor = System.Drawing.Color.Transparent;
            btn_Test2.BackgroundImage = Properties.Resources.LongMessage;
            btn_Test2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Test2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Test2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Test2.ForeColor = System.Drawing.Color.White;
            btn_Test2.Location = new System.Drawing.Point(430, 769);
            btn_Test2.Name = "btn_Test2";
            btn_Test2.Size = new System.Drawing.Size(283, 39);
            btn_Test2.TabIndex = 4;
            btn_Test2.Text = "고급 농부 (3강) 10명 구매";
            btn_Test2.UseVisualStyleBackColor = false;
            btn_Test2.Click += btn_Test2_Click;
            // 
            // btn_Test
            // 
            btn_Test.BackColor = System.Drawing.Color.Transparent;
            btn_Test.BackgroundImage = Properties.Resources.LongMessage;
            btn_Test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Test.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Test.ForeColor = System.Drawing.Color.White;
            btn_Test.Location = new System.Drawing.Point(430, 722);
            btn_Test.Name = "btn_Test";
            btn_Test.Size = new System.Drawing.Size(283, 39);
            btn_Test.TabIndex = 0;
            btn_Test.Text = "하급 농부 (0강) 10명 구매";
            btn_Test.UseVisualStyleBackColor = false;
            btn_Test.Click += btn_Test_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.dungeon;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureBox2.Location = new System.Drawing.Point(39, 161);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(438, 150);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.message;
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(173, 100);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(206, 56);
            panel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(71, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 37);
            label2.TabIndex = 16;
            label2.Text = "던전";
            // 
            // panel15
            // 
            panel15.BackColor = System.Drawing.SystemColors.ActiveBorder;
            panel15.BackgroundImage = Properties.Resources.LongMessage;
            panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panel15.Controls.Add(pictureBox1);
            panel15.Controls.Add(label3);
            panel15.Controls.Add(lb_Money_tab1);
            panel15.Location = new System.Drawing.Point(23, 5);
            panel15.Margin = new System.Windows.Forms.Padding(2);
            panel15.Name = "panel15";
            panel15.Size = new System.Drawing.Size(375, 50);
            panel15.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = Properties.Resources.money;
            pictureBox1.Location = new System.Drawing.Point(18, 1);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(52, 45);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel16
            // 
            panel16.BackColor = System.Drawing.SystemColors.ActiveBorder;
            panel16.Dock = System.Windows.Forms.DockStyle.Top;
            panel16.Location = new System.Drawing.Point(3, 3);
            panel16.Margin = new System.Windows.Forms.Padding(2);
            panel16.Name = "panel16";
            panel16.Size = new System.Drawing.Size(869, 53);
            panel16.TabIndex = 23;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.mine_map;
            tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tabPage2.Controls.Add(lb_Money_tab2);
            tabPage2.Controls.Add(pictureBox15);
            tabPage2.Controls.Add(pictureBox14);
            tabPage2.Controls.Add(pictureBox13);
            tabPage2.Controls.Add(panel19);
            tabPage2.Controls.Add(panel18);
            tabPage2.Controls.Add(panel17);
            tabPage2.Controls.Add(cbSelectBuild);
            tabPage2.Controls.Add(pbBuildHP);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(875, 835);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "일터";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lb_Money_tab2
            // 
            lb_Money_tab2.AutoSize = true;
            lb_Money_tab2.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Money_tab2.Location = new System.Drawing.Point(692, 55);
            lb_Money_tab2.Name = "lb_Money_tab2";
            lb_Money_tab2.Size = new System.Drawing.Size(92, 25);
            lb_Money_tab2.TabIndex = 11;
            lb_Money_tab2.Text = "lb_Money";
            // 
            // pictureBox15
            // 
            pictureBox15.Image = Properties.Resources.mine_worker_left;
            pictureBox15.Location = new System.Drawing.Point(144, 340);
            pictureBox15.Margin = new System.Windows.Forms.Padding(2);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new System.Drawing.Size(51, 49);
            pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox15.TabIndex = 10;
            pictureBox15.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Properties.Resources.mine_worker_front;
            pictureBox14.Location = new System.Drawing.Point(430, 123);
            pictureBox14.Margin = new System.Windows.Forms.Padding(2);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new System.Drawing.Size(51, 49);
            pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox14.TabIndex = 10;
            pictureBox14.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.mine_worker_right;
            pictureBox13.Location = new System.Drawing.Point(702, 340);
            pictureBox13.Margin = new System.Windows.Forms.Padding(2);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new System.Drawing.Size(51, 49);
            pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 10;
            pictureBox13.TabStop = false;
            // 
            // panel19
            // 
            panel19.BackgroundImage = Properties.Resources.LongMessage;
            panel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panel19.Controls.Add(label6);
            panel19.Controls.Add(label7);
            panel19.Controls.Add(lbAttackSum);
            panel19.Location = new System.Drawing.Point(169, 685);
            panel19.Margin = new System.Windows.Forms.Padding(2);
            panel19.Name = "panel19";
            panel19.Size = new System.Drawing.Size(391, 54);
            panel19.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label6.Location = new System.Drawing.Point(26, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(131, 30);
            label6.TabIndex = 5;
            label6.Text = "현재 공격력";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label7.Location = new System.Drawing.Point(173, 9);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(19, 30);
            label7.TabIndex = 5;
            label7.Text = ":";
            // 
            // lbAttackSum
            // 
            lbAttackSum.AutoSize = true;
            lbAttackSum.BackColor = System.Drawing.Color.Transparent;
            lbAttackSum.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbAttackSum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lbAttackSum.Location = new System.Drawing.Point(204, 9);
            lbAttackSum.Name = "lbAttackSum";
            lbAttackSum.Size = new System.Drawing.Size(22, 30);
            lbAttackSum.TabIndex = 5;
            lbAttackSum.Text = "-";
            // 
            // panel18
            // 
            panel18.BackgroundImage = Properties.Resources.LongMessage;
            panel18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panel18.Controls.Add(label4);
            panel18.Controls.Add(label5);
            panel18.Controls.Add(lbHP);
            panel18.Location = new System.Drawing.Point(169, 626);
            panel18.Margin = new System.Windows.Forms.Padding(2);
            panel18.Name = "panel18";
            panel18.Size = new System.Drawing.Size(391, 54);
            panel18.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label4.Location = new System.Drawing.Point(28, 10);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(96, 30);
            label4.TabIndex = 5;
            label4.Text = "남은 HP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label5.Location = new System.Drawing.Point(135, 10);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(19, 30);
            label5.TabIndex = 5;
            label5.Text = ":";
            // 
            // lbHP
            // 
            lbHP.AutoSize = true;
            lbHP.BackColor = System.Drawing.Color.Transparent;
            lbHP.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbHP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lbHP.Location = new System.Drawing.Point(183, 10);
            lbHP.Name = "lbHP";
            lbHP.Size = new System.Drawing.Size(22, 30);
            lbHP.TabIndex = 5;
            lbHP.Text = "-";
            // 
            // panel17
            // 
            panel17.BackgroundImage = Properties.Resources.LongMessage;
            panel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panel17.Controls.Add(lbBuildInfo);
            panel17.Location = new System.Drawing.Point(245, 55);
            panel17.Margin = new System.Windows.Forms.Padding(2);
            panel17.Name = "panel17";
            panel17.Size = new System.Drawing.Size(391, 54);
            panel17.TabIndex = 7;
            // 
            // lbBuildInfo
            // 
            lbBuildInfo.AutoSize = true;
            lbBuildInfo.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbBuildInfo.ForeColor = System.Drawing.Color.White;
            lbBuildInfo.Location = new System.Drawing.Point(71, 10);
            lbBuildInfo.Name = "lbBuildInfo";
            lbBuildInfo.Size = new System.Drawing.Size(248, 32);
            lbBuildInfo.TabIndex = 5;
            lbBuildInfo.Text = "1단계 건물 방어력 : 1";
            // 
            // cbSelectBuild
            // 
            cbSelectBuild.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbSelectBuild.FormattingEnabled = true;
            cbSelectBuild.Items.AddRange(new object[] { "1단계 건물", "2단계 건물", "3단계 건물", "4단계 건물", "5단계 건물" });
            cbSelectBuild.Location = new System.Drawing.Point(599, 694);
            cbSelectBuild.Name = "cbSelectBuild";
            cbSelectBuild.Size = new System.Drawing.Size(109, 31);
            cbSelectBuild.TabIndex = 6;
            cbSelectBuild.Text = "1단계 건물";
            cbSelectBuild.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pbBuildHP
            // 
            pbBuildHP.Location = new System.Drawing.Point(200, 574);
            pbBuildHP.Name = "pbBuildHP";
            pbBuildHP.Size = new System.Drawing.Size(500, 45);
            pbBuildHP.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            pbBuildHP.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            panel3.Location = new System.Drawing.Point(304, 224);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(295, 281);
            panel3.TabIndex = 0;
            panel3.Visible = false;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = System.Drawing.Color.White;
            tabPage3.Controls.Add(lbox_Chat_tab3);
            tabPage3.Controls.Add(pictureBox18);
            tabPage3.Controls.Add(pictureBox17);
            tabPage3.Controls.Add(pictureBox16);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(lb_Money_tab3);
            tabPage3.Controls.Add(pn_Store_6);
            tabPage3.Controls.Add(pn_Store_7);
            tabPage3.Controls.Add(pn_Store_8);
            tabPage3.Controls.Add(pn_Store_5);
            tabPage3.Controls.Add(pn_Store_4);
            tabPage3.Controls.Add(pn_Store_3);
            tabPage3.Controls.Add(pn_Store_2);
            tabPage3.Controls.Add(pn_Store_1);
            tabPage3.Controls.Add(pictstore);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(875, 835);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "상점";
            // 
            // lbox_Chat_tab3
            // 
            lbox_Chat_tab3.Font = new System.Drawing.Font("바탕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbox_Chat_tab3.FormattingEnabled = true;
            lbox_Chat_tab3.ItemHeight = 16;
            lbox_Chat_tab3.Location = new System.Drawing.Point(39, 708);
            lbox_Chat_tab3.Name = "lbox_Chat_tab3";
            lbox_Chat_tab3.Size = new System.Drawing.Size(379, 100);
            lbox_Chat_tab3.TabIndex = 3;
            // 
            // lb_Money_tab3
            // 
            lb_Money_tab3.AutoSize = true;
            lb_Money_tab3.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Money_tab3.Location = new System.Drawing.Point(683, 35);
            lb_Money_tab3.Name = "lb_Money_tab3";
            lb_Money_tab3.Size = new System.Drawing.Size(92, 25);
            lb_Money_tab3.TabIndex = 2;
            lb_Money_tab3.Text = "lb_Money";
            // 
            // pn_Store_6
            // 
            pn_Store_6.BackColor = System.Drawing.Color.Blue;
            pn_Store_6.Location = new System.Drawing.Point(660, 549);
            pn_Store_6.Name = "pn_Store_6";
            pn_Store_6.Size = new System.Drawing.Size(83, 73);
            pn_Store_6.TabIndex = 1;
            // 
            // pn_Store_7
            // 
            pn_Store_7.BackColor = System.Drawing.Color.Blue;
            pn_Store_7.Location = new System.Drawing.Point(374, 549);
            pn_Store_7.Name = "pn_Store_7";
            pn_Store_7.Size = new System.Drawing.Size(83, 73);
            pn_Store_7.TabIndex = 1;
            // 
            // pn_Store_8
            // 
            pn_Store_8.BackColor = System.Drawing.Color.Blue;
            pn_Store_8.Location = new System.Drawing.Point(184, 549);
            pn_Store_8.Name = "pn_Store_8";
            pn_Store_8.Size = new System.Drawing.Size(83, 73);
            pn_Store_8.TabIndex = 1;
            // 
            // pn_Store_5
            // 
            pn_Store_5.BackColor = System.Drawing.Color.Red;
            pn_Store_5.Location = new System.Drawing.Point(642, 400);
            pn_Store_5.Name = "pn_Store_5";
            pn_Store_5.Size = new System.Drawing.Size(83, 73);
            pn_Store_5.TabIndex = 1;
            // 
            // pn_Store_4
            // 
            pn_Store_4.BackColor = System.Drawing.Color.Red;
            pn_Store_4.Location = new System.Drawing.Point(642, 290);
            pn_Store_4.Name = "pn_Store_4";
            pn_Store_4.Size = new System.Drawing.Size(83, 73);
            pn_Store_4.TabIndex = 1;
            // 
            // pn_Store_3
            // 
            pn_Store_3.BackColor = System.Drawing.Color.Red;
            pn_Store_3.Location = new System.Drawing.Point(594, 151);
            pn_Store_3.Name = "pn_Store_3";
            pn_Store_3.Size = new System.Drawing.Size(83, 73);
            pn_Store_3.TabIndex = 1;
            // 
            // pn_Store_2
            // 
            pn_Store_2.BackColor = System.Drawing.Color.Red;
            pn_Store_2.Location = new System.Drawing.Point(374, 151);
            pn_Store_2.Name = "pn_Store_2";
            pn_Store_2.Size = new System.Drawing.Size(83, 73);
            pn_Store_2.TabIndex = 1;
            // 
            // pn_Store_1
            // 
            pn_Store_1.BackColor = System.Drawing.Color.Red;
            pn_Store_1.Location = new System.Drawing.Point(158, 151);
            pn_Store_1.Name = "pn_Store_1";
            pn_Store_1.Size = new System.Drawing.Size(83, 73);
            pn_Store_1.TabIndex = 1;
            // 
            // pictstore
            // 
            pictstore.Image = Properties.Resources.worker_low;
            pictstore.Location = new System.Drawing.Point(400, 400);
            pictstore.Name = "pictstore";
            pictstore.Size = new System.Drawing.Size(37, 39);
            pictstore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictstore.TabIndex = 0;
            pictstore.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Allview0_value
            // 
            Allview0_value.Location = new System.Drawing.Point(0, 0);
            Allview0_value.Name = "Allview0_value";
            Allview0_value.Size = new System.Drawing.Size(100, 23);
            Allview0_value.TabIndex = 0;
            // 
            // timerstorebay
            // 
            timerstorebay.Tick += timerstorebay_Tick;
            // 
            // building
            // 
            //building.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            //building.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("building.ImageStream");
            //building.TransparentColor = System.Drawing.Color.Transparent;
            //building.Images.SetKeyName(0, "build_1.png");
            //building.Images.SetKeyName(1, "build_2.png");
            //building.Images.SetKeyName(2, "build_3.png");
            //building.Images.SetKeyName(3, "build_4.png");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(143, 103);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(67, 45);
            label9.TabIndex = 3;
            label9.Text = "하급농부\r\n가격:110원\r\n+10개";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(358, 103);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(67, 45);
            label19.TabIndex = 3;
            label19.Text = "상급일꾼\r\n가격:330원\r\n+10개";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(576, 103);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(74, 45);
            label20.TabIndex = 3;
            label20.Text = "기사\n가격:7700원\r\n+10개";
            // 
            // pictureBox16
            // 
            pictureBox16.Image = Properties.Resources.worker_high;
            pictureBox16.Location = new System.Drawing.Point(431, 103);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new System.Drawing.Size(50, 50);
            pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox16.TabIndex = 4;
            pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.Image = Properties.Resources.peasent;
            pictureBox17.Location = new System.Drawing.Point(216, 103);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new System.Drawing.Size(50, 50);
            pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox17.TabIndex = 4;
            pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.Image = Properties.Resources.knight;
            pictureBox18.Location = new System.Drawing.Point(656, 103);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new System.Drawing.Size(50, 50);
            pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox18.TabIndex = 4;
            pictureBox18.TabStop = false;
            // 
            // MobleTeamProject_Gambling
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(884, 861);
            Controls.Add(tabControl1);
            Name = "MobleTeamProject_Gambling";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MobleTeamProject_Gambling";
            FormClosed += MobleTeamProject_Gambling_FormClosed;
            Load += MobleTeamProject_Gambling_Load;
            panel_Upgrade.ResumeLayout(false);
            panel_Upgrade.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictstore).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lbox_Chat_tab1;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Money_tab1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button btn_Test2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_All0;
        private System.Windows.Forms.Button btn_All1;
        private System.Windows.Forms.Button btn_All2;
        private System.Windows.Forms.Button btn_All3;
        private System.Windows.Forms.Button btn_All4;
        private System.Windows.Forms.Button btn_All5;
        private System.Windows.Forms.Button btn_All6;
        private System.Windows.Forms.Button btn_All7;
        private System.Windows.Forms.Button btn_All8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar pbBuildHP;
        private System.Windows.Forms.Button btn_AllChoice;
        private System.Windows.Forms.Label lbHP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbAttackSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList characters;
        private System.Windows.Forms.ComboBox cbSelectBuild;
        private System.Windows.Forms.Button btn_ViewUnit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_Allview0;
        private System.Windows.Forms.Label Allview0_value;
        // private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel flowLayoutPanel2;
        private System.Windows.Forms.Label lb_Allview5;
        private System.Windows.Forms.Label lb_Allview8;
        private System.Windows.Forms.Label lb_Allview4;
        private System.Windows.Forms.Label lb_Allview7;
        private System.Windows.Forms.Label lb_Allview3;
        private System.Windows.Forms.Label lb_Allview6;
        private System.Windows.Forms.Label lb_Allview;
        private System.Windows.Forms.Label lb_Allview1;
        private System.Windows.Forms.Label lb_Allview2;
        private System.Windows.Forms.Label lb_Puls_5_Count;
        private System.Windows.Forms.Label lb_Puls_4_Count;
        private System.Windows.Forms.Label lb_Puls_8_Count;
        private System.Windows.Forms.Label lb_Puls_3_Count;
        private System.Windows.Forms.Label lb_Puls_7_Count;
        private System.Windows.Forms.Label lb_Puls_6_Count;
        private System.Windows.Forms.Label lb_Puls_2_Count;
        private System.Windows.Forms.Label lb_Puls_1_Count;
        private System.Windows.Forms.Panel panel_Upgrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Puls_0_Count;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbBuildInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Panel pn_Store_6;
        private System.Windows.Forms.Panel pn_Store_7;
        private System.Windows.Forms.Panel pn_Store_8;
        private System.Windows.Forms.Panel pn_Store_5;
        private System.Windows.Forms.Panel pn_Store_4;
        private System.Windows.Forms.Panel pn_Store_3;
        private System.Windows.Forms.Panel pn_Store_1;
        private System.Windows.Forms.PictureBox pictstore;
        private System.Windows.Forms.Timer timerstore;
        private System.Windows.Forms.Timer timerstorebay;
        private System.Windows.Forms.ImageList building;
        private System.Windows.Forms.Label lb_Money_tab2;
        private System.Windows.Forms.Label lb_Money_tab3;
        private System.Windows.Forms.Panel pn_Store_2;
        private System.Windows.Forms.ListBox lbox_Chat_tab3;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox17;
    }
}