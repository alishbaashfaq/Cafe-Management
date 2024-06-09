using cafemanagament.allusercontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafemanagament
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        public DashBoard( string user)
        {
            InitializeComponent();
            if (user == "Guest")
            {

                button2.Hide();
                button3.Hide();
                button4.Hide();
            }
            else if(user== "Admin" )
            {
                button2.Show();
                button3.Show();
                button4.Show();
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();

        }
       


        private void button3_Click(object sender, EventArgs e)
        {
            uc_additems.visible = true;
            uc_additems.bringtofront();
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            uc_additems.visible = false;
        }
    }
}
