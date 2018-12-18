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
using BusinessLayer;

namespace MainForm
{
    public partial class TaskListForm : Form
    {
        TaskBusiness _businessTask;
       Entities.Task  _task;
        private int titleID;
        
        public TaskListForm()
        {
            InitializeComponent();
            dgvTask.DataSource = null;
        }
        public TaskListForm(int titleID)
        {
            InitializeComponent();
            this.titleID = titleID;
        }

        private void TaskListForm_Load(object sender, EventArgs e)
        {
            dgvTask.DataSource = null;
            _businessTask = new TaskBusiness();
            List<Entities.Task> taskList = _businessTask.GetAll();

            var list = (from s in taskList 
                        select new
                        {
                            ID = s.ID,
                            StartDate = s.BeginDate,
                            EndDate = s.FinalDate,
                            Employee = s.Employee.FirstName,
                            Project = s.Project.Name,
                            Status = s.Status,
                            Description = s.Description

                        }).ToList();
            dgvTask.DataSource = list;
        }

        private void dgvTask_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            e.ContextMenuStrip = cmTask;
            dgvTask.Rows[e.RowIndex].Selected = true;
            
        }

        //private void RefershDgv()
        //{
            
        //    List<Entities.Task> taskList = _businessTask.GetAll();

        //    var list = (from s in taskList
        //                select new
        //                {
        //                    ID = s.ID,
        //                    StartDate = s.BeginDate,
        //                    EndDate = s.FinalDate,
        //                    Employee = s.EmloyeeId,
        //                    Project = s.ProjectId,
        //                    Status = s.Status

        //                }).ToList();

        //    dgvTask.DataSource = list;
            





        //}


        private void miUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTask.SelectedRows.Count>0)
            {
                object cellValue = dgvTask.SelectedRows[0].Cells["ID"].Value;
                int taskID = (int)cellValue;
                

                TaskForm tf = new TaskForm (taskID);
                tf.MdiParent = this.MdiParent;

                tf.Show();
                




            }
        }

        private void miDelete_Click(object sender, EventArgs e)
        {


            if (dgvTask.SelectedRows.Count>0)
            {
                try
                {
                    object cellValue = dgvTask.SelectedRows[0].Cells["ID"].Value;
                    int taskID = (int)cellValue;

                    _task = _businessTask.GetById(taskID);

                    DialogResult dr = MessageBox.Show("Silmek istediğinize eminmisiniz", "Dikkat", MessageBoxButtons.YesNo);

                    if (dr==DialogResult.Yes)
                    {
                        _businessTask.Remove(_task);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                   
                }

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowPanelWhenFormClosing();
            this.Close();
            
           
        }

        private void TaskListForm_FormClosing(object sender, FormClosingEventArgs e)
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

                    if (titleID == 2)
                    {
                        if (pnl.Name == "pnlTeamLeader")
                        {
                            pnl.Visible = true;
                        }  
                    }
                    if (titleID == 3)
                    {
                        if (pnl.Name == "pnlAnalyst")
                        {
                            pnl.Visible = true;
                        }
                    }

                }
            }
        }
    }
}
