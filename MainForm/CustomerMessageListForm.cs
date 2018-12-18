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
    public partial class CustomerMessageListForm : Form
    {
        public CustomerMessageListForm()
        {
            InitializeComponent();
        }

        CustomerMessageBusiness _customerMessageBLL;
        CustomerMessage _customerMessage;

        private void CustomerMessageListForm_Load(object sender, EventArgs e)
        {
            _customerMessageBLL = new CustomerMessageBusiness();
            List<CustomerMessage> customerMessageList = _customerMessageBLL.GetAll();

            var list = (from cm in customerMessageList
                        select new
                        {
                            cm.ID,
                            cm.Name,
                            cm.Status,
                            cm.Description,
                            cm.CustomerID,
                            CompanyName = cm.Customer.CompanyName
                        }
                      ).ToList();

            dtgCustomerMessage.DataSource = list;    
        }

        private void miUpdate_Click(object sender, EventArgs e)
        {
            if (dtgCustomerMessage.SelectedRows.Count > 0)
            {
                object cellValue = dtgCustomerMessage.SelectedRows[0].Cells["ID"].Value;
                int customerID = (int)cellValue;

                CustomerMessageForm messageForm = new CustomerMessageForm(customerID);
                messageForm.MdiParent = this.MdiParent;
                messageForm.Show();
            }
        }

        private void miDelete_Click(object sender, EventArgs e)
        {
            if (dtgCustomerMessage.SelectedRows.Count > 0)
            {
                try
                {
                    object cellValue = dtgCustomerMessage.SelectedRows[0].Cells["ID"].Value;
                    int customerMessageID = (int)cellValue;

                    _customerMessage = _customerMessageBLL.GetById(customerMessageID);

                    DialogResult dr = MessageBox.Show(_customerMessage.Name + " " + _customerMessage.Description + " " + " adlı mesajı silmek istediğinize emin misiniz", "Dikkat", MessageBoxButtons.YesNo);


                    if (dr == DialogResult.Yes)
                        _customerMessageBLL.Remove(_customerMessage);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
        }

        private void dtgCustomerMessage_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            e.ContextMenuStrip = contextMenuStrip1;
            dtgCustomerMessage.Rows[e.RowIndex].Selected = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowPanelWhenFormClosing();
            this.Close();
           


        }

        private void CustomerMessageListForm_FormClosing(object sender, FormClosingEventArgs e)
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
