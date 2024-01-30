using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        int[,] unit_position = { { 114, 506 }, { 114, 450 }, { 114, 394 }, { 114, 338 }, { 114, 282 }, { 114, 226 }, { 114, 170 }, { 170, 114 }, { 226, 114 }, { 282, 114 }, 
                                    { 338, 114 }, { 394, 114 }, { 450, 114 }, { 506, 114 }, { 562, 114 }, { 620, 114 }, { 676, 170 }, { 676, 226 }, { 676, 282 }, { 676, 338 }, 
                                    { 676, 394 }, { 676, 450 }, { 676, 506 } };
        private void unit_Position(int[,] unit_position, int index)
        {

        }
        int unit_x = 114, unit_y = 506, unit_cnt = 0;
        private void button1_Click(object sender, EventArgs e)  //유닛 생성
        {
            unit_cnt++;
            if (unit_cnt <= 7)
            {
                Panel unit1 = new Panel();
                unit1.Location = new Point();
                unit1.Size = new Size(50, 50);
                unit1.BackColor = Color.Black;
                this.Controls.Add(unit1);

                unit_y -= 54;
            }
            if (unit_cnt > 7 && unit_cnt <= 16)
            {
                if (unit_cnt == 8)
                    unit_x += 54;

                Panel unit1 = new Panel();
                unit1.Location = new Point();
                unit1.Size = new Size(50, 50);
                unit1.BackColor = Color.Black;
                this.Controls.Add(unit1);

                unit_x += 54;
            }
            if (unit_cnt > 16 && unit_cnt <= 23)
            {
                if (unit_cnt == 17)
                    unit_y += 54;

                Panel unit1 = new Panel();
                unit1.Location = new Point(unit_x, unit_y);
                unit1.Size = new Size(50, 50);
                unit1.BackColor = Color.Black;
                this.Controls.Add(unit1);

                unit_y += 54;
            }
        }
    }
}
