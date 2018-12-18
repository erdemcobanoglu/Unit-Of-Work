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
    public partial class CustomerEditForm : Form
    {
        public CustomerEditForm()
        {
            InitializeComponent();

        }

        private int customerID;
        Customer customer;

        public CustomerEditForm(int customerID)
        {
            InitializeComponent();

            this.Text = "Güncelle";
            btnSave.Text = "Güncelle";
            this.customerID = customerID;

            _customerBusiness = new CustomerBusiness();  //Burası kritik 

            customer = _customerBusiness.GetById(customerID);  //todo: güncelleme hatası
            txtCompanyName.Text = customer.CompanyName;
            mtxtPhone.Text = customer.Phone;
            txtEmail.Text = customer.Email;
            txtUserName.Text = customer.UserName;
            txtPassword.Text = customer.Password;
            txtContactPerson.Text = customer.ContactPerson;

        }


        CustomerBusiness _customerBusiness;

        private void CustomerEditForm_Load(object sender, EventArgs e)
        {

        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
              txtUserName.Text = txtCompanyName.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
              txtPassword.Text = txtEmail.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            _customerBusiness = new CustomerBusiness();

            try
            {
                if (customerID<1)
                {
                    customer.ProjectStatus = cmbProjectStatus.SelectedItem.ToString();
                    customer.CompanyName = txtCompanyName.Text;
                    customer.Phone = mtxtPhone.Text;
                    customer.Email = txtEmail.Text;
                    customer.UserName = txtUserName.Text;
                    customer.Password = txtPassword.Text;
                    customer.ContactPerson = txtContactPerson.Text;

                    _customerBusiness.Add(customer); 
                }

                else
                {
                    // customer = new Customer();
                    customer.ProjectStatus = cmbProjectStatus.SelectedText;
                    customer.ID = customerID;
                    customer.CompanyName = txtCompanyName.Text;
                    customer.Phone = mtxtPhone.Text;
                    customer.Email = txtEmail.Text;
                    customer.UserName = txtUserName.Text;
                    customer.Password = txtPassword.Text;
                    customer.ContactPerson = txtContactPerson.Text;
                    _customerBusiness.Update(customer);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                ClearTextBox();
            }
        }

        public void ClearTextBox()
        {
            txtCompanyName.Text = null;
            txtEmail.Text = null;
            txtPassword.Text = null;
            txtUserName.Text = null;
            mtxtPhone.Text = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowPanelWhenFormClosing();
            this.Close();

        }

      

        private void CustomerEditForm_FormClosing(object sender, FormClosingEventArgs e)
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
