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

namespace MainForm
{
    public partial class TesterForm : Form
    {
        public TesterForm()
        {
            InitializeComponent();
        }


        private void miUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTaskList.SelectedRows.Count > 0)
            {
                object cellValue = dgvTaskList.SelectedRows[0].Cells["ID"].Value;
                int TaskID = (int)cellValue;

                TaskForm useTask = new TaskForm(TaskID);
                useTask.MdiParent = this.MdiParent;
                useTask.Show();
            }
        }

        private void dataGridView1_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            e.ContextMenuStrip = contextMenuStrip1;
            dgvTaskList.Rows[e.RowIndex].Selected = true;
        }

        private void TesterForm_Load(object sender, EventArgs e)
        {
            TaskBusiness _taskBusiness;
            _taskBusiness = new TaskBusiness();
            List<Entities.Task> taskList = _taskBusiness.GetAll();
            dgvTaskList.DataSource = taskList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowPanelWhenFormClosing();
            this.Close();
           

        }

        private void TesterForm_FormClosing(object sender, FormClosingEventArgs e)
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
                    if (pnl.Name == "pnlTester")
                    {
                        pnl.Visible = true;
                    }
                }
            }
        }

    }
}
