using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Repository;
using Library.Models;
namespace WinFormsApplication
{
    public partial class FrmStudentInternShipResult : Form
    {
        
        public TblStudent Student { get; set; }
        public TblRegisterJob RegisterJob { get; set; }
        public FrmStudentInternShipResult()
        {
            InitializeComponent();
        }

        //Method: Load kết quả thực tập lên
        private void FrmStudentInternShipResult_Load(object sender, EventArgs e)
        {
            TxtFullNameInternshipResult.Text = RegisterJob.StudentCodeNavigation.StudentName.ToString();
            TxtEmailInternshipResult.Text = RegisterJob.StudentCodeNavigation.Username.ToString();
            TxtStudentIDInternshipResult.Text = RegisterJob.StudentCode.ToString();
            TxtMajorInternshipResult.Text = RegisterJob.StudentCodeNavigation.Majorname.ToString();
            TxtJobNameInternshipResult.Text = RegisterJob.JobCodeNavigation.JobName.ToString();
            TxtAddressInternshipResult.Text = RegisterJob.StudentCodeNavigation.Address.ToString();

            if (string.IsNullOrEmpty(RegisterJob.Grade.ToString()))
            {
                TxtGradeInternshipResult.Text = "Not yet";
            }
            else
            {
                TxtGradeInternshipResult.Text = RegisterJob.Grade.ToString();
            }

            if (RegisterJob.Comment == null)
            {
                TxtCommentInternshipResult.Text = "Not yet";
            }
            else
            {
                TxtCommentInternshipResult.Text = RegisterJob.Comment.ToString();
            }
            string status = "Working";
            if(RegisterJob.StudentCodeNavigation.IsIntern == 2)
            {
                status = "Finished";
            }
            TxtPassStatusInternshipResult.Text = status;
        }
    }
}
