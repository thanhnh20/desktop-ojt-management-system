
namespace WinFormsApplication
{
    partial class FrmUniversityHome
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
            this.PnNumberOfStudentInCurrentSemester = new System.Windows.Forms.Panel();
            this.TxtNumberOfStudents = new System.Windows.Forms.Label();
            this.LbNumbersOfStudent = new System.Windows.Forms.Label();
            this.PicNumberOfStudentInCurrentSysmester = new FontAwesome.Sharp.IconPictureBox();
            this.PnNumberOfSignedCompanies = new System.Windows.Forms.Panel();
            this.TxtNumberOfSignedCompanies = new System.Windows.Forms.Label();
            this.LbNumberOfSignedCompanies = new System.Windows.Forms.Label();
            this.PicNumberOfSignedCompanies = new FontAwesome.Sharp.IconPictureBox();
            this.PnNumberOfCompanyPost = new System.Windows.Forms.Panel();
            this.TxtNumberOfPosts = new System.Windows.Forms.Label();
            this.LbNumberOfCompanyPosts = new System.Windows.Forms.Label();
            this.PicNumberOfPosts = new FontAwesome.Sharp.IconPictureBox();
            this.PnNumberOfMajor = new System.Windows.Forms.Panel();
            this.TxtNumberOfMajor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PicNumberOfMajor = new FontAwesome.Sharp.IconPictureBox();
            this.BtnAddNewSemester = new System.Windows.Forms.Button();
            this.BtnAddNewMajor = new System.Windows.Forms.Button();
            this.TblPnHeaderHome.SuspendLayout();
            this.PnNumberOfStudentInCurrentSemester.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNumberOfStudentInCurrentSysmester)).BeginInit();
            this.PnNumberOfSignedCompanies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNumberOfSignedCompanies)).BeginInit();
            this.PnNumberOfCompanyPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNumberOfPosts)).BeginInit();
            this.PnNumberOfMajor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNumberOfMajor)).BeginInit();
            this.SuspendLayout();
            // 
            // TblPnHeaderHome
            // 
            this.TblPnHeaderHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TblPnHeaderHome.ColumnCount = 4;
            this.TblPnHeaderHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TblPnHeaderHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TblPnHeaderHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TblPnHeaderHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TblPnHeaderHome.Controls.Add(this.PnNumberOfStudentInCurrentSemester, 0, 0);
            this.TblPnHeaderHome.Controls.Add(this.PnNumberOfSignedCompanies, 1, 0);
            this.TblPnHeaderHome.Controls.Add(this.PnNumberOfCompanyPost, 2, 0);
            this.TblPnHeaderHome.Controls.Add(this.PnNumberOfMajor, 3, 0);
            this.TblPnHeaderHome.Location = new System.Drawing.Point(51, 163);
            this.TblPnHeaderHome.Name = "TblPnHeaderHome";
            this.TblPnHeaderHome.RowCount = 1;
            this.TblPnHeaderHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblPnHeaderHome.Size = new System.Drawing.Size(961, 131);
            this.TblPnHeaderHome.TabIndex = 0;
            // 
            // PnNumberOfStudentInCurrentSemester
            // 
            this.PnNumberOfStudentInCurrentSemester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(215)))), ((int)(((byte)(213)))));
            this.PnNumberOfStudentInCurrentSemester.Controls.Add(this.TxtNumberOfStudents);
            this.PnNumberOfStudentInCurrentSemester.Controls.Add(this.LbNumbersOfStudent);
            this.PnNumberOfStudentInCurrentSemester.Controls.Add(this.PicNumberOfStudentInCurrentSysmester);
            this.PnNumberOfStudentInCurrentSemester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnNumberOfStudentInCurrentSemester.Location = new System.Drawing.Point(3, 3);
            this.PnNumberOfStudentInCurrentSemester.Name = "PnNumberOfStudentInCurrentSemester";
            this.PnNumberOfStudentInCurrentSemester.Size = new System.Drawing.Size(234, 125);
            this.PnNumberOfStudentInCurrentSemester.TabIndex = 0;
            // 
            // TxtNumberOfStudents
            // 
            this.TxtNumberOfStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNumberOfStudents.AutoSize = true;
            this.TxtNumberOfStudents.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumberOfStudents.ForeColor = System.Drawing.Color.Black;
            this.TxtNumberOfStudents.Location = new System.Drawing.Point(119, 65);
            this.TxtNumberOfStudents.Name = "TxtNumberOfStudents";
            this.TxtNumberOfStudents.Size = new System.Drawing.Size(20, 24);
            this.TxtNumberOfStudents.TabIndex = 3;
            this.TxtNumberOfStudents.Text = "0";
            // 
            // LbNumbersOfStudent
            // 
            this.LbNumbersOfStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbNumbersOfStudent.AutoSize = true;
            this.LbNumbersOfStudent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbNumbersOfStudent.ForeColor = System.Drawing.Color.Black;
            this.LbNumbersOfStudent.Location = new System.Drawing.Point(39, 11);
            this.LbNumbersOfStudent.Name = "LbNumbersOfStudent";
            this.LbNumbersOfStudent.Size = new System.Drawing.Size(179, 24);
            this.LbNumbersOfStudent.TabIndex = 2;
            this.LbNumbersOfStudent.Text = "Number of Students";
            // 
            // PicNumberOfStudentInCurrentSysmester
            // 
            this.PicNumberOfStudentInCurrentSysmester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(215)))), ((int)(((byte)(213)))));
            this.PicNumberOfStudentInCurrentSysmester.ForeColor = System.Drawing.Color.Black;
            this.PicNumberOfStudentInCurrentSysmester.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.PicNumberOfStudentInCurrentSysmester.IconColor = System.Drawing.Color.Black;
            this.PicNumberOfStudentInCurrentSysmester.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PicNumberOfStudentInCurrentSysmester.IconSize = 40;
            this.PicNumberOfStudentInCurrentSysmester.Location = new System.Drawing.Point(13, 49);
            this.PicNumberOfStudentInCurrentSysmester.Name = "PicNumberOfStudentInCurrentSysmester";
            this.PicNumberOfStudentInCurrentSysmester.Size = new System.Drawing.Size(40, 40);
            this.PicNumberOfStudentInCurrentSysmester.TabIndex = 0;
            this.PicNumberOfStudentInCurrentSysmester.TabStop = false;
            // 
            // PnNumberOfSignedCompanies
            // 
            this.PnNumberOfSignedCompanies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(96)))));
            this.PnNumberOfSignedCompanies.Controls.Add(this.TxtNumberOfSignedCompanies);
            this.PnNumberOfSignedCompanies.Controls.Add(this.LbNumberOfSignedCompanies);
            this.PnNumberOfSignedCompanies.Controls.Add(this.PicNumberOfSignedCompanies);
            this.PnNumberOfSignedCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnNumberOfSignedCompanies.Location = new System.Drawing.Point(243, 3);
            this.PnNumberOfSignedCompanies.Name = "PnNumberOfSignedCompanies";
            this.PnNumberOfSignedCompanies.Size = new System.Drawing.Size(234, 125);
            this.PnNumberOfSignedCompanies.TabIndex = 1;
            // 
            // TxtNumberOfSignedCompanies
            // 
            this.TxtNumberOfSignedCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNumberOfSignedCompanies.AutoSize = true;
            this.TxtNumberOfSignedCompanies.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumberOfSignedCompanies.ForeColor = System.Drawing.Color.Black;
            this.TxtNumberOfSignedCompanies.Location = new System.Drawing.Point(108, 65);
            this.TxtNumberOfSignedCompanies.Name = "TxtNumberOfSignedCompanies";
            this.TxtNumberOfSignedCompanies.Size = new System.Drawing.Size(20, 24);
            this.TxtNumberOfSignedCompanies.TabIndex = 6;
            this.TxtNumberOfSignedCompanies.Text = "0";
            // 
            // LbNumberOfSignedCompanies
            // 
            this.LbNumberOfSignedCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbNumberOfSignedCompanies.AutoSize = true;
            this.LbNumberOfSignedCompanies.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbNumberOfSignedCompanies.ForeColor = System.Drawing.Color.Black;
            this.LbNumberOfSignedCompanies.Location = new System.Drawing.Point(33, 11);
            this.LbNumberOfSignedCompanies.Name = "LbNumberOfSignedCompanies";
            this.LbNumberOfSignedCompanies.Size = new System.Drawing.Size(198, 24);
            this.LbNumberOfSignedCompanies.TabIndex = 5;
            this.LbNumberOfSignedCompanies.Text = "Number of Companies";
            // 
            // PicNumberOfSignedCompanies
            // 
            this.PicNumberOfSignedCompanies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(114)))), ((int)(((byte)(96)))));
            this.PicNumberOfSignedCompanies.ForeColor = System.Drawing.Color.Black;
            this.PicNumberOfSignedCompanies.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.PicNumberOfSignedCompanies.IconColor = System.Drawing.Color.Black;
            this.PicNumberOfSignedCompanies.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PicNumberOfSignedCompanies.IconSize = 40;
            this.PicNumberOfSignedCompanies.Location = new System.Drawing.Point(7, 49);
            this.PicNumberOfSignedCompanies.Name = "PicNumberOfSignedCompanies";
            this.PicNumberOfSignedCompanies.Size = new System.Drawing.Size(40, 40);
            this.PicNumberOfSignedCompanies.TabIndex = 4;
            this.PicNumberOfSignedCompanies.TabStop = false;
            // 
            // PnNumberOfCompanyPost
            // 
            this.PnNumberOfCompanyPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(195)))));
            this.PnNumberOfCompanyPost.Controls.Add(this.TxtNumberOfPosts);
            this.PnNumberOfCompanyPost.Controls.Add(this.LbNumberOfCompanyPosts);
            this.PnNumberOfCompanyPost.Controls.Add(this.PicNumberOfPosts);
            this.PnNumberOfCompanyPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnNumberOfCompanyPost.Location = new System.Drawing.Point(483, 3);
            this.PnNumberOfCompanyPost.Name = "PnNumberOfCompanyPost";
            this.PnNumberOfCompanyPost.Size = new System.Drawing.Size(234, 125);
            this.PnNumberOfCompanyPost.TabIndex = 2;
            // 
            // TxtNumberOfPosts
            // 
            this.TxtNumberOfPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNumberOfPosts.AutoSize = true;
            this.TxtNumberOfPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumberOfPosts.ForeColor = System.Drawing.Color.Black;
            this.TxtNumberOfPosts.Location = new System.Drawing.Point(116, 65);
            this.TxtNumberOfPosts.Name = "TxtNumberOfPosts";
            this.TxtNumberOfPosts.Size = new System.Drawing.Size(20, 24);
            this.TxtNumberOfPosts.TabIndex = 6;
            this.TxtNumberOfPosts.Text = "0";
            // 
            // LbNumberOfCompanyPosts
            // 
            this.LbNumberOfCompanyPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbNumberOfCompanyPosts.AutoSize = true;
            this.LbNumberOfCompanyPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbNumberOfCompanyPosts.ForeColor = System.Drawing.Color.Black;
            this.LbNumberOfCompanyPosts.Location = new System.Drawing.Point(48, 11);
            this.LbNumberOfCompanyPosts.Name = "LbNumberOfCompanyPosts";
            this.LbNumberOfCompanyPosts.Size = new System.Drawing.Size(149, 24);
            this.LbNumberOfCompanyPosts.TabIndex = 5;
            this.LbNumberOfCompanyPosts.Text = "Number of Posts";
            // 
            // PicNumberOfPosts
            // 
            this.PicNumberOfPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(195)))));
            this.PicNumberOfPosts.ForeColor = System.Drawing.Color.Black;
            this.PicNumberOfPosts.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.PicNumberOfPosts.IconColor = System.Drawing.Color.Black;
            this.PicNumberOfPosts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PicNumberOfPosts.IconSize = 40;
            this.PicNumberOfPosts.Location = new System.Drawing.Point(14, 49);
            this.PicNumberOfPosts.Name = "PicNumberOfPosts";
            this.PicNumberOfPosts.Size = new System.Drawing.Size(40, 40);
            this.PicNumberOfPosts.TabIndex = 4;
            this.PicNumberOfPosts.TabStop = false;
            // 
            // PnNumberOfMajor
            // 
            this.PnNumberOfMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(151)))), ((int)(((byte)(147)))));
            this.PnNumberOfMajor.Controls.Add(this.TxtNumberOfMajor);
            this.PnNumberOfMajor.Controls.Add(this.label6);
            this.PnNumberOfMajor.Controls.Add(this.PicNumberOfMajor);
            this.PnNumberOfMajor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnNumberOfMajor.Location = new System.Drawing.Point(723, 3);
            this.PnNumberOfMajor.Name = "PnNumberOfMajor";
            this.PnNumberOfMajor.Size = new System.Drawing.Size(235, 125);
            this.PnNumberOfMajor.TabIndex = 3;
            // 
            // TxtNumberOfMajor
            // 
            this.TxtNumberOfMajor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNumberOfMajor.AutoSize = true;
            this.TxtNumberOfMajor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumberOfMajor.ForeColor = System.Drawing.Color.Black;
            this.TxtNumberOfMajor.Location = new System.Drawing.Point(117, 65);
            this.TxtNumberOfMajor.Name = "TxtNumberOfMajor";
            this.TxtNumberOfMajor.Size = new System.Drawing.Size(20, 24);
            this.TxtNumberOfMajor.TabIndex = 6;
            this.TxtNumberOfMajor.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(48, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number of Majors";
            // 
            // PicNumberOfMajor
            // 
            this.PicNumberOfMajor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(151)))), ((int)(((byte)(147)))));
            this.PicNumberOfMajor.ForeColor = System.Drawing.Color.Black;
            this.PicNumberOfMajor.IconChar = FontAwesome.Sharp.IconChar.Suitcase;
            this.PicNumberOfMajor.IconColor = System.Drawing.Color.Black;
            this.PicNumberOfMajor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PicNumberOfMajor.IconSize = 40;
            this.PicNumberOfMajor.Location = new System.Drawing.Point(15, 49);
            this.PicNumberOfMajor.Name = "PicNumberOfMajor";
            this.PicNumberOfMajor.Size = new System.Drawing.Size(40, 40);
            this.PicNumberOfMajor.TabIndex = 4;
            this.PicNumberOfMajor.TabStop = false;
            // 
            // BtnAddNewSemester
            // 
            this.BtnAddNewSemester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddNewSemester.Location = new System.Drawing.Point(801, 22);
            this.BtnAddNewSemester.Name = "BtnAddNewSemester";
            this.BtnAddNewSemester.Size = new System.Drawing.Size(211, 40);
            this.BtnAddNewSemester.TabIndex = 1;
            this.BtnAddNewSemester.Text = "Add a new semester";
            this.BtnAddNewSemester.UseVisualStyleBackColor = true;
            this.BtnAddNewSemester.Click += new System.EventHandler(this.BtnAddNewSemester_Click);
            // 
            // BtnAddNewMajor
            // 
            this.BtnAddNewMajor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddNewMajor.Location = new System.Drawing.Point(801, 81);
            this.BtnAddNewMajor.Name = "BtnAddNewMajor";
            this.BtnAddNewMajor.Size = new System.Drawing.Size(211, 40);
            this.BtnAddNewMajor.TabIndex = 2;
            this.BtnAddNewMajor.Text = "Add a new major";
            this.BtnAddNewMajor.UseVisualStyleBackColor = true;
            this.BtnAddNewMajor.Click += new System.EventHandler(this.BtnAddNewMajor_Click);
            // 
            // FrmUniversityHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 604);
            this.Controls.Add(this.BtnAddNewMajor);
            this.Controls.Add(this.BtnAddNewSemester);
            this.Controls.Add(this.TblPnHeaderHome);
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1111, 651);
            this.Name = "FrmUniversityHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmUniversityHome_Load);
            this.TblPnHeaderHome.ResumeLayout(false);
            this.PnNumberOfStudentInCurrentSemester.ResumeLayout(false);
            this.PnNumberOfStudentInCurrentSemester.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNumberOfStudentInCurrentSysmester)).EndInit();
            this.PnNumberOfSignedCompanies.ResumeLayout(false);
            this.PnNumberOfSignedCompanies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNumberOfSignedCompanies)).EndInit();
            this.PnNumberOfCompanyPost.ResumeLayout(false);
            this.PnNumberOfCompanyPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNumberOfPosts)).EndInit();
            this.PnNumberOfMajor.ResumeLayout(false);
            this.PnNumberOfMajor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNumberOfMajor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblPnHeaderHome;
        private System.Windows.Forms.Panel PnNumberOfStudentInCurrentSemester;
        private System.Windows.Forms.Panel PnNumberOfSignedCompanies;
        private System.Windows.Forms.Panel PnNumberOfCompanyPost;
        private FontAwesome.Sharp.IconPictureBox PicNumberOfStudentInCurrentSysmester;
        private System.Windows.Forms.Label LbNumbersOfStudent;
        private System.Windows.Forms.Label TxtNumberOfStudents;
        private System.Windows.Forms.Label TxtNumberOfSignedCompanies;
        private System.Windows.Forms.Label LbNumberOfSignedCompanies;
        private FontAwesome.Sharp.IconPictureBox PicNumberOfSignedCompanies;
        private System.Windows.Forms.Label TxtNumberOfPosts;
        private System.Windows.Forms.Label LbNumberOfCompanyPosts;
        private FontAwesome.Sharp.IconPictureBox PicNumberOfPosts;
        private System.Windows.Forms.Panel PnNumberOfMajor;
        private System.Windows.Forms.Label TxtNumberOfMajor;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox PicNumberOfMajor;
        private System.Windows.Forms.Button BtnAddNewSemester;
        private System.Windows.Forms.Button BtnAddNewMajor;
    }
}