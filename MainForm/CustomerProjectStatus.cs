using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace MainForm
{
    public partial class CustomerProjectStatus : Form
    {
        private List<Project> projects;

        public CustomerProjectStatus()
        {
            InitializeComponent();
        }

        public CustomerProjectStatus(List<Project> projects)
        {
            InitializeComponent();
            this.projects = projects;
        }

        private void CustomerProjectStatus_Load(object sender, EventArgs e)
        {
         
            dgvCustomerProjectStatus.DataSource = null;
            dgvCustomerProjectStatus.DataSource = projects;
        }

        private void CustomerProjectStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = (MainForm)this.MdiParent;
            //todo :

            foreach (Control item in this.MdiParent.Controls)
            {
                if (item is Panel)
                {
                    Panel pnl = (Panel)item;
                    if (pnl.Name == "pnlCustomer")
                    {
                        pnl.Visible = true;
                    }
                }
            }
        }
    }
}
