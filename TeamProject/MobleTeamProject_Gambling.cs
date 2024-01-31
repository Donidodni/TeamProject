using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//const int one_to_two = 90;
//const int zero_to_one = 90;
//const int zero_to_one = 90;
//const int zero_to_one = 90;
//const int zero_to_one = 90;
//const int zero_to_one = 90;
//const int zero_to_one = 90;
//const int zero_to_one = 90;

namespace TeamProject
{
    public partial class MobleTeamProject_Gambling : Form
    {
        public class WeaponUpgrade //무기 속성
        {
            public int Level { get; set; }
            public string Name { get; set; }
            public int Attack { get; set; }
            public int SellPrice { get; set; }
        }
        List<List<WeaponUpgrade>> weapons = new List<List<WeaponUpgrade>>(); // 무기의 숫자를 나타냄. weapons[0]에는 0강 무기 n개 존재
        Dictionary<int, WeaponUpgrade> weaponsDictionary = new Dictionary<int, WeaponUpgrade>(); //키,값 형태로 무기강화별 정보를 저장

        List<Panel> MainPanelList = new List<Panel>(); // 무기들 랜덤생성시 중복 검사
        public MobleTeamProject_Gambling()
        {
            InitializeComponent();
            InitializeWeapons(); //Dictionary에 무기 정보 추가
            for (int i = 0; i < 11; i++)
            {
                List<WeaponUpgrade> weaponUpgrades = new List<WeaponUpgrade>();
                weapons.Add(weaponUpgrades); // 0~10강 무기를 담을 리스트 생성
            }

        }



        void AddPanels(int type, int count) // type만큼 강화된 무기 count만큼 생성
        {
            if (weaponsDictionary.ContainsKey(type))
            {
                List<WeaponUpgrade> weaponUpgradeList = weapons[type];
                for (int i = 0; i < count; i++)
                {
                    Random random = new Random();
                    int x = random.Next(0, 10);
                    int y = random.Next(0, 5);

                    WeaponUpgrade existingWeapon = weaponsDictionary[type];

                    Panel testPanel = new Panel(); // 패널 객체 생성
                    testPanel.Size = new System.Drawing.Size(50, 30); // 패널 크기 설정
                    testPanel.BackColor = Color.FromName(existingWeapon.Name); // 색깔 설정(없어도 됨)
                    testPanel.Name = existingWeapon.Name; // 이부분에서 기사,농부등 무기별 이미지 설정
                    testPanel.Location = new Point(x * 50, y * 50);

                    while (CheckOverlap(testPanel, MainPanelList))
                    {
                        lbox_Chat.Items.Add($"겹침 x : {x} y : {y}");
                        x = random.Next(0, 5);
                        y = random.Next(0, 5);
                        testPanel.Location = new Point(x * 50, y * 50);
                    }

                    lbox_Chat.Items.Add($"x : {x} y : {y}");
                    panel_Main.Controls.Add(testPanel); // 메인 패널에 패널 추가
                    testPanel.Click += Panel_Click;

                    // 새로운 무기를 추가하는 대신 이미 있는 무기 속성을 사용
                    WeaponUpgrade newWeapon = new WeaponUpgrade()
                    {
                        Level = existingWeapon.Level,
                        Name = existingWeapon.Name,
                        Attack = existingWeapon.Attack,
                        SellPrice = existingWeapon.SellPrice,
                    };
                    testPanel.Tag = $"Level: {newWeapon.Level}, Attack: {newWeapon.Attack}, Sell Price: {newWeapon.SellPrice}";


                    weaponUpgradeList.Add(newWeapon);


                }
            }
        }

        public bool CheckOverlap(Panel panel, List<Panel> MainPanelList)
        {
            foreach (Panel otherPanel in MainPanelList)
            {
                if (panel.Location == otherPanel.Location)
                    return true;
            }
            MainPanelList.Add(panel);
            return false; // 겹치지않음
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = (Panel)sender;
            Button enhanceButton = new Button();
            enhanceButton.Text = "강화하기";
            enhanceButton.Location = new Point(clickedPanel.Location.X + clickedPanel.Width, clickedPanel.Location.Y + 10);
            // enhanceButton 클릭 이벤트 처리
            enhanceButton.Click += (s, ev) =>
            {
                // 강화하기 기능 구현
                // ...
            };
            panel_Main.Controls.Add(enhanceButton);

            Button sendButton = new Button();
            sendButton.Text = "일터 보내기";
            sendButton.Location = new Point(clickedPanel.Location.X + clickedPanel.Width, clickedPanel.Location.Y + 40);
            // sendButton 클릭 이벤트 처리
            sendButton.Click += (s, ev) =>
            {
                // 일터 보내기 기능 구현
                // ...
            };
            panel_Main.Controls.Add(sendButton);

            Button sellButton = new Button();
            sellButton.Text = "판매하기";
            sellButton.Location = new Point(clickedPanel.Location.X + clickedPanel.Width, clickedPanel.Location.Y + 70);
            // sellButton 클릭 이벤트 처리
            sellButton.Click += (s, ev) =>
            {
                // 판매하기 기능 구현
                // ...
            };
            panel_Main.Controls.Add(sellButton);
        }


        private void btn_Test_Click(object sender, EventArgs e)
        {
            AddPanels(0, 5);
        }

        private void btn_Test2_Click(object sender, EventArgs e)
        {
            AddPanels(1, 5);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////강화소///////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                                                            /*일터 코드*/

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////일터/////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                                                            /*상점 코드*/

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////상점/////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
