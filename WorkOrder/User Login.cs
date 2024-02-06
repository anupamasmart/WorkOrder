using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkOrder
{
    public partial class User_Login : Form
    {
        public User_Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            SqlDataAdapter sqd = new SqlDataAdapter("Select * From User_Details Where UserID='" + textBox1 + "' and Password='" + textBox2 + "'", conn.ActiveConnection());
            DataTable dt = new DataTable();
            sqd.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                Dialog_Work_Order obj = new Dialog_Work_Order();
                obj.Show();
                this.Hide();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
