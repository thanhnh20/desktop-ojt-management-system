using Library.Models;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApplication
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        //Method: Khi login cần check valid các giá trị và các điều kiện login
        // và phân quyền cho user
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //code login ở đây 
                string email = TxtEmail.Text;
                string password = TxtPassword.Text;
                bool found = false;
                string error = "";
                TblAccount account = null;
                if (email.Length == 0)
                {
                    found = true;
                    error += "Email is required.\n";
                }
                if (password.Length == 0)
                {
                    found = true;
                    error += "Password is required.\n";
                }
                if (password.Length > 0 && email.Length > 0)
                {
                    IRepositoryTblAccount repositoryTblAccount = new RepositoryTblAccount();
                    bool checkAvailableAccount = repositoryTblAccount.CheckAvailabelAccount(email);
                    if (checkAvailableAccount == false)
                    {
                        found = true;
                        error += "Your email does not allow use in this system.\n";
                    }
                    else
                    {
                        account = repositoryTblAccount.CheckLogin(email, password);
                        if (account == null)
                        {
                            found = true;
                            error += "Email or Password is invalid.\n";
                        }
                    }
                }
                if (found)
                {
                    MessageBox.Show(error, "Login - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (account.IsAdmin == 0)
                    {
                        //role: university
                        FrmUniversityDashboard frmUniversityDashboard = new FrmUniversityDashboard();
                        this.Hide();
                        frmUniversityDashboard.ShowDialog();
                    }
                    else if (account.IsAdmin == 1)
                    {
                        //role: student
                        FrmStudentDashBoard frmStudentDashBoard = new FrmStudentDashBoard()
                        {
                            studentAccount = account,
                        };
                        this.Hide();
                        frmStudentDashBoard.ShowDialog();
                    }
                    else if (account.IsAdmin == 2)
                    {
                        //role: company
                        FrmCompanyDashboard frmCompanyDashboard = new FrmCompanyDashboard()
                        {
                            companyAccount = account,
                        };
                        this.Hide();
                        frmCompanyDashboard.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
