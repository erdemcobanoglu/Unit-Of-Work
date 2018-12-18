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
    public partial class TitleEditForm : Form
    {
        TitleBusiness _titleBusiness;
        Title _title;
        private int titleId;

        public TitleEditForm()
        {
            InitializeComponent();
        }

        public TitleEditForm(int titleId)
        {
            InitializeComponent();
            _titleBusiness = new TitleBusiness();
            this.titleId = titleId;
            this.Text = "Güncelleme Ekranı";
            btnSave.Text = "Güncelle";
            _title = _titleBusiness.GetById(titleId);
            txtTitle.Text = _title.TitleName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            _titleBusiness = new TitleBusiness();
            _title = new Title();

            try
            {
                if (titleId<1)
                {
                   
                    _title.TitleName = txtTitle.Text;
                    _titleBusiness.Add(_title); 
                }
                else
                {
                    _title.ID = titleId;
                    _title.TitleName = txtTitle.Text;
                    _titleBusiness.Update(_title);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.MdiParent = mainForm;
            this.Close();
            

        }
    }
}
