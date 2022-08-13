using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Library.Data_Access;
using Library.Models;
using Library.Repository;

namespace WinFormsApplication
{
    public partial class FrmCompanyManageInternsApplicaton : Form
    {
        private readonly IRepositoryTblRegisterJob repositoryTblRegisterJob = new RepositoryTblRegisterJob();
        public IRepositoryTblJob repositoryTblJob { get; set; }
        public IRepositoryTblSemester repositoryTblSemester { get; set; }
        //private readonly BindingSource source = new BindingSource();
        public TblAccount CompanyAccount { get; set; }
        public FrmCompanyManageInternsApplicaton()
        {
            InitializeComponent();
        }

        //Method: confirm application of student(intern)
        private void DgvApplicationList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = DgvApplicationList.CurrentCell.RowIndex;
            int jobCode = int.Parse(DgvApplicationList.Rows[index].Cells[6].Value.ToString());
            string studentCode = DgvApplicationList.Rows[index].Cells[0].Value.ToString();
            var appliedJob =
                repositoryTblRegisterJob.GetAppliedJobByIDAndStudentCode(jobCode,
                    studentCode);
            if (appliedJob.StudentConfirm == true && appliedJob.IsCompanyConfirm == 0)
            {
                DialogResult result = MessageBox.Show("Do you want to confirm for this student who applied your job?",
                    "Interns Application - Confirm Application",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    appliedJob.IsCompanyConfirm = 1;
                    //update trạng thái isInterns for student
                    IRepositoryTblStudent repositoryTblStudent = new RepositoryTblStudent();
                    TblStudent student = repositoryTblStudent.GetStudentByStudentID(studentCode);
                    student.IsIntern = 1;
                    repositoryTblStudent.UpdateStudent(student);
                    // thực hiện cập nhật companyConfirm là accepted
                    repositoryTblRegisterJob.UpdateStatusApplyJobAsCompany(appliedJob);
                    //cập nhật lại numberinterns
                    repositoryTblJob = new RepositoryTblJob();
                    TblJob currentJob = repositoryTblJob.GetJobByID(jobCode);
                    currentJob.NumberInterns -= 1;
                    repositoryTblJob.UpdateJob(currentJob);
                    //nếu 1 trong 2 cái được confirm thì cái còn lại sẽ chuyển student_Confirm = fasle
                    repositoryTblSemester = new RepositoryTblSemester();
                    TblSemester currentSemester = repositoryTblSemester.GetCurrentSemester();
                    IEnumerable<TblRegisterJob> registerJobs = repositoryTblRegisterJob.GetListStudentApplied(currentSemester, appliedJob.StudentCode);
                    foreach (var item in registerJobs)
                    {
                        if (item.JobCode == appliedJob.JobCode)
                        {
                            continue;
                        } else
                        {
                            item.StudentConfirm = false;
                            repositoryTblRegisterJob.UpdateRegister(item);
                        }
                    }
                }
                else if (result == DialogResult.No)
                {
                    // thực hiện cập nhật companyConfirm là dined
                    appliedJob.IsCompanyConfirm = 2;
                    repositoryTblRegisterJob.UpdateStatusApplyJobAsCompany(appliedJob);
                }
            } else
            {
                if (appliedJob.IsCompanyConfirm != 0)
                {
                    MessageBox.Show("This student application was confirmed before!", "Confirmed student applycation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (appliedJob.StudentConfirm == false)
                {
                    MessageBox.Show("This student application is canceled!", "Confirmed student applycation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            // cancel là thoát form này
            LoadAppiedJob();
        }
        public void LoadAppiedJob()
        {
            BindingSource source = new BindingSource();

            try
            {

                source.DataSource = repositoryTblRegisterJob.GetListStudentAppliedJobAsCompanyByUserName(CompanyAccount.Username).ToList();
                txtJobCodeInvisible.DataBindings.Clear();
                txtStudentCodeInvisible.DataBindings.Clear();
                txtJobCodeInvisible.DataBindings.Add("Text", source, "JobCode");
                txtStudentCodeInvisible.DataBindings.Add("Text", source, "StudentCode");
                DgvApplicationList.DataSource = source;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Load data error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //Method: thực hiện load dữ liệu của danh sách đăng kí list của student
        private void FrmCompanyManageInternsApplicaton_Load(object sender, EventArgs e)
        {
            CbFilterApplicationList.Text = "Job name";
            LoadAppiedJob();

        }

        //Method: Thực hiện search theo filter và giá trị được nhập
        private void BtnSearchApplication_Click(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();

            string filterSearch = CbFilterApplicationList.Text;
            try
            {
                switch (filterSearch)
                {
                    case "Status":
                        if ("accept".Contains(TxtSearchApplication.Text))
                        {
                            source.DataSource = repositoryTblRegisterJob.SearchAppliedJobByStatusAsCompany(1).ToList();
                        }
                        else if ("denied".Contains(TxtSearchApplication.Text))
                        {
                            source.DataSource = repositoryTblRegisterJob.SearchAppliedJobByStatusAsCompany(2).ToList();
                        }
                        else if ("not yet".Contains(TxtSearchApplication.Text))
                        {
                            source.DataSource = repositoryTblRegisterJob.SearchAppliedJobByStatusAsCompany(0).ToList();
                        }
                        break;
                    default:
                        source.DataSource =
                            repositoryTblRegisterJob.SearchAppliedJobByJobNameAsCompany(TxtSearchApplication.Text).ToList();
                        break;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Search error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (source.Count > 0)
            {
                txtJobCodeInvisible.DataBindings.Clear();
                txtStudentCodeInvisible.DataBindings.Clear();
                txtJobCodeInvisible.DataBindings.Add("Text", source, "JobCode");
                txtStudentCodeInvisible.DataBindings.Add("Text", source, "StudentCode");
                DgvApplicationList.DataSource = source;
            }
            else
            {
                MessageBox.Show("No record match!", "Search student application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvApplicationList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DgvApplicationList.Columns[e.ColumnIndex].Name == "StudentConfirm")
            {
                if (e.Value != null && e.Value.ToString().Equals("True"))

                {
                    e.Value = new string("Accept");
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    e.Value = new string("Cancel");
                    e.CellStyle.ForeColor = Color.Red;
                }
            }

            if (DgvApplicationList.Columns[e.ColumnIndex].Name == "CompanyConfirm")
            {
                if (e.Value != null && e.Value.Equals(1))

                {
                    e.Value = new string("Accepted");
                    e.CellStyle.ForeColor = Color.Green;
                }
                else if (e.Value != null && e.Value.Equals(2))
                {
                    e.Value = new string("Denied");
                    e.CellStyle.ForeColor = Color.Red;
                }
                else
                {
                    e.Value = new string("Not Yet");
                }
            }
        }


        private void CbFilterApplicationList_TextChanged(object sender, EventArgs e)
        {
            TxtSearchApplication.Text = "";
        }
    }
}
