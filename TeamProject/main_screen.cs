using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;  //배경 음악 사용을 위해 필요하며, 프로젝트 - 프로젝트 참조 추가 - COM - Media.player 를 선택하여 활성화 합니다.

namespace WinFormsApp2
{
    public partial class main_screen : Form
    {

        static int second_count = 0; // 그라데이션 전용 카운트 변수입니다.
        Timer fade = new Timer();

        public main_screen()
        {
            InitializeComponent();
            Main_Title.Interval = 18;
            Main_Title.Enabled = true;
            pictureBox3.Visible = false;
        }



        private void playSimpleSound(int play) // 매개변수 있는 음악 재생 메서드 입니다. 
        {
            SoundPlayer simpleSound = new SoundPlayer(TeamProject.Properties.Resources.project_bgm);// 배경 음악 경로(주의 : wav 파일만 인식하며, mp3 사용시 인식 불가 에러 뜸)          
            if (play == 1) simpleSound.Play(); // 매개변수를 사용하여 음악 재생을 컨트롤 합니다. 
            else simpleSound.Stop();
        }
        private void playDingSound(int play)
        {
 
            SoundPlayer DingSound = new SoundPlayer(TeamProject.Properties.Resources.bing_sound);
            if (play == 1) DingSound.Play(); // 매개변수를 사용하여 음악 재생을 컨트롤 합니다. 
            else DingSound.Stop();
            //Media Player 가 동시 재생이 안되는 문제가 있습니다.
        }




        private void Main_Title_Tick(object sender, EventArgs e)
        {
            second_count++; // 그라데이션 전용 카운트 변수입니다.

            double gradient = 15 * Math.Pow(0.9, second_count); // 용사 사진에 그라데이션 이펙트를 부여합니다
            Point point = new Point(pictureBox1.Location.X + (int)gradient, pictureBox1.Location.Y);
            pictureBox1.Location = point;


            double gradient1 = 22 * Math.Pow(0.9, second_count); // 제목 사진에 그라데이션 이펙트를 부여합니다.
            Point point1 = new Point(pictureBox2.Location.X - (int)gradient1, pictureBox2.Location.Y);
            pictureBox2.Location = point1;

            if (second_count == 30) // 두 사진의 그라데이션 이펙트 부여 길이를 조절합니다. second_count가 40 이면 중지 및 리셋합니다. 
            {
                Main_Title.Enabled = false;
                pictureBox3.Visible = true;
                playDingSound(1);
                second_count = 0;
            }   
        }



        private void button1_Click(object sender, EventArgs e)
        {
            playSimpleSound(0); // 음악을 종료합니다.

            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opacity = 0;
            fade.Interval = 10;
            fade.Tick += new EventHandler(fadeIn);
            fade.Start();
        }
        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                fade.Stop();
            else
                Opacity += 0.02;
        }
    }
}
