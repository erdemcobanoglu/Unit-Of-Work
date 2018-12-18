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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

        }

        int titleID;
        Employee _employee;
        EmployeeBusiness employeeBuss;

        Customer _customer;
        CustomerBusiness customerBuss;

        #region FormDragİşlemleri
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }



        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void btnMax_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized
                          ? FormWindowState.Normal
                          : FormWindowState.Maximized;
        }

        #endregion

        #region AçılırLoginFormİşlemleri


        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlLogin.Width = 330;
            btnMenu.Visible = false;
            btnClose.Visible = true;

            lblpassword.Visible = true;
            lblusername.Visible = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlLogin.Width = 110;
            btnMenu.Visible = true;
            btnClose.Visible = false;

            lblpassword.Visible = false;
            lblusername.Visible = false;

        }
        #endregion


        private void btnLogin_Click(object sender, EventArgs e)
        {
            pnlLogin.Width = 110;
            btnMenu.Visible = true;
            btnClose.Visible = false;

            // eğer login dogru ise Yan panel Close olsun ve kapansın if kontrolü koymayı unutma

            lblpassword.Visible = false;
            lblusername.Visible = false;



            employeeBuss = new EmployeeBusiness();
            customerBuss = new CustomerBusiness();
            _employee = employeeBuss.GetTitleIdByUserName(txtUserName.Text, txtPassword.Text);
            _customer = customerBuss.GetCustomerByPassword(txtUserName.Text, txtPassword.Text);

            try
            {

                if (_employee == null)
                {
                    if (_customer==null)
                    {
                        throw new Exception("Hatalı giriş yaptınız");

                    }
                    else
                    {
                        pnlCustomer.Visible = true;
                        lblUser.Visible = true;
                        btnUser.Visible = true;
                        btnShutDown.Visible = true;
                        lblUser.Text = _customer.CompanyName ;

                        pnlPassword.Visible = true;
                    }
                }


                else
                {
                    if (_employee.TitleId == 1 || _employee.TitleId == 2 || _employee.TitleId == 3 || _employee.TitleId == 4 || _employee.TitleId == 5)
                    {
                        titleID = _employee.TitleId;
                        if (_employee.TitleId == 1)
                            pnlManager.Visible = true;
                        if (_employee.TitleId == 3)
                            pnlAnalyst.Visible = true;
                        if (_employee.TitleId == 2)
                            pnlTeamLeader.Visible = true;
                        if (_employee.TitleId == 4)
                            pnlTester.Visible = true;
                        if (_employee.TitleId == 5)
                            pnlDeveloper.Visible = true;

                        lblUser.Visible = true;
                        btnUser.Visible = true;
                        btnShutDown.Visible = true;
                        lblUser.Text = _employee.FirstName + " " + _employee.LastName;

                        pnlPassword.Visible = true;
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            ProjectEditForm editForm = new ProjectEditForm();
            editForm.MdiParent = this;
            editForm.Show();
            ClosePanelVisible();

        }

        private void btnProjectList_Click(object sender, EventArgs e)
        {
            ProjectListForm projectListForm = new ProjectListForm(titleID);
            projectListForm.MdiParent = this;
            projectListForm.Show();
            ClosePanelVisible();
        }

        private void btnEmployeeEdit_Click(object sender, EventArgs e)
        {
            EmployeeEditForm employeeEditForm = new EmployeeEditForm();
            employeeEditForm.MdiParent = this;
            employeeEditForm.Show();
            ClosePanelVisible();
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm(titleID);
            employeeListForm.MdiParent = this;
            employeeListForm.Show();
            ClosePanelVisible();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            CustomerEditForm customerEditForm = new CustomerEditForm();
            customerEditForm.MdiParent = this;
            customerEditForm.Show();
            ClosePanelVisible();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            EmployeeListForm empListForm = new EmployeeListForm(titleID);
            empListForm.MdiParent = this;
            empListForm.Show();
            ClosePanelVisible();

        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            int a = 0;
            TaskForm taskEditForm = new TaskForm(titleID, a);   //todo:
            taskEditForm.MdiParent = this;
            taskEditForm.Show();
            ClosePanelVisible();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerMessageForm customerMessageListForm = new CustomerMessageForm();
            customerMessageListForm.MdiParent = this;
            customerMessageListForm.Show();
            ClosePanelVisible();
        }

        #region Login Form Iptal edildi
        private void Form1_Load(object sender, EventArgs e)
        {


            // login.Show();

            #region LabelGizle
            lblpassword.Visible = false;
            lblusername.Visible = false;
            lblConfirm.Visible = false;
            lblbbbb.Visible = false;

            #endregion

            btnUser.Visible = false;
            lblUser.Visible = false;
            btnShutDown.Visible = false;
            lblNameGet.Visible = false;

            #region pnlPasswordGizle
            pnlPassword.Visible = false;
            #endregion

            ClosePanelVisible();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaskListForm taskListForm = new TaskListForm(titleID);
            taskListForm.MdiParent = this;
            taskListForm.Show();
            ClosePanelVisible();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            TesterForm developerForm = new TesterForm();
            developerForm.MdiParent = this;
            developerForm.Show();
            ClosePanelVisible();
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            TaskListForm taskListForm = new TaskListForm(titleID);
            taskListForm.MdiParent = this;
            taskListForm.Show();
            ClosePanelVisible();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            CustomerMessageForm edittCustomerMessage = new CustomerMessageForm();
            edittCustomerMessage.MdiParent = this;
            edittCustomerMessage.Show();
            ClosePanelVisible();
        }

        private void btnPasswordUpdate_Click(object sender, EventArgs e)
        {
            //Erdem ben Globalde Employee yi çektim Güncelleme için kullnabilirsin.(Employee giriş yapan kişinin bilgileridir)

            // todo: pass word sorgusu çek 

            pnlPassword.Width = 110;
            btnPasswordUpdate.Visible = true;
            btnHide.Visible = false;

            // eğer login dogru ise Yan panel Close olsun ve kapansın if kontrolü koymayı unutma

            #region  Visible işlemleri
            lblbbbb.Visible = false;
            lblConfirm.Visible = false;

            lblUser.Visible = true;
            btnUser.Visible = true;
            btnShutDown.Visible = true;
            //lblUser.Text = _employee.FirstName + " " + _employee.LastName;
            pnlPassword.Visible = true;
            #endregion


            try
            {

                if (_employee!=null)
                {
                    _employee.Password = txtConfirmPassword.Text;
                    employeeBuss.Update(_employee); 
                }

                else
                {
                    _customer.Password = txtConfirmPassword.Text;
                    customerBuss.Update(_customer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnHide_Click_1(object sender, EventArgs e)
        {
            pnlPassword.Width = 110;
            btnPasswordUpdate.Visible = true;
            btnHide.Visible = false;
            lblNameGet.Visible = false;
            lblbbbb.Visible = false;
            lblConfirm.Visible = false;
        }


        private void btnShutDown_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void DeveloperTasklist_Click(object sender, EventArgs e)
        {
            DeveloperForm developerForm = new DeveloperForm();
            developerForm.MdiParent = this;
            developerForm.Show();
            ClosePanelVisible();


        }

        private void btnDOneTaskList_Click(object sender, EventArgs e)
        {
            DeveloperForm developerForm = new DeveloperForm();
            developerForm.MdiParent = this;
            developerForm.Show();
            ClosePanelVisible();
        }

        private void btnPnlPass_Click(object sender, EventArgs e)
        {
            //lblNameGet.Text = _employee.FirstName + " " + _employee.LastName;
            pnlPassword.Width = 330;
            btnPasswordUpdate.Visible = true;
            btnHide.Visible = true;

            lblbbbb.Visible = true;
            lblConfirm.Visible = true;

            lblNameGet.Visible = true;

        }

        #endregion

        #region Panel Gorunurluk islemleri
        public void ClosePanelVisible()
        {

            pnlAnalyst.Visible = false;
            pnlCustomer.Visible = false;
            pnlDeveloper.Visible = false;
            pnlManager.Visible = false;
            pnlTeamLeader.Visible = false;
            pnlTester.Visible = false;
        }
        #endregion



        private void button28_Click(object sender, EventArgs e)
        {
            ProjectBusiness pbuss = new ProjectBusiness();
            List<Project> projects = new List<Project>();
            projects = pbuss.GetProjectByCustomerID(_customer.ID);
            
            CustomerProjectStatus projectStatus = new CustomerProjectStatus(projects);
            projectStatus.MdiParent = this;
            projectStatus.Show();
            ClosePanelVisible();

        }

    }
}
