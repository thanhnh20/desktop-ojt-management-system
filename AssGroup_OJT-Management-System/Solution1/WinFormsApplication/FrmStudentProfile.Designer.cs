
namespace WinFormsApplication
{
    partial class FrmStudentProfile
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
            this.LbGender = new System.Windows.Forms.Label();
            this.LbAddress = new System.Windows.Forms.Label();
            this.LbDateOfBirth = new System.Windows.Forms.Label();
            this.LbStudentID = new System.Windows.Forms.Label();
            this.LbSemester = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbFullName = new System.Windows.Forms.Label();
            this.LbMajor = new System.Windows.Forms.Label();
            this.PnStudentProfile = new System.Windows.Forms.Panel();
            this.CbSemester = new System.Windows.Forms.ComboBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.MTxtDateofBirth = new System.Windows.Forms.MaskedTextBox();
            this.CbMajor = new System.Windows.Forms.ComboBox();
            this.CbGender = new System.Windows.Forms.ComboBox();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtStudentID = new System.Windows.Forms.TextBox();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.PnStudentProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbGender
            // 
            this.LbGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbGender.AutoSize = true;
            this.LbGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbGender.Location = new System.Drawing.Point(41, 184);
            this.LbGender.Name = "LbGender";
            this.LbGender.Size = new System.Drawing.Size(82, 24);
            this.LbGender.TabIndex = 0;
            this.LbGender.Text = "Gender: ";
            // 
            // LbAddress
            // 
            this.LbAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbAddress.AutoSize = true;
            this.LbAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbAddress.Location = new System.Drawing.Point(41, 326);
            this.LbAddress.Name = "LbAddress";
            this.LbAddress.Size = new System.Drawing.Size(87, 24);
            this.LbAddress.TabIndex = 1;
            this.LbAddress.Text = "Address: ";
            // 
            // LbDateOfBirth
            // 
            this.LbDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbDateOfBirth.AutoSize = true;
            this.LbDateOfBirth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbDateOfBirth.Location = new System.Drawing.Point(577, 109);
            this.LbDateOfBirth.Name = "LbDateOfBirth";
            this.LbDateOfBirth.Size = new System.Drawing.Size(127, 24);
            this.LbDateOfBirth.TabIndex = 2;
            this.LbDateOfBirth.Text = "Date of Birth: ";
            // 
            // LbStudentID
            // 
            this.LbStudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbStudentID.AutoSize = true;
            this.LbStudentID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStudentID.Location = new System.Drawing.Point(577, 31);
            this.LbStudentID.Name = "LbStudentID";
            this.LbStudentID.Size = new System.Drawing.Size(120, 24);
            this.LbStudentID.TabIndex = 3;
            this.LbStudentID.Text = "Student\'s ID: ";
            // 
            // LbSemester
            // 
            this.LbSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbSemester.AutoSize = true;
            this.LbSemester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbSemester.Location = new System.Drawing.Point(41, 249);
            this.LbSemester.Name = "LbSemester";
            this.LbSemester.Size = new System.Drawing.Size(92, 24);
            this.LbSemester.TabIndex = 4;
            this.LbSemester.Text = "Semester:";
            // 
            // LbEmail
            // 
            this.LbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbEmail.Location = new System.Drawing.Point(41, 109);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(66, 24);
            this.LbEmail.TabIndex = 5;
            this.LbEmail.Text = "Email: ";
            // 
            // LbFullName
            // 
            this.LbFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbFullName.AutoSize = true;
            this.LbFullName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFullName.Location = new System.Drawing.Point(41, 31);
            this.LbFullName.Name = "LbFullName";
            this.LbFullName.Size = new System.Drawing.Size(104, 24);
            this.LbFullName.TabIndex = 6;
            this.LbFullName.Text = "Full Name: ";
            // 
            // LbMajor
            // 
            this.LbMajor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbMajor.AutoSize = true;
            this.LbMajor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbMajor.Location = new System.Drawing.Point(577, 184);
            this.LbMajor.Name = "LbMajor";
            this.LbMajor.Size = new System.Drawing.Size(70, 24);
            this.LbMajor.TabIndex = 7;
            this.LbMajor.Text = "Major: ";
            // 
            // PnStudentProfile
            // 
            this.PnStudentProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PnStudentProfile.Controls.Add(this.CbSemester);
            this.PnStudentProfile.Controls.Add(this.BtnEdit);
            this.PnStudentProfile.Controls.Add(this.MTxtDateofBirth);
            this.PnStudentProfile.Controls.Add(this.CbMajor);
            this.PnStudentProfile.Controls.Add(this.CbGender);
            this.PnStudentProfile.Controls.Add(this.TxtAddress);
            this.PnStudentProfile.Controls.Add(this.TxtEmail);
            this.PnStudentProfile.Controls.Add(this.TxtStudentID);
            this.PnStudentProfile.Controls.Add(this.TxtFullName);
            this.PnStudentProfile.Controls.Add(this.LbEmail);
            this.PnStudentProfile.Controls.Add(this.LbGender);
            this.PnStudentProfile.Controls.Add(this.LbMajor);
            this.PnStudentProfile.Controls.Add(this.LbDateOfBirth);
            this.PnStudentProfile.Controls.Add(this.LbFullName);
            this.PnStudentProfile.Controls.Add(this.LbSemester);
            this.PnStudentProfile.Controls.Add(this.LbStudentID);
            this.PnStudentProfile.Controls.Add(this.LbAddress);
            this.PnStudentProfile.Location = new System.Drawing.Point(0, 0);
            this.PnStudentProfile.Name = "PnStudentProfile";
            this.PnStudentProfile.Size = new System.Drawing.Size(1093, 551);
            this.PnStudentProfile.TabIndex = 8;
            // 
            // CbSemester
            // 
            this.CbSemester.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbSemester.Enabled = false;
            this.CbSemester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbSemester.FormattingEnabled = true;
            this.CbSemester.Location = new System.Drawing.Point(161, 241);
            this.CbSemester.Name = "CbSemester";
            this.CbSemester.Size = new System.Drawing.Size(208, 32);
            this.CbSemester.TabIndex = 17;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEdit.Location = new System.Drawing.Point(474, 414);
            this.BtnEdit.MaximumSize = new System.Drawing.Size(173, 58);
            this.BtnEdit.MinimumSize = new System.Drawing.Size(135, 39);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(135, 39);
            this.BtnEdit.TabIndex = 16;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // MTxtDateofBirth
            // 
            this.MTxtDateofBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MTxtDateofBirth.Enabled = false;
            this.MTxtDateofBirth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MTxtDateofBirth.Location = new System.Drawing.Point(720, 101);
            this.MTxtDateofBirth.Mask = "00/00/0000";
            this.MTxtDateofBirth.Name = "MTxtDateofBirth";
            this.MTxtDateofBirth.Size = new System.Drawing.Size(165, 32);
            this.MTxtDateofBirth.TabIndex = 15;
            this.MTxtDateofBirth.ValidatingType = typeof(System.DateTime);
            // 
            // CbMajor
            // 
            this.CbMajor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbMajor.Enabled = false;
            this.CbMajor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbMajor.FormattingEnabled = true;
            this.CbMajor.Location = new System.Drawing.Point(720, 176);
            this.CbMajor.Name = "CbMajor";
            this.CbMajor.Size = new System.Drawing.Size(302, 32);
            this.CbMajor.TabIndex = 14;
            // 
            // CbGender
            // 
            this.CbGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbGender.Enabled = false;
            this.CbGender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbGender.FormattingEnabled = true;
            this.CbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CbGender.Location = new System.Drawing.Point(161, 176);
            this.CbGender.Name = "CbGender";
            this.CbGender.Size = new System.Drawing.Size(148, 32);
            this.CbGender.TabIndex = 13;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtAddress.Enabled = false;
            this.TxtAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAddress.Location = new System.Drawing.Point(161, 321);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(861, 32);
            this.TxtAddress.TabIndex = 11;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEmail.Location = new System.Drawing.Point(161, 104);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(302, 32);
            this.TxtEmail.TabIndex = 10;
            // 
            // TxtStudentID
            // 
            this.TxtStudentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtStudentID.Enabled = false;
            this.TxtStudentID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStudentID.Location = new System.Drawing.Point(720, 26);
            this.TxtStudentID.Name = "TxtStudentID";
            this.TxtStudentID.Size = new System.Drawing.Size(302, 32);
            this.TxtStudentID.TabIndex = 9;
            // 
            // TxtFullName
            // 
            this.TxtFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtFullName.Enabled = false;
            this.TxtFullName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFullName.Location = new System.Drawing.Point(161, 25);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(302, 32);
            this.TxtFullName.TabIndex = 8;
            // 
            // FrmStudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 551);
            this.Controls.Add(this.PnStudentProfile);
            this.MaximumSize = new System.Drawing.Size(1332, 747);
            this.MinimumSize = new System.Drawing.Size(1111, 598);
            this.Name = "FrmStudentProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Profile";
            this.Load += new System.EventHandler(this.FrmStudentProfile_Load);
            this.PnStudentProfile.ResumeLayout(false);
            this.PnStudentProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbGender;
        private System.Windows.Forms.Label LbAddress;
        private System.Windows.Forms.Label LbDateOfBirth;
        private System.Windows.Forms.Label LbStudentID;
        private System.Windows.Forms.Label LbSemester;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbFullName;
        private System.Windows.Forms.Label LbMajor;
        private System.Windows.Forms.Panel PnStudentProfile;
        private System.Windows.Forms.MaskedTextBox MTxtDateofBirth;
        private System.Windows.Forms.ComboBox CbMajor;
        private System.Windows.Forms.ComboBox CbGender;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtStudentID;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.ComboBox CbSemester;
    }
}