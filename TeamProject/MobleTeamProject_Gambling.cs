using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


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

        public int Money;
        List<List<WeaponUpgrade>> weapons = new List<List<WeaponUpgrade>>(); // 무기의 숫자를 나타냄. weapons[0]에는 0강 무기 n개 존재
        Dictionary<int, WeaponUpgrade> weaponsDictionary = new Dictionary<int, WeaponUpgrade>(); //키,값 형태로 무기강화별 정보를 저장
        Dictionary<Panel, Timer> timerDictionary = new Dictionary<Panel, Timer>(); //패널마다 타이머를 달아주어 개별 행동 가능
        List<Panel> MainPanelList = new List<Panel>(); // 무기들 랜덤생성시 중복 검사
        int[] SuccessProbability = { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, 5 };

        private Button enhanceButton;
        private Button sendButton;
        private Button sellButton;
        private Panel clickedPanel;
        
        private int speed = 10; // 이동 속도 조절 가능

        public MobleTeamProject_Gambling()
        {
            InitializeComponent();
            InitializeWeapons(); //Dictionary에 무기 정보 추가
            for (int i = 0; i < 11; i++)
            {
                List<WeaponUpgrade> weaponUpgrades = new List<WeaponUpgrade>();
                weapons.Add(weaponUpgrades); // 0~10강 무기를 담을 리스트 생성
            }
            Money = 0;
            lb_Money.Text = Money.ToString() + " 골드";
        }



        void AddPanels(int type, int count) // type만큼 강화된 무기 count만큼 생성
        {
            if (weaponsDictionary.ContainsKey(type))
            {
                List<WeaponUpgrade> weaponUpgradeList = weapons[type];
                for (int i = 0; i < count; i++)
                {
                    Random random = new Random();
                    int x = random.Next(0, 3);
                    int y = random.Next(3, 6);

                    WeaponUpgrade existingWeapon = weaponsDictionary[type];

                    Panel testPanel = new Panel(); // 패널 객체 생성
                    testPanel.Size = new System.Drawing.Size(50, 30); // 패널 크기 설정
                    testPanel.BackColor = Color.FromName(existingWeapon.Name); // 색깔 설정(없어도 됨)
                    testPanel.Name = existingWeapon.Name; // 이부분에서 기사,농부등 무기별 이미지 설정
                    testPanel.Location = new Point(x * 50, y * 50);

                    while (CheckOverlap(testPanel, MainPanelList))
                    {
                        lbox_Chat.Items.Add($"겹침 x : {x} y : {y}");
                        x = random.Next(0, 3);
                        y = random.Next(3, 6);
                        testPanel.Location = new Point(x * 50, y * 50);
                    }

                    lbox_Chat.Items.Add($"x : {x} y : {y}");
                    
                    testPanel.Click += Panel_Click;

                    // 새로운 무기를 추가하는 대신 이미 있는 무기 속성을 사용
                    WeaponUpgrade newWeapon = new WeaponUpgrade()
                    {
                        Level = existingWeapon.Level,
                        Name = existingWeapon.Name,
                        Attack = existingWeapon.Attack,
                        SellPrice = existingWeapon.SellPrice,
                    };
                    testPanel.Tag = $"{newWeapon.Level},{newWeapon.Attack},{newWeapon.SellPrice}";
                    weaponUpgradeList.Add(newWeapon);

                    Timer moveTimer = new Timer();
                    moveTimer.Interval = 20;
                    timerDictionary.Add(testPanel, moveTimer);

                    panel_Main.Controls.Add(testPanel); // 메인 패널에 패널 추가
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
            RemoveButtons();

            Panel clickedPanel = (Panel)sender;
            enhanceButton = new Button();
            enhanceButton.Text = "강화하기";
            enhanceButton.Location = new Point(clickedPanel.Location.X + clickedPanel.Width, clickedPanel.Location.Y + 10);
            enhanceButton.Click += (s, ev) => StartMovePanelUp(clickedPanel);
            panel_Main.Controls.Add(enhanceButton);

            sendButton = new Button();
            sendButton.Text = "일터 보내기";
            sendButton.Location = new Point(clickedPanel.Location.X + clickedPanel.Width, clickedPanel.Location.Y + 40);
            // sendButton 클릭 이벤트 처리
            sendButton.Click += (s, ev) => StartMovePanelRight(clickedPanel);
            panel_Main.Controls.Add(sendButton);

            sellButton = new Button();
            sellButton.Text = "판매하기";
            sellButton.Location = new Point(clickedPanel.Location.X + clickedPanel.Width, clickedPanel.Location.Y + 70);
            // sellButton 클릭 이벤트 처리
            sellButton.Click += (s, ev) => Sell(clickedPanel);            
            panel_Main.Controls.Add(sellButton);
        }
        private void StartMovePanelUp(Panel panel)
        {
            RemoveButtons();
            Timer moveTimer = timerDictionary[panel];
            moveTimer.Interval = 20; // 타이머 주기 (20ms로 설정, 조절 가능)
            moveTimer.Tick += (s, ev) => MovePanelUp(panel,moveTimer);
            moveTimer.Start(); // 타이머 시작
        }

        private void StartMovePanelRight(Panel panel)
        {
            RemoveButtons();
            Timer moveTimer = timerDictionary[panel];
            moveTimer.Interval = 20; // 타이머 주기 (20ms로 설정, 조절 가능)
            moveTimer.Tick += (s, ev) => MovePanelRight(panel, moveTimer);
            moveTimer.Start(); // 타이머 시작
        }

        private void MovePanelUp(Panel clickedPanel, Timer moveTimer)
        {            
            if (moveTimer != null)
            {
                clickedPanel.Location = new Point(clickedPanel.Location.X, clickedPanel.Location.Y - speed);
                CheckCollisionWithUpgradePanel(clickedPanel);

                if (clickedPanel.Location.Y <= -90)
                {
                    moveTimer.Stop();
                }
              
                
            }          

        }

        private void MovePanelRight(Panel clickedPanel, Timer moveTimer)
        {
            clickedPanel.Location = new Point(clickedPanel.Location.X + speed, clickedPanel.Location.Y);
            CheckCollisionWithWorkPanel(clickedPanel);

            if (clickedPanel.Location.X >=670)
            {
                moveTimer.Stop();
            }

        }

        private void Sell(Panel clickedPanel)
        {
            string tagString = clickedPanel.Tag?.ToString();
            string[] tagParts = tagString.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            int index = int.Parse(tagParts[0].Trim());
            string sellPriceString = tagParts[2].Trim();
            if(int.TryParse(sellPriceString, out int price))
            {
                Money += price;
                lb_Money.Text = Money.ToString() + " 골드";
                RemovePanel(clickedPanel);
            }
            RemoveButtons();
        }

        private void RemovePanel(Panel clickedPanel)
        {
            string tagString = clickedPanel.Tag?.ToString();
            string[] tagParts = tagString.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            int index = int.Parse(tagParts[0].Trim());
            string sellPriceString = tagParts[2].Trim();
            weapons[index].RemoveAt(0);
            timerDictionary.Remove(clickedPanel);
            panel_Main.Controls.Remove(clickedPanel);
            MainPanelList.Remove(clickedPanel);
        }


        private void RemoveButtons()
        {
            if (enhanceButton != null)
            {
                panel_Main.Controls.Remove(enhanceButton);
                enhanceButton.Dispose();
                enhanceButton = null;
            }

            if (sendButton != null)
            {
                panel_Main.Controls.Remove(sendButton);
                sendButton.Dispose();
                sendButton = null;
            }

            if (sellButton != null)
            {
                panel_Main.Controls.Remove(sellButton);
                sellButton.Dispose();
                sellButton = null;
            }
        }

        private void CheckCollisionWithUpgradePanel(Panel selectedPanel)
        {
            if (selectedPanel.Location.Y <= -90)
            {
                UpgradeWeapon(selectedPanel);
                RemovePanel(selectedPanel);
            }
        }

        private void CheckCollisionWithWorkPanel(Panel selectedPanel)
        {
            if (selectedPanel.Location.X >= 670)
            {
                MoveWork(selectedPanel);
                RemovePanel(selectedPanel);
            }
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            AddPanels(0, 1);
        }

        private void btn_Test2_Click(object sender, EventArgs e)
        {
            AddPanels(1, 1);
        }

        private void panel_Main_Click_1(object sender, EventArgs e)
        {
            RemoveButtons();
        }

        private void UpgradeWeapon(Panel clickedPanel)
        {
            string tagString = clickedPanel.Tag?.ToString();
            string[] tagParts = tagString.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            int index = int.Parse(tagParts[0].Trim());
            Random random = new Random();
            int randomValue = random.Next(1, 101);
            if (randomValue <= SuccessProbability[index]) //강화 성공시
            {
                AddPanels(index + 1, 1);
                lbox_Chat.Items.Add($"강화가 성공하여 +{index+1} 무기가 제련되었습니다.");

            }
            else //강화 실패시
            {
                lbox_Chat.Items.Add($"강화가 실패하여 +{index} 무기가 파괴되었습니다.");
            }


        }

        private void MoveWork(Panel clickedPanel)
        {
            //Move(panel);
            string tagString = clickedPanel.Tag?.ToString();
            string[] tagParts = tagString.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            int index = int.Parse(tagParts[0].Trim());
            lbox_Chat.Items.Add($"일터로 +{tagParts[1]} 무기가 이동하였습니다.");
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////강화소///////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        String testPanel_Tag = "1,1,1";   //합칠 때 지우기
        String Unit_Image1 = "C:\\Users\\user\\Pictures\\Screenshots\\스크린샷 2024-01-05 110728.png";
        private void NewUnit(Panel panel)
        {
            string tagString = testPanel_Tag.ToString();    //합칠 때 이름 수정 -> testPanel.Tag?.ToString();
            string[] tagParts = tagString.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);   //강화소에서 온 유닛정보 스플릿
            int level = int.Parse(tagParts[0].Trim());  //유닛 레벨
            int Attack = int.Parse(tagParts[1].Trim()); //유닛 공격력
        }

        //유닛 위치 정보 배열
        public int[,] PntArr = { { 144, 506 }, { 144, 450 }, { 144, 394 }, { 144, 282 }, { 144, 226 }, { 144, 170 }, { 200, 114 }, { 256, 114 }, { 312, 114 }, { 368, 114 }, { 480, 114 }, { 536, 114 }, { 592, 114 }, { 650, 114 }, { 706, 170 }, { 706, 226 }, { 706, 282 }, { 706, 394 }, { 706, 450 }, { 706, 506 } };
        public bool[] full = new bool[20]; //array 인덱스 좌표에 패널 할당 여부

        private void UnitMake_Click(object sender, EventArgs e)  //유닛 생성
        {
            int cnt = 0;
            for (int i = 0; i < 20; i++)    //유닛의 자리가 모두 할당되었는지
            {
                if (full[i])
                    cnt++;
                else
                    continue;
            }
            if (cnt >= 20)
            {
                MessageBox.Show("20개 이상 추가할 수 없습니다.");
            }
            else
            {
                Panel testPanel = new Panel(); // 패널 객체 생성
                testPanel.Size = new System.Drawing.Size(50, 50); // 패널 크기 설정
                testPanel.BackColor = Color.Black;
                //testPanel.BackgroundImage = System.Drawing.Image.FromFile(Unit_Image1);
                testPanel.Name = "Test";
                for (int i = 0; i < 20; i++)
                {
                    if (!full[i])   //비어있을 경우
                    {
                        testPanel.Location = new Point(PntArr[i, 0], PntArr[i, 1]);   //유닛 생성 좌표 설정
                        full[i] = true;
                        break;
                    }
                }
                testPanel.Click += Panel1_Click;

                NewUnit(testPanel);     //유닛의 레벨, 공격력 정보 할당
                Controls.Add(testPanel);    //유닛패널 생성
               // tabControl2.
            }
        }

        private void Panel1_Click(object sender, EventArgs e)    //패널 제거
        {
            Panel clickedPanel = (Panel)sender;
            Controls.Remove(clickedPanel); clickedPanel.Dispose();
            for (int i = 0; i < 20; i++)   //패널 좌표와 비교
                if (clickedPanel.Location.X == PntArr[i, 0] && clickedPanel.Location.Y == PntArr[i, 1])
                    full[i] = false;
        }

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
