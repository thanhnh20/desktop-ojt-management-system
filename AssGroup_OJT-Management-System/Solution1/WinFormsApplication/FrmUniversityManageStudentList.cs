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
    public partial class FrmUniversityManageStudentList : Form
    {
        public FrmUniversityManageStudentList()
        {
            InitializeComponent();
        }
        //BindingSource source;
        private IRepositoryTblAccount accoutRepo = new RepositoryTblAccount();
        private IRepositoryTblStudent studentRepo = new RepositoryTblStudent();
        private IRepositoryTblSemester semesterRepo = new RepositoryTblSemester();
        private IRepositoryTblMajor majorRepo = new RepositoryTblMajor();
        private IRepositoryTblStudentSemester stuSemesterRepo = new RepositoryTblStudentSemester();
        private IRepositoryTblRegisterJob registerJobRepo = new RepositoryTblRegisterJob();
        public TblSemester selectedSemester { get; set; }
        public TblSemester currentSemester { get; set;}
        private TblStudent studentStore { get; set; }

        //Method: Load dữ liệu sinh viên hiển thị sinh viên kì hiện tại
        private void FrmUniversityManageStudentList_Load(object sender, EventArgs e)
        {
            CbSesmester.DataSource = semesterRepo.GetAllSemesterName();
            selectedSemester = semesterRepo.GetCurrentSemester();
            currentSemester = semesterRepo.GetCurrentSemester();
           
            CbSesmester.Text = selectedSemester.SemesterName.ToString();

            CbFilterStudentList.Text = "Student code";

            IEnumerable<TblStudent> studentList = studentRepo.GetStudentListBySemesterID(selectedSemester.SemesterId);
            LoadStudentList(studentList);

        }

        
        //Method: chức năng add 1 sinh viên mới
        private void BtnAddNewStudent_Click(object sender, EventArgs e)
        {
            FrmUniversityAddNewStudent frmUniversityAddNewStudent = new FrmUniversityAddNewStudent();
            frmUniversityAddNewStudent.ShowDialog();
            searchByFilter();
        }

        //Method: chức năng luôn luôn search student list theo kì được chọn

        private void CbSesmester_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selectedSemester = semesterRepo.GetSemesterByName(CbSesmester.Text);
            searchByFilter();
        }

        //Method: chức năng search student theo filter mà user chọn và nhập
        private void BtnSearchStudentList_Click(object sender, EventArgs e)
        {
            searchByFilter();
        }

        //Method: open frm edit information cho student
        private void DgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmUniversityEditStudentInformation frmUniversityEditStudentInformation = new FrmUniversityEditStudentInformation()
            {
                StudentStore = this.studentStore,
                SelectedSemester = this.selectedSemester,
            };
            frmUniversityEditStudentInformation.ShowDialog();
            searchByFilter();
        }

        private void LoadStudentList(IEnumerable<TblStudent> list)
        {
            //source = new BindingSource();
            //source.DataSource = list;
            DgvStudentList.DataSource = null;
            DgvStudentList.Rows.Clear();
            
            if (list != null) 
            {
                DgvStudentList.ColumnCount = 9;
                DgvStudentList.Columns[0].Name = "Student's ID";
                DgvStudentList.Columns[1].Name = "Student Name";
                DgvStudentList.Columns[2].Name = "Email";
                DgvStudentList.Columns[3].Name = "Semester";
                DgvStudentList.Columns[4].Name = "Intern Status";
                DgvStudentList.Columns[5].Name = "Course Status";
                DgvStudentList.Columns[6].Name = "Major";
                DgvStudentList.Columns[7].Name = "Credit";
                DgvStudentList.Columns[8].Name = "Address";

                foreach (var student in list)
                {
                    // lấy số lượng học kỳ mà sinh viên đã tham gia 
                    var num = stuSemesterRepo.GetStudentInOtherSemester(student.StudentCode);
                    // kiểm tra kỳ gần nhất  pass hay ko trong registerJob
                    bool checkCour = registerJobRepo.checkCourStatusByStudentCode(student.StudentCode);

                    TblAccount tmpAccount = accoutRepo.GetAccountByEmail(student.Username);
                    string tmpIntern = "";

                    if (selectedSemester.SemesterId == currentSemester.SemesterId)
                    {
                        switch (student.IsIntern)
                        {
                            case 0:
                                tmpIntern = "Not Yet";
                                break;
                            case 1:
                                tmpIntern = "Working";
                                break;
                            case 2:
                                tmpIntern = "Finished";
                                break;
                        }
                    }
                    else
                    {
                        tmpIntern = "Finished";
                    }


                    string tmpCourse = "";

                    if (num.Count() == 1)
                    {
                        if (selectedSemester.SemesterId == currentSemester.SemesterId)
                        {// mới thêm 
                            // tmpCourse = "Not Yet";
                            if (student.IsIntern != 2)
                            {
                                tmpCourse = "Not Yet";
                            }
                            else
                            {
                                if (checkCour)
                                {
                                    tmpCourse = "Passed";
                                }
                                else
                                {
                                    tmpCourse = "Not Passed";
                                }
                            }
                        }
                        else
                        {
                            if (checkCour)
                            {
                                tmpCourse = "Passed";
                            }
                            else
                            {
                                tmpCourse = "Not Passed";
                            }
                        }
                    }
                    else
                    {
                        TblStudentSemester result1 = num.FirstOrDefault();
                        if (selectedSemester.SemesterId == result1.SemesterId && checkCour)
                        {
                            tmpCourse = "Passed";
                        }
                        else
                        {
                            if (selectedSemester.SemesterId == currentSemester.SemesterId)
                            {
                                tmpCourse = "Not Yet";
                            }
                            else
                            {
                                tmpCourse = "Not Passed";
                            }
                        }
                    }


                    string[] tmpStudent = new string[]
                    {
                    student.StudentCode.ToString(),
                    student.StudentName.ToString(),
                    student.Username.ToString(),
                    selectedSemester.SemesterName.ToString(),
                    tmpIntern,
                    tmpCourse,
                    student.Majorname.ToString(),
                    student.Credit.ToString(),
                    student.Address.ToString()
                    };
                    DgvStudentList.Rows.Add(tmpStudent);
                }
            }
        
            DgvStudentList.AllowUserToAddRows = false;  
        }

        private void searchByFilter()
        {
            try
            {
                IEnumerable<TblStudent> listStudentFilter = null;
                if (string.IsNullOrEmpty(TxtSearchStudentFollowingFilter.Text.Trim()))
                {
                    listStudentFilter = studentRepo.GetStudentListBySemesterID(selectedSemester.SemesterId);
                }
                else
                {
                    switch (CbFilterStudentList.Text)
                    {
                        case "Student code":
                            listStudentFilter = studentRepo.GetStudentListByStudentCode(selectedSemester.SemesterId, TxtSearchStudentFollowingFilter.Text.Trim());
                            break;

                        case "Student name":
                            listStudentFilter = studentRepo.GetStudentListByStudentName(selectedSemester.SemesterId, TxtSearchStudentFollowingFilter.Text.Trim());
                            break;

                        case "Address":
                            listStudentFilter = studentRepo.GetStudentListByAddress(selectedSemester.SemesterId, TxtSearchStudentFollowingFilter.Text.Trim());
                            break;

                        case "Major name":
                            listStudentFilter = studentRepo.GetStudentListByMajorName(selectedSemester.SemesterId, TxtSearchStudentFollowingFilter.Text.Trim());
                            break;

                        case "Credit":
                            if (string.IsNullOrEmpty(TxtSearchStudentFollowingFilter.Text.Trim()))
                            {
                                listStudentFilter = studentRepo.GetStudentListBySemesterID(selectedSemester.SemesterId);
                            }
                            else
                            {
                                if (int.TryParse(TxtSearchStudentFollowingFilter.Text, out int credit))
                                {
                                    if (credit <= 68 || credit > 200)
                                    {
                                        throw new Exception("Credit must be of range (68-200)");
                                    }
                                    else
                                    {
                                        listStudentFilter = studentRepo.GetStudentListByCredits(selectedSemester.SemesterId, credit);
                                    }
                                }
                                else
                                {
                                    throw new Exception("Credit is Number");
                                }
                            }
                            break;
                    }
                    if (listStudentFilter == null || listStudentFilter.Count() == 0)
                    {
                        semesterRepo = new RepositoryTblSemester();
                        TblSemester currentSemester = semesterRepo.GetCurrentSemester();
                        listStudentFilter = studentRepo.GetStudentListBySemesterID(currentSemester.SemesterId);
                        MessageBox.Show("No records match!", "Search student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                LoadStudentList(listStudentFilter);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            }
        }

        private void DgvStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int tmpIntern = 0;
                string tmp = DgvStudentList.Rows[e.RowIndex].Cells[4].Value.ToString();
                switch (tmp)
                {
                    case "Not Yet":
                        tmpIntern = 0;
                        break;
                    case "Working":
                        tmpIntern = 1;
                        break;
                    case "Finished":
                        tmpIntern = 2;
                        break;
                }
                studentStore = new TblStudent()
                {
                    StudentCode = DgvStudentList.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    IsIntern = tmpIntern
                };
            }
        }

    }
}
