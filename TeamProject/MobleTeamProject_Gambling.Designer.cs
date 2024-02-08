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
                Name = "고참 기사",
                Attack = 800,
                SellPrice = 2000,
            };
            weaponsDictionary.Add(7, lv7);

            WeaponUpgrade lv8 = new WeaponUpgrade() //8번 무기 속성
            {
                Level = 8,
                Name = "신입 용사",
                Attack = 5000,
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
            lbox_Chat_tab3 = new System.Windows.Forms.ListBox();
            panel_Upgrade = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            flowLayoutPanel2 = new System.Windows.Forms.Panel();
            panel21 = new System.Windows.Forms.Panel();
            pictureBox22 = new System.Windows.Forms.PictureBox();
            label34 = new System.Windows.Forms.Label();
            label35 = new System.Windows.Forms.Label();
            label36 = new System.Windows.Forms.Label();
            panel20 = new System.Windows.Forms.Panel();
            pictureBox21 = new System.Windows.Forms.PictureBox();
            label31 = new System.Windows.Forms.Label();
            label32 = new System.Windows.Forms.Label();
            label33 = new System.Windows.Forms.Label();
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
            btn_All9 = new System.Windows.Forms.Button();
            btn_All10 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            lb_Money_tab1 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            label10 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            panel_Main = new System.Windows.Forms.Panel();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            panel16 = new System.Windows.Forms.Panel();
            btn_ViewUnit = new System.Windows.Forms.Button();
            btn_AllChoice = new System.Windows.Forms.Button();
            panel15 = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            tabPage2 = new System.Windows.Forms.TabPage();
            panel_work = new System.Windows.Forms.Panel();
            label28 = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            pictureBox19 = new System.Windows.Forms.PictureBox();
            label23 = new System.Windows.Forms.Label();
            lb_Money_tab2_1 = new System.Windows.Forms.Label();
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
            panel_shop = new System.Windows.Forms.Panel();
            label29 = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            pictureBox20 = new System.Windows.Forms.PictureBox();
            label27 = new System.Windows.Forms.Label();
            lb_Money_tab3_1 = new System.Windows.Forms.Label();
            pn_Store_6 = new System.Windows.Forms.Panel();
            label26 = new System.Windows.Forms.Label();
            pn_Store_7 = new System.Windows.Forms.Panel();
            label24 = new System.Windows.Forms.Label();
            pn_Store_8 = new System.Windows.Forms.Panel();
            label25 = new System.Windows.Forms.Label();
            pn_Store_5 = new System.Windows.Forms.Panel();
            label22 = new System.Windows.Forms.Label();
            pn_Store_4 = new System.Windows.Forms.Panel();
            label21 = new System.Windows.Forms.Label();
            pn_Store_3 = new System.Windows.Forms.Panel();
            label20 = new System.Windows.Forms.Label();
            pictureBox18 = new System.Windows.Forms.PictureBox();
            pn_Store_2 = new System.Windows.Forms.Panel();
            label19 = new System.Windows.Forms.Label();
            pictureBox16 = new System.Windows.Forms.PictureBox();
            pn_Store_1 = new System.Windows.Forms.Panel();
            label9 = new System.Windows.Forms.Label();
            pictureBox17 = new System.Windows.Forms.PictureBox();
            pictstore = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Allview0_value = new System.Windows.Forms.Label();
            timerstore = new System.Windows.Forms.Timer(components);
            timerstorebay = new System.Windows.Forms.Timer(components);
            building = new System.Windows.Forms.ImageList(components);
            build = new System.Windows.Forms.ImageList(components);
            game_main_exit = new System.Windows.Forms.Button();
            panel6 = new System.Windows.Forms.Panel();
            label30 = new System.Windows.Forms.Label();
            panel_Upgrade.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
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
            panel16.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            panel_work.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            panel19.SuspendLayout();
            panel18.SuspendLayout();
            panel17.SuspendLayout();
            tabPage3.SuspendLayout();
            panel_shop.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            pn_Store_6.SuspendLayout();
            pn_Store_7.SuspendLayout();
            pn_Store_8.SuspendLayout();
            pn_Store_5.SuspendLayout();
            pn_Store_4.SuspendLayout();
            pn_Store_3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            pn_Store_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            pn_Store_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictstore).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // lbox_Chat_tab1
            // 
            lbox_Chat_tab1.Font = new System.Drawing.Font("Galmuri11 Regular", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbox_Chat_tab1.FormattingEnabled = true;
            lbox_Chat_tab1.ItemHeight = 22;
            lbox_Chat_tab1.Location = new System.Drawing.Point(39, 708);
            lbox_Chat_tab1.Name = "lbox_Chat_tab1";
            lbox_Chat_tab1.Size = new System.Drawing.Size(379, 70);
            lbox_Chat_tab1.TabIndex = 0;
            // 
            // lbox_Chat_tab3
            // 
            lbox_Chat_tab3.Font = new System.Drawing.Font("Galmuri11 Regular", 14.2499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbox_Chat_tab3.FormattingEnabled = true;
            lbox_Chat_tab3.ItemHeight = 25;
            lbox_Chat_tab3.Location = new System.Drawing.Point(39, 708);
            lbox_Chat_tab3.Name = "lbox_Chat_tab3";
            lbox_Chat_tab3.Size = new System.Drawing.Size(379, 79);
            lbox_Chat_tab3.TabIndex = 0;
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
            flowLayoutPanel2.BackgroundImage = Properties.Resources.main_view_export;
            flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(panel21);
            flowLayoutPanel2.Controls.Add(panel20);
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
            flowLayoutPanel2.Location = new System.Drawing.Point(10, 56);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(604, 268);
            flowLayoutPanel2.TabIndex = 11;
            flowLayoutPanel2.Visible = false;
            // 
            // panel21
            // 
            panel21.BackColor = System.Drawing.Color.Transparent;
            panel21.BackgroundImage = Properties.Resources.main_view_panel_export;
            panel21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel21.Controls.Add(pictureBox22);
            panel21.Controls.Add(label34);
            panel21.Controls.Add(label35);
            panel21.Controls.Add(label36);
            panel21.Location = new System.Drawing.Point(389, 132);
            panel21.Margin = new System.Windows.Forms.Padding(2);
            panel21.Name = "panel21";
            panel21.Size = new System.Drawing.Size(177, 52);
            panel21.TabIndex = 6;
            // 
            // pictureBox22
            // 
            pictureBox22.BackColor = System.Drawing.Color.Transparent;
            pictureBox22.Image = Properties.Resources.gold;
            pictureBox22.Location = new System.Drawing.Point(0, 7);
            pictureBox22.Margin = new System.Windows.Forms.Padding(2);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new System.Drawing.Size(47, 45);
            pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox22.TabIndex = 1;
            pictureBox22.TabStop = false;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label34.Location = new System.Drawing.Point(54, 11);
            label34.Name = "label34";
            label34.Size = new System.Drawing.Size(0, 20);
            label34.TabIndex = 0;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = System.Drawing.Color.Transparent;
            label35.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label35.Location = new System.Drawing.Point(95, 27);
            label35.Name = "label35";
            label35.Size = new System.Drawing.Size(13, 16);
            label35.TabIndex = 0;
            label35.Text = "-";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.BackColor = System.Drawing.Color.Transparent;
            label36.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label36.Location = new System.Drawing.Point(54, 9);
            label36.Name = "label36";
            label36.Size = new System.Drawing.Size(99, 16);
            label36.TabIndex = 0;
            label36.Text = "전설 용사 (10강)";
            // 
            // panel20
            // 
            panel20.BackColor = System.Drawing.Color.Transparent;
            panel20.BackgroundImage = Properties.Resources.main_view_panel_export;
            panel20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel20.Controls.Add(pictureBox21);
            panel20.Controls.Add(label31);
            panel20.Controls.Add(label32);
            panel20.Controls.Add(label33);
            panel20.Location = new System.Drawing.Point(387, 76);
            panel20.Margin = new System.Windows.Forms.Padding(2);
            panel20.Name = "panel20";
            panel20.Size = new System.Drawing.Size(177, 52);
            panel20.TabIndex = 6;
            // 
            // pictureBox21
            // 
            pictureBox21.BackColor = System.Drawing.Color.Transparent;
            pictureBox21.Image = Properties.Resources.warrior_high1;
            pictureBox21.Location = new System.Drawing.Point(2, 7);
            pictureBox21.Margin = new System.Windows.Forms.Padding(2);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new System.Drawing.Size(47, 45);
            pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox21.TabIndex = 1;
            pictureBox21.TabStop = false;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label31.Location = new System.Drawing.Point(54, 11);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(0, 20);
            label31.TabIndex = 0;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = System.Drawing.Color.Transparent;
            label32.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label32.Location = new System.Drawing.Point(95, 27);
            label32.Name = "label32";
            label32.Size = new System.Drawing.Size(13, 16);
            label32.TabIndex = 0;
            label32.Text = "-";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BackColor = System.Drawing.Color.Transparent;
            label33.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label33.Location = new System.Drawing.Point(54, 9);
            label33.Name = "label33";
            label33.Size = new System.Drawing.Size(105, 16);
            label33.TabIndex = 0;
            label33.Text = "베테랑 용사 (9강)";
            // 
            // panel14
            // 
            panel14.BackColor = System.Drawing.Color.Transparent;
            panel14.BackgroundImage = Properties.Resources.main_view_panel_export;
            panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel14.Controls.Add(pictureBox12);
            panel14.Controls.Add(label18);
            panel14.Controls.Add(lb_Puls_8_Count);
            panel14.Controls.Add(lb_Allview8);
            panel14.Location = new System.Drawing.Point(387, 20);
            panel14.Margin = new System.Windows.Forms.Padding(2);
            panel14.Name = "panel14";
            panel14.Size = new System.Drawing.Size(177, 52);
            panel14.TabIndex = 6;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = System.Drawing.Color.Transparent;
            pictureBox12.Image = Properties.Resources.warrior_low1;
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
            lb_Puls_8_Count.BackColor = System.Drawing.Color.Transparent;
            lb_Puls_8_Count.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_8_Count.Location = new System.Drawing.Point(95, 31);
            lb_Puls_8_Count.Name = "lb_Puls_8_Count";
            lb_Puls_8_Count.Size = new System.Drawing.Size(13, 16);
            lb_Puls_8_Count.TabIndex = 0;
            lb_Puls_8_Count.Text = "-";
            // 
            // lb_Allview8
            // 
            lb_Allview8.AutoSize = true;
            lb_Allview8.BackColor = System.Drawing.Color.Transparent;
            lb_Allview8.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Allview8.Location = new System.Drawing.Point(54, 9);
            lb_Allview8.Name = "lb_Allview8";
            lb_Allview8.Size = new System.Drawing.Size(93, 16);
            lb_Allview8.TabIndex = 0;
            lb_Allview8.Text = "신입 용사 (8강)";
            // 
            // panel13
            // 
            panel13.BackColor = System.Drawing.Color.Transparent;
            panel13.BackgroundImage = Properties.Resources.main_view_panel_export;
            panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel13.Controls.Add(pictureBox11);
            panel13.Controls.Add(label17);
            panel13.Controls.Add(lb_Allview7);
            panel13.Controls.Add(lb_Puls_7_Count);
            panel13.Location = new System.Drawing.Point(205, 188);
            panel13.Margin = new System.Windows.Forms.Padding(2);
            panel13.Name = "panel13";
            panel13.Size = new System.Drawing.Size(177, 52);
            panel13.TabIndex = 6;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = System.Drawing.Color.Transparent;
            pictureBox11.Image = Properties.Resources.soldier_high_stand;
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
            lb_Allview7.BackColor = System.Drawing.Color.Transparent;
            lb_Allview7.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Allview7.Location = new System.Drawing.Point(54, 9);
            lb_Allview7.Name = "lb_Allview7";
            lb_Allview7.Size = new System.Drawing.Size(93, 16);
            lb_Allview7.TabIndex = 0;
            lb_Allview7.Text = "고참 기사 (7강)";
            // 
            // lb_Puls_7_Count
            // 
            lb_Puls_7_Count.AutoSize = true;
            lb_Puls_7_Count.BackColor = System.Drawing.Color.Transparent;
            lb_Puls_7_Count.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_7_Count.Location = new System.Drawing.Point(95, 27);
            lb_Puls_7_Count.Name = "lb_Puls_7_Count";
            lb_Puls_7_Count.Size = new System.Drawing.Size(13, 16);
            lb_Puls_7_Count.TabIndex = 0;
            lb_Puls_7_Count.Text = "-";
            // 
            // panel12
            // 
            panel12.BackColor = System.Drawing.Color.Transparent;
            panel12.BackgroundImage = Properties.Resources.main_view_panel_export;
            panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel12.Controls.Add(pictureBox10);
            panel12.Controls.Add(label16);
            panel12.Controls.Add(lb_Allview6);
            panel12.Controls.Add(lb_Puls_6_Count);
            panel12.Location = new System.Drawing.Point(205, 132);
            panel12.Margin = new System.Windows.Forms.Padding(2);
            panel12.Name = "panel12";
            panel12.Size = new System.Drawing.Size(177, 52);
            panel12.TabIndex = 6;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = System.Drawing.Color.Transparent;
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
            lb_Allview6.BackColor = System.Drawing.Color.Transparent;
            lb_Allview6.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Allview6.Location = new System.Drawing.Point(70, 9);
            lb_Allview6.Name = "lb_Allview6";
            lb_Allview6.Size = new System.Drawing.Size(64, 16);
            lb_Allview6.TabIndex = 0;
            lb_Allview6.Text = "기사 (6강)";
            // 
            // lb_Puls_6_Count
            // 
            lb_Puls_6_Count.AutoSize = true;
            lb_Puls_6_Count.BackColor = System.Drawing.Color.Transparent;
            lb_Puls_6_Count.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_6_Count.Location = new System.Drawing.Point(95, 27);
            lb_Puls_6_Count.Name = "lb_Puls_6_Count";
            lb_Puls_6_Count.Size = new System.Drawing.Size(13, 16);
            lb_Puls_6_Count.TabIndex = 0;
            lb_Puls_6_Count.Text = "-";
            // 
            // panel11
            // 
            panel11.BackColor = System.Drawing.Color.Transparent;
            panel11.BackgroundImage = Properties.Resources.main_view_panel_export;
            panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel11.Controls.Add(pictureBox9);
            panel11.Controls.Add(label15);
            panel11.Controls.Add(lb_Allview5);
            panel11.Controls.Add(lb_Puls_5_Count);
            panel11.Location = new System.Drawing.Point(205, 76);
            panel11.Margin = new System.Windows.Forms.Padding(2);
            panel11.Name = "panel11";
            panel11.Size = new System.Drawing.Size(177, 52);
            panel11.TabIndex = 6;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = System.Drawing.Color.Transparent;
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
            lb_Allview5.BackColor = System.Drawing.Color.Transparent;
            lb_Allview5.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Allview5.Location = new System.Drawing.Point(54, 9);
            lb_Allview5.Name = "lb_Allview5";
            lb_Allview5.Size = new System.Drawing.Size(93, 16);
            lb_Allview5.TabIndex = 0;
            lb_Allview5.Text = "측근 군인 (5강)";
            // 
            // lb_Puls_5_Count
            // 
            lb_Puls_5_Count.AutoSize = true;
            lb_Puls_5_Count.BackColor = System.Drawing.Color.Transparent;
            lb_Puls_5_Count.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_5_Count.Location = new System.Drawing.Point(95, 26);
            lb_Puls_5_Count.Name = "lb_Puls_5_Count";
            lb_Puls_5_Count.Size = new System.Drawing.Size(13, 16);
            lb_Puls_5_Count.TabIndex = 0;
            lb_Puls_5_Count.Text = "-";
            // 
            // panel10
            // 
            panel10.BackColor = System.Drawing.Color.Transparent;
            panel10.BackgroundImage = Properties.Resources.main_view_panel_export;
            panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel10.Controls.Add(pictureBox8);
            panel10.Controls.Add(label14);
            panel10.Controls.Add(lb_Allview4);
            panel10.Controls.Add(lb_Puls_4_Count);
            panel10.Location = new System.Drawing.Point(205, 20);
            panel10.Margin = new System.Windows.Forms.Padding(2);
            panel10.Name = "panel10";
            panel10.Size = new System.Drawing.Size(177, 52);
            panel10.TabIndex = 5;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = System.Drawing.Color.Transparent;
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
            lb_Allview4.BackColor = System.Drawing.Color.Transparent;
            lb_Allview4.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Allview4.Location = new System.Drawing.Point(54, 9);
            lb_Allview4.Name = "lb_Allview4";
            lb_Allview4.Size = new System.Drawing.Size(93, 16);
            lb_Allview4.TabIndex = 0;
            lb_Allview4.Text = "일반 군인 (4강)";
            // 
            // lb_Puls_4_Count
            // 
            lb_Puls_4_Count.AutoSize = true;
            lb_Puls_4_Count.BackColor = System.Drawing.Color.Transparent;
            lb_Puls_4_Count.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_4_Count.Location = new System.Drawing.Point(95, 26);
            lb_Puls_4_Count.Name = "lb_Puls_4_Count";
            lb_Puls_4_Count.Size = new System.Drawing.Size(13, 16);
            lb_Puls_4_Count.TabIndex = 0;
            lb_Puls_4_Count.Text = "-";
            // 
            // panel9
            // 
            panel9.BackColor = System.Drawing.Color.Transparent;
            panel9.BackgroundImage = Properties.Resources.main_view_panel_export;
            panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel9.Controls.Add(pictureBox7);
            panel9.Controls.Add(label13);
            panel9.Controls.Add(lb_Allview3);
            panel9.Controls.Add(lb_Puls_3_Count);
            panel9.Location = new System.Drawing.Point(23, 188);
            panel9.Margin = new System.Windows.Forms.Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(177, 52);
            panel9.TabIndex = 5;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = System.Drawing.Color.Transparent;
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
            lb_Allview3.BackColor = System.Drawing.Color.Transparent;
            lb_Allview3.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Allview3.Location = new System.Drawing.Point(57, 9);
            lb_Allview3.Name = "lb_Allview3";
            lb_Allview3.Size = new System.Drawing.Size(93, 16);
            lb_Allview3.TabIndex = 0;
            lb_Allview3.Text = "상급 일꾼 (3강)";
            // 
            // lb_Puls_3_Count
            // 
            lb_Puls_3_Count.AutoSize = true;
            lb_Puls_3_Count.BackColor = System.Drawing.Color.Transparent;
            lb_Puls_3_Count.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_3_Count.Location = new System.Drawing.Point(95, 26);
            lb_Puls_3_Count.Name = "lb_Puls_3_Count";
            lb_Puls_3_Count.Size = new System.Drawing.Size(13, 16);
            lb_Puls_3_Count.TabIndex = 0;
            lb_Puls_3_Count.Text = "-";
            // 
            // panel8
            // 
            panel8.BackColor = System.Drawing.Color.Transparent;
            panel8.BackgroundImage = Properties.Resources.main_view_panel_export;
            panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel8.Controls.Add(pictureBox6);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(lb_Allview2);
            panel8.Controls.Add(lb_Puls_2_Count);
            panel8.Location = new System.Drawing.Point(23, 132);
            panel8.Margin = new System.Windows.Forms.Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(177, 52);
            panel8.TabIndex = 4;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = System.Drawing.Color.Transparent;
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
            lb_Allview2.BackColor = System.Drawing.Color.Transparent;
            lb_Allview2.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Allview2.Location = new System.Drawing.Point(57, 9);
            lb_Allview2.Name = "lb_Allview2";
            lb_Allview2.Size = new System.Drawing.Size(93, 16);
            lb_Allview2.TabIndex = 0;
            lb_Allview2.Text = "하급 일꾼 (2강)";
            // 
            // lb_Puls_2_Count
            // 
            lb_Puls_2_Count.AutoSize = true;
            lb_Puls_2_Count.BackColor = System.Drawing.Color.Transparent;
            lb_Puls_2_Count.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_2_Count.Location = new System.Drawing.Point(95, 26);
            lb_Puls_2_Count.Name = "lb_Puls_2_Count";
            lb_Puls_2_Count.Size = new System.Drawing.Size(13, 16);
            lb_Puls_2_Count.TabIndex = 0;
            lb_Puls_2_Count.Text = "-";
            // 
            // panel7
            // 
            panel7.BackColor = System.Drawing.Color.Transparent;
            panel7.BackgroundImage = Properties.Resources.main_view_panel_export;
            panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel7.Controls.Add(pictureBox5);
            panel7.Controls.Add(label11);
            panel7.Controls.Add(lb_Puls_1_Count);
            panel7.Controls.Add(lb_Allview1);
            panel7.Location = new System.Drawing.Point(23, 76);
            panel7.Margin = new System.Windows.Forms.Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(177, 52);
            panel7.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = System.Drawing.Color.Transparent;
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
            lb_Puls_1_Count.BackColor = System.Drawing.Color.Transparent;
            lb_Puls_1_Count.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_1_Count.Location = new System.Drawing.Point(95, 28);
            lb_Puls_1_Count.Name = "lb_Puls_1_Count";
            lb_Puls_1_Count.Size = new System.Drawing.Size(13, 16);
            lb_Puls_1_Count.TabIndex = 0;
            lb_Puls_1_Count.Text = "-";
            // 
            // lb_Allview1
            // 
            lb_Allview1.AutoSize = true;
            lb_Allview1.BackColor = System.Drawing.Color.Transparent;
            lb_Allview1.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Allview1.Location = new System.Drawing.Point(57, 9);
            lb_Allview1.Name = "lb_Allview1";
            lb_Allview1.Size = new System.Drawing.Size(91, 16);
            lb_Allview1.TabIndex = 0;
            lb_Allview1.Text = "상급 농부 (1강)";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.main_view_panel_export;
            panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(lb_Allview);
            panel2.Controls.Add(lb_Puls_0_Count);
            panel2.Location = new System.Drawing.Point(23, 20);
            panel2.Margin = new System.Windows.Forms.Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(177, 52);
            panel2.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
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
            lb_Allview.BackColor = System.Drawing.Color.Transparent;
            lb_Allview.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Allview.Location = new System.Drawing.Point(57, 9);
            lb_Allview.Name = "lb_Allview";
            lb_Allview.Size = new System.Drawing.Size(93, 16);
            lb_Allview.TabIndex = 0;
            lb_Allview.Text = "하급 농부 (0강)";
            // 
            // lb_Puls_0_Count
            // 
            lb_Puls_0_Count.AutoSize = true;
            lb_Puls_0_Count.BackColor = System.Drawing.Color.Transparent;
            lb_Puls_0_Count.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Puls_0_Count.Location = new System.Drawing.Point(95, 27);
            lb_Puls_0_Count.Name = "lb_Puls_0_Count";
            lb_Puls_0_Count.Size = new System.Drawing.Size(13, 16);
            lb_Puls_0_Count.TabIndex = 0;
            lb_Puls_0_Count.Text = "-";
            // 
            // btn_Refresh
            // 
            btn_Refresh.BackgroundImage = Properties.Resources.message;
            btn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_Refresh.FlatAppearance.BorderSize = 0;
            btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Refresh.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            flowLayoutPanel1.BackgroundImage = Properties.Resources.main_all_select_export;
            flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            flowLayoutPanel1.Controls.Add(btn_All0);
            flowLayoutPanel1.Controls.Add(btn_All1);
            flowLayoutPanel1.Controls.Add(btn_All2);
            flowLayoutPanel1.Controls.Add(btn_All3);
            flowLayoutPanel1.Controls.Add(btn_All4);
            flowLayoutPanel1.Controls.Add(btn_All5);
            flowLayoutPanel1.Controls.Add(btn_All6);
            flowLayoutPanel1.Controls.Add(btn_All7);
            flowLayoutPanel1.Controls.Add(btn_All8);
            flowLayoutPanel1.Controls.Add(btn_All9);
            flowLayoutPanel1.Controls.Add(btn_All10);
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(620, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(250, 266);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Visible = false;
            // 
            // btn_All0
            // 
            btn_All0.BackColor = System.Drawing.Color.Transparent;
            btn_All0.BackgroundImage = Properties.Resources.main_view_btn_export;
            btn_All0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_All0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All0.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_All0.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All0.ImageIndex = 0;
            btn_All0.ImageList = characters;
            btn_All0.Location = new System.Drawing.Point(18, 20);
            btn_All0.Margin = new System.Windows.Forms.Padding(18, 20, 3, 3);
            btn_All0.Name = "btn_All0";
            btn_All0.Size = new System.Drawing.Size(64, 50);
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
            characters.Images.SetKeyName(7, "knight_high.png");
            characters.Images.SetKeyName(8, "warrior_low.png");
            characters.Images.SetKeyName(9, "warrior_high.png");
            characters.Images.SetKeyName(10, "gold_soldier.png");
            // 
            // btn_All1
            // 
            btn_All1.BackColor = System.Drawing.Color.Transparent;
            btn_All1.BackgroundImage = Properties.Resources.main_view_btn_export;
            btn_All1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_All1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All1.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_All1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All1.ImageIndex = 1;
            btn_All1.ImageList = characters;
            btn_All1.Location = new System.Drawing.Point(18, 76);
            btn_All1.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            btn_All1.Name = "btn_All1";
            btn_All1.Size = new System.Drawing.Size(64, 50);
            btn_All1.TabIndex = 1;
            btn_All1.Tag = "1";
            btn_All1.Text = "1강";
            btn_All1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All1.UseVisualStyleBackColor = false;
            btn_All1.Click += btn_CreateAllButton;
            // 
            // btn_All2
            // 
            btn_All2.BackColor = System.Drawing.Color.Transparent;
            btn_All2.BackgroundImage = Properties.Resources.main_view_btn_export;
            btn_All2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_All2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All2.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_All2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All2.ImageIndex = 2;
            btn_All2.ImageList = characters;
            btn_All2.Location = new System.Drawing.Point(18, 132);
            btn_All2.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            btn_All2.Name = "btn_All2";
            btn_All2.Size = new System.Drawing.Size(64, 50);
            btn_All2.TabIndex = 2;
            btn_All2.Tag = "2";
            btn_All2.Text = "2강";
            btn_All2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All2.UseVisualStyleBackColor = false;
            btn_All2.Click += btn_CreateAllButton;
            // 
            // btn_All3
            // 
            btn_All3.BackColor = System.Drawing.Color.Transparent;
            btn_All3.BackgroundImage = Properties.Resources.main_view_btn_export;
            btn_All3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_All3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All3.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_All3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All3.ImageIndex = 3;
            btn_All3.ImageList = characters;
            btn_All3.Location = new System.Drawing.Point(18, 188);
            btn_All3.Margin = new System.Windows.Forms.Padding(18, 3, 3, 3);
            btn_All3.Name = "btn_All3";
            btn_All3.Size = new System.Drawing.Size(64, 50);
            btn_All3.TabIndex = 3;
            btn_All3.Tag = "3";
            btn_All3.Text = "3강";
            btn_All3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All3.UseVisualStyleBackColor = false;
            btn_All3.Click += btn_CreateAllButton;
            // 
            // btn_All4
            // 
            btn_All4.BackColor = System.Drawing.Color.Transparent;
            btn_All4.BackgroundImage = Properties.Resources.main_view_btn_export;
            btn_All4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_All4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All4.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_All4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All4.ImageIndex = 4;
            btn_All4.ImageList = characters;
            btn_All4.Location = new System.Drawing.Point(88, 20);
            btn_All4.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            btn_All4.Name = "btn_All4";
            btn_All4.Size = new System.Drawing.Size(64, 50);
            btn_All4.TabIndex = 4;
            btn_All4.Tag = "4";
            btn_All4.Text = "4강";
            btn_All4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All4.UseVisualStyleBackColor = false;
            btn_All4.Click += btn_CreateAllButton;
            // 
            // btn_All5
            // 
            btn_All5.BackColor = System.Drawing.Color.Transparent;
            btn_All5.BackgroundImage = Properties.Resources.main_view_btn_export;
            btn_All5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_All5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All5.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_All5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All5.ImageIndex = 5;
            btn_All5.ImageList = characters;
            btn_All5.Location = new System.Drawing.Point(88, 76);
            btn_All5.Name = "btn_All5";
            btn_All5.Size = new System.Drawing.Size(64, 50);
            btn_All5.TabIndex = 5;
            btn_All5.Tag = "5";
            btn_All5.Text = "5강";
            btn_All5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All5.UseVisualStyleBackColor = false;
            btn_All5.Click += btn_CreateAllButton;
            // 
            // btn_All6
            // 
            btn_All6.BackColor = System.Drawing.Color.Transparent;
            btn_All6.BackgroundImage = Properties.Resources.main_view_btn_export;
            btn_All6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_All6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All6.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_All6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All6.ImageIndex = 6;
            btn_All6.ImageList = characters;
            btn_All6.Location = new System.Drawing.Point(88, 132);
            btn_All6.Name = "btn_All6";
            btn_All6.Size = new System.Drawing.Size(64, 50);
            btn_All6.TabIndex = 6;
            btn_All6.Tag = "6";
            btn_All6.Text = "6강";
            btn_All6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All6.UseVisualStyleBackColor = false;
            btn_All6.Click += btn_CreateAllButton;
            // 
            // btn_All7
            // 
            btn_All7.BackColor = System.Drawing.Color.Transparent;
            btn_All7.BackgroundImage = Properties.Resources.main_view_btn_export;
            btn_All7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_All7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All7.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_All7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All7.ImageIndex = 7;
            btn_All7.ImageList = characters;
            btn_All7.Location = new System.Drawing.Point(88, 188);
            btn_All7.Name = "btn_All7";
            btn_All7.Size = new System.Drawing.Size(64, 50);
            btn_All7.TabIndex = 7;
            btn_All7.Tag = "7";
            btn_All7.Text = "7강";
            btn_All7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All7.UseVisualStyleBackColor = false;
            btn_All7.Click += btn_CreateAllButton;
            // 
            // btn_All8
            // 
            btn_All8.BackColor = System.Drawing.Color.Transparent;
            btn_All8.BackgroundImage = Properties.Resources.main_view_btn_export;
            btn_All8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_All8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All8.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_All8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All8.ImageIndex = 8;
            btn_All8.ImageList = characters;
            btn_All8.Location = new System.Drawing.Point(158, 20);
            btn_All8.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            btn_All8.Name = "btn_All8";
            btn_All8.Size = new System.Drawing.Size(64, 50);
            btn_All8.TabIndex = 8;
            btn_All8.Tag = "8";
            btn_All8.Text = "8강";
            btn_All8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All8.UseVisualStyleBackColor = false;
            btn_All8.Click += btn_CreateAllButton;
            // 
            // btn_All9
            // 
            btn_All9.BackColor = System.Drawing.Color.Transparent;
            btn_All9.BackgroundImage = Properties.Resources.main_view_btn_export;
            btn_All9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_All9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All9.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_All9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All9.ImageIndex = 9;
            btn_All9.ImageList = characters;
            btn_All9.Location = new System.Drawing.Point(158, 76);
            btn_All9.Name = "btn_All9";
            btn_All9.Size = new System.Drawing.Size(64, 50);
            btn_All9.TabIndex = 9;
            btn_All9.Tag = "8";
            btn_All9.Text = "9강";
            btn_All9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All9.UseVisualStyleBackColor = false;
            btn_All9.Click += btn_CreateAllButton;
            // 
            // btn_All10
            // 
            btn_All10.BackColor = System.Drawing.Color.Transparent;
            btn_All10.BackgroundImage = Properties.Resources.main_view_btn_export;
            btn_All10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_All10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_All10.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_All10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All10.ImageIndex = 10;
            btn_All10.ImageList = characters;
            btn_All10.Location = new System.Drawing.Point(158, 132);
            btn_All10.Name = "btn_All10";
            btn_All10.Size = new System.Drawing.Size(64, 50);
            btn_All10.TabIndex = 10;
            btn_All10.Tag = "8";
            btn_All10.Text = "10강";
            btn_All10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btn_All10.UseVisualStyleBackColor = false;
            btn_All10.Click += btn_CreateAllButton;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Galmuri11 Regular", 14.2499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(69, 12);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 25);
            label3.TabIndex = 0;
            label3.Text = "보유 골드 :";
            // 
            // lb_Money_tab1
            // 
            lb_Money_tab1.AutoSize = true;
            lb_Money_tab1.BackColor = System.Drawing.Color.Transparent;
            lb_Money_tab1.Font = new System.Drawing.Font("Galmuri11 Regular", 14.2499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Money_tab1.ForeColor = System.Drawing.Color.White;
            lb_Money_tab1.Location = new System.Drawing.Point(187, 11);
            lb_Money_tab1.Name = "lb_Money_tab1";
            lb_Money_tab1.Size = new System.Drawing.Size(107, 25);
            lb_Money_tab1.TabIndex = 0;
            lb_Money_tab1.Text = "lb_Money";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new System.Drawing.Font("Galmuri11 Regular", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabControl1.Location = new System.Drawing.Point(1, 50);
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
            tabPage1.AutoScroll = true;
            tabPage1.BackColor = System.Drawing.Color.LightCyan;
            tabPage1.Controls.Add(flowLayoutPanel2);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(flowLayoutPanel1);
            tabPage1.Controls.Add(panel_Main);
            tabPage1.Controls.Add(lbox_Chat_tab1);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(panel16);
            tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            tabPage1.Location = new System.Drawing.Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(875, 831);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "강화소";
            tabPage1.Click += tabPage1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.FromArgb(128, 64, 64);
            label10.Font = new System.Drawing.Font("Galmuri11 Regular", 23.9999981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.SystemColors.Control;
            label10.Location = new System.Drawing.Point(734, 451);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(82, 42);
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
            pictureBox3.Location = new System.Drawing.Point(661, 355);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(219, 324);
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
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(71, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 31);
            label2.TabIndex = 16;
            label2.Text = "던전";
            // 
            // panel16
            // 
            panel16.BackColor = System.Drawing.SystemColors.ActiveBorder;
            panel16.BackgroundImage = Properties.Resources.ui_main;
            panel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel16.Controls.Add(btn_ViewUnit);
            panel16.Controls.Add(btn_AllChoice);
            panel16.Controls.Add(panel15);
            panel16.Dock = System.Windows.Forms.DockStyle.Top;
            panel16.Location = new System.Drawing.Point(3, 3);
            panel16.Margin = new System.Windows.Forms.Padding(2);
            panel16.Name = "panel16";
            panel16.Size = new System.Drawing.Size(874, 53);
            panel16.TabIndex = 23;
            // 
            // btn_ViewUnit
            // 
            btn_ViewUnit.BackColor = System.Drawing.Color.Transparent;
            btn_ViewUnit.BackgroundImage = Properties.Resources.message;
            btn_ViewUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_ViewUnit.FlatAppearance.BorderSize = 0;
            btn_ViewUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_ViewUnit.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_ViewUnit.ForeColor = System.Drawing.Color.White;
            btn_ViewUnit.Location = new System.Drawing.Point(431, 5);
            btn_ViewUnit.Name = "btn_ViewUnit";
            btn_ViewUnit.Size = new System.Drawing.Size(164, 44);
            btn_ViewUnit.TabIndex = 6;
            btn_ViewUnit.Text = "인원 보기";
            btn_ViewUnit.UseVisualStyleBackColor = false;
            btn_ViewUnit.Click += btn_ViewUnit_Click;
            // 
            // btn_AllChoice
            // 
            btn_AllChoice.BackColor = System.Drawing.Color.Transparent;
            btn_AllChoice.BackgroundImage = Properties.Resources.message;
            btn_AllChoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            btn_AllChoice.FlatAppearance.BorderSize = 0;
            btn_AllChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_AllChoice.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_AllChoice.ForeColor = System.Drawing.Color.White;
            btn_AllChoice.Location = new System.Drawing.Point(703, 5);
            btn_AllChoice.Name = "btn_AllChoice";
            btn_AllChoice.Size = new System.Drawing.Size(164, 44);
            btn_AllChoice.TabIndex = 5;
            btn_AllChoice.Text = "전체 선택";
            btn_AllChoice.UseVisualStyleBackColor = false;
            btn_AllChoice.Click += btn_AllChoice_Click;
            // 
            // panel15
            // 
            panel15.BackColor = System.Drawing.Color.Transparent;
            panel15.BackgroundImage = Properties.Resources.LongMessage;
            panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panel15.Controls.Add(pictureBox1);
            panel15.Controls.Add(label3);
            panel15.Controls.Add(lb_Money_tab1);
            panel15.Location = new System.Drawing.Point(15, 2);
            panel15.Margin = new System.Windows.Forms.Padding(2);
            panel15.Name = "panel15";
            panel15.Size = new System.Drawing.Size(375, 50);
            panel15.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = Properties.Resources.money;
            pictureBox1.Location = new System.Drawing.Point(22, 6);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(52, 45);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.mine_map;
            tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            tabPage2.Controls.Add(panel_work);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(pictureBox15);
            tabPage2.Controls.Add(pictureBox14);
            tabPage2.Controls.Add(pictureBox13);
            tabPage2.Controls.Add(panel19);
            tabPage2.Controls.Add(panel18);
            tabPage2.Controls.Add(panel17);
            tabPage2.Controls.Add(cbSelectBuild);
            tabPage2.Controls.Add(pbBuildHP);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new System.Drawing.Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(875, 833);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "광산";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel_work
            // 
            panel_work.BackgroundImage = Properties.Resources.message;
            panel_work.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panel_work.Controls.Add(label28);
            panel_work.Location = new System.Drawing.Point(670, 7);
            panel_work.Margin = new System.Windows.Forms.Padding(2);
            panel_work.Name = "panel_work";
            panel_work.Size = new System.Drawing.Size(194, 54);
            panel_work.TabIndex = 24;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new System.Drawing.Font("Galmuri11 Regular", 14.2499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label28.ForeColor = System.Drawing.Color.White;
            label28.Location = new System.Drawing.Point(73, 12);
            label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(50, 25);
            label28.TabIndex = 0;
            label28.Text = "일터";
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.LongMessage;
            panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panel4.Controls.Add(pictureBox19);
            panel4.Controls.Add(label23);
            panel4.Controls.Add(lb_Money_tab2_1);
            panel4.Location = new System.Drawing.Point(23, 5);
            panel4.Margin = new System.Windows.Forms.Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(375, 50);
            panel4.TabIndex = 23;
            // 
            // pictureBox19
            // 
            pictureBox19.BackColor = System.Drawing.Color.Transparent;
            pictureBox19.Image = Properties.Resources.money;
            pictureBox19.Location = new System.Drawing.Point(26, 6);
            pictureBox19.Margin = new System.Windows.Forms.Padding(2);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new System.Drawing.Size(52, 45);
            pictureBox19.TabIndex = 1;
            pictureBox19.TabStop = false;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = System.Drawing.Color.Transparent;
            label23.Font = new System.Drawing.Font("Galmuri11 Regular", 14.2499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label23.ForeColor = System.Drawing.Color.White;
            label23.Location = new System.Drawing.Point(77, 11);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(110, 25);
            label23.TabIndex = 0;
            label23.Text = "보유 골드 :";
            // 
            // lb_Money_tab2_1
            // 
            lb_Money_tab2_1.AutoSize = true;
            lb_Money_tab2_1.BackColor = System.Drawing.Color.Transparent;
            lb_Money_tab2_1.Font = new System.Drawing.Font("Galmuri11 Regular", 14.2499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Money_tab2_1.ForeColor = System.Drawing.Color.White;
            lb_Money_tab2_1.Location = new System.Drawing.Point(187, 10);
            lb_Money_tab2_1.Name = "lb_Money_tab2_1";
            lb_Money_tab2_1.Size = new System.Drawing.Size(107, 25);
            lb_Money_tab2_1.TabIndex = 0;
            lb_Money_tab2_1.Text = "lb_Money";
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
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label6.Location = new System.Drawing.Point(26, 13);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(90, 24);
            label6.TabIndex = 5;
            label6.Text = "현재 공격력";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label7.Location = new System.Drawing.Point(173, 10);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(18, 26);
            label7.TabIndex = 5;
            label7.Text = ":";
            // 
            // lbAttackSum
            // 
            lbAttackSum.AutoSize = true;
            lbAttackSum.BackColor = System.Drawing.Color.Transparent;
            lbAttackSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbAttackSum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lbAttackSum.Location = new System.Drawing.Point(204, 13);
            lbAttackSum.Name = "lbAttackSum";
            lbAttackSum.Size = new System.Drawing.Size(58, 24);
            lbAttackSum.TabIndex = 5;
            lbAttackSum.Text = "0 (+3)";
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
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label4.Location = new System.Drawing.Point(28, 14);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(71, 24);
            label4.TabIndex = 5;
            label4.Text = "남은 HP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label5.Location = new System.Drawing.Point(135, 11);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(18, 26);
            label5.TabIndex = 5;
            label5.Text = ":";
            // 
            // lbHP
            // 
            lbHP.AutoSize = true;
            lbHP.BackColor = System.Drawing.Color.Transparent;
            lbHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbHP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lbHP.Location = new System.Drawing.Point(183, 10);
            lbHP.Name = "lbHP";
            lbHP.Size = new System.Drawing.Size(16, 24);
            lbHP.TabIndex = 5;
            lbHP.Text = "-";
            // 
            // panel17
            // 
            panel17.BackgroundImage = Properties.Resources.LongMessage;
            panel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panel17.Controls.Add(lbBuildInfo);
            panel17.Location = new System.Drawing.Point(246, 64);
            panel17.Margin = new System.Windows.Forms.Padding(2);
            panel17.Name = "panel17";
            panel17.Size = new System.Drawing.Size(391, 54);
            panel17.TabIndex = 7;
            // 
            // lbBuildInfo
            // 
            lbBuildInfo.AutoSize = true;
            lbBuildInfo.Font = new System.Drawing.Font("Galmuri11 Regular", 14.2499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbBuildInfo.ForeColor = System.Drawing.Color.White;
            lbBuildInfo.Location = new System.Drawing.Point(93, 13);
            lbBuildInfo.Name = "lbBuildInfo";
            lbBuildInfo.Size = new System.Drawing.Size(203, 25);
            lbBuildInfo.TabIndex = 5;
            lbBuildInfo.Text = "1단계 건물 방어력 : 1";
            // 
            // cbSelectBuild
            // 
            cbSelectBuild.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbSelectBuild.FormattingEnabled = true;
            cbSelectBuild.Items.AddRange(new object[] { "1단계 건물", "2단계 건물", "3단계 건물", "4단계 건물", "5단계 건물" });
            cbSelectBuild.Location = new System.Drawing.Point(592, 637);
            cbSelectBuild.Name = "cbSelectBuild";
            cbSelectBuild.Size = new System.Drawing.Size(109, 30);
            cbSelectBuild.TabIndex = 6;
            cbSelectBuild.Text = "1단계 건물";
            cbSelectBuild.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pbBuildHP
            // 
            pbBuildHP.Location = new System.Drawing.Point(200, 574);
            pbBuildHP.Name = "pbBuildHP";
            pbBuildHP.Size = new System.Drawing.Size(500, 45);
            pbBuildHP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
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
            tabPage3.BackgroundImage = Properties.Resources.shop_map;
            tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            tabPage3.Controls.Add(panel_shop);
            tabPage3.Controls.Add(panel5);
            tabPage3.Controls.Add(pn_Store_6);
            tabPage3.Controls.Add(pn_Store_7);
            tabPage3.Controls.Add(pn_Store_8);
            tabPage3.Controls.Add(pn_Store_5);
            tabPage3.Controls.Add(pn_Store_4);
            tabPage3.Controls.Add(pn_Store_3);
            tabPage3.Controls.Add(pn_Store_2);
            tabPage3.Controls.Add(pn_Store_1);
            tabPage3.Controls.Add(pictstore);
            tabPage3.Controls.Add(lbox_Chat_tab3);
            tabPage3.Location = new System.Drawing.Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(875, 833);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "상점";
            // 
            // panel_shop
            // 
            panel_shop.BackColor = System.Drawing.Color.Transparent;
            panel_shop.BackgroundImage = Properties.Resources.message;
            panel_shop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panel_shop.Controls.Add(label29);
            panel_shop.Location = new System.Drawing.Point(670, 7);
            panel_shop.Margin = new System.Windows.Forms.Padding(2);
            panel_shop.Name = "panel_shop";
            panel_shop.Size = new System.Drawing.Size(194, 54);
            panel_shop.TabIndex = 25;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = System.Drawing.Color.Transparent;
            label29.Font = new System.Drawing.Font("Galmuri11 Regular", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label29.ForeColor = System.Drawing.Color.White;
            label29.Location = new System.Drawing.Point(72, 12);
            label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(50, 25);
            label29.TabIndex = 0;
            label29.Text = "상점";
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.LongMessage;
            panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            panel5.Controls.Add(pictureBox20);
            panel5.Controls.Add(label27);
            panel5.Controls.Add(lb_Money_tab3_1);
            panel5.Location = new System.Drawing.Point(23, 5);
            panel5.Margin = new System.Windows.Forms.Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(375, 50);
            panel5.TabIndex = 24;
            // 
            // pictureBox20
            // 
            pictureBox20.BackColor = System.Drawing.Color.Transparent;
            pictureBox20.Image = Properties.Resources.money;
            pictureBox20.Location = new System.Drawing.Point(28, 5);
            pictureBox20.Margin = new System.Windows.Forms.Padding(2);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new System.Drawing.Size(52, 45);
            pictureBox20.TabIndex = 1;
            pictureBox20.TabStop = false;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = System.Drawing.Color.Transparent;
            label27.Font = new System.Drawing.Font("Galmuri11 Regular", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label27.ForeColor = System.Drawing.Color.White;
            label27.Location = new System.Drawing.Point(79, 12);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(110, 25);
            label27.TabIndex = 0;
            label27.Text = "보유 골드 :";
            // 
            // lb_Money_tab3_1
            // 
            lb_Money_tab3_1.AutoSize = true;
            lb_Money_tab3_1.BackColor = System.Drawing.Color.Transparent;
            lb_Money_tab3_1.Font = new System.Drawing.Font("Galmuri11 Regular", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_Money_tab3_1.ForeColor = System.Drawing.Color.White;
            lb_Money_tab3_1.Location = new System.Drawing.Point(189, 11);
            lb_Money_tab3_1.Name = "lb_Money_tab3_1";
            lb_Money_tab3_1.Size = new System.Drawing.Size(107, 25);
            lb_Money_tab3_1.TabIndex = 0;
            lb_Money_tab3_1.Text = "lb_Money";
            // 
            // pn_Store_6
            // 
            pn_Store_6.BackColor = System.Drawing.Color.Transparent;
            pn_Store_6.BackgroundImage = Properties.Resources.title_shop;
            pn_Store_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pn_Store_6.Controls.Add(label26);
            pn_Store_6.Location = new System.Drawing.Point(616, 566);
            pn_Store_6.Name = "pn_Store_6";
            pn_Store_6.Size = new System.Drawing.Size(180, 73);
            pn_Store_6.TabIndex = 1;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label26.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label26.Location = new System.Drawing.Point(37, 20);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(97, 32);
            label26.TabIndex = 3;
            label26.Text = "로또(상급)\r\n가격 : 50000원";
            // 
            // pn_Store_7
            // 
            pn_Store_7.BackColor = System.Drawing.Color.Transparent;
            pn_Store_7.BackgroundImage = Properties.Resources.title_shop;
            pn_Store_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pn_Store_7.Controls.Add(label24);
            pn_Store_7.Location = new System.Drawing.Point(457, 345);
            pn_Store_7.Name = "pn_Store_7";
            pn_Store_7.Size = new System.Drawing.Size(165, 94);
            pn_Store_7.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label24.Location = new System.Drawing.Point(20, 29);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(109, 32);
            label24.TabIndex = 3;
            label24.Text = "강화 확률 증가(소)\r\n가격 : 1000원\r\n";
            // 
            // pn_Store_8
            // 
            pn_Store_8.BackColor = System.Drawing.Color.Transparent;
            pn_Store_8.BackgroundImage = Properties.Resources.title_shop;
            pn_Store_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pn_Store_8.Controls.Add(label25);
            pn_Store_8.Location = new System.Drawing.Point(41, 545);
            pn_Store_8.Name = "pn_Store_8";
            pn_Store_8.Size = new System.Drawing.Size(161, 94);
            pn_Store_8.TabIndex = 1;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label25.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label25.Location = new System.Drawing.Point(19, 29);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(109, 32);
            label25.TabIndex = 3;
            label25.Text = "강화 확률 증가(대)\r\n가격 : 50000원";
            // 
            // pn_Store_5
            // 
            pn_Store_5.BackColor = System.Drawing.Color.Transparent;
            pn_Store_5.BackgroundImage = Properties.Resources.title_shop;
            pn_Store_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pn_Store_5.Controls.Add(label22);
            pn_Store_5.Location = new System.Drawing.Point(296, 635);
            pn_Store_5.Name = "pn_Store_5";
            pn_Store_5.Size = new System.Drawing.Size(180, 73);
            pn_Store_5.TabIndex = 1;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label22.Location = new System.Drawing.Point(43, 21);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(89, 32);
            label22.TabIndex = 3;
            label22.Text = "로또 (중급)\r\n가격 : 3000원";
            // 
            // pn_Store_4
            // 
            pn_Store_4.BackColor = System.Drawing.Color.Transparent;
            pn_Store_4.BackgroundImage = Properties.Resources.title_shop;
            pn_Store_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pn_Store_4.Controls.Add(label21);
            pn_Store_4.Location = new System.Drawing.Point(179, 410);
            pn_Store_4.Name = "pn_Store_4";
            pn_Store_4.Size = new System.Drawing.Size(180, 81);
            pn_Store_4.TabIndex = 1;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label21.Location = new System.Drawing.Point(45, 23);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(81, 32);
            label21.TabIndex = 3;
            label21.Text = "로또 (하급)\r\n가격 : 300원\r\n";
            // 
            // pn_Store_3
            // 
            pn_Store_3.BackColor = System.Drawing.Color.Transparent;
            pn_Store_3.BackgroundImage = Properties.Resources.title_shop;
            pn_Store_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pn_Store_3.Controls.Add(label20);
            pn_Store_3.Controls.Add(pictureBox18);
            pn_Store_3.Location = new System.Drawing.Point(484, 160);
            pn_Store_3.Name = "pn_Store_3";
            pn_Store_3.Size = new System.Drawing.Size(212, 89);
            pn_Store_3.TabIndex = 1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label20.Location = new System.Drawing.Point(79, 26);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(89, 32);
            label20.TabIndex = 3;
            label20.Text = "기사 10명\r\n가격 : 7700원\r\n";
            // 
            // pictureBox18
            // 
            pictureBox18.Image = Properties.Resources.knight;
            pictureBox18.Location = new System.Drawing.Point(26, 21);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new System.Drawing.Size(50, 50);
            pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox18.TabIndex = 4;
            pictureBox18.TabStop = false;
            // 
            // pn_Store_2
            // 
            pn_Store_2.BackColor = System.Drawing.Color.Transparent;
            pn_Store_2.BackgroundImage = Properties.Resources.title_shop;
            pn_Store_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pn_Store_2.Controls.Add(label19);
            pn_Store_2.Controls.Add(pictureBox16);
            pn_Store_2.Location = new System.Drawing.Point(309, 151);
            pn_Store_2.Name = "pn_Store_2";
            pn_Store_2.Size = new System.Drawing.Size(195, 94);
            pn_Store_2.TabIndex = 1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label19.Location = new System.Drawing.Point(68, 32);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(91, 32);
            label19.TabIndex = 3;
            label19.Text = "상급 일꾼 10명\r\n가격 : 330원\r\n";
            // 
            // pictureBox16
            // 
            pictureBox16.Image = Properties.Resources.worker_high;
            pictureBox16.Location = new System.Drawing.Point(25, 25);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new System.Drawing.Size(50, 50);
            pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox16.TabIndex = 4;
            pictureBox16.TabStop = false;
            // 
            // pn_Store_1
            // 
            pn_Store_1.BackColor = System.Drawing.Color.Transparent;
            pn_Store_1.BackgroundImage = Properties.Resources.title_shop;
            pn_Store_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pn_Store_1.Controls.Add(label9);
            pn_Store_1.Controls.Add(pictureBox17);
            pn_Store_1.Location = new System.Drawing.Point(41, 177);
            pn_Store_1.Name = "pn_Store_1";
            pn_Store_1.Size = new System.Drawing.Size(215, 94);
            pn_Store_1.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Galmuri11 Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label9.Location = new System.Drawing.Point(81, 30);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(91, 32);
            label9.TabIndex = 3;
            label9.Text = "하급 농부 10명\r\n가격 : 110원\r\n";
            // 
            // pictureBox17
            // 
            pictureBox17.BackColor = System.Drawing.Color.Transparent;
            pictureBox17.Image = Properties.Resources.peasent;
            pictureBox17.Location = new System.Drawing.Point(30, 25);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new System.Drawing.Size(50, 50);
            pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox17.TabIndex = 4;
            pictureBox17.TabStop = false;
            // 
            // pictstore
            // 
            pictstore.BackColor = System.Drawing.Color.Transparent;
            pictstore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictstore.Image = Properties.Resources.shop_character;
            pictstore.Location = new System.Drawing.Point(361, 345);
            pictstore.Name = "pictstore";
            pictstore.Size = new System.Drawing.Size(57, 57);
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
            building.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            building.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("building.ImageStream");
            building.TransparentColor = System.Drawing.Color.Transparent;
            building.Images.SetKeyName(0, "build_1.png");
            building.Images.SetKeyName(1, "build_2.png");
            building.Images.SetKeyName(2, "build_3.png");
            building.Images.SetKeyName(3, "build_4.png");
            // 
            // build
            // 
            build.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            build.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("build.ImageStream");
            build.TransparentColor = System.Drawing.Color.Transparent;
            build.Images.SetKeyName(0, "build_1.png");
            build.Images.SetKeyName(1, "build_2.png");
            build.Images.SetKeyName(2, "build_3.png");
            build.Images.SetKeyName(3, "build_4.png");
            build.Images.SetKeyName(4, "build_5.png");
            // 
            // game_main_exit
            // 
            game_main_exit.BackColor = System.Drawing.Color.Transparent;
            game_main_exit.BackgroundImage = Properties.Resources.exit;
            game_main_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            game_main_exit.FlatAppearance.BorderSize = 0;
            game_main_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            game_main_exit.Location = new System.Drawing.Point(824, 4);
            game_main_exit.Name = "game_main_exit";
            game_main_exit.Size = new System.Drawing.Size(59, 35);
            game_main_exit.TabIndex = 10;
            game_main_exit.UseVisualStyleBackColor = false;
            game_main_exit.Click += game_main_exit_Click;
            // 
            // panel6
            // 
            panel6.BackColor = System.Drawing.Color.Transparent;
            panel6.BackgroundImage = Properties.Resources.ui_main;
            panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel6.Controls.Add(label30);
            panel6.Controls.Add(game_main_exit);
            panel6.Dock = System.Windows.Forms.DockStyle.Top;
            panel6.Location = new System.Drawing.Point(0, 0);
            panel6.Margin = new System.Windows.Forms.Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(884, 45);
            panel6.TabIndex = 11;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new System.Drawing.Font("Galmuri11 Regular", 14.2499981F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label30.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label30.Location = new System.Drawing.Point(11, 11);
            label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label30.Name = "label30";
            label30.Size = new System.Drawing.Size(115, 25);
            label30.TabIndex = 11;
            label30.Text = "용사 키우기";
            // 
            // MobleTeamProject_Gambling
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(884, 900);
            Controls.Add(tabControl1);
            Controls.Add(panel6);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "MobleTeamProject_Gambling";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MobleTeamProject_Gambling";
            FormClosed += MobleTeamProject_Gambling_FormClosed;
            Load += MobleTeamProject_Gambling_Load;
            panel_Upgrade.ResumeLayout(false);
            panel_Upgrade.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
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
            panel16.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            panel_work.ResumeLayout(false);
            panel_work.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
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
            panel_shop.ResumeLayout(false);
            panel_shop.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            pn_Store_6.ResumeLayout(false);
            pn_Store_6.PerformLayout();
            pn_Store_7.ResumeLayout(false);
            pn_Store_7.PerformLayout();
            pn_Store_8.ResumeLayout(false);
            pn_Store_8.PerformLayout();
            pn_Store_5.ResumeLayout(false);
            pn_Store_5.PerformLayout();
            pn_Store_4.ResumeLayout(false);
            pn_Store_4.PerformLayout();
            pn_Store_3.ResumeLayout(false);
            pn_Store_3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            pn_Store_2.ResumeLayout(false);
            pn_Store_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            pn_Store_1.ResumeLayout(false);
            pn_Store_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictstore).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lbox_Chat_tab1;
        private System.Windows.Forms.ListBox lbox_Chat_tab3;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Money_tab1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.Panel pn_Store_2;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lb_Money_tab2_1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lb_Money_tab3_1;
        private System.Windows.Forms.ImageList build;
        private System.Windows.Forms.Button game_main_exit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel_work;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel_shop;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.PictureBox pictureBox21;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btn_All9;
        private System.Windows.Forms.Button btn_All10;
    }
}