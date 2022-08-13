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
    public partial class FrmUniversityEditStudentInformation : Form
    {
        private IRepositoryTblSemester semesterRepo = new RepositoryTblSemester();
        private IRepositoryTblStudent studentRepo = new RepositoryTblStudent();
        private IRepositoryTblAccount accountRepo = new RepositoryTblAccount();
        private IRepositoryTblRegisterJob registerJobRepo = new RepositoryTblRegisterJob();
        private IRepositoryTblStudentSemester studentSemesterRepo = new RepositoryTblStudentSemester();

        private bool isAuto { get; set; } = true;
        private bool isClose { get; set; } = true;
        public TblStudent StudentStore { get; set; }

        public TblSemester SelectedSemester { get; set; }
        public TblSemester currentSemester { get; set; }

        private bool isPass { get; set; } = true; // kiểm trang student cần update đã pass hay chưa 

        public FrmUniversityEditStudentInformation()
        {
            InitializeComponent();
        }

        //Method: Load dữ liệu lên cho frm edit Student information
        private void FrmUniversityEditStudentInformation_Load(object sender, EventArgs e)
        {
            TxtEmail.Enabled = false;
            TxtStudentID.Enabled = false;
            TxtStudentName.Enabled = false;
            LoadStudentInfor();
            currentSemester = semesterRepo.GetCurrentSemester();
            IList<string> listSemster = new List<string>();
            listSemster.Add(SelectedSemester.SemesterName);

            if (currentSemester.SemesterId == SelectedSemester.SemesterId)
            {
                CbSemester.Enabled = false;
            }
            else
            {
                isPass = registerJobRepo.checkStudentIsPass(StudentStore.StudentCode);
                if (!isPass)
                {
                    listSemster.Add(currentSemester.SemesterName);
                    CbSemester.DataSource = listSemster;
                } else
                {
                    CbSemester.Enabled = false;
                }
            }
            CbSemester.DataSource = listSemster;
        }


        //Method: Thực hiện update thông tin cho student
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = MessageBox.Show("Are you sure that you want to update?", "Update a student",
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (rs == DialogResult.OK) 
                {
                    checkInput();
                    if (TxtPassword.Text != StudentStore.UsernameNavigation.Password)
                    {
                        TblAccount tmpAccount = new TblAccount()
                        {
                            Username = StudentStore.Username,
                            Password = TxtPassword.Text
                        };
                        accountRepo.UpdateAccount(tmpAccount);
                    }

                    if (!isPass)
                    {
                        if (CbSemester.Text != currentSemester.SemesterName)
                        {
                            // update bth
                            if (TxtCredit.Text != StudentStore.Credit.ToString())
                            {
                                TblStudent tmpStudent = studentRepo.GetStudentByStudentID(StudentStore.StudentCode);
                                tmpStudent.Credit = int.Parse(TxtCredit.Text);
                                studentRepo.UpdateStudent(tmpStudent);
                            }
                        }
                        else
                        {
                            // insert 
                            // update kì mới 
                            TblStudentSemester tmpStuSem = new TblStudentSemester()
                            {
                                StudentCode = StudentStore.StudentCode,
                                SemesterId = currentSemester.SemesterId
                            };
                            if (!studentSemesterRepo.CheckStudentAndSemesterIsExist(tmpStuSem))
                            {
                                 bool isPass = registerJobRepo.checkStudentIsPass(StudentStore.StudentCode);
                                if (isPass)
                                {
                                    throw new Exception("Student is paseed in another semester.");
                                }
                                else
                                {
                                    studentSemesterRepo.InsertStuSemester(tmpStuSem);

                                    if (TxtCredit.Text != StudentStore.Credit.ToString())
                                    {
                                        TblStudent tmpStudent = studentRepo.GetStudentByStudentID(StudentStore.StudentCode);
                                        tmpStudent.Credit = int.Parse(TxtCredit.Text);
                                        tmpStudent.IsIntern = 0;
                                        studentRepo.UpdateStudent(tmpStudent);
                                    }
                                }
                            }
                            else
                            {
                                throw new Exception("Student already existed in " + currentSemester.SemesterName + "\n You need to update in current semester");
                            }
                        }
                    }
                    else
                    {
                        // pass | not yet ở kì hiện tại 
                        if (TxtCredit.Text != StudentStore.Credit.ToString())
                        {
                            TblStudent tmpStudent = studentRepo.GetStudentByStudentID(StudentStore.StudentCode);
                            tmpStudent.Credit = int.Parse(TxtCredit.Text);
                            studentRepo.UpdateStudent(tmpStudent);
                        }
                    }
                    isClose = false;
                    MessageBox.Show("Updated successfully", "Update a student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    isAuto = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Method: close frm hiện tại
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadStudentInfor()
        {
            StudentStore = studentRepo.GetStudentByStudentID(StudentStore.StudentCode);
            TxtStudentID.Text = StudentStore.StudentCode.ToString();
            TxtStudentName.Text = StudentStore.StudentName.ToString();
            TxtEmail.Text = StudentStore.Username.ToString();
            CbSemester.Text = SelectedSemester.SemesterName.ToString();
            TxtCredit.Text = StudentStore.Credit.ToString();
            TblAccount tmpAccount = accountRepo.GetAccountByEmail(StudentStore.Username);
            StudentStore.UsernameNavigation = tmpAccount;
            TxtPassword.Text = tmpAccount.Password;
        }

        private void checkInput()
        {
            bool check = false;
            string error = "";
            
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                check = true;
                error += "\n - Password is Empty";
            }
            else
            {
                if (TxtPassword.Text.Length > 20)
                {
                    check = true;
                    error += "\n - Password must be of lenght less than 20.";
                }
            }

            if (string.IsNullOrEmpty(TxtCredit.Text.Trim()))
            {
                check = true;
                error += "\n - Credit is Empty.";
            }
            else
            {
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
            }

            if (check)
            {
                throw new Exception(error);
            }
        }

        private void FrmUniversityEditStudentInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (isAuto) { e.Cancel = true; }
            if (isClose)
            {
                DialogResult rs = MessageBox.Show("Are you sure that you want to eixt?", "Edit a student information " +
                    "- Exit confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
