using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafemanagament.allusercontrol
{
    public partial class us_welcome : UserControl
    {
        public us_welcome()
        {
            InitializeComponent();
        }

        int num = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                label2.Location = new Point(94,367);
                
                label2.ForeColor = Color.OrangeRed;
                num++;
            }
            else if (num == 1)
            {
                label2.Location = new Point(166,367);
                label2.ForeColor = Color.LawnGreen;
                num++;

            }
            else if(num==2)
            {
                label2.Location = new Point(268, 367);
                label2.ForeColor = Color.RoyalBlue;
                num = 0;
            }
        }

        private void us_welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
