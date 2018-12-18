using BusinessLayer;
using Entities;
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
    public partial class ProjectListForm : Form
    {
        ProjectBusiness _projectBusiness;
        private int titleID;

        public ProjectListForm()
        {
            InitializeComponent();

        }

        public ProjectListForm(int titleID)
        {
            InitializeComponent();
            this.titleID = titleID;
        }

        private void ProjectListForm_Load(object sender, EventArgs e)
        {
            _projectBusiness = new ProjectBusiness();
            List<Project> projectList = _projectBusiness.GetAll();

            dgvList.DataSource = null;
            dgvList.DataSource = projectList;
        }

        private void dgvList_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            e.ContextMenuStrip = contextMenuStrip1;
            dgvList.Rows[e.RowIndex].Selected = true;
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object cellValue = dgvList.SelectedRows[0].Cells["ID"].Value;
            int projectId = (int)cellValue;

            ProjectEditForm editForm = new ProjectEditForm(projectId);
            editForm.MdiParent = this.MdiParent;
            editForm.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _projectBusiness = new ProjectBusiness();
                object cellValue = dgvList.SelectedRows[0].Cells["ID"].Value;
                int projectId = (int)cellValue;

                Project project = _projectBusiness.GetById(projectId);

                DialogResult dr = MessageBox.Show(project.Name + " "+" isimli kaydı silmek istediğinize emin misiniz ","Dikkat", MessageBoxButtons.YesNo);

                if (dr== DialogResult.Yes)
                {
                    _projectBusiness.Remove(project); 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowPanelWhenFormClosing();
            this.Close();
            
        }

        private void ProjectListForm_FormClosing(object sender, FormClosingEventArgs e)
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
                    if (titleID==1)
                    {
                        
                        if (pnl.Name == "pnlManager")
                        {
                            pnl.Visible = true;
                        } 
                    }

                    if (titleID==3)
                    {
                        if (pnl.Name == "pnlAnalyst")
                        {
                            pnl.Visible = true;
                        }
                    }

                    if(titleID==2)
                    {
                        if (pnl.Name == "pnlTeamLeader")
                        {
                            pnl.Visible = true;
                        }
                    }
                }
            }
        }

      
    }
}
