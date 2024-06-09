using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cafemanagament.allusercontrol
{
    public partial class uc_additems : UserControl
    {
        internal static bool visible;

        public uc_additems()
        {
            InitializeComponent();
            SqlConnection con = SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bitsclan\Documents\itemsDB.mdf;Integrated Security=True;Connect Timeout=30");
        }

        private SqlConnection SqlConnection(string v)
        {
            throw new NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uc_additems_Load(object sender, EventArgs e)
        {

        }

        internal static void bringtofront()
        {
            throw new NotImplementedException();
        }
    }
}
