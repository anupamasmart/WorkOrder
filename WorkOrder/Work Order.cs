using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkOrder
{
    public partial class Work_Order : Form
    {
        public Work_Order()
        {
            InitializeComponent();

        }

        Requester Req = new Requester() { TopLevel = false, TopMost = true };
        Requesting_Site_Info RrqSite = new Requesting_Site_Info() { TopLevel = false, TopMost = true };
        Antenna_Details AntDet = new Antenna_Details() { TopLevel = false, TopMost = true };
        private void panelWorkOrder_Paint(object sender, PaintEventArgs e)
        {
            Req.FormBorderStyle = FormBorderStyle.None;
            panelWorkOrder.Controls.Add(Req);
            Req.Show();

        }

        private void btnRequester_Click(object sender, EventArgs e)
        {
            Req.FormBorderStyle = FormBorderStyle.None;
            panelWorkOrder.Controls.Add(Req);
            Req.Show();
            RrqSite.Hide();
            AntDet.Hide();
        }

        private void btnReSiteDetails_Click(object sender, EventArgs e)
        {
            RrqSite.FormBorderStyle = FormBorderStyle.None;
            panelWorkOrder.Controls.Add(RrqSite);
            Req.Hide();
            RrqSite.Show();
            AntDet.Hide();
        }

        private void btnAntennaInfo_Click(object sender, EventArgs e)
        {
            AntDet.FormBorderStyle = FormBorderStyle.None;
            panelWorkOrder.Controls.Add(AntDet);
            Req.Hide();
            RrqSite.Hide();
            AntDet.Show();
        }
    }
}
