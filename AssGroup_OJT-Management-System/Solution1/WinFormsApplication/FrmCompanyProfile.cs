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
    public partial class FrmCompanyProfile : Form
    {
        public TblAccount companyAccount { get; set; }
        public IRepositoryTblCompany repositoryTblCompany { get; set; }
        public TblCompany companyInfor { get; set; }
        public FrmCompanyDashboard frmCompanyDashboard { get; set; }
        public FrmCompanyProfile()
        {
            InitializeComponent();
        }

        //Method: Load dữ liệu của công ty đang đăng nhập vào hệ thống
        private void FrmCompanyProfile_Load(object sender, EventArgs e)
        {
            LoadFrmCompanyProfile();
        }

        public void LoadFrmCompanyProfile()
        {
            try
            {
                repositoryTblCompany = new RepositoryTblCompany();
                companyInfor = repositoryTblCompany.GetCompanyInformation(companyAccount.Username);
                TxtCompanyTax.Text = companyInfor.TaxCode;
                txtAddress.Text = companyInfor.Address;
                TxtEmail.Text = companyInfor.Username;
                TxtFullName.Text = companyInfor.CompanyName;
                frmCompanyDashboard.LoadFrmCompanyDashboard();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "My Profile - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method: open frm edit profile để thực hiện edit
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FrmCompanyEditProfile frmCompanyEditProfile = new FrmCompanyEditProfile()
            {
                companyAccount = companyAccount,
                companyInfor = companyInfor,
                parentForm = this
            };
            frmCompanyEditProfile.ShowDialog();
        }
    }
}
