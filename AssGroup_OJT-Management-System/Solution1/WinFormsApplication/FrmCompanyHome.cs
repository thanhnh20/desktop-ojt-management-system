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
    public partial class FrmCompanyHome : Form
    {
        public TblAccount companyAccount { get; set; }
        public IRepositoryTblCompany RepositoryTblCompany { get; set; }
        public IRepositoryTblJob repositoryTblJob { get; set; }
        public FrmCompanyHome()
        {
            InitializeComponent();
        }

        //Method: Load dữ liệu của company lên để hiển thị lên home form 
        private void FrmCompanyHome_Load(object sender, EventArgs e)
        {
            //Get company infor
            RepositoryTblCompany = new RepositoryTblCompany();
            TblCompany companyInfor = RepositoryTblCompany.GetCompanyInformation(companyAccount.Username);
            TxtCompanyTax.Text = companyInfor.TaxCode;
            TxtEmail.Text = companyInfor.Username;
            TxtCompanyName.Text = companyInfor.CompanyName;
            //get list interns thông qua bài post(jobcode) được company và student xác nhận -> taxcode
            repositoryTblJob = new RepositoryTblJob();
            int numberOfInterns = repositoryTblJob.GetNumberOfInterns(companyInfor, 1, 1);
            TxtNumberOfStudents.Text = numberOfInterns.ToString();
            //get list job post
            List<TblJob> ListJob = repositoryTblJob.GetListCompanyJobPost(companyInfor);
            if (ListJob == null)
            {
                TxtNumberOfJobs.Text = "0";
            }
            else
            {
                TxtNumberOfJobs.Text = ListJob.Count.ToString();
            }
            //get list interns application
            int numberOfIntensApplication = repositoryTblJob.GetNumberOfInterns(companyInfor, 0, 0);
            TxtNumberOfApplications.Text = numberOfIntensApplication.ToString();
        }
    }
}
