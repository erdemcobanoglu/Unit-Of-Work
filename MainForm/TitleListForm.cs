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
    public partial class TitleListForm : Form
    {
        TitleBusiness _titleBusiness;
        public TitleListForm()
        {
            InitializeComponent();
        }

        private void TitleListForm_Load(object sender, EventArgs e)
        {
            _titleBusiness = new TitleBusiness();
            List<Title> titleList = _titleBusiness.GetAll();
            var list = (from t in titleList
                        select new
                        {
                            ID = t.ID,
                            TitleName = t.TitleName
                        }
                      ).ToList();

            dgvTitleList.DataSource = null;
            dgvTitleList.DataSource = list;
        }

        private void dgvTitleList_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            e.ContextMenuStrip = contextMenuStrip2;
            dgvTitleList.Rows[e.RowIndex].Selected = true;
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object cellValue = dgvTitleList.SelectedRows[0].Cells["ID"].Value;
            int titleId = (int)cellValue;

            TitleEditForm editForm = new TitleEditForm(titleId);
            editForm.MdiParent = this.MdiParent;
            editForm.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _titleBusiness = new TitleBusiness();
            
            object cellValue = dgvTitleList.SelectedRows[0].Cells["ID"].Value;
            int titleId = (int)cellValue;

            Title title = _titleBusiness.GetById(titleId);
            try
            {
                DialogResult dr = MessageBox.Show(title.TitleName+" İsimli kaydı silmek istediğinize emin misiniz ?" , "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr== DialogResult.Yes)
                {
                    _titleBusiness.Remove(title); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainFrom = new MainForm();
            this.MdiParent = mainFrom;
           
            mainFrom.Show();
            
        }
    }
}
