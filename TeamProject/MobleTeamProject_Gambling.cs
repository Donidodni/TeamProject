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
    enum PanelColor
    {
        Color0,
        Color1,
        Color2,
        Color3,
        Color4,
        Color5,
        Color6,
        Color7,
        Color8,
        Color9,
        Color10
    }

    public partial class MobleTeamProject_Gambling : Form
    {
        const int zero_to_one = 90;
        List<List<Panel>> weaponUpgrades = new List<List<Panel>>();
        List<Panel> MainPanelList = new List<Panel>();
        public MobleTeamProject_Gambling()
        {
            InitializeComponent();
            for (int i = 0; i <= 10; i++)
            {
                weaponUpgrades.Add(new List<Panel>());
            }
        }
        void SetPanelColor(Panel panel, PanelColor color)
        {
            switch (color)
            {
                case PanelColor.Color0:
                    panel.BackColor = Color.Red;
                    break;
                case PanelColor.Color1:
                    panel.BackColor = Color.Blue;
                    break;
                case PanelColor.Color2:
                    panel.BackColor = Color.Green;
                    break;
                case PanelColor.Color3:
                    panel.BackColor = Color.Yellow;
                    break;
                case PanelColor.Color4:
                    panel.BackColor = Color.Orange;
                    break;
                case PanelColor.Color5:
                    panel.BackColor = Color.Purple;
                    break;
                case PanelColor.Color6:
                    panel.BackColor = Color.Pink;
                    break;
                case PanelColor.Color7:
                    panel.BackColor = Color.Brown;
                    break;
                case PanelColor.Color8:
                    panel.BackColor = Color.Gray;
                    break;
                case PanelColor.Color9:
                    panel.BackColor = Color.Cyan;
                    break;
                case PanelColor.Color10:
                    panel.BackColor = Color.Magenta;
                    break;
                default:
                    panel.BackColor = Color.White;
                    break;
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

        void AddPanels(int type, int count) // type강을 count만큼 구매
        {
            if (type >= 0 && type <= 10)
            {
                List<Panel> panelList = weaponUpgrades[type];
                for (int i = 0; i < count; i++)
                {
                    Random random = new Random();
                    int x = random.Next(0, 10);
                    int y = random.Next(0, 5);
                    Panel testPanel = new Panel(); // 패널 객체 생성
                    testPanel.Size = new System.Drawing.Size(50, 50); // 패널 크기 설정
                    testPanel.BackColor = Color.Black; // 패널 배경색 설정
                    testPanel.Name = "Level" + type;
                    int j = 0;
                    testPanel.Location = new Point(x * 50, y * 50);
                    while (CheckOverlap(testPanel, MainPanelList))
                    {
                        lbox_Chat.Items.Add($"겹침 x : {x} y : {y}");
                        x = random.Next(0, 5);
                        y = random.Next(0, 5);
                        testPanel.Location = new Point(x * 50, y * 50);
                        j++;
                        if (j == 1000)
                            break;
                    }
                    lbox_Chat.Items.Add($"x : {x} y : {y}");
                    panel_Main.Controls.Add(testPanel); // 메인 패널에 패널 추가
                    panelList.Add(testPanel);
                }
            }
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            AddPanels(0, 5);
        }

        private void btn_Test2_Click(object sender, EventArgs e)
        {
            AddPanels(1, 5);
        }
    }
}
