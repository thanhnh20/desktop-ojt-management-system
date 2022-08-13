using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;
using Library.Repository;

namespace WinFormsApplication
{
    public partial class FrmStudentProfile : Form
    {
        public IRepositoryTblStudent repositoryTblStudent { get; set; }
        public IRepositoryTblSemester RepositoryTblSemester { get; set; }
        public IRepositoryTblAccount RepositoryTblAccount { get; set; }
        public TblStudent StudentInfo { get; set; }
        public TblAccount StudentAccount { get; set; }
        public TblSemester Semester { get; set; }
        public FrmStudentProfile()
        {
            InitializeComponent();
        }

        public void LoadStudentProfile()
        {
            repositoryTblStudent = new RepositoryTblStudent();
            StudentInfo = repositoryTblStudent.GetStudentProfileByUserName(StudentAccount.Username);
            TxtStudentID.Text = StudentInfo.StudentCode;
            MTxtDateofBirth.Text = StudentInfo.BirthOfDate?.ToString("dd/MM/yyyy");
            TxtFullName.Text = StudentInfo.StudentName;
            TxtStudentID.Text = StudentInfo.StudentCode;
            if (StudentInfo.Gender == false)
            {
                CbGender.Text = "Female";
            }
            else CbGender.Text = "Male";
            CbMajor.Text = StudentInfo.Majorname;
            TxtEmail.Text = StudentInfo.Username;
            TxtAddress.Text = StudentInfo.Address;


            RepositoryTblSemester = new RepositoryTblSemester();
            Semester = RepositoryTblSemester.GetCurrentSemester();
            CbSemester.Text = Semester.SemesterName;
        }

        //Method: load form student profile, và load dữ liệu về major và semester
        private void FrmStudentProfile_Load(object sender, EventArgs e)
        {
            LoadStudentProfile();
        }


        //Method: Khi nhấn nút Edit profile thì sẽ mở form edit profile để edit
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FrmStudentEditProfile frmStudentEditProfile = new FrmStudentEditProfile()
            {
                StudentInfo = StudentInfo,
                AccountInfo = StudentAccount,
                SemesterInfo = Semester,
                parentForm = this
            };
            frmStudentEditProfile.ShowDialog();
        }
    }
}
