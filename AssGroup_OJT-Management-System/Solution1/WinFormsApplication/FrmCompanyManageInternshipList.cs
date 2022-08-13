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
    public partial class FrmCompanyManageInternshipList : Form
    {
        public TblAccount companyAccount { get; set; }
        public FrmCompanyManageInternshipList()
        {
            InitializeComponent();
        }

        private IRepositoryTblRegisterJob registJobRepo = new RepositoryTblRegisterJob();
        private IRepositoryTblSemester semesterRepo = new RepositoryTblSemester();
        private IRepositoryTblJob jobRepo = new RepositoryTblJob();
        private IRepositoryTblStudent studentRepo = new RepositoryTblStudent();
        private IRepositoryTblCompany companyRepo = new RepositoryTblCompany(); 

        private TblSemester currentSemester { get; set; }
        private TblRegisterJob interInfor { get; set; }

        private TblCompany companyInfor { get; set; }    

        //Method: Load dữ liệu danh sách sinh viên đã và đang thực tập tại công ty này
        private void FrmCompanyManageInternshipList_Load(object sender, EventArgs e)
        {
            TblCompany companyInformation = companyRepo.GetCompanyInformation(companyAccount.Username);
            companyInfor = companyRepo.GetCompanyByTaxCode(companyInformation.TaxCode);
            currentSemester = semesterRepo.GetCurrentSemester();
            IEnumerable<TblRegisterJob> list = registJobRepo.GetIntershipInCurrentSemester(currentSemester.SemesterId, companyInfor.TaxCode);
            CbFilterStudentList.Text = "Student code";
            LoadInterList(list);
        }

        //Method: mở trang đánh giá đối với sinh viên với trạng thái isInterns là working
        private void DgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            FrmCompanyEvaluateInterns frmCompanyEvaluateInterns = new FrmCompanyEvaluateInterns()
            {
                InternInfor = this.interInfor,
                CompanyInfor = this.companyInfor
            };
            frmCompanyEvaluateInterns.ShowDialog();
            IEnumerable<TblRegisterJob> list = registJobRepo.GetIntershipInCurrentSemester(currentSemester.SemesterId, companyInfor.TaxCode);
            LoadInterList(list);
        }

        private void LoadInterList (IEnumerable<TblRegisterJob> list)
        {
            DgvStudentList.DataSource = null;
            DgvStudentList.Rows.Clear();

            if (list != null)
            {
                DgvStudentList.ColumnCount = 7;
                DgvStudentList.Columns[0].Name = "Intern ID";
                DgvStudentList.Columns[1].Name = "Intern Name";
                DgvStudentList.Columns[2].Name = "Job Name";
                DgvStudentList.Columns[3].Name = "Status";
                DgvStudentList.Columns[4].Name = "Grade";
                DgvStudentList.Columns[5].Name = "Comment";
                DgvStudentList.Columns[6].Name = "Email";

                foreach (var item in list)
                {
                    string tmpStatus = "";
                    var tmpStu = studentRepo.GetStudentByStudentID(item.StudentCode);
                    switch (tmpStu.IsIntern)
                    {
                        case 1:
                            tmpStatus = "Working";
                            break;
                        case 2:
                            tmpStatus = "Finished";
                            break;
                    }

                    var tmpJob = jobRepo.GetJobByID(item.JobCode);
                    var tmpStudent = studentRepo.GetStudentByStudentID(item.StudentCode);
                    string[] tmpIntern = new string[]
                    {
                        item.StudentCode.ToString(),
                        tmpStudent.StudentName.ToString(),
                        tmpJob.JobName.ToString(),
                        tmpStatus,
                        item.Grade == null ? "" : item.Grade.ToString(),
                        item.Comment  == null ? "" : item.Comment.ToString(),
                        tmpStudent.Username.ToString(),
                    };

                    DgvStudentList.Rows.Add(tmpIntern);
                }
            }
            DgvStudentList.AllowUserToAddRows = false;
        }


        private void searchByFilter()
        {
            IEnumerable<TblRegisterJob> listInternFilter = null;
            if (string.IsNullOrEmpty(TxtSearchStudentFollowingFilter.Text.Trim()))
            {
                listInternFilter = registJobRepo.GetIntershipInCurrentSemester(currentSemester.SemesterId, companyInfor.TaxCode);
            }
            else
            {
                string tmpSearch = TxtSearchStudentFollowingFilter.Text.Trim();
                switch (CbFilterStudentList.Text)
                {
                    case "Student code":
                        listInternFilter = registJobRepo.GetIntershipInCurrentSemesterByStudentCode(currentSemester.SemesterId, companyInfor.TaxCode,tmpSearch);
                        break;

                    case "Student name":
                        listInternFilter = registJobRepo.GetIntershipInCurrentSemesterByStudentName(currentSemester.SemesterId, companyInfor.TaxCode,tmpSearch);
                        break;

                    case "Status":
                        if (int.TryParse(tmpSearch, out var resultStatus))
                        {
                            if (resultStatus == 1 || resultStatus == 2)
                            {
                                listInternFilter = registJobRepo.GetIntershipInCurrentSemesterByStatus(currentSemester.SemesterId, companyInfor.TaxCode,resultStatus);
                            }
                            else
                            {
                                MessageBox.Show("Search status by number 1 - Working | 2 - Finished", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                TxtSearchStudentFollowingFilter.Text = String.Empty;
                                TxtSearchStudentFollowingFilter.PlaceholderText = "Hint: Search by number 1 - Working | 2 - Finished";
                                listInternFilter = registJobRepo.GetIntershipInCurrentSemester(currentSemester.SemesterId, companyInfor.TaxCode);
                            }
                        } else
                        {
                            MessageBox.Show("Search status by number 1 - Working | 2 - Finished", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TxtSearchStudentFollowingFilter.Text = String.Empty;
                            TxtSearchStudentFollowingFilter.PlaceholderText = "Hint: Search by number 1 - Working | 2 - Finished";
                            listInternFilter = registJobRepo.GetIntershipInCurrentSemester(currentSemester.SemesterId, companyInfor.TaxCode);
                        }
                        break;
                }
            }
            if (listInternFilter.Count() == 0)
            {
                listInternFilter = registJobRepo.GetIntershipInCurrentSemester(currentSemester.SemesterId, companyInfor.TaxCode);
                MessageBox.Show("No record match!", "Search interns", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadInterList((IEnumerable<TblRegisterJob>)listInternFilter);
        }

        private void DgvStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string tmpStudentCode = DgvStudentList.Rows[e.RowIndex].Cells[0].Value.ToString();
                interInfor = registJobRepo.GetIntershipInCurrentSemesterByStudentCode(currentSemester.SemesterId, companyInfor.TaxCode,tmpStudentCode).FirstOrDefault();
            }
        }

        private void CbFilterStudentList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CbFilterStudentList.Text.Equals("Status"))
            {
                TxtSearchStudentFollowingFilter.Text = String.Empty;
                TxtSearchStudentFollowingFilter.PlaceholderText = "Hint: Search by number 1 - Working | 2 - Finished";
            }
            searchByFilter();
        }

        private void BtnSearchStudentList_Click(object sender, EventArgs e)
        {
            searchByFilter();
        }
    }
}
