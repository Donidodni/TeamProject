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

        public int Money; // 보유 돈
        List<List<WeaponUpgrade>> weapons = new List<List<WeaponUpgrade>>(); // 무기의 숫자를 나타냄. weapons[0]에는 0강 무기 n개 존재
        Dictionary<int, WeaponUpgrade> weaponsDictionary = new Dictionary<int, WeaponUpgrade>(); //키,값 형태로 무기강화별 정보를 저장
        Dictionary<Panel, Timer> timerDictionary = new Dictionary<Panel, Timer>(); //패널마다 타이머를 달아주어 개별 행동 가능
        List<Panel> MainPanelList = new List<Panel>(); // 무기들 랜덤생성시 중복 검사
        int[] SuccessProbability = { 100, 90, 80, 70, 60, 50, 40, 30, 20, 10, 5 }; //강화 확률
        int workX = 670; // 패널이 일터로 갈 수 있는 X좌표
        int upgradeY = -90; // 패널이 강화할 수 있는 Y좌표
        public bool EsterEgg = true;

        private Button enhanceButton;
        private Button sendButton;
        private Button sellButton;
        private Panel clickedPanel;

        private int speed = 10; // 이동 속도 조절 가능

        public MobleTeamProject_Gambling()
        {
            InitializeComponent();
            InitializeWeapons(); //Dictionary에 무기 정보 추가
            InitializeWeaponsList(); // 0~10강 무기를 담을 리스트 생성
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
                    int x = random.Next(0, 10); // 메인 패널 생성숫자 조절가능
                    int y = random.Next(2, 8);  // 메인 패널 생성숫자 조절가능
                    int limit = 10 * 6;  // x의 경우의 수 * y의 경우의 수

                    WeaponUpgrade existingWeapon = weaponsDictionary[type]; // Dictionary로 type강의 무기 정보를 가져옴

                    Panel testPanel = new Panel(); // 패널 객체 생성
                    testPanel.Size = new System.Drawing.Size(50, 50); // 패널 크기 설정
                    testPanel.BackgroundImage = characters.Images[type]; // 색깔 설정(없어도 됨)
                    // 현재 characters 이미지 리스트에 2강 밖에 없어서 그 이상 강화시 인덱스 오류

                    testPanel.Name = existingWeapon.Name; // 이부분에서 기사,농부등 무기별 이미지 설정
                    testPanel.Location = new Point(x * 50, y * 50);

                    if (MainPanelList.Count == limit)
                    {
                        MessageBox.Show("강화 공간 부족");
                        break;
                    }

                    while (CheckOverlap(testPanel, MainPanelList) && MainPanelList.Count != limit) // 이미 그 자리에 생성되있는지 체크
                    {
                        x = random.Next(0, 10);
                        y = random.Next(2, 8);
                        testPanel.Location = new Point(x * 50, y * 50);
                    }
                    testPanel.Click += Panel_Click;

                    // 새로운 무기를 추가하는 대신 이미 있는 무기 속성을 사용
                    WeaponUpgrade newWeapon = new WeaponUpgrade()
                    {
                        Level = existingWeapon.Level,
                        Name = existingWeapon.Name,
                        Attack = existingWeapon.Attack,
                        SellPrice = existingWeapon.SellPrice,
                    };
                    testPanel.Tag = $"{newWeapon.Level},{newWeapon.Attack},{newWeapon.SellPrice},{newWeapon.Name}";
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
        private void RemovePanel(Panel clickedPanel) // 선택된 판넬 삭제
        {
            string tagString = clickedPanel.Tag?.ToString();
            if (string.IsNullOrEmpty(tagString))
                return;

            string[] tagParts = tagString.Split(',');
            if (tagParts.Length < 1)
                return;

            if (int.TryParse(tagParts[0].Trim(), out int index) && index >= 0 && index < weapons.Count)
            {
                weapons[index].RemoveAt(0);
            }

            timerDictionary.Remove(clickedPanel);
            panel_Main.Controls.Remove(clickedPanel);
            MainPanelList.Remove(clickedPanel);
        }

        private void RemoveButtons() // 강화,일터,판매 버튼 삭제
        {
            if (enhanceButton != null)
            {
                panel_Main.Controls.Remove(enhanceButton);
                flowLayoutPanel1.Controls.Remove(enhanceButton);
                enhanceButton.Dispose();
                enhanceButton = null;
            }

            if (sendButton != null)
            {
                panel_Main.Controls.Remove(sendButton);
                flowLayoutPanel1.Controls.Remove(sendButton);
                sendButton.Dispose();
                sendButton = null;
            }

            if (sellButton != null)
            {
                panel_Main.Controls.Remove(sellButton);
                flowLayoutPanel1.Controls.Remove(sellButton);
                sellButton.Dispose();
                sellButton = null;
            }
        }


        private void Panel_Click(object sender, EventArgs e) // 판넬(무기) 클릭 이벤트
        {
            RemoveButtons();

            Panel clickedPanel = (Panel)sender;
            MakeButton(clickedPanel);
        }

        private void MakeButton(Panel clickedPanel) // 판넬(무기)를 클릭했을때 옆에 버튼생성
        {
            enhanceButton = new Button();
            enhanceButton.Text = "던전";
            enhanceButton.Location = new Point(clickedPanel.Location.X + clickedPanel.Width, clickedPanel.Location.Y + 10);
            enhanceButton.Click += (s, ev) => StartMovePanelUp(clickedPanel);
            panel_Main.Controls.Add(enhanceButton);
            enhanceButton.BringToFront();

            sendButton = new Button();
            sendButton.Text = "광산";
            sendButton.Location = new Point(clickedPanel.Location.X + clickedPanel.Width, clickedPanel.Location.Y + 40);
            // sendButton 클릭 이벤트 처리
            sendButton.Click += (s, ev) => StartMovePanelRight(clickedPanel);
            panel_Main.Controls.Add(sendButton);
            sendButton.BringToFront();

            sellButton = new Button();
            sellButton.Text = "판매";
            sellButton.Location = new Point(clickedPanel.Location.X + clickedPanel.Width, clickedPanel.Location.Y + 70);
            // sellButton 클릭 이벤트 처리
            sellButton.Click += (s, ev) => Sell(clickedPanel);
            panel_Main.Controls.Add(sellButton);
            sellButton.BringToFront();
        }

        private void MakeButton(Button clickedButton) //버튼(전체선택)을 클릭했을때 버튼생성
        {
            enhanceButton = new Button();
            enhanceButton.Text = "던전";
            enhanceButton.Location = new Point(clickedButton.Location.X + clickedButton.Width, clickedButton.Location.Y + 10);
            enhanceButton.Size = new Size(60, 25);
            enhanceButton.Click += (s, ev) => StartMove_FromButton_Up(clickedButton);
            flowLayoutPanel1.Controls.Add(enhanceButton);

            sendButton = new Button();
            sendButton.Text = "광산";
            sendButton.Location = new Point(clickedButton.Location.X + clickedButton.Width, clickedButton.Location.Y + 40);
            sendButton.Size = new Size(60, 25);
            // sendButton 클릭 이벤트 처리
            sendButton.Click += (s, ev) => StartMove_FromButton_Right(clickedButton);
            flowLayoutPanel1.Controls.Add(sendButton);

            sellButton = new Button();
            sellButton.Text = "판매";
            sellButton.Location = new Point(clickedButton.Location.X + clickedButton.Width, clickedButton.Location.Y + 70);
            sellButton.Size = new Size(60, 25);
            // sellButton 클릭 이벤트 처리
            sellButton.Click += (s, ev) => Sell_FromButton(clickedButton);
            flowLayoutPanel1.Controls.Add(sellButton);
        }
        private void StartMovePanelUp(Panel panel) // 판넬(무기)를 위로 보냄
        {
            RemoveButtons();
            Timer moveTimer = timerDictionary[panel];
            moveTimer.Interval = 10; // 타이머 주기 (20ms로 설정, 조절 가능)
            moveTimer.Tick += (s, ev) => MovePanelUp(panel, moveTimer);
            moveTimer.Start(); // 타이머 시작
        }

        private void StartMovePanelRight(Panel panel) // 판넬(무기)를 오른쪽으로 보냄
        {
            RemoveButtons();
            Timer moveTimer = timerDictionary[panel];
            moveTimer.Interval = 20; // 타이머 주기 (20ms로 설정, 조절 가능)
            moveTimer.Tick += (s, ev) => MovePanelRight(panel, moveTimer);
            moveTimer.Start(); // 타이머 시작
        }

        private void MovePanelUp(Panel clickedPanel, Timer moveTimer) // 위로 가다가 upgradeY를 만나면 강화
        {
            if (moveTimer != null)
            {
                clickedPanel.Location = new Point(clickedPanel.Location.X, clickedPanel.Location.Y - speed);
                CheckCollisionWithUpgradePanel(clickedPanel);

                if (clickedPanel.Location.Y <= upgradeY - 1)
                {
                    moveTimer.Stop();
                }
            }
        }

        private void MovePanelRight(Panel clickedPanel, Timer moveTimer) // 오른쪽으로 가다가 workX를 만나면 일터
        {
            clickedPanel.Location = new Point(clickedPanel.Location.X + speed, clickedPanel.Location.Y);
            CheckCollisionWithWorkPanel(clickedPanel);

            if (clickedPanel.Location.X == workX)
            {
                moveTimer.Stop();
            }
        }

        private void Sell(Panel clickedPanel) // 선택된 판넬(무기) 판매
        {
            string tagString = clickedPanel.Tag?.ToString();
            if (string.IsNullOrEmpty(tagString))
                return;

            string[] tagParts = tagString.Split(',');
            if (tagParts.Length < 3)
                return;

            if (int.TryParse(tagParts[2].Trim(), out int price))
            {
                Money += price;
                lb_Money.Text = $"{Money} 골드";
                RemovePanel(clickedPanel);
            }

            RemoveButtons();
        }






        private void CheckCollisionWithUpgradePanel(Panel selectedPanel) //Y축 검사
        {
            if (selectedPanel.Location.Y <= upgradeY - 1)
            {
                UpgradeWeapon(selectedPanel);
            }
        }

        private void CheckCollisionWithWorkPanel(Panel selectedPanel) //X축 검사
        {
            if ((selectedPanel.Location.Y <= upgradeY + 10) && (selectedPanel.Location.X >= workX - 20) && EsterEgg)
            {
                ShowMessage("이스터에그 발견! 1000골드가 추가됩니다");
                Money += 1000;
                lb_Money.Text = Money.ToString();
                EsterEgg = false;
                MoveWork(selectedPanel);
                RemovePanel(selectedPanel);
                return;

            }

            if (selectedPanel.Location.X == workX)
            {
                MoveWork(selectedPanel);
                RemovePanel(selectedPanel);
            }
        }

        private void ShowMessage(string message) //아래 ListBox에 메세지 추가
        {
            lbox_Chat.Items.Add(message);
            lbox_Chat.TopIndex = lbox_Chat.Items.Count - 1;
            // 스크롤 아래로 이동
            lbox_Chat.SelectedIndex = lbox_Chat.Items.Count - 1;
            lbox_Chat.SelectedIndex = -1; // 선택 해제
        }
        private void MoveWork(Panel clickedPanel) // 일터로 이동
        {
            Move(clickedPanel);
        }
        private void btn_AllChoice_Click(object sender, EventArgs e) //모두 강화 버튼 보이게/안보이게
        {
            flowLayoutPanel1.Visible = !flowLayoutPanel1.Visible;
        }
        private void btn_ViewUnit_Click(object sender, EventArgs e) // 김민석 - 유닛 보기 UI
        {
            flowLayoutPanel2.Visible = !flowLayoutPanel2.Visible;
        }

        private void btn_CreateAllButton(object sender, EventArgs e) //모두 강화 버튼 선택시 강화/일터/판매 보이게
        {
            RemoveButtons();
            MakeButton((Button)sender);
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            AddPanels(0, 10);
        }

        private void btn_Test2_Click(object sender, EventArgs e)
        {
            AddPanels(1, 1);
        }



        private void UpgradeWeapon(Panel clickedPanel) //무기 강화
        {
            string tagString = clickedPanel.Tag?.ToString();
            string[] tagParts = tagString.Split(',');
            if (tagParts.Length < 1)
                return;

            if (int.TryParse(tagParts[0].Trim(), out int index) && index >= 0 && index < SuccessProbability.Length)
            {
                Random random = new Random();
                int randomValue = random.Next(1, 101);

                // 강화 성공 시
                if (randomValue <= SuccessProbability[index])
                {
                    RemovePanel(clickedPanel);
                    AddPanels(index + 1, 1);
                    ShowMessage($"던전에서 성공적으로 돌아왔습니다. ({index + 1}강)");
                }
                // 강화 실패 시
                else
                {
                    RemovePanel(clickedPanel);
                    ShowMessage($"던전에서 돌아오지 못했습니다... ({index} 강)");
                }

                // 최대 채팅 수를 10으로 제한하고 오래된 채팅 삭제
                while (lbox_Chat.Items.Count > 10)
                {
                    lbox_Chat.Items.RemoveAt(0);
                }
            }

        }

        private Panel[] FindPanelFromButton(int i) //무기 강화 정도를 찾고 모두 선택
        {
            List<Panel> panels = new List<Panel>();
            foreach (Control control in panel_Main.Controls)
            {
                if (control is Panel panel && control.Tag != null)
                {
                    string[] tagParts = control.Tag.ToString().Split(',');
                    if (tagParts[0] == i.ToString())
                        panels.Add(panel);
                }

            }
            return panels.ToArray();
        }

        private void StartMove_FromButton_Up(Button clickedButton) // 모두 선택후 강화
        {
            Panel[] clickedPanel = FindPanelFromButton(int.Parse(clickedButton.Tag.ToString()));
            foreach (Panel panel in clickedPanel)
            {
                StartMovePanelUp(panel);
            }

        }

        private void StartMove_FromButton_Right(Button clickedButton) // 모두 선택후 일터
        {
            Panel[] clickedPanel = FindPanelFromButton(int.Parse(clickedButton.Tag.ToString()));
            foreach (Panel panel in clickedPanel)
            {
                StartMovePanelRight(panel);
            }
        }

        private void Sell_FromButton(Button clickedButton) // 모두 선택후 판매
        {
            Panel[] clickedPanel = FindPanelFromButton(int.Parse(clickedButton.Tag.ToString()));
            foreach (Panel panel in clickedPanel)
            {
                Sell(panel);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            RemoveButtons();
        }
        private void panel_Main_Click_1(object sender, EventArgs e) //다른곳 클릭시 이미 생성된 강화/일터/판매 삭제
        {
            RemoveButtons();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////강화소///////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        String Unit_Image1 = "C:\\Users\\user\\Pictures\\Screenshots\\스크린샷 2024-01-05 110728.png";

        //유닛 위치 정보 배열
        public int[,] PntArr = { { 144, 506 }, { 144, 450 }, { 144, 394 }, { 144, 282 }, { 144, 226 }, { 144, 170 }, { 200, 114 }, { 256, 114 }, { 312, 114 }, { 368, 114 }, { 480, 114 }, { 536, 114 }, { 592, 114 }, { 650, 114 }, { 706, 170 }, { 706, 226 }, { 706, 282 }, { 706, 394 }, { 706, 450 }, { 706, 506 } };
        public bool[] full = new bool[20];  //array 인덱스 좌표에 패널 할당 여부 초기값 false
        public int[] Attack = new int[20];  //좌표마다 유닛의 공격력 값 

        private void Move(Panel weapon)
        {
            string tagString = weapon.Tag?.ToString();
            string[] tagParts = tagString.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
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
                //MessageBox.Show("20개 이상 추가할 수 없습니다.");
                AddPanels(int.Parse(tagParts[0].Trim()), 1);

                lbox_Chat.Items.Add("20개 이상 추가할 수 없습니다.");
                lbox_Chat.SelectedIndex = lbox_Chat.Items.Count - 1;
                lbox_Chat.SelectedIndex = -1; // 선택 해제
            }
            else
            {
                Panel testPanel = new Panel(); // 패널 객체 생성
                testPanel.Size = new System.Drawing.Size(50, 50); // 패널 크기 설정
                testPanel.BackColor = Color.FromName(tagParts[3].Trim());
                //testPanel.BackgroundImage = System.Drawing.Image.FromFile(Unit_Image1);   //이미지로 넣을 경우
                testPanel.Name = "Test";
                for (int i = 0; i < 20; i++)
                {
                    if (!full[i])   //비어있을 경우
                    {
                        testPanel.Location = new Point(PntArr[i, 0], PntArr[i, 1]);   //유닛 생성 좌표 설정
                        full[i] = true; Attack[i] = int.Parse(tagParts[1]); //공격력 추가
                        break;
                    }
                }
                testPanel.Click += Panel1_Click;

                tabControl1.TabPages[1].Controls.Add(testPanel);    //유닛패널 생성
            }
            int index = int.Parse(tagParts[0].Trim());
            lbox_Chat.Items.Add($"일터로 +{tagParts[3]} 무기가 이동하였습니다.");
        }

        private void Panel1_Click(object sender, EventArgs e)    //패널 제거 -> 강화소 반환으로 수정예정
        {
            Panel clickedPanel = (Panel)sender;
            Controls.Remove(clickedPanel); clickedPanel.Dispose();
            for (int i = 0; i < 20; i++)   //패널 좌표와 비교
                if (clickedPanel.Location.X == PntArr[i, 0] && clickedPanel.Location.Y == PntArr[i, 1])
                {
                    full[i] = false; Attack[i] = 0;
                }
        }

        Panel pnBuilding = new Panel();
        private void AttackBuild()
        {
            if (cbSelectBuild.SelectedIndex != -1)  //건물을 선택했을 경우
            {
                int sum = 0;
                foreach (int i in Attack)
                {
                    sum += i;
                }
                if (pbBuildHP.Value > sum)
                    pbBuildHP.Value -= sum;
                //건물 파괴 시
                else
                {
                    pbBuildHP.Value = pbBuildHP.Minimum;    //HP = 0
                    Money += pbBuildHP.Maximum; //보상
                    lb_Money.Text = Money.ToString();
                    lbox_Chat.Items.Add($"{cbSelectBuild.SelectedIndex + 1}단계 건물을 파괴했습니다. (+{pbBuildHP.Maximum}골드)");
                    tabControl1.TabPages[1].Controls.Remove(pnBuilding);
                    timer1.Stop();
                }
                lbHP.Text = pbBuildHP.Value.ToString();
                lbAttackSum.Text = sum.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AttackBuild();
        }

        private void MobleTeamProject_Gambling_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnBuilding.Location = new Point(200, 170);   //건물 생성 좌표 설정
            pnBuilding.Size = new Size(500, 386); // 패널 크기 설정
            pbBuildHP.Minimum = 0;
            if (cbSelectBuild.SelectedIndex == 0)    //1단계 건물
            {
                //빌딩 생성
                pnBuilding.BackColor = Color.Black;
                //testPanel.BackgroundImage = System.Drawing.Image.FromFile(Unit_Image1);   //이미지로 넣을 경우

                //빌딩 HP 초기값
                pbBuildHP.Maximum = 100;
                pbBuildHP.Value = pbBuildHP.Maximum;

            }
            if (cbSelectBuild.SelectedIndex == 1)    //2단계 건물
            {
                //빌딩 생성
                pnBuilding.BackColor = Color.Red;
                //testPanel.BackgroundImage = System.Drawing.Image.FromFile(Unit_Image1);   //이미지로 넣을 경우

                //빌딩 HP 초기값
                pbBuildHP.Maximum = 200;
                pbBuildHP.Value = pbBuildHP.Maximum;

            }
            if (cbSelectBuild.SelectedIndex == 2)    //3단계 건물
            {
                //빌딩 생성
                pnBuilding.BackColor = Color.Purple;
                //testPanel.BackgroundImage = System.Drawing.Image.FromFile(Unit_Image1);   //이미지로 넣을 경우

                //빌딩 HP 초기값
                pbBuildHP.Maximum = 500;
                pbBuildHP.Value = pbBuildHP.Maximum;

            }
            if (cbSelectBuild.SelectedIndex == 3)    //4단계 건물
            {
                //빌딩 생성
                pnBuilding.BackColor = Color.Plum;
                //testPanel.BackgroundImage = System.Drawing.Image.FromFile(Unit_Image1);   //이미지로 넣을 경우

                //빌딩 HP 초기값
                pbBuildHP.Maximum = 1000;
                pbBuildHP.Value = pbBuildHP.Maximum;

            }
            if (cbSelectBuild.SelectedIndex == 4)    //5단계 건물
            {
                //빌딩 생성
                pnBuilding.BackColor = Color.Pink;
                //testPanel.BackgroundImage = System.Drawing.Image.FromFile(Unit_Image1);   //이미지로 넣을 경우

                //빌딩 HP 초기값
                pbBuildHP.Maximum = 2000;
                pbBuildHP.Value = pbBuildHP.Maximum;

            }
            tabControl1.TabPages[1].Controls.Add(pnBuilding);    //빌딩패널 생성
            timer1.Start(); //건물 공격 시작
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
