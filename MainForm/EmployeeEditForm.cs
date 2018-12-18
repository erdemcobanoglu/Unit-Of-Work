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
    
  
    public partial class EmployeeEditForm : Form
    {
        EmployeeBusiness _employeeBusiness=new EmployeeBusiness();
        private int employeeID;
        Employee employee;

        public EmployeeEditForm()
        {
            InitializeComponent();
        }

        public EmployeeEditForm(int employeeID)
        {
            InitializeComponent();
            //employee = new Employee();
            this.Text = "Güncelleme Formu";
            btnSave.Text = "Güncelle";
            this.employeeID = employeeID;
            employee = _employeeBusiness.GetById(employeeID);
            txtAdress.Text = employee.Address;
            txtCountry.Text = employee.Country;
            txtEmail.Text = employee.Email;
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            txtPassword.Text = employee.Password;
            txtSocialNumber.Text = employee.SocialNumber;
            txtUserName.Text = employee.UserName;




        }

        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {
            TitleBusiness employeeTitle = new TitleBusiness();

            List<Title> titleList = employeeTitle.GetAll();

            cmbTitle.DataSource = null;
            cmbTitle.DataSource = titleList;
            cmbTitle.DisplayMember = "TitleName";
            cmbTitle.ValueMember = "ID";



            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtUserName.Text = txtEmail.Text;
        }

        private void txtSocialNumber_TextChanged(object sender, EventArgs e)
        {
            txtPassword.Text = txtSocialNumber.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _employeeBusiness = new EmployeeBusiness();


            try
            {
                if (this.employeeID<1)
                {
                    employee = new Employee();
                    employee.Address = txtAdress.Text;
                    employee.BirthDate = dtpDateofBirth.Value;
                    employee.Country = txtCountry.Text;
                    employee.Email = txtEmail.Text;
                    employee.FirstName = txtFirstName.Text;
                    if (rdFemale.Checked)
                        employee.GenderId = 1;
                    else
                        employee.GenderId = 2;
                    employee.LastName = txtLastName.Text;
                    employee.Password = txtPassword.Text;
                    employee.Phone = mtxtPhoneNumber.Text;
                    employee.SocialNumber = txtSocialNumber.Text;
                    employee.TitleId = (int)cmbTitle.SelectedValue;

                    if (rdWorkOff.Checked)
                        employee.Status = "Çalışmıyor";
                    else
                        employee.Status = "Çalışıyor";

                    employee.UserName = txtUserName.Text;

                    _employeeBusiness.Add(employee); 
                }


                else
                {
                    employee.ID = this.employeeID;
                    employee.Address = txtAdress.Text;
                    employee.BirthDate = dtpDateofBirth.Value;
                    employee.Country = txtCountry.Text;
                    employee.Email = txtEmail.Text;
                    employee.FirstName = txtFirstName.Text;

                    if (rdFemale.Checked)
                        employee.GenderId = 1;
                    else
                        employee.GenderId = 2;

                    employee.LastName = txtLastName.Text;
                    employee.Password = txtPassword.Text;
                    employee.Phone = mtxtPhoneNumber.Text;
                    employee.SocialNumber = txtSocialNumber.Text;
                    employee.TitleId = (int)cmbTitle.SelectedValue;

                    if (rdWorkOff.Checked)
                        employee.Status = "Çalışmıyor";
                    else
                        employee.Status = "Çalışıyor";

                    employee.UserName = txtUserName.Text;

                    _employeeBusiness.Update(employee);
                }


                

            }

            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
                DeleteTextBoxes();
            }


        }

        public void DeleteTextBoxes()
        {
            txtAdress.Text = "";
            txtCountry.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtSocialNumber.Text = "";
            txtUserName.Text = "";
          
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowPanelWhenFormClosing();
            this.Close();
           
        }

        private void EmployeeEditForm_FormClosing(object sender, FormClosingEventArgs e)
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
