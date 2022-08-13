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
    public partial class FrmCompanyEditProfile : Form
    {
        public TblAccount companyAccount { get; set; }
        public TblCompany companyInfor { get; set; }
        public IRepositoryTblCompany repositoryTblCompany { get; set; }
        public FrmCompanyProfile parentForm { get; set; }
        public FrmCompanyEditProfile()
        {
            InitializeComponent();
        }

        //Method: update company information
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string companyName = TxtFullName.Text;
            string address = txtAddress.Text;
            bool found = false;
            string error = "";
            try
            {
                if (companyName.Length == 0)
                {
                    found = true;
                    error += "Company name is required.\n";
                }
                if (companyName.Length > 100)
                {
                    found = true;
                    error += "Company name is required less than 100 characters.\n";
                }
                if (address.Length == 0)
                {
                    found = true;
                    error += "Address is required.\n";
                }
                if (address.Length > 100 || address.Length < 5)
                {
                    found = true;
                    error += "Address is required 5..100 characters.\n";
                }
                if (found)
                {
                    MessageBox.Show(error, "Update Profile - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    companyInfor.CompanyName = companyName;
                    companyInfor.Address = address;
                    repositoryTblCompany = new RepositoryTblCompany();
                    repositoryTblCompany.UpdateCompanyInformation(companyInfor);
                    parentForm.LoadFrmCompanyProfile();
                    this.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Profile - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Method: đóng windows này
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCompanyEditProfile_Load(object sender, EventArgs e)
        {
            txtAddress.Text = companyInfor.Address;
            TxtCompanyTax.Text = companyInfor.TaxCode;
            TxtEmail.Text = companyInfor.Username;
            TxtFullName.Text = companyInfor.CompanyName;
        }
    }
}
