
namespace WinFormsApplication
{
    partial class FrmUniversityAddNewStudent
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
            this.PnHeader = new System.Windows.Forms.Panel();
            this.LbHeader = new System.Windows.Forms.Label();
            this.PnLayout = new System.Windows.Forms.Panel();
            this.PnControls = new System.Windows.Forms.Panel();
            this.BtnInsertANewStudent = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PnLayout1 = new System.Windows.Forms.Panel();
            this.PnInformation = new System.Windows.Forms.Panel();
            this.TxtCredit = new System.Windows.Forms.TextBox();
            this.LbCredit = new System.Windows.Forms.Label();
            this.CbSemester = new System.Windows.Forms.ComboBox();
            this.CbMajor = new System.Windows.Forms.ComboBox();
            this.MtxtDateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.CbGender = new System.Windows.Forms.ComboBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtStudentID = new System.Windows.Forms.TextBox();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.LbAddress = new System.Windows.Forms.Label();
            this.LbSemester = new System.Windows.Forms.Label();
            this.LbMajor = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.LbGender = new System.Windows.Forms.Label();
            this.LbDateOfBirth = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbFullName = new System.Windows.Forms.Label();
            this.LbStudentID = new System.Windows.Forms.Label();
            this.PnHeader.SuspendLayout();
            this.PnControls.SuspendLayout();
            this.PnInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnHeader
            // 
            this.PnHeader.Controls.Add(this.LbHeader);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(0, 0);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(505, 90);
            this.PnHeader.TabIndex = 0;
            // 
            // LbHeader
            // 
            this.LbHeader.AutoSize = true;
            this.LbHeader.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.LbHeader.Location = new System.Drawing.Point(98, 26);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(308, 45);
            this.LbHeader.TabIndex = 0;
            this.LbHeader.Text = "Add A New Student";
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLayout.Location = new System.Drawing.Point(0, 90);
            this.PnLayout.Name = "PnLayout";
            this.PnLayout.Size = new System.Drawing.Size(505, 1);
            this.PnLayout.TabIndex = 1;
            // 
            // PnControls
            // 
            this.PnControls.Controls.Add(this.BtnInsertANewStudent);
            this.PnControls.Controls.Add(this.BtnCancel);
            this.PnControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnControls.Location = new System.Drawing.Point(0, 685);
            this.PnControls.Name = "PnControls";
            this.PnControls.Size = new System.Drawing.Size(505, 94);
            this.PnControls.TabIndex = 2;
            // 
            // BtnInsertANewStudent
            // 
            this.BtnInsertANewStudent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInsertANewStudent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnInsertANewStudent.Location = new System.Drawing.Point(293, 28);
            this.BtnInsertANewStudent.Name = "BtnInsertANewStudent";
            this.BtnInsertANewStudent.Size = new System.Drawing.Size(162, 39);
            this.BtnInsertANewStudent.TabIndex = 3;
            this.BtnInsertANewStudent.Text = "Insert";
            this.BtnInsertANewStudent.UseVisualStyleBackColor = true;
            this.BtnInsertANewStudent.Click += new System.EventHandler(this.BtnInsertANewStudent_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancel.Location = new System.Drawing.Point(50, 28);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(162, 39);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PnLayout1
            // 
            this.PnLayout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnLayout1.Location = new System.Drawing.Point(0, 684);
            this.PnLayout1.Name = "PnLayout1";
            this.PnLayout1.Size = new System.Drawing.Size(505, 1);
            this.PnLayout1.TabIndex = 3;
            // 
            // PnInformation
            // 
            this.PnInformation.Controls.Add(this.TxtCredit);
            this.PnInformation.Controls.Add(this.LbCredit);
            this.PnInformation.Controls.Add(this.CbSemester);
            this.PnInformation.Controls.Add(this.CbMajor);
            this.PnInformation.Controls.Add(this.MtxtDateOfBirth);
            this.PnInformation.Controls.Add(this.CbGender);
            this.PnInformation.Controls.Add(this.TxtAddress);
            this.PnInformation.Controls.Add(this.TxtPassword);
            this.PnInformation.Controls.Add(this.TxtEmail);
            this.PnInformation.Controls.Add(this.TxtStudentID);
            this.PnInformation.Controls.Add(this.TxtFullName);
            this.PnInformation.Controls.Add(this.LbAddress);
            this.PnInformation.Controls.Add(this.LbSemester);
            this.PnInformation.Controls.Add(this.LbMajor);
            this.PnInformation.Controls.Add(this.LbPassword);
            this.PnInformation.Controls.Add(this.LbGender);
            this.PnInformation.Controls.Add(this.LbDateOfBirth);
            this.PnInformation.Controls.Add(this.LbEmail);
            this.PnInformation.Controls.Add(this.LbFullName);
            this.PnInformation.Controls.Add(this.LbStudentID);
            this.PnInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnInformation.Location = new System.Drawing.Point(0, 91);
            this.PnInformation.Name = "PnInformation";
            this.PnInformation.Size = new System.Drawing.Size(505, 593);
            this.PnInformation.TabIndex = 4;
            // 
            // TxtCredit
            // 
            this.TxtCredit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCredit.Location = new System.Drawing.Point(196, 336);
            this.TxtCredit.Name = "TxtCredit";
            this.TxtCredit.Size = new System.Drawing.Size(183, 32);
            this.TxtCredit.TabIndex = 36;
            // 
            // LbCredit
            // 
            this.LbCredit.AutoSize = true;
            this.LbCredit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCredit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbCredit.Location = new System.Drawing.Point(24, 344);
            this.LbCredit.Name = "LbCredit";
            this.LbCredit.Size = new System.Drawing.Size(71, 24);
            this.LbCredit.TabIndex = 38;
            this.LbCredit.Text = "Credit: ";
            // 
            // CbSemester
            // 
            this.CbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSemester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbSemester.FormattingEnabled = true;
            this.CbSemester.Location = new System.Drawing.Point(196, 392);
            this.CbSemester.Name = "CbSemester";
            this.CbSemester.Size = new System.Drawing.Size(183, 32);
            this.CbSemester.TabIndex = 37;
            // 
            // CbMajor
            // 
            this.CbMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbMajor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbMajor.FormattingEnabled = true;
            this.CbMajor.Location = new System.Drawing.Point(196, 288);
            this.CbMajor.Name = "CbMajor";
            this.CbMajor.Size = new System.Drawing.Size(284, 32);
            this.CbMajor.TabIndex = 35;
            // 
            // MtxtDateOfBirth
            // 
            this.MtxtDateOfBirth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MtxtDateOfBirth.Location = new System.Drawing.Point(196, 243);
            this.MtxtDateOfBirth.Mask = "00/00/0000";
            this.MtxtDateOfBirth.Name = "MtxtDateOfBirth";
            this.MtxtDateOfBirth.Size = new System.Drawing.Size(183, 32);
            this.MtxtDateOfBirth.TabIndex = 34;
            this.MtxtDateOfBirth.ValidatingType = typeof(System.DateTime);
            // 
            // CbGender
            // 
            this.CbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbGender.FormattingEnabled = true;
            this.CbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CbGender.Location = new System.Drawing.Point(196, 201);
            this.CbGender.Name = "CbGender";
            this.CbGender.Size = new System.Drawing.Size(151, 32);
            this.CbGender.TabIndex = 33;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAddress.Location = new System.Drawing.Point(196, 455);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(284, 100);
            this.TxtAddress.TabIndex = 38;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPassword.Location = new System.Drawing.Point(196, 156);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(284, 32);
            this.TxtPassword.TabIndex = 32;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEmail.Location = new System.Drawing.Point(196, 109);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(284, 32);
            this.TxtEmail.TabIndex = 31;
            // 
            // TxtStudentID
            // 
            this.TxtStudentID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStudentID.Location = new System.Drawing.Point(196, 59);
            this.TxtStudentID.Name = "TxtStudentID";
            this.TxtStudentID.Size = new System.Drawing.Size(202, 32);
            this.TxtStudentID.TabIndex = 30;
            // 
            // TxtFullName
            // 
            this.TxtFullName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFullName.Location = new System.Drawing.Point(196, 11);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(284, 32);
            this.TxtFullName.TabIndex = 29;
            // 
            // LbAddress
            // 
            this.LbAddress.AutoSize = true;
            this.LbAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbAddress.Location = new System.Drawing.Point(24, 455);
            this.LbAddress.Name = "LbAddress";
            this.LbAddress.Size = new System.Drawing.Size(87, 24);
            this.LbAddress.TabIndex = 28;
            this.LbAddress.Text = "Address: ";
            // 
            // LbSemester
            // 
            this.LbSemester.AutoSize = true;
            this.LbSemester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbSemester.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbSemester.Location = new System.Drawing.Point(24, 400);
            this.LbSemester.Name = "LbSemester";
            this.LbSemester.Size = new System.Drawing.Size(97, 24);
            this.LbSemester.TabIndex = 27;
            this.LbSemester.Text = "Semester: ";
            // 
            // LbMajor
            // 
            this.LbMajor.AutoSize = true;
            this.LbMajor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbMajor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbMajor.Location = new System.Drawing.Point(24, 296);
            this.LbMajor.Name = "LbMajor";
            this.LbMajor.Size = new System.Drawing.Size(70, 24);
            this.LbMajor.TabIndex = 26;
            this.LbMajor.Text = "Major: ";
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbPassword.Location = new System.Drawing.Point(24, 164);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(99, 24);
            this.LbPassword.TabIndex = 25;
            this.LbPassword.Text = "Password: ";
            // 
            // LbGender
            // 
            this.LbGender.AutoSize = true;
            this.LbGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbGender.Location = new System.Drawing.Point(24, 209);
            this.LbGender.Name = "LbGender";
            this.LbGender.Size = new System.Drawing.Size(77, 24);
            this.LbGender.TabIndex = 24;
            this.LbGender.Text = "Gender:";
            // 
            // LbDateOfBirth
            // 
            this.LbDateOfBirth.AutoSize = true;
            this.LbDateOfBirth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbDateOfBirth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbDateOfBirth.Location = new System.Drawing.Point(24, 251);
            this.LbDateOfBirth.Name = "LbDateOfBirth";
            this.LbDateOfBirth.Size = new System.Drawing.Size(127, 24);
            this.LbDateOfBirth.TabIndex = 23;
            this.LbDateOfBirth.Text = "Date of Birth: ";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbEmail.Location = new System.Drawing.Point(24, 117);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(66, 24);
            this.LbEmail.TabIndex = 22;
            this.LbEmail.Text = "Email: ";
            // 
            // LbFullName
            // 
            this.LbFullName.AutoSize = true;
            this.LbFullName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbFullName.Location = new System.Drawing.Point(24, 19);
            this.LbFullName.Name = "LbFullName";
            this.LbFullName.Size = new System.Drawing.Size(104, 24);
            this.LbFullName.TabIndex = 20;
            this.LbFullName.Text = "Full Name: ";
            // 
            // LbStudentID
            // 
            this.LbStudentID.AutoSize = true;
            this.LbStudentID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStudentID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbStudentID.Location = new System.Drawing.Point(24, 67);
            this.LbStudentID.Name = "LbStudentID";
            this.LbStudentID.Size = new System.Drawing.Size(120, 24);
            this.LbStudentID.TabIndex = 21;
            this.LbStudentID.Text = "Student\'s ID: ";
            // 
            // FrmUniversityAddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 779);
            this.Controls.Add(this.PnInformation);
            this.Controls.Add(this.PnLayout1);
            this.Controls.Add(this.PnControls);
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.PnHeader);
            this.MaximumSize = new System.Drawing.Size(523, 826);
            this.MinimumSize = new System.Drawing.Size(523, 826);
            this.Name = "FrmUniversityAddNewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert New Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUniversityAddNewStudent_FormClosing);
            this.Load += new System.EventHandler(this.FrmUniversityAddNewStudent_Load);
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            this.PnControls.ResumeLayout(false);
            this.PnInformation.ResumeLayout(false);
            this.PnInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Label LbHeader;
        private System.Windows.Forms.Panel PnLayout;
        private System.Windows.Forms.Panel PnControls;
        private System.Windows.Forms.Panel PnLayout1;
        private System.Windows.Forms.Panel PnInformation;
        private System.Windows.Forms.ComboBox CbSemester;
        private System.Windows.Forms.ComboBox CbMajor;
        private System.Windows.Forms.MaskedTextBox MtxtDateOfBirth;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtStudentID;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.Label LbAddress;
        private System.Windows.Forms.Label LbSemester;
        private System.Windows.Forms.Label LbMajor;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Label LbGender;
        private System.Windows.Forms.Label LbDateOfBirth;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbFullName;
        private System.Windows.Forms.Label LbStudentID;
        private System.Windows.Forms.Button BtnInsertANewStudent;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtCredit;
        private System.Windows.Forms.Label LbCredit;
        private System.Windows.Forms.ComboBox CbGender;
    }
}