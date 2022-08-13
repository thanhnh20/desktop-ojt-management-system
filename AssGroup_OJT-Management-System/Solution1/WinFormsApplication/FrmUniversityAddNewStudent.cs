using Library.Models;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApplication
{
    public partial class FrmUniversityAddNewStudent : Form
    {
        public FrmUniversityAddNewStudent()
        {
            InitializeComponent();
        }

        private IRepositoryTblAccount accoutRepo = new RepositoryTblAccount();
        private IRepositoryTblStudent studentRepo = new RepositoryTblStudent();
        private IRepositoryTblSemester semesterRepo = new RepositoryTblSemester();
        private IRepositoryTblMajor majorRepo = new RepositoryTblMajor();
        private IRepositoryTblStudentSemester stuSemRepo = new RepositoryTblStudentSemester();

        private bool isClose { get; set; } = true; 
        public TblSemester semesterStore { get; set; } 

        //Method: khi nhấn vào button add new a student
        private void BtnInsertANewStudent_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = MessageBox.Show("Are you sure that you want to save?", "Insert a new student",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    checkInput();
                    checkInputValidation();
                    TblAccount tmpAccount = new TblAccount()
                    {
                        Username = TxtEmail.Text,
                        Password = TxtPassword.Text,
                        IsAdmin = 1
                    };
                    accoutRepo.InsertAccount(tmpAccount);

                    bool tmpGender = (CbGender.Text.Equals("Male")) ? true : false;
                    TblStudent tmpStudent = new TblStudent()
                    {
                        StudentCode = TxtStudentID.Text,
                        StudentName = TxtFullName.Text.Trim(),
                        BirthOfDate = DateTime.Parse(MtxtDateOfBirth.Text),
                        Credit = int.Parse(TxtCredit.Text),
                        Username = TxtEmail.Text.Trim(),
                        Address = TxtAddress.Text.Trim(),
                        Gender = tmpGender,
                        Majorname = CbMajor.Text,
                        IsIntern = 0
                    };

                    studentRepo.InsertStudent(tmpStudent);

                    TblStudentSemester tmpStuSem = new TblStudentSemester()
                    {
                        StudentCode = TxtStudentID.Text,
                        SemesterId = semesterStore.SemesterId
                    };

                    stuSemRepo.InsertStuSemester(tmpStuSem);
                    isClose = false;
                    MessageBox.Show("Inserted successfully", "Insert a student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        //Method: Load dữ liệu về major, về semester lên để show dữ liệu
        private void FrmUniversityAddNewStudent_Load(object sender, EventArgs e)
        {
            try
            {
                semesterStore = semesterRepo.GetCurrentSemester();
                CbSemester.Enabled = false;
                CbGender.Text = "Male";
                IList<string> tmpSemester = new List<string>();
                tmpSemester.Add(semesterStore.SemesterName);

                CbSemester.DataSource = tmpSemester;
                CbMajor.DataSource = majorRepo.GetAllMajorName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        //Method: đóng frm hiện tại
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        // Kiểm tra input có rỗng ko 
        private void checkInput()
        {
            bool check = false;
            string error = "";

            if (string.IsNullOrEmpty(TxtFullName.Text.Trim()))
            {
                check = true;
                error += "\n - Student Name is Empty.";
            }

            if (string.IsNullOrEmpty(TxtStudentID.Text.Trim()))
            {
                check = true;
                error += "\n - Student ID is Empty.";
            }
           
            if (string.IsNullOrEmpty(TxtEmail.Text.Trim()))
            {
                check = true;
                error += "\n - Email is Empty.";
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                check = true;
                error += "\n - Password is Empty";
            }

            if (string.IsNullOrEmpty(CbGender.Text.Trim()))
            {
                check = true;
                error += "\n - Gender is Empty.";
            }

            Regex regex = new Regex(@"\d");
            if (!regex.IsMatch(MtxtDateOfBirth.Text))
            {
                check = true;
                error += "\n - Date Of Birth is Empty.";
            }

            if (string.IsNullOrEmpty(CbMajor.Text.Trim()))
            {
                check = true;
                error += "\n - Major is Empty.";
            }

            if (string.IsNullOrEmpty(TxtCredit.Text.Trim()))
            {
                check = true;
                error += "\n - Credit is Empty.";
            }

            if (string.IsNullOrEmpty(TxtAddress.Text.Trim()))
            {
                check = true;
                error += "\n - Address is Empty.";
            }

            if (check)
            {
                throw new Exception (error);
            }
        }

        private void checkInputValidation()
        {
            bool check = false;
            string error = "";

            if (TxtFullName.Text.Trim().Length < 6 || TxtFullName.Text.Trim().Length > 50)
            {
                check = true;
                error += "\n - Full Name must be of length (6-50).";
            }
            else
            {
                Regex regex = new Regex(@"\w");
                Regex regexSpace = new Regex(@"\s");
                Regex regexNumber = new Regex(@"\d");
                MatchCollection mc = regex.Matches(TxtFullName.Text);
                MatchCollection mv = regexSpace.Matches(TxtFullName.Text);
                if (TxtFullName.Text.Length != mc.Count + mv.Count || regexNumber.IsMatch(TxtFullName.Text))
                {
                    check = true;
                    error = "\n - FullName has special characters.";
                }
            }

            if (TxtStudentID.Text.Length != 8)
            {
                error += "\n - Student ID must be of length 8.";
            }
            else
            {
                Regex regex = new Regex(@"\w");
                MatchCollection mc = regex.Matches(TxtStudentID.Text);
                if (TxtStudentID.Text.Length != mc.Count)
                {
                    check = true;
                    error = "\n - Student ID has special characters.";
                }
                else
                {
                    Regex tmpRegex = new Regex(@"^[A-Z]{2}\d{6}");
                   if (!tmpRegex.IsMatch(TxtStudentID.Text))
                    {
                        check = true;
                        error += "\n - Student ID is wrong format (EX: SE151262).";
                    }
                    else
                    {
                        if (studentRepo.ChecStudentIDIsExist(TxtStudentID.Text)){
                            check = true;
                            error += "\n - Student ID already exist.";
                        }
                    }
                }
            }

            if (TxtEmail.Text.Length > 40)
            {
                check = true;
                error += "\n - Email must be of length less than 30.";
            }
            else
            {
                Regex regex = new Regex(@"\s");
                if (regex.IsMatch(TxtEmail.Text.Trim()))
                {
                    check = true;
                    error += "\n - Email has WhiteSpace.";
                }
                else
                {
                    if (!TxtEmail.Text.Trim().EndsWith("@fpt.edu.vn"))
                    {
                        check = true;
                        error += "\n - Email must end with \"@fpt.edu.vn\".";
                    }
                    else
                    {
                        if (accoutRepo.CheckEmailIsExist(TxtEmail.Text.Trim()))
                        {
                            check = true;
                            error += "\n - Email already exist.";
                        }
                    }
                }
            }

            if (TxtPassword.Text.Length > 20)
            {
                check = true;
                error += "\n - Password must be of lenght less than 20.";
            }

            if (DateTime.TryParse(MtxtDateOfBirth.Text,out var dateTime)){
                DateTime present = DateTime.Now;
                if (present.Year - dateTime.Year < 18)
                {
                    check = true;
                    error += $"\n - Date of Birth must be before {present.Year - 18}";
                }
                else
                {
                    if (present.Year - dateTime.Year > 100)
                    {
                        check = true;
                        error += "\n - Date of birth is not suitable.";
                    }
                }
            }
            else
            {
                check = true;
                error += "\n - Date Of Birth is wrong format(MM/dd/yyyy).";
            }

            if (int.TryParse(TxtCredit.Text, out var credit))
            {
                if (credit <= 68 || credit > 200)
                {
                    check = true;
                    error += "\n - Credit must be of range (69-200).";
                }
            }
            else
            {
                check = true;
                error += "\n - Credit is Number/";
            }

            if (TxtAddress.Text.Trim().Length > 100)
            {
                check = true;
                error += "\n - Address must be of length less than 100 character.";
            }

            if (check)
            {
                throw new Exception(error);
            }
        }

        private void FrmUniversityAddNewStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isClose)
            {
                DialogResult dr = MessageBox.Show("Are you sure that you want to exit?",
                           "Insert a new student - Exit confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
