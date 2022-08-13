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
    public partial class FrmCompanyEvaluateInterns : Form
    {
        public FrmCompanyEvaluateInterns()
        {
            InitializeComponent();
        }

        private bool isClose { get; set; } = true;

        public TblRegisterJob InternInfor { get; set; }
        public TblCompany CompanyInfor { get; set; }

        private IRepositoryTblRegisterJob regisJotRepo = new RepositoryTblRegisterJob();
        private IRepositoryTblStudent studentRepo = new RepositoryTblStudent();
        private IRepositoryTblJob jobRepo = new RepositoryTblJob();

        //Method: thực hiện cập nhật điểm và cập nhật evaluation
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rs = MessageBox.Show("Are you sure that you want to update?", "Evaluation a intern information " 
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    checkInput();
                    InternInfor.Comment = TxtComment.Text.Trim();
                    int tmpGrade = int.Parse(CbGrade.Text);
                    InternInfor.Grade = tmpGrade;

                    var tmpStudent = studentRepo.GetStudentByStudentID(InternInfor.StudentCode);
                    tmpStudent.IsIntern = 2;
                    if (tmpGrade < 5)
                    {
                        InternInfor.IsPass = false;
                    }
                    else
                    {
                        InternInfor.IsPass = true;
                    }
                    studentRepo.UpdateStudent(tmpStudent);
                    regisJotRepo.UpdateInternEvaluation(InternInfor);
                    MessageBox.Show("Updated successfully", "Evaluation a intern information "
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isClose = false;
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Method: thực hiện close frm hiện tại
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkInput()
        {
            bool check = false;
            string error = "";

            if (string.IsNullOrEmpty(CbGrade.Text))
            {
                check = true;
                error = "\n Grade is Empty.";
            } 

            if (string.IsNullOrEmpty(TxtComment.Text.Trim()))
            {
                check = true;
                error = "\n Comment is Empty.";
            }
            else
            {
                if (TxtComment.Text.Trim().Length < 5 || TxtComment.Text.Trim().Length >= 200)
                {
                    check = true;
                    error = "\n Comment must be of length 5-200 words.";
                }
            }

            if (check)
            {
                throw new Exception(error);
            }
        }

        private void FrmCompanyEvaluateInterns_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isClose)
            {
                DialogResult rs = MessageBox.Show("Are you sure that you want to eixt?", "Evaluation a intern information " +
                    "- Exit confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void FrmCompanyEvaluateInterns_Load(object sender, EventArgs e)
        {
            TxtStudentID.Enabled = false;
            TxtStudentName.Enabled = false;
            TxtJobName.Enabled = false;

            LoadInfor();
        }

        private void LoadInfor()
        {
            var tmpStudent = studentRepo.GetStudentByStudentID(InternInfor.StudentCode);
            var tmpJob = jobRepo.GetJobByID(InternInfor.JobCode);
            TxtStudentID.Text = InternInfor.StudentCode.ToString();
            TxtStudentName.Text = tmpStudent.StudentName.ToString();
            TxtJobName.Text = tmpJob.JobName.ToString();
            CbGrade.Text = InternInfor.Grade == null ? "0" : InternInfor.Grade.ToString();
            TxtComment.Text = InternInfor.Comment == null ? "" : InternInfor.Comment.ToString();
        }
    }
}
