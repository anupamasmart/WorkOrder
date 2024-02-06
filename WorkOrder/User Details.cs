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
    public partial class User_Details : Form
    {
        public User_Details()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            RecordEdit();
            ViewGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            RecordSave();
            MessageBox.Show("Records Inserted Successfully..!");
            CreateNew();
            ViewGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RecordDelete();
            ViewGrid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateNew();
        }
        void RecordEdit()
        {
            Connection conn = new Connection();
            SqlCommand cmd = new SqlCommand("UPDATE User_Details  SET  UserName = ' " + txtName.Text + "', Password = ' " + txtPassword.Text + "',ContactNo = ' " + txtContact.Text + "',Region = ' " + txtRegion.Text + "' WHERE UserID =' " + txtID.Text + "' ", conn.ActiveConnection());
            
            cmd.ExecuteNonQuery();
        }
        void RecordSave()
        {
            Connection conn = new Connection();
            SqlCommand cmd = new SqlCommand("INSERT INTO User_Details values (@UserID,@UserName,@Password,@ContactNo,@Region)", conn.ActiveConnection());
            cmd.Parameters.AddWithValue("@UserID", txtID.Text);
            cmd.Parameters.AddWithValue("@UserName",txtName.Text);
            cmd.Parameters.AddWithValue("@Password",txtPassword.Text);
            cmd.Parameters.AddWithValue("@ContactNo",txtContact.Text);
            cmd.Parameters.AddWithValue("@Region", txtRegion.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succesfuly Save");
        }
        void RecordDelete()
        {
            Connection conn = new Connection();
            SqlCommand cmd = new SqlCommand("DELETE FROM User_Details WHERE UserID = '" + txtID.Text + "'", conn.ActiveConnection());
            
            cmd.ExecuteNonQuery();
        }


        void CreateNew()
        {
            txtID.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtContact.Clear();
            txtRegion.Clear();
        }
        void ViewGrid()
        {
            Connection conn = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From User_Details  ", conn.ActiveConnection());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (n + 1).ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["UserId"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["UserName"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Password"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["ContactNo"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Region"].ToString();
            }
        }

        private void User_Details_Load(object sender, EventArgs e)
        {
            CreateNew();
            ViewGrid();
        }
    }

}
