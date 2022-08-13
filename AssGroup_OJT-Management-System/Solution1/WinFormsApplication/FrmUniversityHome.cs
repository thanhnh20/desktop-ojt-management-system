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
    public partial class FrmUniversityHome : Form
    {
        public IRepositoryTblSemester semesterRepository { get; set; }
        public IRepositoryTblStudentSemester repositoryTblStudentSemester { get; set; }
        public IRepositoryTblCompany repositoryTblCompany { get; set; }
        public IRepositoryTblJob repositoryTblJob { get; set; }
        public IRepositoryTblMajor repositoryTblMajor { get; set; }
        public IRepositoryTblSemester repositoryTblSemester { get; set; }
        public FrmUniversityDashboard parentForm { get; set; }
        
        public FrmUniversityHome()
        {
            InitializeComponent();
        }

        //Method: load dữ liệu để hiển thị trang home
        private void FrmUniversityHome_Load(object sender, EventArgs e)
        {
            // load dữ liệu về kì hiện tại dựa trên ngày bắt đầu và ngày kết thúc
            // Spring bắt đầu 31/12 - 30/4 mỗi năm
            // Summer bắt đầu 30/4 - 31/8 mỗi năm
            // Fall bắt đầu 31/8 - 31/12 mỗi năm
            LoadFrmUnversityHome();
        }

        private void LoadFrmUnversityHome()
        {
            try
            {
                DateTime today = DateTime.Today;
                semesterRepository = new RepositoryTblSemester();
                TblSemester currentSemester = semesterRepository.GetCurrentSemester();
                int compareDate = DateTime.Compare(currentSemester.EndDate.Value, today);
                if (compareDate == 0 || compareDate < 0)// nếu ngày hôm này bằng với ngày kết thúc của kì hiện tại thì được phép mở add a new semester 
                {
                    BtnAddNewSemester.Enabled = true;
                }
                else
                {
                    BtnAddNewSemester.Enabled = false;
                }
                // load dữ liệu về đếm số sinh viên của kì hiện tại
                repositoryTblStudentSemester = new RepositoryTblStudentSemester();
                int numberOfStudent = repositoryTblStudentSemester.GetNumberOfStudentOfCurrentSemester(currentSemester);
                TxtNumberOfStudents.Text = numberOfStudent.ToString();
                // load dữ liệu về đếm số company
                repositoryTblCompany = new RepositoryTblCompany();
                int numberOfCompany = repositoryTblCompany.GetNumberOfCompany();
                TxtNumberOfSignedCompanies.Text = numberOfCompany.ToString();
                // load dữ liệu về đếm số các bài post còn hạn và còn số lượng
                repositoryTblJob = new RepositoryTblJob();
                int numbreOfAvailableJob = repositoryTblJob.GetNumberOfAvailableJob();
                TxtNumberOfPosts.Text = numbreOfAvailableJob.ToString();
                // load dữ liệu về đếm số lượng major mà trường đang có 
                repositoryTblMajor = new RepositoryTblMajor();
                int numberOfMajors = repositoryTblMajor.GetNumberOfListMajor();
                TxtNumberOfMajor.Text = numberOfMajors.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "University Home", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method: add a new semester
        private void BtnAddNewSemester_Click(object sender, EventArgs e)
        {
            // thực hiện load học kì trước đó và thực hiện tạo kì mới dựa vào label (Spring, summer, fall)
            // và năm của kì vừa rồi để thực hiện tính toán 
            // Spring bắt đầu 31/12 - 30/4 mỗi năm
            // Summer bắt đầu 30/4 - 31/8 mỗi năm
            // Fall bắt đầu 31/8 - 31/12 mỗi năm
            try
            {
                repositoryTblSemester = new RepositoryTblSemester();
                TblSemester semester = repositoryTblSemester.GetCurrentSemester();
                string semesterEndDate = semester.EndDate.Value.ToString("dd/MM/yyyy");
                string semesterLabel = semester.SemesterName.Split(" ")[0];
                DateTime today = DateTime.Today;
                string currentYear = today.Year.ToString();
                string newSemesterName =  "";
                string strStartDate = "";
                string strEndDate = "";
                if ("Spring".Equals(semesterLabel))
                {
                    newSemesterName = $"Summer {currentYear}";
                    strStartDate = semester.EndDate.Value.ToString();
                    strEndDate = $"{currentYear}-08-31";
                }
                if ("Summer".Equals(semesterLabel))
                {
                    newSemesterName = $"Fall {currentYear}";
                    strStartDate = semester.EndDate.Value.ToString();
                    strEndDate = $"{currentYear}-12-31";
                }
                if ("Fall".Equals(semesterLabel))
                {
                    int newYear = int.Parse(currentYear) + 1;
                    newSemesterName = $"Spring {newYear}";
                    strStartDate = semester.EndDate.Value.ToString();
                    strEndDate = $"{newYear}-04-30";
                }

                DialogResult result = MessageBox.Show($"{semester.SemesterName} finished in {semesterEndDate}. Click 'Ok' to add a new semester.", "University Home - Add a new Semester", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    DateTime startDate = DateTime.Parse(strStartDate);
                    DateTime endDate = DateTime.Parse(strEndDate);
                    //add new semester
                    TblSemester newSemester = new TblSemester()
                    {
                        SemesterName = newSemesterName,
                        StartDate = startDate,
                        EndDate = endDate
                    };
                    repositoryTblSemester.AddNewSemester(newSemester);
                    LoadFrmUnversityHome();
                    parentForm.LoadFrmUniversityDashboard();
                } else
                {
                    LoadFrmUnversityHome();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "University Home - Add a new semester", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        //Method: add a new major
        private void BtnAddNewMajor_Click(object sender, EventArgs e)
        {
            FrmUniversityAddNewMajor frmUniversityAddNewMajor = new FrmUniversityAddNewMajor()
            {
                parentForm = this.parentForm,
            };
            DialogResult result = frmUniversityAddNewMajor.ShowDialog();
            
        }
    }
}
