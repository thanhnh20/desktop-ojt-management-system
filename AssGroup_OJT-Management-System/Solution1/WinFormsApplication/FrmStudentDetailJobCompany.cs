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
    public partial class FrmStudentDetailJobCompany : Form
    {
        public FrmStudentDetailJobCompany()
        {
            InitializeComponent();
        }

        private IRepositoryTblJob jobRepo = new RepositoryTblJob();
        private IRepositoryTblSemester semesterRepo = new RepositoryTblSemester();
        private IRepositoryTblRegisterJob registerJobRepo = new RepositoryTblRegisterJob();
        private IRepositoryTblCompany companyRepo = new RepositoryTblCompany();
        private IRepositoryTblMajor majorRepo = new RepositoryTblMajor();

        public TblStudent StudentInfor { get; set; }

        public TblJob JobInfor { get; set; }

        public bool ApplyOrCancel { get; set; }

        public bool IsChange { get; set; } = false;

        public TblRegisterJob SelectJobFromChange { get; set; }

        private TblSemester currentSemester { get; set; }
        //Method: khi bấm nút Exit thì thoát form detail job company
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Method: Chức năng apply vào job của company
        private void BtnApply_Click(object sender, EventArgs e)
        {
            if (BtnApply.Text.Equals("Apply"))
            {
                TblJob tblJob = jobRepo.GetJobByID(JobInfor.JobCode);
                if (tblJob.NumberInterns > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure that you apply this job ?", "Student Application - Apply a Job",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        var listApplied = registerJobRepo.GetListStudentApplied(currentSemester, StudentInfor.StudentCode);
                        int tmpAspiration = 1;
                        if (listApplied.Count() == 1)
                        {
                            var firstRegisterJob = listApplied.First();
                            if (firstRegisterJob.Aspiration == 1)
                            {
                                tmpAspiration = 2;
                            }
                            else
                            {
                                tmpAspiration = 1;
                            }
                        }

                        if (IsChange && SelectJobFromChange != null)
                        {
                            tmpAspiration = (int)SelectJobFromChange.Aspiration;
                            registerJobRepo.DeleteRegister(SelectJobFromChange);
                        }
                        var tmpregister = new TblRegisterJob()
                        {
                            JobCode = JobInfor.JobCode,
                            StudentCode = StudentInfor.StudentCode,
                            StudentConfirm = true,
                            Aspiration = tmpAspiration,
                            IsCompanyConfirm = 0
                        };
                        registerJobRepo.InsertRegister(tmpregister);

                        if (!IsChange)
                        {
                            SelectJobFromChange = tmpregister;
                        }
                        //Code chức năng apply ở đây
                        BtnApply.Text = "Cancel";
                        TxtAppliedStatus.Text = "Waiting";

                        this.Close();

                    }
                } else
                {
                    MessageBox.Show("The number of vacancies for this job has run out", "Apply job - Run off vacancies", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            } else if (BtnApply.Text.Equals("Cancel"))
            {
                DialogResult result = MessageBox.Show("Are you sure that you cancel this job ?", "Student Application - Cancel a Job",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    //code chức năng cancel apply ở đây
                    var registerJob = registerJobRepo.GetAppliedJobByIDAndStudentCode(JobInfor.JobCode, StudentInfor.StudentCode);
                    if (registerJob != null)
                    {
                        registerJobRepo.DeleteRegister(registerJob);

                        //cập nhật lại nguyện vọng cho job còn lại 
                        var listAppliedCancel = registerJobRepo.GetListStudentApplied(currentSemester, StudentInfor.StudentCode);
                        if (listAppliedCancel.Count() == 1)
                        {
                            var tmpListAppliedCancel = listAppliedCancel.First();
                            tmpListAppliedCancel.Aspiration = 1;
                            registerJobRepo.UpdateInternEvaluation(tmpListAppliedCancel);
                        }
                    }
                    BtnApply.Text = "Apply";
                    TxtAppliedStatus.Text = "Not Yet";
                    this.Close();
                }
            }
                
        }

        //Method: Load dữ liệu của major của job lên lên và chọn 
        private void FrmStudentDetailJobCompany_Load(object sender, EventArgs e)
        {
            currentSemester = semesterRepo.GetCurrentSemester();
            TxtJobName.Enabled = false;
            TxtNumberOfInterns.Enabled = false;
            TxtAddressCompany.Enabled = false;
            CbMajorJob.Enabled = false;
            TxtJobDescriptio.Enabled = false;
            MTextExpirationDate.Enabled = false;
            TxtAppliedStatus.Enabled = false;
            loadJobInfor();
            if (ApplyOrCancel)
            {
                BtnApply.Text = "Apply";
                TxtAppliedStatus.Text = "Not Yet";
            }
            else
            {
                BtnApply.Text = "Cancel";
                if (!IsChange)
                {
                    SelectJobFromChange = registerJobRepo.GetAppliedJobByIDAndStudentCode(JobInfor.JobCode, StudentInfor.StudentCode);
                }
                switch (SelectJobFromChange.IsCompanyConfirm)
                {
                    case 0:
                        TxtAppliedStatus.Text = "Waiting";
                        break;
                    case 1:
                        TxtAppliedStatus.Text = "Accepted";
                        break;

                    case 2:
                        TxtAppliedStatus.Text = "Denied";
                        break;
                }
            }

            if (StudentInfor.IsIntern != 0)
            {
                BtnApply.Enabled = false;
            }
        }

        private void loadJobInfor()
        {
            var tmpCompany = companyRepo.GetCompanyByTaxCode(JobInfor.TaxCode);
            var tmpMajor = majorRepo.GetMajorByMajorCode(JobInfor.MajorCode);
            TxtJobName.Text = JobInfor.JobName.ToString();  
            TxtAddressCompany.Text = tmpCompany.Address.ToString();
            TxtNumberOfInterns.Text = JobInfor.NumberInterns.ToString();
            CbMajorJob.Text = tmpMajor.MajorName.ToString();
            MTextExpirationDate.Text = JobInfor.ExpirationDate.ToString();
            TxtJobDescriptio.Text = JobInfor.JobDescription.ToString();
        }
    }
}
