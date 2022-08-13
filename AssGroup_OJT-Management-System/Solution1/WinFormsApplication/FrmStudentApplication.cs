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
    public partial class FrmStudentApplication : Form
    {
        public FrmStudentApplication()
        {
            InitializeComponent();
        }

        private IRepositoryTblJob jobRepo = new RepositoryTblJob();
        private IRepositoryTblSemester semesterRepo = new RepositoryTblSemester();
        private IRepositoryTblRegisterJob registerJobRepo = new RepositoryTblRegisterJob();
        private IRepositoryTblStudent studentRepo = new RepositoryTblStudent();
        private IRepositoryTblCompany companyRepo = new RepositoryTblCompany(); 
        // dùng tạm id để lấy studentInfor 
        //public string stuCode = "SE151262";
        public TblAccount studentAccount { get; set; }
        public TblStudent StudentInfor { get; set; }
        public TblSemester currentSemester { get; set; }

        private TblRegisterJob registerJob1 { get; set; }
        private TblRegisterJob registerJob2 { get; set; }

        //Method: Load dữ liệu của 2 bài được applied bởi sinh viên này
        private void FrmStudentApplication_Load(object sender, EventArgs e)
        {
            TblStudent student = studentRepo.GetStudentProfileByUserName(studentAccount.Username);
            //code load data ở đây
            StudentInfor = studentRepo.GetStudentByStudentID(student.StudentCode);

            currentSemester = semesterRepo.GetCurrentSemester();
            
            LoadScreen();
        }


        //Method: Hủy (xóa) applied vào job nguyện vọng 1 này của sinh viên
        private void BtnCancelAspiration1_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Are you sure that you want to cancel this job?", "Student Application - Cancel a Job", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                //code xóa applied ở đây
                registerJobRepo.DeleteRegister(registerJob1);

                //cập nhật lại nguyện vọng cho job còn lại 
                var listAppliedCancel = registerJobRepo.GetListStudentApplied(currentSemester, StudentInfor.StudentCode);
                if (listAppliedCancel.Count() == 1)
                {
                    var tmpListAppliedCancel = listAppliedCancel.First();
                    tmpListAppliedCancel.Aspiration = 1;
                    registerJobRepo.UpdateInternEvaluation(tmpListAppliedCancel);
                }
                LoadScreen();
            }
            
        }


        //Method: Change job cho sinh viên khi muốn job khác làm Nguyện vọng 1
        private void BtnChangeAspiration1_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Are you sure that you want to change this job by another job?", "Student Application - Change a Job",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                FrmStudentJobCompanyList frmStudentJobCompanyList = new FrmStudentJobCompanyList()
                {
                    IsChange = true,
                    SelectJobFromChange = registerJob1,
                    studentAccount = studentAccount
                };
                frmStudentJobCompanyList.ShowDialog();
                LoadScreen();
                //code change applied ở đây

            }

        }

        //Method: Hủy (xóa) applied vào job nguyện vọng 2 này của sinh viên
        private void BtnCancelAspiration2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to cancel this job?", "Student Application - Cancel a Job",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                //code xóa applied ở đây
                registerJobRepo.DeleteRegister(registerJob2);

                LoadScreen();
            }
        }

        //Method: Change job cho sinh viên khi muốn job khác làm Nguyện vọng 2
        private void BtnChangeAspiration2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to change this job by another job?", "Student Application - Change a Job",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                FrmStudentJobCompanyList frmStudentJobCompanyList = new FrmStudentJobCompanyList()
                {
                    IsChange = true,
                    SelectJobFromChange = registerJob2,
                    studentAccount = studentAccount
                };
                frmStudentJobCompanyList.ShowDialog();
                LoadScreen();
                //code change applied ở đây
            }
        }

        private void LoadAspiration1(TblJob job)
        {
            var tmpCompany = companyRepo.GetCompanyByTaxCode(job.TaxCode);
            LbJobNameAspiration1.Text = job.JobName;
            TxtCompanyNameAspiration1.Text = tmpCompany.CompanyName;
            TxtAddressAspiration1.Text = tmpCompany.Address;
            TxtQuantityAspiration1.Text = job.NumberInterns.ToString();

            var tmpRegisterJob = registerJobRepo.GetAppliedJobByIDAndStudentCode(job.JobCode, StudentInfor.StudentCode);
            if (tmpRegisterJob.IsCompanyConfirm == null) tmpRegisterJob.IsCompanyConfirm = 0;
            switch (tmpRegisterJob.IsCompanyConfirm)
            {
                case 0:
                    TxtStatusAspiration1.Text = "Waiting";
                    break;
                case 1:
                    TxtStatusAspiration1.Text = "Accepted";
                    break;
                case 2:
                    TxtStatusAspiration1.Text = "Denied";
                    break;
            }

            LbAddressAspiration1.Enabled = false;
            TxtQuantityAspiration1.Enabled = false;
            TxtAddressAspiration1.Enabled = false;
        }


        private void LoadAspiration2(TblJob job)
        {
            var tmpCompany = companyRepo.GetCompanyByTaxCode(job.TaxCode);
            LbJobNameAspiration2.Text = job.JobName;
            TxtCompanyNameAspiration2.Text = tmpCompany.CompanyName;
            TxtAddressAspiration2.Text = tmpCompany.Address;
            TxtQuantityAspiration2.Text = job.NumberInterns.ToString();
            
            var tmpRegisterJob = registerJobRepo.GetAppliedJobByIDAndStudentCode(job.JobCode,StudentInfor.StudentCode);
            if (tmpRegisterJob.IsCompanyConfirm == null) tmpRegisterJob.IsCompanyConfirm = 0;
            switch (tmpRegisterJob.IsCompanyConfirm)
            {
                case 0:
                    TxtStatusAspiration2.Text = "Waiting";
                    break;
                case 1:
                    TxtStatusAspiration2.Text = "Accepted";
                    break;
                case 2:
                    TxtStatusAspiration2.Text = "Denied";
                    break ;
            }


            LbAddressAspiration2.Enabled = false;
            TxtQuantityAspiration2.Enabled = false;
            TxtAddressAspiration2.Enabled = false;
        }

        private void LoadScreen()
        {
            ClearText();
            var listApplied = registerJobRepo.GetListStudentApplied(currentSemester, StudentInfor.StudentCode);
            switch (listApplied.Count())
            {
                case 0:
                    PnAspiration1.Enabled = false;
                    PnAspiration2.Enabled = false;
                    break;
                case 1:
                    PnAspiration2.Enabled = false;
                    registerJob1 = listApplied.First();
                    var tmp = jobRepo.GetJobByID(registerJob1.JobCode);
                    LoadAspiration1(tmp);
                    break;
                case 2:
                    registerJob1 = listApplied.First();
                    var tmp1 = jobRepo.GetJobByID(registerJob1.JobCode);
                    LoadAspiration1(tmp1);

                    registerJob2 = listApplied.Last();
                    var tmp2 = jobRepo.GetJobByID(registerJob2.JobCode);
                    LoadAspiration2(tmp2);
                    break;
            }
            if (StudentInfor.IsIntern != 0)
            {
                PnAspiration1.Enabled = false;
                PnAspiration2.Enabled = false;
            }
        }

        private void ClearText()
        {
            TxtAddressAspiration1.Clear();
            TxtAddressAspiration2.Clear();
            TxtCompanyNameAspiration1.Clear();
            TxtCompanyNameAspiration2.Clear();
            TxtQuantityAspiration1.Clear();
            TxtQuantityAspiration2.Clear();
            TxtStatusAspiration1.Clear();
            TxtStatusAspiration2.Clear();
            LbJobNameAspiration1.Text = "Job Name";
            LbJobNameAspiration2.Text = "Job Name";
        }

    }
}
