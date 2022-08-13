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
    public partial class FrmStudentJobCompanyList : Form
    {
        public FrmStudentJobCompanyList()
        {
            InitializeComponent();
        }


        private IRepositoryTblJob jobRepo = new RepositoryTblJob();
        private IRepositoryTblSemester semesterRepo = new RepositoryTblSemester();
        private IRepositoryTblRegisterJob registerJobRepo = new RepositoryTblRegisterJob();
        private IRepositoryTblStudent studentRepo = new RepositoryTblStudent();
        private IRepositoryTblCompany companyRepo = new RepositoryTblCompany(); 
        private IRepositoryTblMajor majorRepo = new RepositoryTblMajor();

        public TblAccount studentAccount { get; set; }
        public TblStudent studentInfor { get; set; }
        private TblJob jobInfor { get; set; }
        private TblSemester currentSemester { get; set; }

        public bool IsChange { get; set; } = false;
        public TblRegisterJob SelectJobFromChange { get; set; }
        
        //Method: chức năng search theo filter được chọn và text được nhập
        private void BtnSearchJobList_Click(object sender, EventArgs e)
        {
            SearchByFilter();
        }

        //Method: show ra frmStudentDetailJobCompany để thực hiện chức năng apply
        private void DgvCompaniesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool status = false;
            if (e.RowIndex != -1)
            {
                int jobCode = int.Parse(DgvCompaniesList.Rows[e.RowIndex].Cells[0].Value.ToString());
                TblJob tblJob = jobRepo.GetJobByID(jobCode);
                if (tblJob.NumberInterns == 0)
                {
                    status = true;
                }
            }
            if (status == false)
            {
                FrmStudentDetailJobCompany frmStudentDetailJobCompany = new FrmStudentDetailJobCompany()
                {
                    StudentInfor = this.studentInfor,
                    JobInfor = this.jobInfor
                };
                var listApplied = registerJobRepo.GetListStudentApplied(currentSemester, studentInfor.StudentCode);
                bool isCheck = false;


                if (IsChange)
                {
                    frmStudentDetailJobCompany.SelectJobFromChange = SelectJobFromChange;
                    frmStudentDetailJobCompany.IsChange = true;
                    var list1 = registerJobRepo.GetListStudentApplied(currentSemester, studentInfor.StudentCode);
                    if (SelectJobFromChange == null)
                    {
                        frmStudentDetailJobCompany.ApplyOrCancel = true;
                        frmStudentDetailJobCompany.ShowDialog();
                    }
                    else
                    {
                        // Update or Cancel 
                        if (jobInfor.JobCode == SelectJobFromChange.JobCode)
                        {
                            frmStudentDetailJobCompany.ApplyOrCancel = false;
                            frmStudentDetailJobCompany.ShowDialog();
                        }
                        else
                        {
                            foreach (var item in listApplied)
                            {
                                // change aspiration 2 job
                                if (item.JobCode == jobInfor.JobCode && item.JobCode != SelectJobFromChange.JobCode)
                                {
                                    DialogResult rs = MessageBox.Show("You have applied this job. Do you want change aspiration?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    if (rs == DialogResult.OK)
                                    {
                                        int tmpAspiration1 = (int)item.Aspiration;
                                        item.Aspiration = SelectJobFromChange.Aspiration;
                                        SelectJobFromChange.Aspiration = tmpAspiration1;
                                        registerJobRepo.UpdateInternEvaluation(item);
                                        registerJobRepo.UpdateInternEvaluation(SelectJobFromChange);
                                    }
                                    isCheck = true;
                                }
                            }

                            // Add new Job into old job 
                            if (!isCheck)
                            {
                                frmStudentDetailJobCompany.IsChange = true;
                                if (jobInfor.JobCode == SelectJobFromChange.JobCode)
                                {
                                    frmStudentDetailJobCompany.ApplyOrCancel = false;
                                }
                                else
                                {
                                    frmStudentDetailJobCompany.ApplyOrCancel = true;
                                }
                                frmStudentDetailJobCompany.SelectJobFromChange = SelectJobFromChange;
                                frmStudentDetailJobCompany.ShowDialog();
                                //  SelectJobFromChange = registerJobRepo.GetAppliedJobByIDAndStudentCode(jobInfor.JobCode, studentInfor.StudentCode);
                            }
                        }
                        SelectJobFromChange = registerJobRepo.GetAppliedJobByIDAndStudentCode(SelectJobFromChange.JobCode, studentInfor.StudentCode);
                    }
                    var list2 = registerJobRepo.GetListStudentApplied(currentSemester, studentInfor.StudentCode);
                    if (list2.Count() != 0)
                    {
                        if (list1.FirstOrDefault().JobCode != list2.FirstOrDefault().JobCode ||
                            list1.LastOrDefault().JobCode != list2.LastOrDefault().JobCode)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    if (listApplied != null)
                    {
                        foreach (var item in listApplied)
                        {
                            if (item.JobCode == jobInfor.JobCode)
                            {
                                frmStudentDetailJobCompany.ApplyOrCancel = false;
                                frmStudentDetailJobCompany.ShowDialog();
                                isCheck = true;
                            }
                        }
                    }

                    if (!isCheck)
                    {
                        if (listApplied.Count() != 2)
                        {
                            frmStudentDetailJobCompany.ApplyOrCancel = true;
                            frmStudentDetailJobCompany.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Student have registerd 2 aspiration.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            } else
            {
                MessageBox.Show("The number of vacancies for this job has run out", "Apply job - Run off vacancies", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            IEnumerable<TblJob> jobList = jobRepo.GetJobActive();
            LoadJobList(jobList);
        }

        //Method: Chức năng load danh sách các job của các công ty chưa hết hạn
        //  và còn quantity tuyển dụng
        private void FrmStudentJobCompanyList_Load(object sender, EventArgs e)
        {
            TblStudent student = studentRepo.GetStudentProfileByUserName(studentAccount.Username);
            studentInfor = studentRepo.GetStudentByStudentID(student.StudentCode);
            currentSemester = semesterRepo.GetCurrentSemester();
            CbFilterJobCompanyList.Text = "Company name";
            IEnumerable<TblJob> jobList = jobRepo.GetJobActive();
            LoadJobList(jobList);
        }

        private void DgvCompaniesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int tmpID = int.Parse(DgvCompaniesList.Rows[e.RowIndex].Cells[0].Value.ToString());
                jobInfor = jobRepo.GetJobByID(tmpID);
            }
        }

        private void LoadJobList(IEnumerable<TblJob> list)
        {
            DgvCompaniesList.DataSource = null;
            DgvCompaniesList.Rows.Clear();

            if (list != null)
            {
                DgvCompaniesList.ColumnCount = 6;
                DgvCompaniesList.Columns[0].Name = "Job Code";
                DgvCompaniesList.Columns[1].Name = "Job Name";
                DgvCompaniesList.Columns[2].Name = "Quantity";
                DgvCompaniesList.Columns[3].Name = "Expiration Date";
                DgvCompaniesList.Columns[4].Name = "Company Name";
                DgvCompaniesList.Columns[5].Name = "Major Name";

                foreach (var item in list)
                {
                    DateTime tmpDate = (DateTime)item.ExpirationDate;
                    var tmpCompany = companyRepo.GetCompanyByTaxCode(item.TaxCode);
                    var tmpMajor = majorRepo.GetMajorByMajorCode(item.MajorCode);
                    string[] tmpJob = new string[]
                    {
                        item.JobCode.ToString(),
                        item.JobName.ToString(),
                        item.NumberInterns.ToString(),
                        tmpDate.ToString(),
                        tmpCompany.CompanyName.ToString(),
                        tmpMajor.MajorName.ToString()
                    };
                    DgvCompaniesList.Rows.Add(tmpJob);
                }
            }
            DgvCompaniesList.AllowUserToAddRows = false;
        }


        private void SearchByFilter()
        {
            IEnumerable<TblJob> listInternFilter = null;
            if (string.IsNullOrEmpty(TxtSearchJobCompanyName.Text.Trim()))
            {
                listInternFilter = jobRepo.GetJobActive();
            }
            else
            {
                string tmpSearch = TxtSearchJobCompanyName.Text.Trim();
                switch (CbFilterJobCompanyList.Text)
                {
                    case "Company name":
                        listInternFilter = jobRepo.SearchJobByCompanyNameAsStudent(tmpSearch);
                        break;

                    case "Company Address":
                        listInternFilter = jobRepo.SearchJobByCompanyAddressAsStudent(tmpSearch);
                        break;
                    
                    case "Job name":
                        listInternFilter = jobRepo.SearchJobByJobNameAsStudent(tmpSearch);
                        break;
                    case "Major name":
                        listInternFilter = jobRepo.SearchJobByMajorNameAsStudent(tmpSearch);
                        break;
                }
            } 
            LoadJobList(listInternFilter);
        }
    }
    
}
