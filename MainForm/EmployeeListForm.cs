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
    public partial class EmployeeListForm : Form
    {
        EmployeeBusiness _employeeBusiness;
        Employee _employee;

        private int titleID;
        public EmployeeListForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
        }

        public EmployeeListForm(int titleID)
        {
            InitializeComponent();
            this.titleID = titleID;
        }

        private void dataGridView1_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            e.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Rows[e.RowIndex].Selected = true;
        }

        private void miUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                object cellValue = dataGridView1.SelectedRows[0].Cells["ID"].Value;
                int employeeID = (int)cellValue;

                EmployeeEditForm editForm = new EmployeeEditForm(employeeID);
                editForm.MdiParent = this.MdiParent;
                editForm.Show();
            }

        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            _employeeBusiness = new EmployeeBusiness();
            List<Employee> employeeList = _employeeBusiness.GetAll();
            dataGridView1.DataSource = employeeList;



        }

        private void miDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    object cellValue = dataGridView1.SelectedRows[0].Cells["ID"].Value;
                    int employeeID = (int)cellValue;

                    _employee = _employeeBusiness.GetById(employeeID);

                    DialogResult dr = MessageBox.Show(_employee.FirstName + " " + _employee.LastName + " " + " adlı kişiyi silmek istediğinize emin misiniz", "Dikkat", MessageBoxButtons.YesNo);


                    if (dr == DialogResult.Yes)
                        _employeeBusiness.Remove(_employee);

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

        private void EmployeeListForm_FormClosing(object sender, FormClosingEventArgs e)
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
                    if (titleID == 1)
                    {

                        if (pnl.Name == "pnlManager")
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

                    if (titleID == 2)
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

