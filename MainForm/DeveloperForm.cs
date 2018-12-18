using BusinessLayer;
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
    public partial class DeveloperForm : Form
    {
        public DeveloperForm()
        {
            InitializeComponent();
        }




        private void miUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTaskList.SelectedRows.Count > 0)
            {
                object cellValue = dgvTaskList.SelectedRows[0].Cells["ID"].Value;
                int taskID = (int)cellValue;

                TaskForm useTask = new TaskForm(taskID);
                useTask.MdiParent = this.MdiParent;
                useTask.Show();

            }
        }

        private void dgvTaskList_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            e.ContextMenuStrip = contextMenuStrip1;
            dgvTaskList.Rows[e.RowIndex].Selected = true;
        }

        private void DeveloperForm_Load(object sender, EventArgs e)
        {

            TaskBusiness _taskBusiness;
            _taskBusiness = new TaskBusiness();
            List<Entities.Task> taskList = _taskBusiness.GetAll();
            dgvTaskList.DataSource = taskList;


        }


        private void btnBack_Click_1(object sender, EventArgs e)
        {

            ShowPanelWhenFormClosing();
            this.Close();

        }

        private void DeveloperForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowPanelWhenFormClosing();
        }

        public void ShowPanelWhenFormClosing()
        {
            MainForm mainForm = (MainForm)this.MdiParent;
            //todo :
        
            foreach (Control item in this.MdiParent.Controls)
            {
                if (item is Panel)
                {
                    Panel pnl = (Panel)item;
                    if (pnl.Name == "pnlDeveloper")
                    {
                        pnl.Visible = true;
                    }
                }
            }
           


        }


    }
}
