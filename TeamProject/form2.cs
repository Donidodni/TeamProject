using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }
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

        private void button1_Click(object sender, EventArgs e)  //유닛 생성
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
                //testPanel.BackColor = Color.Black;
                testPanel.BackgroundImage = System.Drawing.Image.FromFile(Unit_Image1);
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
                testPanel.Click += Panel_Click;

                NewUnit(testPanel);     //유닛의 레벨, 공격력 정보 할당
                Controls.Add(testPanel);    //유닛패널 생성
            }
        }

        private void Panel_Click(object sender, EventArgs e)    //패널 제거
        {
            Panel clickedPanel = (Panel)sender; 
            Controls.Remove(clickedPanel); clickedPanel.Dispose();
            for(int i = 0; i < 20; i++)   //패널 좌표와 비교
                if (clickedPanel.Location.X == PntArr[i, 0] && clickedPanel.Location.Y == PntArr[i, 1])
                    full[i] = false;
        }
    }
}
