using FontAwesome.Sharp;
using Library.Models;
using Library.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;
using Library.Repository;

namespace WinFormsApplication
{
    public partial class FrmStudentDashBoard : Form
    {
        public IRepositoryTblStudent repositoryTblStudent = new RepositoryTblStudent();

        public IRepositoryTblRegisterJob repositoryTblRegisterJob = new RepositoryTblRegisterJob();
        public TblAccount studentAccount { get; set; }
        //Fields Cấu hình giao diện
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private int redColor = 255;
        private int greenColor = 153;
        private int blueColor = 51;
        //--------------------------
        public FrmStudentDashBoard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            PnDashBoard.Controls.Add(leftBorderBtn);
        }

        //Method: khi 1 button được click thể hiện sự active của button
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                //cần trả nguyên lại ban đầu cho các nút đã được nhấn trước
                DisableButton();

                //1. chỉnh button được hover
                // lấy cái button được nhấn
                currentBtn = (IconButton)senderBtn;
                // đổi màu background cho button đó
                currentBtn.BackColor = Color.FromArgb(79, 79, 79);
                // đổi đổi màu chữ
                currentBtn.ForeColor = color;
                // chỉnh giữa cho chữ
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                // chỉnh màu cho icon 
                currentBtn.IconColor = color;
                // chỉnh thứ tự chữ và icon
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                // canh chỉnh icon đằng sau của chữ
                currentBtn.ImageAlign = ContentAlignment.BottomRight;


                //2. chỉnh cái left boarder button đã định nghĩa ở trên
                // chỉnh màu backgorund
                leftBorderBtn.BackColor = color;
                // chỉnh vì trí đúng với button được active
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                // cho button đã được định nghĩa trước đè lên cái cũ
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                PicIconControlHeader.IconChar = currentBtn.IconChar;
                LbControlHeader.Text = currentBtn.Text;
            }
        }

        //Method: khi 1 button khác được nhấn thì button được nhấn trước đó phải trở về bình thường
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //1. chỉnh button được hover quay về bình thường
                // đổi màu background cho button đó khi hết được active
                currentBtn.BackColor = Color.FromArgb(243, 113, 36);
                // đổi đổi màu chữ về bình thường
                currentBtn.ForeColor = Color.White;
                // chỉnh giữa cho chữ về bình thường
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                // chỉnh màu cho icon về bình thường
                currentBtn.IconColor = Color.White;
                // chỉnh thứ tự chữ và icon về như cũ
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                // canh chỉnh icon trước chữ
                currentBtn.ImageAlign = ContentAlignment.BottomLeft;
            }
        }

        //Method: Khi 1 button được nhấn thì mở child form tướng ứng với chức năng chọn
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // cái form trước sẽ bị tắt đi 
                currentChildForm.Close();

            }
            //cấu hình cho child form mới
            currentChildForm = childForm;
            childForm.Dock = DockStyle.Fill;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            PnChildForm.Controls.Add(childForm);
            PnChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LbControlHeader.Text = childForm.Text;
        }

        //Method: Khi student profile được click
        private void BtnStudentProfile_Click(object sender, EventArgs e)
        {
            // cấu hình nút khi được click
            ActiveButton(sender, Color.FromArgb(redColor, greenColor, blueColor));
            OpenChildForm(new FrmStudentProfile()
            {
                StudentAccount = studentAccount,
            });
        }

        //Method: Khi jobs company list được clik
        private void BtnJobsList_Click(object sender, EventArgs e)
        {
            // cấu hình nút khi được click
            ActiveButton(sender, Color.FromArgb(redColor, greenColor, blueColor));
            OpenChildForm(new FrmStudentJobCompanyList()
            {
                studentAccount = studentAccount,
            });
        }

        //Method: Khi student application được click
        private void BtnStudentApplication_Click(object sender, EventArgs e)
        {
            // cấu hình nút khi được click
            ActiveButton(sender, Color.FromArgb(redColor, greenColor, blueColor));
            OpenChildForm(new FrmStudentApplication() { 
                studentAccount = studentAccount,
            });
        }

        //Medthod: Khi internship result được click
        private void BtnInternshipResult_Click(object sender, EventArgs e)
        {
            // cấu hình nút khi được click
            ActiveButton(sender, Color.FromArgb(redColor, greenColor, blueColor));
            //nếu sinh viên đã có kết quả thực tập thì mới cho sử dụng chức năng này
            var student = repositoryTblStudent.GetStudentProfileByUserName(studentAccount.Username);
            var resultIntern = repositoryTblRegisterJob.GetStudentInternResult(student.StudentCode);
            if ( resultIntern != null && resultIntern.StudentCodeNavigation.IsIntern != 0)// điều kiện đã có kết quả thực tập
            {
                OpenChildForm(new FrmStudentInternShipResult()
                {
                    Student = student,
                    RegisterJob = resultIntern
                });
            }
            else
            {
                DialogResult result = MessageBox.Show("You do not have any internship result now!", "Student Management - Internship Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    //chỉnh về giao diện home
                    OpenChildForm(new FrmStudentHome() { 
                        studentAccount = studentAccount,
                    });
                    Reset();
                }
            }

        }

        //Method: chức năng logout
        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            //Code chức năng logout ở đây
            Thread newThread = new Thread(new ThreadStart(OpenFrmLogin));
            newThread.Start();
            this.Close();
        }


        //Medthod: Open frmLogin khi Logout
        private void OpenFrmLogin()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
        }

        //Method: khi nhấn vào logo thì cho quay trở lại trang home bằng cách close child form
        // và reset lại giao diện cha
        private void PicLogo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            OpenChildForm(new FrmStudentHome()
            {
                studentAccount = studentAccount,
            });
            Reset();
        }

        //Method: reset lại giao diện cha
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            PicIconControlHeader.IconChar = IconChar.Home;
            LbControlHeader.Text = "Home";
        }

        //Method: Load nội dung giao diện trang home
        private void FrmStudentDashBoard_Load(object sender, EventArgs e)
        {
            //Code nội dung giao diện trang home ở đây
            OpenChildForm(new FrmStudentHome()
            {
                studentAccount = studentAccount,
            });
            LoadFrmStudentDashboard();
        }

        public void LoadFrmStudentDashboard()
        {
            //Lấy tên người dùng đang đăng nhập
            var student = repositoryTblStudent.GetStudentProfileByUserName(studentAccount.Username);
            LbWelcomeHeader.Text = student.StudentName;
        }
    }
}
