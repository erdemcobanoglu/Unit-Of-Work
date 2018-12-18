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
    public partial class ProjectEditForm : Form
    {
        ProjectBusiness _projectBusiness;
        Project _project;
        private int projectId;

        public ProjectEditForm()
        {
            InitializeComponent();
        }

        public ProjectEditForm(int projectId)
        {
            InitializeComponent();

            dtpStartDate.Visible = true;
            DtpEndDate.Visible = true;

            _projectBusiness = new ProjectBusiness();
            this.projectId = projectId;
            _project = _projectBusiness.GetById(projectId);
            txtId.Text = _project.ID.ToString();
            txtId.ReadOnly = true;
            txtProjectName.Text = _project.Name;
            DtpEndDate.Value = _project.EndDate;
            dtpPlanEndDate.Value = _project.PlanningEndDate;
            dtpStartDate.Value = _project.StartDate;
            DtpPlanStartDate.Value = _project.PlanningStartDate;

        }

        private void ProjectManagerForm_Load(object sender, EventArgs e)
        {
            CustomerBusiness customerBusiness = new CustomerBusiness();
            List<Customer> customerList = customerBusiness.GetAll();

            cmbCustomer.DataSource = null;
            cmbCustomer.DataSource = customerList;
            cmbCustomer.DisplayMember = "CompanyName";
            cmbCustomer.ValueMember = "ID";

            txtId.ReadOnly = true;
            dtpStartDate.Visible = false;
            DtpEndDate.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _projectBusiness = new ProjectBusiness();
            try
            {
                if (projectId < 1)
                {
                    _project = new Project();
                    _project.EndDate = DtpEndDate.Value;
                    _project.StartDate = DtpPlanStartDate.Value;
                    _project.PlanningEndDate = dtpPlanEndDate.Value;
                    _project.PlanningStartDate = DtpPlanStartDate.Value;
                    _project.CustomerID = (int)cmbCustomer.SelectedValue;
                    _project.Name = txtProjectName.Text;
                    _projectBusiness.Add(_project);
                }

                else
                {
                    _project.ID = projectId;
                    _project.EndDate = DtpEndDate.Value;
                    _project.StartDate = DtpPlanStartDate.Value;
                    _project.PlanningEndDate = dtpPlanEndDate.Value;
                    _project.PlanningStartDate = DtpPlanStartDate.Value;
                    _project.CustomerID = (int)cmbCustomer.SelectedValue;
                    _project.Name = txtProjectName.Text;
                    _projectBusiness.Update(_project);
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

        private void ProjectEditForm_FormClosing(object sender, FormClosingEventArgs e)
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
                    if (pnl.Name == "pnlManager")
                    {
                        pnl.Visible = true;
                    }
                }
            }
        }
    }
}
