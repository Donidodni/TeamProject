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
using System.Media;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using WinFormsApp2;

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
        public int limit; // 유닛 한계치
        public int boost;
        List<List<WeaponUpgrade>> weapons = new List<List<WeaponUpgrade>>(); // 무기의 숫자를 나타냄. weapons[0]에는 0강 무기 n개 존재
        Dictionary<int, WeaponUpgrade> weaponsDictionary = new Dictionary<int, WeaponUpgrade>(); //키,값 형태로 무기강화별 정보를 저장
        Dictionary<Panel, Timer> timerDictionary = new Dictionary<Panel, Timer>(); //패널마다 타이머를 달아주어 개별 행동 가능
        List<Panel> MainPanelList = new List<Panel>(); // 무기들 랜덤생성시 중복 검사

        int[] SuccessProbability = { 90, 80, 70, 60, 40, 25, 15, 10, 5 }; //강화 확률
        int workX = 670; // 패널이 일터로 갈 수 있는 X좌표
        int upgradeY = -90; // 패널이 강화할 수 있는 Y좌표
        public bool EsterEgg = true;

        private Button enhanceButton;
        private Button sendButton;
        private Button sellButton;
        private Panel clickedPanel;

        private int speed = 10; // 이동 속도 조절 가능
        SoundPlayer ingame_bgm = new SoundPlayer(TeamProject.Properties.Resources.project_inbgm);

        public MobleTeamProject_Gambling()
        {
            InitializeComponent();
            InitializeWeapons(); //Dictionary에 무기 정보 추가
            InitializeWeaponsList(); // 0~10강 무기를 담을 리스트 생성
            Money = 110;
            limit = 10 * 6;  // x의 경우의 수 * y의 경우의 수
            boost = 0;
            ingame_bgm.Play(); // 김민석 - 해당 코드를 지움으로써 디버깅시 음악을 제거할 수 있습니다.
            MoneyResult();
            InitializePanelMovement();//상점 캐릭터 이동
        }
        private void game_main_exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    int y = random.Next(0, 6);  // 메인 패널 생성숫자 조절가능

                    WeaponUpgrade existingWeapon = weaponsDictionary[type]; // Dictionary로 type강의 무기 정보를 가져옴

                    Panel testPanel = new Panel(); // 패널 객체 생성
                    testPanel.Size = new System.Drawing.Size(50, 50); // 패널 크기 설정
                    testPanel.BackgroundImage = characters.Images[type]; // 색깔 설정(없어도 됨)

                    testPanel.Name = existingWeapon.Name; // 이부분에서 기사,농부등 무기별 이미지 설정
                    testPanel.Location = new Point(x * 50, y * 50);

                    if (MainPanelList.Count == limit)
                    {
                        break;
                    }

                    while (CheckOverlap(testPanel, MainPanelList) && MainPanelList.Count != limit) // 이미 그 자리에 생성되있는지 체크
                    {
                        x = random.Next(0, 10);
                        y = random.Next(0, 6);
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
            enhanceButton.Location = new Point(clickedPanel.Location.X + clickedPanel.Width + 20, clickedPanel.Location.Y + 10);
            enhanceButton.Click += (s, ev) => StartMovePanelUp(clickedPanel);
            panel_Main.Controls.Add(enhanceButton);
            enhanceButton.BringToFront();

            sendButton = new Button();
            sendButton.Text = "광산";
            sendButton.Location = new Point(clickedPanel.Location.X + clickedPanel.Width + 20, clickedPanel.Location.Y + 40);
            // sendButton 클릭 이벤트 처리
            sendButton.Click += (s, ev) => StartMovePanelRight(clickedPanel);
            panel_Main.Controls.Add(sendButton);
            sendButton.BringToFront();

            sellButton = new Button();
            sellButton.Text = "판매";
            sellButton.Location = new Point(clickedPanel.Location.X + clickedPanel.Width + 20, clickedPanel.Location.Y + 70);
            // sellButton 클릭 이벤트 처리
            sellButton.Click += (s, ev) => Sell(clickedPanel);
            panel_Main.Controls.Add(sellButton);
            sellButton.BringToFront();
        }

        private void MakeButton(Button clickedButton) //버튼(전체선택)을 클릭했을때 버튼생성
        {
            enhanceButton = new Button();
            enhanceButton.Text = "던전";
            //enhanceButton.Location = new Point(clickedButton.Location.X + clickedButton.Width + 20, clickedButton.Location.Y + 10);
            enhanceButton.Size = new Size(60, 25);
            enhanceButton.Click += (s, ev) => StartMove_FromButton_Up(clickedButton);
            flowLayoutPanel1.Controls.Add(enhanceButton);

            sendButton = new Button();
            sendButton.Text = "광산";
            //sendButton.Location = new Point(clickedButton.Location.X + clickedButton.Width + 20, clickedButton.Location.Y + 40);
            sendButton.Size = new Size(60, 25);
            // sendButton 클릭 이벤트 처리
            sendButton.Click += (s, ev) => StartMove_FromButton_Right(clickedButton);
            flowLayoutPanel1.Controls.Add(sendButton);

            sellButton = new Button();
            sellButton.Text = "판매";
            //sellButton.Location = new Point(clickedButton.Location.X + clickedButton.Width + 20, clickedButton.Location.Y + 70);
            sellButton.Size = new Size(60, 25);
            // sellButton 클릭 이벤트 처리
            sellButton.Click += (s, ev) => Sell_FromButton(clickedButton);
            flowLayoutPanel1.Controls.Add(sellButton);
        }
        private void StartMovePanelUp(Panel panel) // 판넬(무기)를 위로 보냄
        {
            RemoveButtons();
            Timer moveTimer = timerDictionary[panel];
            moveTimer.Interval = 20; // 타이머 주기 (20ms로 설정, 조절 가능)
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
            if (int.Parse(tagParts[0]) == 9)
            {
                EndGame();
            }

            if (int.TryParse(tagParts[2].Trim(), out int price))
            {
                Money += price;
                MoneyResult();
                ShowMessage($"{tagParts[3]}를 {price}원에 판매하였습니다.");
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
                MoneyResult();
                EsterEgg = false;
                MoveWork(selectedPanel);
                RemovePanel(selectedPanel);
                return;

            }

            if (selectedPanel.Location.X == workX)
            {
                MoveWork(selectedPanel);
            }
        }

        private void ShowMessage(string message) //아래 ListBox에 메세지 추가
        {
            lbox_Chat_tab1.Items.Add(message);
            lbox_Chat_tab1.TopIndex = lbox_Chat_tab1.Items.Count - 1;
            // 스크롤 아래로 이동
            lbox_Chat_tab1.SelectedIndex = lbox_Chat_tab1.Items.Count - 1;
            lbox_Chat_tab1.SelectedIndex = -1; // 선택 해제

            lbox_Chat_tab3.Items.Add(message);
            lbox_Chat_tab3.TopIndex = lbox_Chat_tab3.Items.Count - 1;
            // 스크롤 아래로 이동
            lbox_Chat_tab3.SelectedIndex = lbox_Chat_tab3.Items.Count - 1;
            lbox_Chat_tab3.SelectedIndex = -1; // 선택 해제

            while (lbox_Chat_tab1.Items.Count > 10)
            {
                lbox_Chat_tab1.Items.RemoveAt(0);
            }
            while (lbox_Chat_tab3.Items.Count > 10)
            {
                lbox_Chat_tab3.Items.RemoveAt(0);
            }
        }
        private void MoveWork(Panel clickedPanel) // 일터로 이동
        {
            bool isNotFull = false;
            for (int i = 0; i < 20; i++)    //유닛의 자리가 모두 할당되었는지
            {
                if (!full[i])
                {
                    isNotFull = true;
                    break;
                }
            }
            if (isNotFull)
            {
                Move(clickedPanel);
                RemovePanel(clickedPanel);
            }
            else
            {
                ShowMessage("광산에 유닛이 가득 찼습니다.");
                string tagString = clickedPanel.Tag?.ToString();
                string[] tagParts = tagString.Split(',');
                RemovePanel(clickedPanel);
                AddPanels(int.Parse(tagParts[0]), 1);
            }

        }
        private void btn_AllChoice_Click(object sender, EventArgs e) //모두 강화 버튼 보이게/안보이게
        {
            flowLayoutPanel1.Visible = !flowLayoutPanel1.Visible;
        }
        private void btn_ViewUnit_Click(object sender, EventArgs e) // 김민석 - 유닛 보기 UI
        {
            flowLayoutPanel2.Visible = !flowLayoutPanel2.Visible;

            UpdateUnitCountLabel(lb_Puls_0_Count, 0);
            UpdateUnitCountLabel(lb_Puls_1_Count, 1);
            UpdateUnitCountLabel(lb_Puls_2_Count, 2);
            UpdateUnitCountLabel(lb_Puls_3_Count, 3);
            UpdateUnitCountLabel(lb_Puls_4_Count, 4);
            UpdateUnitCountLabel(lb_Puls_5_Count, 5);
            UpdateUnitCountLabel(lb_Puls_6_Count, 6);
            UpdateUnitCountLabel(lb_Puls_7_Count, 7);
            UpdateUnitCountLabel(lb_Puls_8_Count, 8);
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            UpdateUnitCountLabel(lb_Puls_0_Count, 0);
            UpdateUnitCountLabel(lb_Puls_1_Count, 1);
            UpdateUnitCountLabel(lb_Puls_2_Count, 2);
            UpdateUnitCountLabel(lb_Puls_3_Count, 3);
            UpdateUnitCountLabel(lb_Puls_4_Count, 4);
            UpdateUnitCountLabel(lb_Puls_5_Count, 5);
            UpdateUnitCountLabel(lb_Puls_6_Count, 6);
            UpdateUnitCountLabel(lb_Puls_7_Count, 7);
            UpdateUnitCountLabel(lb_Puls_8_Count, 8);
        }


        private void UpdateUnitCountLabel(Label label, int weaponIndex)
        {
            label.Text = weapons[weaponIndex].Count.ToString() + " 명";
        }

        private void btn_CreateAllButton(object sender, EventArgs e) //모두 강화 버튼 선택시 강화/일터/판매 보이게
        {
            RemoveButtons();
            MakeButton((Button)sender);
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
                if (randomValue <= (SuccessProbability[index] + boost))
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

                boost = 0;
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

        private void EndGame()
        {
            MessageBox.Show("우승!");
        }

        private void MoneyResult()
        {
            lb_Money_tab1.Text = $"{Money}";
            lb_Money_tab2_1.Text = $"{Money}";
            lb_Money_tab3_1.Text = $"{Money}";
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////강화소///////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //유닛 위치 정보 배열
        int[,] PntArr = { { 144, 506 }, { 144, 450 }, { 144, 394 }, { 144, 282 }, { 144, 226 }, { 144, 170 },                               //좌
                          { 200, 114 }, { 256, 114 }, { 312, 114 }, { 368, 114 }, { 480, 114 }, { 536, 114 }, { 592, 114 }, { 650, 114 },   //상
                          { 706, 170 }, { 706, 226 }, { 706, 282 }, { 706, 394 }, { 706, 450 }, { 706, 506 } };                             //우

        bool[] full = new bool[20];  //array 인덱스 좌표에 패널 할당 여부 초기값 false
        int[] Attack = new int[20];  //좌표마다 유닛의 공격력 값
        int[] BuildArmor = { 1, 100, 400, 5000, 50000 };  //단계별 빌딩 방어력
        int[] BuildReward = { 30, 100, 400, 3000, 10000 };    //빌딩 단계별 보상
        int TurretAttack = 3;

        private void Move(Panel weapon)
        {
            ContextMenuStrip SelectUnit = new ContextMenuStrip();
            ToolStripMenuItem GoStrengStation = new ToolStripMenuItem();
            ToolStripMenuItem GoStrengStationAll = new ToolStripMenuItem();

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
            if (cnt >= 20)  //모두 할당 되었을 경우
            {
                AddPanels(int.Parse(tagParts[0].Trim()), 1);
            }
            else            //빈 자리가 있는 경우
            {
                List<WeaponUpgrade> we = weapons[int.Parse(tagParts[0].Trim())]; //weapons에 추가
                WeaponUpgrade newWeapon = new WeaponUpgrade()
                {
                    Level = int.Parse(tagParts[0].Trim()),
                    Name = tagParts[3],
                    Attack = int.Parse(tagParts[1].Trim()),
                    SellPrice = int.Parse(tagParts[2].Trim()),
                };
                we.Add(newWeapon);

                Panel testPanel = new Panel(); // 패널 객체 생성
                testPanel.Size = new Size(50, 50); // 패널 크기 설정
                testPanel.BackgroundImage = characters.Images[newWeapon.Level];   //이미지로 넣을 경우
                testPanel.Name = "Test";
                testPanel.Tag = $"{newWeapon.Level},{newWeapon.Attack},{newWeapon.SellPrice},{newWeapon.Name}";
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

                GoStrengStationAll.Text = "해당 레벨 모두 강화소 보내기";
                GoStrengStationAll.Click += (s, e) =>
                {
                    if (MainPanelList.Count < limit)
                    {
                        Panel[] SameLevetlUnit = Mine(int.Parse(tagParts[0].Trim()));    //모두 선택
                        foreach (Panel panel in SameLevetlUnit)
                        {
                            Controls.Remove(panel); panel.Dispose();
                            for (int i = 0; i < 20; i++)   //패널 좌표와 비교
                                if (panel.Location.X == PntArr[i, 0] && panel.Location.Y == PntArr[i, 1])
                                {
                                    full[i] = false; Attack[i] = 0; break;
                                }
                            weapons[int.Parse(tagParts[0].Trim())].RemoveAt(0);

                            AddPanels(int.Parse(tagParts[0].Trim()), 1);
                            ShowMessage($"강화소로 +{tagParts[3]} 무기가 이동하였습니다.");
                            AttackSum();
                        }
                    }
                    else
                        MessageBox.Show("강화 공간 부족");
                };

                //SelectUnit.Items.Add(GoStrengStation);
                SelectUnit.Items.Add(GoStrengStationAll);
                testPanel.ContextMenuStrip = SelectUnit;

                tabControl1.TabPages[1].Controls.Add(testPanel);    //유닛패널 생성
                //ShowMessage($"일터로 +{tagParts[3]} 무기가 이동하였습니다.");
                AttackSum();
            }
            int index = int.Parse(tagParts[0].Trim());
            ShowMessage($"광산으로 {tagParts[3]}이(가) 이동하였습니다.");
        }
        private void AttackSum()
        {
            int Attacksum = 0;  //현재 유닛 공격력 합계
            foreach (int i in Attack)
            {
                Attacksum += i;
            }
            lbAttackSum.Text = $"{Attacksum}  (+{TurretAttack})";
        }
        private void Panel1_Click(object sender, EventArgs e)    //패널 제거 -> 강화소 반환으로 수정예정
        {
            if (MainPanelList.Count < limit)
            {
                Panel clickedPanel = (Panel)sender;
                string tagString = clickedPanel.Tag?.ToString();
                string[] tagParts = tagString.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                Controls.Remove(clickedPanel); clickedPanel.Dispose();
                for (int i = 0; i < 20; i++)   //패널 좌표와 비교
                    if (clickedPanel.Location.X == PntArr[i, 0] && clickedPanel.Location.Y == PntArr[i, 1])
                    {
                        full[i] = false; Attack[i] = 0; break;
                    }
                weapons[int.Parse(tagParts[0].Trim())].RemoveAt(0);

                AddPanels(int.Parse(tagParts[0].Trim()), 1);
                ShowMessage($"강화소로 +{tagParts[3]} 무기가 이동하였습니다.");
                AttackSum();
            }
            else
                MessageBox.Show("강화 공간 부족");
        }
        private Panel[] Mine(int i) //무기 강화 정도를 찾고 모두 선택
        {
            List<Panel> panels = new List<Panel>();
            foreach (Control control in tabControl1.TabPages[1].Controls)
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


        Panel pnBuilding = new Panel();
        private void AttackBuild()
        {
            if (cbSelectBuild.SelectedIndex != -1)  //건물을 선택했을 경우
            {
                int Attacksum = 0;  //현재 유닛 공격력 합계
                foreach (int i in Attack)
                {
                    Attacksum += i;
                }
                Attacksum += TurretAttack;
                if (pbBuildHP.Value > Attacksum - BuildArmor[cbSelectBuild.SelectedIndex])
                {
                    //유닛의 공격력이 방어력보다 클 경우
                    if (Attacksum >= BuildArmor[cbSelectBuild.SelectedIndex])
                        pbBuildHP.Value -= Attacksum - BuildArmor[cbSelectBuild.SelectedIndex];
                }

                //건물 파괴 시
                else
                {
                    pbBuildHP.Value = pbBuildHP.Minimum;    //HP = 0
                    Money += BuildReward[cbSelectBuild.SelectedIndex];             //건물 파괴 보상
                    MoneyResult();
                    ShowMessage($"{cbSelectBuild.SelectedIndex + 1}단계 건물을 파괴했습니다. (+{BuildReward[cbSelectBuild.SelectedIndex]}골드)");
                    tabControl1.TabPages[1].Controls.Remove(pnBuilding);
                    NewBuilding(cbSelectBuild.SelectedIndex);
                }
                lbHP.Text = pbBuildHP.Value.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AttackBuild();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewBuilding(cbSelectBuild.SelectedIndex);
            lbBuildInfo.Text = $"{cbSelectBuild.SelectedIndex + 1}단계 건물 방어력 : {BuildArmor[cbSelectBuild.SelectedIndex]}";
        }

        private void NewBuilding(int BLevel)    //BLevel = cbSelectBuild.SelectedIndex
        {
            pnBuilding.Location = new Point(200, 170);
            pnBuilding.BackgroundImage = build.Images[BLevel];//건물 생성 좌표 설정
            pnBuilding.Size = new Size(500, 386); // 패널 크기 설정
            pbBuildHP.Minimum = 0;

            Color[] BColor = { Color.Black, Color.Red, Color.Pink, Color.Plum, Color.Gold }; //단계별 빌딩 색상
            int[] BuildHP = { 100, 500, 5000, 30000, 100000 };  //단계별 빌딩 HP
            //빌딩 생성
            // pnBuilding.BackColor = BColor[BLevel];
            //pnBuilding.BackgroundImage = building.Images[BLevel];   //이미지로 넣을 경우
            pnBuilding.BackgroundImageLayout = ImageLayout.Center;
            //testPanel.BackgroundImage = System.Drawing.Image.FromFile(Unit_Image1);   //이미지로 넣을 경우

            //빌딩 HP 초기값
            pbBuildHP.Maximum = BuildHP[BLevel];
            pbBuildHP.Value = pbBuildHP.Maximum;
            tabControl1.TabPages[1].Controls.Add(pnBuilding);    //빌딩패널 생성
        }



        private void MobleTeamProject_Gambling_Load(object sender, EventArgs e)
        {
            NewBuilding(0);
            timer1.Start(); //건물 공격 시작
        }

        private void MobleTeamProject_Gambling_FormClosed(object sender, FormClosedEventArgs e)
        {
            ingame_bgm.Stop();
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////일터/////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /*상점 코드*/
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
            {
                tabPage3.Focus();
            }
        }

        private Panel Panel2;
        private PictureBox curr;
        // 이동 거리
        private bool movingUp, movingDown, movingLeft, movingRight;
        private void InitializePanelMovement()
        {
            Timer timerstorebay = new Timer();
            timerstorebay.Interval = 100;
            timerstorebay.Tick += timerstorebay_Tick;
            timerstorebay.Start();
            curr = pictstore;
            curr.Focus();
            this.KeyDown += tabControl1_KeyDown;
            this.KeyUp += tabControl1_KeyUp;
            Timer moveTimer = new Timer();
            timerstore.Interval = 10; // 타이머 간격 (10ms로 설정)
            timerstore.Tick += (sender, e) => MovePanel();
            timerstore.Start();
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
            {

                switch (e.KeyCode)
                {
                    case Keys.Up:
                        movingUp = true;
                        break;
                    case Keys.Left:
                        movingLeft = true;
                        break;
                    case Keys.Down:
                        movingDown = true;
                        break;
                    case Keys.Right:
                        movingRight = true;
                        break;
                }
            }
        }

        private void tabControl1_KeyUp(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage3)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        movingUp = false;
                        break;
                    case Keys.Left:
                        movingLeft = false;
                        break;
                    case Keys.Down:
                        movingDown = false;
                        break;
                    case Keys.Right:
                        movingRight = false;
                        break;
                }

            }
        }
        private void MovePanel()
        {
            // 현재 설정된 이동 플래그에 따라 판넬을 이동

            if (movingUp)
            {
                if (curr.Location.Y <= 0)
                {
                    curr.Top -= 0;
                }
                else
                {
                    curr.Top -= 5;
                }


            }
            if (movingDown)
            {
                if (curr.Location.Y >= 800)
                {
                    curr.Top -= 0;
                }
                else
                {
                    curr.Top += 5;
                }
            }
            if (movingLeft)
            {
                if (curr.Location.X <= 0)
                {
                    curr.Left -= 0;
                }
                else
                {
                    curr.Left -= 5;
                }
            }
            if (movingRight)
            {
                if (curr.Location.X >= 820)
                {
                    curr.Left += 0;
                }
                else
                    curr.Left += 5;
            }
        }
        private void timerstorebay_Tick(object sender, EventArgs e)
        {
            Rectangle b0 = curr.Bounds;
            Rectangle b1 = pn_Store_1.Bounds;
            Rectangle b2 = pn_Store_2.Bounds;
            Rectangle b3 = pn_Store_3.Bounds;
            Rectangle b4 = pn_Store_4.Bounds;
            Rectangle b5 = pn_Store_5.Bounds;
            Rectangle b6 = pn_Store_6.Bounds;
            Rectangle b7 = pn_Store_7.Bounds;
            Rectangle b8 = pn_Store_8.Bounds;

            if (b1.IntersectsWith(b0))  // 첫번째 비콘. 0강 10개 구매. 110원
            {
                Buyweapons(0, 110); // 강화단계,구매가격
            }
            else if (b2.IntersectsWith(b0))
            {
                Buyweapons(3, 330);
            }
            else if (b3.IntersectsWith(b0))  // 두번째 비콘. 3강 10개 구매. 330원
            {
                Buyweapons(6, 7700);
            }
            else if (b4.IntersectsWith(b0)) // 로또 하급 구매. 300원
            {
                BuyLotto(300);
            }
            else if (b5.IntersectsWith(b0)) // 로또 중급 구매. 3000원
            {
                BuyLotto(3000);
            }
            else if (b6.IntersectsWith(b0)) // 로또 상급 구매. 50000원
            {
                BuyLotto(50000);
            }
            else if (b7.IntersectsWith(b0)) // 확률 강화 하급. 1000원
            {
                SellBoostItem_1(1000);
            }
            else if (b8.IntersectsWith(b0)) // 확률 강화 상급. 50000원
            {
                SellBoostItem_2(50000);
            }
        }
        private void Buyweapons(int type, int price)
        {
            timerstorebay.Stop();
            curr.Location = new Point(361, 345);
            WeaponUpgrade existingWeapon = weaponsDictionary[type]; // Dictionary로 type강의 무기 정보를 가져옴

            if (Money < price)
            {
                ShowMessage("돈이 부족하여 구매에 실패하였습니다.");
            }
            else
            {

                if (MainPanelList.Count + 10 > limit)
                {
                    ShowMessage("공간이 부족하여 구매에 실패하였습니다.");
                }
                else
                {
                    Money -= price;
                    MoneyResult();
                    AddPanels(type, 10);
                    ShowMessage($"{existingWeapon.Name} 10명을 {price} 골드에 구매하였습니다.");
                }
            }
        }

        private void BuyLotto(int price)
        {
            timerstorebay.Stop();
            curr.Location = new Point(361, 345);
            Random random = new Random();
            int x = random.Next(1, 101);
            // 확률에 따른 결과 배열
            string[] results = { "꽝", "대박", "초대박" };

            // 확률에 따라 결과 선택
            int resultIndex = x <= 55 ? 0 : x <= 95 ? 1 : 2;
            string result = results[resultIndex];

            if (Money < price)
            {
                ShowMessage("돈이 부족하여 구매에 실패하였습니다.");
                if (x <= 30 && Money != 0)
                {
                    ShowMessage("돈이 없으면 몸으로 갚아야지.");
                    ShowMessage("이런! 당신은 혹사당한 나머지");
                    ShowMessage("병원비로 모든 돈을 써버렸습니다..");
                    Money = 0;
                    MoneyResult();
                }
            }
            else
            {
                switch (result)
                {
                    case "꽝":
                        ShowMessage("꽝!");
                        break;
                    case "대박":
                        ShowMessage("대박! 2배를 얻었습니다");
                        Money += price * 2;
                        break;
                    case "초대박":
                        ShowMessage("초대박! 10배를 얻었습니다");
                        Money += price * 10;

                        break;
                }
                Money -= price;
                MoneyResult();
            }
        }

        private void SellBoostItem_1(int price)
        {
            timerstorebay.Stop();
            curr.Location = new Point(361, 345);
            if (boost == 5)
            {
                ShowMessage("이미 적용되었습니다.");
            }
            else
            {
                if (Money < price)
                {
                    ShowMessage("돈이 부족하여 구매에 실패하였습니다.");
                }
                else
                {
                    ShowMessage("다음 던전이 조금 안전해진 느낌이 듭니다..");
                    boost = 5;
                    Money -= price;
                    MoneyResult();
                }
            }


        }

        private void SellBoostItem_2(int price)
        {
            timerstorebay.Stop();
            curr.Location = new Point(361, 345);
            if (boost == 10)
            {
                ShowMessage("이미 적용되었습니다.");
            }
            else
            {
                if (Money < price)
                {
                    ShowMessage("돈이 부족하여 구매에 실패하였습니다.");
                }
                else
                {
                    ShowMessage("다음 던전이 많이 안전해진 느낌이 듭니다..");
                    boost = 10;
                    Money -= price;
                    MoneyResult();
                }
            }


        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////상점/////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
