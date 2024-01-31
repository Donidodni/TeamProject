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
        const int zero_to_one = 90;
        List<Panel> MainPanelList = new List<Panel>();
        public MobleTeamProject_Gambling()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                //lbox_Chat.Items.Add(i.ToString());
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
        private void btn_Test_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, 5);
            int y = random.Next(0, 5);
            Panel testPanel = new Panel(); // 패널 객체 생성
            testPanel.Size = new System.Drawing.Size(50, 50); // 패널 크기 설정
            testPanel.BackColor = Color.Black; // 패널 배경색 설정
            int i = 0;
            testPanel.Location = new Point(x * 5, y * 5);
            while (CheckOverlap(testPanel, MainPanelList))
            {
                lbox_Chat.Items.Add($"겹침 x : {x} y : {y}");
                x = random.Next(0, 5);
                y = random.Next(0, 5);
                testPanel.Location = new Point(x * 5, y * 5);
                i++;
                if (i == 1000)
                    break;

            }

            lbox_Chat.Items.Add($"x : {x} y : {y}");


            panel_Main.Controls.Add(testPanel); // 메인 패널에 패널 추가
        }

        private void btn_Test2_Click(object sender, EventArgs e)
        {

        }
    }
}
