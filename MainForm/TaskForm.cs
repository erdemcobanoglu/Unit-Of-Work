using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Entities;


namespace MainForm
{
    public partial class TaskForm : Form
    {
        Entities.Task task;
        TaskBusiness _taskBusiness = new TaskBusiness();
        private int taskID;
        private int titleId;

        public TaskForm()
        {
            InitializeComponent();
        }

        public TaskForm(int taskID)
        {
            InitializeComponent();
            this.taskID = taskID;
            this.Text = "Güncelleme Formu";
            task = _taskBusiness.GetById(taskID);
            txtDescription.Text = task.Description;
           
        }

        public TaskForm(int titleId,int a)
        {
            InitializeComponent();
            this.titleId = titleId;

        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            EmployeeBusiness employeeBusiness = new EmployeeBusiness();
            ProjectBusiness projeBusiness = new ProjectBusiness();

            List<Employee> empList = employeeBusiness.GetAll();
            List<Project> projeList = projeBusiness.GetAll();

            cmbEmployee.DataSource = null;
            cmbEmployee.DataSource = empList;
            cmbEmployee.DisplayMember = "FirstName";
            cmbEmployee.ValueMember = "ID";

            cmbProje.DataSource = null;
            cmbProje.DataSource = projeList;
            cmbProje.DisplayMember = "Name";
            cmbProje.ValueMember = "ID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            _taskBusiness = new TaskBusiness();


            try
            {

                if (this.taskID<1)
                {
                    task = new Entities.Task();
                    task.BeginDate = dtpBeginDate.Value;
                    task.FinalDate = dtpFinalDate.Value;
                    task.Description = txtDescription.Text;
                    if (rdbNotStarted.Checked)
                        task.Status = "Başlanmadı";
                    else if (rdbDevelop.Checked)
                        task.Status = "Geliştirilcek";
                    else if (rdbTested.Checked)
                        task.Status = "Test Edilcek";
                    task.EmloyeeId = (int)cmbEmployee.SelectedValue;
                    task.ProjectId = (int)cmbProje.SelectedValue;


                    _taskBusiness.Add(task);

                }

                else
                {
                    task = new Entities.Task();
                    task.ID = this.taskID;
                    task.BeginDate = dtpBeginDate.Value;
                    task.FinalDate = dtpFinalDate.Value;
                    task.Description = txtDescription.Text;
                    if (rdbNotStarted.Checked)
                        task.Status = "Başlanmadı";
                    else if (rdbDevelop.Checked)
                        task.Status = "Geliştirilcek";
                    else if (rdbTested.Checked)
                        task.Status = "Test Edilcek";
                    task.EmloyeeId = (int)cmbEmployee.SelectedValue;
                    task.ProjectId = (int)cmbProje.SelectedValue;

                    _taskBusiness.Update(task);
                    

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

        private void TaskForm_FormClosing(object sender, FormClosingEventArgs e)
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
                    if (titleId==3)
                    {
                        if (pnl.Name == "pnlAnalyst")
                        {
                            pnl.Visible = true;
                        } 
                    }
                    if (titleId==2)
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
