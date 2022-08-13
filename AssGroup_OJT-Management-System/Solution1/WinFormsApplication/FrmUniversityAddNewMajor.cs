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
    public partial class FrmUniversityAddNewMajor : Form
    {
        public IRepositoryTblMajor repositoryTblMajor { get; set; }
        public FrmUniversityDashboard parentForm { get; set; }
        public FrmUniversityAddNewMajor()
        {
            InitializeComponent();
        }

        //Method: Add a new major
        private void BtnAddNewMajor_Click(object sender, EventArgs e)
        {
            //check chuỗi không chứa các kí tự đặc biệt
            //check major name không được trùng trong list major
            string majorName = txtMajorName.Text;
            string pattern = "[^\\p{L}\\s]";
            //Để chỉ định sử dụng Unicode chúng ta dùng kí hiệu \p nhưng trong chuỗi " " ta phải dùng \\p
            // \s là lấy dấu khoảng trắng
            // L có nghĩa là đại diện cho các kí tự Unicode Alphabet.
            Regex regex = new Regex(pattern);
            bool found = false;
            string errors = "";
            if (majorName.Trim().Length == 0)
            {
                found = true;
                errors = "Major name is required.\n";
            }
            if (regex.IsMatch(majorName))
            {
                found = true;
                errors = "Major name does not contain any special characters.\n";
            } else
            {
                //check tên này đã có trong database chưa
                repositoryTblMajor = new RepositoryTblMajor();
                bool status = repositoryTblMajor.CheckExitedMajor(majorName);
                if (status)
                {
                    found = true;
                    errors = "Major name is assigned to another major.\n";
                }
            }
            if (found)
            {
                MessageBox.Show(errors, "University Home - Add a new Major", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                TblMajor newMajor = new TblMajor()
                {
                    MajorName = majorName,
                };
                repositoryTblMajor.AddNewMajor(newMajor);
                this.Close();
                parentForm.LoadFrmUniversityDashboard();
            }
        }

        //Method: close this frm
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult isExit = MessageBox.Show("Are your sure that you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (isExit == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
