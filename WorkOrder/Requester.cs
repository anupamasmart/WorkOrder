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
    public partial class Requester : Form
    {
        public Requester()
        {
            InitializeComponent();
        }

        private void btnNEXT_Click(object sender, EventArgs e)
        {
            Requesting_Site_Info ReqSite = new Requesting_Site_Info() { TopLevel = false, TopMost = true };


        }
    }
}
