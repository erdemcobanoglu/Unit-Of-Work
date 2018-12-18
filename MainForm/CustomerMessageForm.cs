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
    public partial class CustomerMessageForm : Form
    {
        public CustomerMessageForm()
        {
            InitializeComponent();
        }

        private int messageID;
        CustomerMessage customer;
        CustomerMessageBusiness _customerBusiness;

        public CustomerMessageForm(int messageID)
        {
            InitializeComponent();

            this.Text = "Güncelle";
            btnSave.Text = "Güncelle";  // todo: 
            this.messageID = messageID;

            _customerBusiness = new CustomerMessageBusiness();

            customer = _customerBusiness.GetById(messageID);
            txtTitle.Text = customer.Name;
            txtDescription.Text = customer.Description;
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _customerBusiness = new CustomerMessageBusiness();
            try
            {

                if (this.messageID > 0)
                {
                    customer = new CustomerMessage(); // kritik unutma
                    customer.ID = this.messageID;
                    customer.Name = txtTitle.Text;
                    customer.Description = txtDescription.Text;
                    customer.CustomerID = 1; 

                    


                    if (radioNotSee.Checked)
                        customer.Status = "Görülmedi";
                    else
                        customer.Status = "Görüldü";

                    _customerBusiness.Update(customer);
                }
                else
                {
                    customer = new CustomerMessage();
                    customer.Name = txtTitle.Text;
                    customer.Description = txtDescription.Text;

                    customer.CustomerID = 1;  // todo: Customer ıd çek buraya otomatik 
                    

                    if (radioNotSee.Checked)
                        customer.Status = "Görülmedi";
                    else
                        customer.Status = "Görüldü";

                    _customerBusiness.Add(customer);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                DeleteTextBoxes();
            }
        }

        public void DeleteTextBoxes()
        {
            txtDescription.Text = null;
            txtTitle.Text = null;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowPanelWhenFormClosing();
            this.Close();
            

        }

        private void CustomerMessageForm_FormClosing(object sender, FormClosingEventArgs e)
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
                    if (pnl.Name == "pnlCustomer")
                    {
                        pnl.Visible = true;
                    }
                }
            }



        }
    }
}
