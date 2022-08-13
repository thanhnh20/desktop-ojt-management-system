
namespace WinFormsApplication
{
    partial class FrmStudentHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TblPnHeaderHome = new System.Windows.Forms.TableLayoutPanel();
            this.PnJobHeader = new System.Windows.Forms.Panel();
            this.LbNumberOfActiveJobsHeader = new System.Windows.Forms.Label();
            this.LbActiveJobsHeader = new System.Windows.Forms.Label();
            this.PicJobHeader = new FontAwesome.Sharp.IconPictureBox();
            this.PnCompanyHeader = new System.Windows.Forms.Panel();
            this.TxtNumberOfSignedCompaniesHeader = new System.Windows.Forms.Label();
            this.LbCompanyNameHader = new System.Windows.Forms.Label();
            this.PicCompanyHeader = new FontAwesome.Sharp.IconPictureBox();
            this.PnInformationStudent = new System.Windows.Forms.Panel();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.TxtSemester = new System.Windows.Forms.TextBox();
            this.TxtCredit = new System.Windows.Forms.TextBox();
            this.TxtStudentID = new System.Windows.Forms.TextBox();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.LbMajor = new System.Windows.Forms.Label();
            this.LbNumberOfCredit = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbSemester = new System.Windows.Forms.Label();
            this.LbStudentID = new System.Windows.Forms.Label();
            this.LbStudentNAme = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbStudentInformation = new System.Windows.Forms.Label();
            this.TblPnHeaderHome.SuspendLayout();
            this.PnJobHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicJobHeader)).BeginInit();
            this.PnCompanyHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCompanyHeader)).BeginInit();
            this.PnInformationStudent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblPnHeaderHome
            // 
            this.TblPnHeaderHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TblPnHeaderHome.ColumnCount = 2;
            this.TblPnHeaderHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnHeaderHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnHeaderHome.Controls.Add(this.PnJobHeader, 1, 0);
            this.TblPnHeaderHome.Controls.Add(this.PnCompanyHeader, 0, 0);
            this.TblPnHeaderHome.Location = new System.Drawing.Point(234, 81);
            this.TblPnHeaderHome.Name = "TblPnHeaderHome";
            this.TblPnHeaderHome.RowCount = 1;
            this.TblPnHeaderHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblPnHeaderHome.Size = new System.Drawing.Size(621, 109);
            this.TblPnHeaderHome.TabIndex = 0;
            // 
            // PnJobHeader
            // 
            this.PnJobHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.PnJobHeader.Controls.Add(this.LbNumberOfActiveJobsHeader);
            this.PnJobHeader.Controls.Add(this.LbActiveJobsHeader);
            this.PnJobHeader.Controls.Add(this.PicJobHeader);
            this.PnJobHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnJobHeader.Location = new System.Drawing.Point(313, 3);
            this.PnJobHeader.Name = "PnJobHeader";
            this.PnJobHeader.Size = new System.Drawing.Size(305, 103);
            this.PnJobHeader.TabIndex = 2;
            // 
            // LbNumberOfActiveJobsHeader
            // 
            this.LbNumberOfActiveJobsHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbNumberOfActiveJobsHeader.AutoSize = true;
            this.LbNumberOfActiveJobsHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbNumberOfActiveJobsHeader.ForeColor = System.Drawing.Color.White;
            this.LbNumberOfActiveJobsHeader.Location = new System.Drawing.Point(172, 48);
            this.LbNumberOfActiveJobsHeader.Name = "LbNumberOfActiveJobsHeader";
            this.LbNumberOfActiveJobsHeader.Size = new System.Drawing.Size(20, 24);
            this.LbNumberOfActiveJobsHeader.TabIndex = 4;
            this.LbNumberOfActiveJobsHeader.Text = "0";
            // 
            // LbActiveJobsHeader
            // 
            this.LbActiveJobsHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbActiveJobsHeader.AutoSize = true;
            this.LbActiveJobsHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbActiveJobsHeader.ForeColor = System.Drawing.Color.White;
            this.LbActiveJobsHeader.Location = new System.Drawing.Point(133, 11);
            this.LbActiveJobsHeader.Name = "LbActiveJobsHeader";
            this.LbActiveJobsHeader.Size = new System.Drawing.Size(101, 24);
            this.LbActiveJobsHeader.TabIndex = 3;
            this.LbActiveJobsHeader.Text = "Active Jobs";
            // 
            // PicJobHeader
            // 
            this.PicJobHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.PicJobHeader.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.PicJobHeader.IconColor = System.Drawing.Color.White;
            this.PicJobHeader.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PicJobHeader.IconSize = 40;
            this.PicJobHeader.Location = new System.Drawing.Point(32, 32);
            this.PicJobHeader.Name = "PicJobHeader";
            this.PicJobHeader.Size = new System.Drawing.Size(40, 40);
            this.PicJobHeader.TabIndex = 0;
            this.PicJobHeader.TabStop = false;
            // 
            // PnCompanyHeader
            // 
            this.PnCompanyHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.PnCompanyHeader.Controls.Add(this.TxtNumberOfSignedCompaniesHeader);
            this.PnCompanyHeader.Controls.Add(this.LbCompanyNameHader);
            this.PnCompanyHeader.Controls.Add(this.PicCompanyHeader);
            this.PnCompanyHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnCompanyHeader.Location = new System.Drawing.Point(3, 3);
            this.PnCompanyHeader.Name = "PnCompanyHeader";
            this.PnCompanyHeader.Size = new System.Drawing.Size(304, 103);
            this.PnCompanyHeader.TabIndex = 1;
            // 
            // TxtNumberOfSignedCompaniesHeader
            // 
            this.TxtNumberOfSignedCompaniesHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNumberOfSignedCompaniesHeader.AutoSize = true;
            this.TxtNumberOfSignedCompaniesHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumberOfSignedCompaniesHeader.ForeColor = System.Drawing.Color.White;
            this.TxtNumberOfSignedCompaniesHeader.Location = new System.Drawing.Point(171, 48);
            this.TxtNumberOfSignedCompaniesHeader.Name = "TxtNumberOfSignedCompaniesHeader";
            this.TxtNumberOfSignedCompaniesHeader.Size = new System.Drawing.Size(20, 24);
            this.TxtNumberOfSignedCompaniesHeader.TabIndex = 2;
            this.TxtNumberOfSignedCompaniesHeader.Text = "0";
            // 
            // LbCompanyNameHader
            // 
            this.LbCompanyNameHader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbCompanyNameHader.AutoSize = true;
            this.LbCompanyNameHader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCompanyNameHader.ForeColor = System.Drawing.Color.White;
            this.LbCompanyNameHader.Location = new System.Drawing.Point(109, 11);
            this.LbCompanyNameHader.Name = "LbCompanyNameHader";
            this.LbCompanyNameHader.Size = new System.Drawing.Size(163, 24);
            this.LbCompanyNameHader.TabIndex = 1;
            this.LbCompanyNameHader.Text = "Signed Companies";
            // 
            // PicCompanyHeader
            // 
            this.PicCompanyHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicCompanyHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.PicCompanyHeader.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.PicCompanyHeader.IconColor = System.Drawing.Color.White;
            this.PicCompanyHeader.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PicCompanyHeader.IconSize = 40;
            this.PicCompanyHeader.Location = new System.Drawing.Point(32, 32);
            this.PicCompanyHeader.Name = "PicCompanyHeader";
            this.PicCompanyHeader.Size = new System.Drawing.Size(45, 40);
            this.PicCompanyHeader.TabIndex = 0;
            this.PicCompanyHeader.TabStop = false;
            // 
            // PnInformationStudent
            // 
            this.PnInformationStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnInformationStudent.BackColor = System.Drawing.Color.White;
            this.PnInformationStudent.Controls.Add(this.txtMajor);
            this.PnInformationStudent.Controls.Add(this.textEmail);
            this.PnInformationStudent.Controls.Add(this.TxtSemester);
            this.PnInformationStudent.Controls.Add(this.TxtCredit);
            this.PnInformationStudent.Controls.Add(this.TxtStudentID);
            this.PnInformationStudent.Controls.Add(this.TxtStudentName);
            this.PnInformationStudent.Controls.Add(this.LbMajor);
            this.PnInformationStudent.Controls.Add(this.LbNumberOfCredit);
            this.PnInformationStudent.Controls.Add(this.LbEmail);
            this.PnInformationStudent.Controls.Add(this.LbSemester);
            this.PnInformationStudent.Controls.Add(this.LbStudentID);
            this.PnInformationStudent.Controls.Add(this.LbStudentNAme);
            this.PnInformationStudent.Controls.Add(this.panel1);
            this.PnInformationStudent.Location = new System.Drawing.Point(134, 196);
            this.PnInformationStudent.Name = "PnInformationStudent";
            this.PnInformationStudent.Size = new System.Drawing.Size(865, 247);
            this.PnInformationStudent.TabIndex = 1;
            // 
            // txtMajor
            // 
            this.txtMajor.Enabled = false;
            this.txtMajor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMajor.Location = new System.Drawing.Point(598, 161);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(222, 32);
            this.txtMajor.TabIndex = 14;
            // 
            // textEmail
            // 
            this.textEmail.Enabled = false;
            this.textEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEmail.Location = new System.Drawing.Point(186, 166);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(299, 32);
            this.textEmail.TabIndex = 13;
            // 
            // TxtSemester
            // 
            this.TxtSemester.Enabled = false;
            this.TxtSemester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSemester.Location = new System.Drawing.Point(598, 71);
            this.TxtSemester.Name = "TxtSemester";
            this.TxtSemester.Size = new System.Drawing.Size(222, 32);
            this.TxtSemester.TabIndex = 12;
            // 
            // TxtCredit
            // 
            this.TxtCredit.Enabled = false;
            this.TxtCredit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCredit.Location = new System.Drawing.Point(598, 117);
            this.TxtCredit.Name = "TxtCredit";
            this.TxtCredit.Size = new System.Drawing.Size(108, 32);
            this.TxtCredit.TabIndex = 11;
            // 
            // TxtStudentID
            // 
            this.TxtStudentID.Enabled = false;
            this.TxtStudentID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStudentID.Location = new System.Drawing.Point(186, 117);
            this.TxtStudentID.Name = "TxtStudentID";
            this.TxtStudentID.Size = new System.Drawing.Size(189, 32);
            this.TxtStudentID.TabIndex = 10;
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.Enabled = false;
            this.TxtStudentName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStudentName.Location = new System.Drawing.Point(186, 71);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(299, 32);
            this.TxtStudentName.TabIndex = 9;
            // 
            // LbMajor
            // 
            this.LbMajor.AutoSize = true;
            this.LbMajor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbMajor.Location = new System.Drawing.Point(495, 169);
            this.LbMajor.Name = "LbMajor";
            this.LbMajor.Size = new System.Drawing.Size(70, 24);
            this.LbMajor.TabIndex = 7;
            this.LbMajor.Text = "Major: ";
            // 
            // LbNumberOfCredit
            // 
            this.LbNumberOfCredit.AutoSize = true;
            this.LbNumberOfCredit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbNumberOfCredit.Location = new System.Drawing.Point(495, 125);
            this.LbNumberOfCredit.Name = "LbNumberOfCredit";
            this.LbNumberOfCredit.Size = new System.Drawing.Size(71, 24);
            this.LbNumberOfCredit.TabIndex = 6;
            this.LbNumberOfCredit.Text = "Credit: ";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbEmail.Location = new System.Drawing.Point(42, 174);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(66, 24);
            this.LbEmail.TabIndex = 5;
            this.LbEmail.Text = "Email: ";
            // 
            // LbSemester
            // 
            this.LbSemester.AutoSize = true;
            this.LbSemester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbSemester.Location = new System.Drawing.Point(495, 81);
            this.LbSemester.Name = "LbSemester";
            this.LbSemester.Size = new System.Drawing.Size(97, 24);
            this.LbSemester.TabIndex = 4;
            this.LbSemester.Text = "Semester: ";
            // 
            // LbStudentID
            // 
            this.LbStudentID.AutoSize = true;
            this.LbStudentID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStudentID.Location = new System.Drawing.Point(42, 125);
            this.LbStudentID.Name = "LbStudentID";
            this.LbStudentID.Size = new System.Drawing.Size(108, 24);
            this.LbStudentID.TabIndex = 3;
            this.LbStudentID.Text = "Student ID: ";
            // 
            // LbStudentNAme
            // 
            this.LbStudentNAme.AutoSize = true;
            this.LbStudentNAme.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStudentNAme.Location = new System.Drawing.Point(42, 81);
            this.LbStudentNAme.Name = "LbStudentNAme";
            this.LbStudentNAme.Size = new System.Drawing.Size(138, 24);
            this.LbStudentNAme.TabIndex = 2;
            this.LbStudentNAme.Text = "Student name: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.LbStudentInformation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 65);
            this.panel1.TabIndex = 1;
            // 
            // LbStudentInformation
            // 
            this.LbStudentInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbStudentInformation.AutoSize = true;
            this.LbStudentInformation.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStudentInformation.ForeColor = System.Drawing.Color.White;
            this.LbStudentInformation.Location = new System.Drawing.Point(295, 16);
            this.LbStudentInformation.Name = "LbStudentInformation";
            this.LbStudentInformation.Size = new System.Drawing.Size(266, 37);
            this.LbStudentInformation.TabIndex = 0;
            this.LbStudentInformation.Text = "Student Information";
            // 
            // FrmStudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 604);
            this.Controls.Add(this.PnInformationStudent);
            this.Controls.Add(this.TblPnHeaderHome);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1111, 651);
            this.Name = "FrmStudentHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmStudentHome_Load);
            this.TblPnHeaderHome.ResumeLayout(false);
            this.PnJobHeader.ResumeLayout(false);
            this.PnJobHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicJobHeader)).EndInit();
            this.PnCompanyHeader.ResumeLayout(false);
            this.PnCompanyHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCompanyHeader)).EndInit();
            this.PnInformationStudent.ResumeLayout(false);
            this.PnInformationStudent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblPnHeaderHome;
        private System.Windows.Forms.Panel PnJobHeader;
        private System.Windows.Forms.Panel PnCompanyHeader;
        private FontAwesome.Sharp.IconPictureBox PicCompanyHeader;
        private FontAwesome.Sharp.IconPictureBox PicJobHeader;
        private System.Windows.Forms.Label LbCompanyNameHader;
        private System.Windows.Forms.Label TxtNumberOfSignedCompaniesHeader;
        private System.Windows.Forms.Label LbNumberOfActiveJobsHeader;
        private System.Windows.Forms.Label LbActiveJobsHeader;
        private System.Windows.Forms.Panel PnInformationStudent;
        private System.Windows.Forms.Label LbStudentInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LbStudentNAme;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox TxtSemester;
        private System.Windows.Forms.TextBox TxtCredit;
        private System.Windows.Forms.TextBox TxtStudentID;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.Label LbMajor;
        private System.Windows.Forms.Label LbNumberOfCredit;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbSemester;
        private System.Windows.Forms.Label LbStudentID;
        private System.Windows.Forms.TextBox txtMajor;
    }
}