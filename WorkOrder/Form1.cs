using System.Numerics;

namespace WorkOrder
{
    public partial class Dialog_Work_Order : Form
    {
        public Dialog_Work_Order()
        {
            InitializeComponent();
        }
        User_Details UserD = new User_Details() { TopLevel = false, TopMost = true };
        Site_Details SiteD = new Site_Details() { TopLevel = false, TopMost = true };
        New_Antenna_Details AntennaD = new New_Antenna_Details() { TopLevel = false, TopMost = true };
        private void btnUserDetails_Click(object sender, EventArgs e)
        {

            UserD.FormBorderStyle = FormBorderStyle.None;
            panelface.Controls.Add(UserD);
            UserD.Show();
            SiteD.Hide();
            AntennaD.Hide();

        }

        private void btnSiteDetails_Click(object sender, EventArgs e)
        {

            SiteD.FormBorderStyle = FormBorderStyle.None;
            panelface.Controls.Add(SiteD);
            SiteD.Show();
            UserD.Hide();
            AntennaD.Hide();
        }

        private void btnAntennaDetails_Click(object sender, EventArgs e)
        {

            AntennaD.FormBorderStyle = FormBorderStyle.None; ;
            panelface.Controls.Add(AntennaD);
            AntennaD.Show();
            UserD.Hide();
            SiteD.Hide();
        }

        private void btnGenWorkOrder_Click(object sender, EventArgs e)
        {
            Work_Order WorkOD = new Work_Order();
            WorkOD.Show();

        }

        private void panelface_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dialog_Work_Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}