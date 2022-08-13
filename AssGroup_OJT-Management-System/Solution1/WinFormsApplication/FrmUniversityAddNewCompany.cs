using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Repository;
using System.Text.RegularExpressions;
using Library.Models;
namespace WinFormsApplication
{
    public partial class FrmUniversityAddNewCompany : Form
    {
        IRepositoryTblAccount repositoryTblAccount = new RepositoryTblAccount();
        IRepositoryTblCompany repositoryTblCompany = new RepositoryTblCompany();

        public TblCompany TblCompany { get; set; }
        public FrmUniversityAddNewCompany()
        {
            InitializeComponent();
        }

        //Method: thực hiện insert new company
        private void BtnInsertANewCompany_Click(object sender, EventArgs e)
        {
            
            string pattern = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";
            
            //get text
            string email = TxtCompanyEmail.Text;
            string password = TxtPassword.Text;
            string companyTax = TxtCompanyTax.Text;
            string companyName = TxtCompanyName.Text;
            string address = TxtCompanyAddress.Text;

            //TxtPassword.Text = string.Empty;

            string ppattern = "^[a-zA-Z0-9+_.-]@/fpt.edu.vn/+$";
            bool check = true;
            string msgError = ""; 
            //check invalid
            Match match = Regex.Match(email, pattern);
            
            if (email == string.Empty || password == string.Empty || companyTax == string.Empty || companyName == string.Empty || address == string.Empty)
            {
                //MessageBox.Show("Please enter full information !!!", "Notification");
                msgError += "Please enter full information\n";
                check = false;
            }
            else
            {
                //if (!match.Success)
                if(!email.Trim().EndsWith("@fpt.edu.vn") || email.Length > 40)
                {
                    //MessageBox.Show("Your email is invalid format !!!", "Notification");
                    msgError += "Your email is required format less than 40 characters (Ex: abc@fpt.edu.vn)\n";
                    check = false;
                }
                if (repositoryTblAccount.GetAccountByEmail(email) != null)
                {
                    //MessageBox.Show("Company email id duplicated !!!", "Notification");
                    msgError += "Company email id duplicated\n";
                    check = false;
                }
                if (password.Length < 6 || password.Length > 20)
                {
                    //MessageBox.Show("Password required is more than 8 characters !!!", "Notification");
                    msgError += "Password required is required 6-20 characters\n";
                    check = false;
                }
                if (companyTax.Length != 10)
                {
                    msgError += "Company tax is required 10 characters.";
                    check = false;
                } else
                {
                    string taxCodePattern = @"^[0-9]{10,10}$";
                    Regex regex = new Regex(taxCodePattern);
                    if (regex.IsMatch(companyTax) == false)
                    {
                        msgError += "Company tax is required the number format.";
                        check = false;
                    }
                    if (repositoryTblCompany.GetCompanyByTaxCode(companyTax) != null)
                    {
                        //MessageBox.Show("Company tax id duplicated !!!", "Notification");
                        msgError += "Company tax id duplicated\n";
                        check = false;
                    }
                }
                if (companyName.Length > 100)
                {
                    msgError += "Company name is required less than 100 characters.\n";
                    check = false;
                }
                if (address.Length > 100)
                {
                    msgError += "Address is required less than 100 characters.\n";
                }
            }                          
            if (!check)
            {
                MessageBox.Show(msgError, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var TblCompany = new TblCompany()
                {
                    TaxCode = companyTax,
                    Username = email,
                    CompanyName = companyName,
                    Address = address,
                    UsernameNavigation = new TblAccount() {
                    Username = email,
                    Password = password,
                    IsAdmin = 2,
                    },                  
                };
                bool result = repositoryTblCompany.CreateCompany(TblCompany);
                if (result)
                {
                    MessageBox.Show("Successfully added a new company", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
        }

        //Method: Thoát màn hình hiện tại
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
