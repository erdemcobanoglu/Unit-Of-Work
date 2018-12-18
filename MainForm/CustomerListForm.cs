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
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }

        CustomerBusiness _customerBusiness;
        Customer _customer;

        private void miUpdate_Click(object sender, EventArgs e)
        {
           if(dgvCustomerList.SelectedRows.Count > 0)
            {
                object cellValue = dgvCustomerList.SelectedRows[0].Cells["ID"].Value;
                int customerID = (int)cellValue;

                CustomerEditForm editForm = new CustomerEditForm(customerID);
                editForm.MdiParent = this.MdiParent;
                editForm.Show();
            }
        }

        private void miDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomerList.SelectedRows.Count > 0)
            {
                try
                {
                    object cellValue = dgvCustomerList.SelectedRows[0].Cells["ID"].Value;
                    int cutomerID = (int)cellValue;

                    _customer = _customerBusiness.GetById(cutomerID);

                    DialogResult dr = MessageBox.Show(_customer.CompanyName + " "  + "Adlı Müşteriyi silmek istedigine eminmisin"," Dikkat",MessageBoxButtons.YesNo);

                    if (dr == DialogResult.Yes)
                        _customerBusiness.Remove(_customer);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            _customerBusiness = new CustomerBusiness();
            List<Customer> customerList = _customerBusiness.GetAll();
            dgvCustomerList.DataSource = customerList;
        }

        private void dgvCustomerList_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            e.ContextMenuStrip = contextMenuStrip1;
            dgvCustomerList.Rows[e.RowIndex].Selected = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowPanelWhenFormClosing();
            this.Close();
          

        }

        private void CustomerListForm_FormClosing(object sender, FormClosingEventArgs e)
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
