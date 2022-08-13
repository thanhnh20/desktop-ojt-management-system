
namespace WinFormsApplication
{
    partial class FrmUniversityEditStudentInformation
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
            this.PnContols = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PnInformation = new System.Windows.Forms.Panel();
            this.CbSemester = new System.Windows.Forms.ComboBox();
            this.TxtCredit = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.TxtStudentID = new System.Windows.Forms.TextBox();
            this.LbCredit = new System.Windows.Forms.Label();
            this.LbSemester = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbStudentName = new System.Windows.Forms.Label();
            this.LbStudentID = new System.Windows.Forms.Label();
            this.PnLayout = new System.Windows.Forms.Panel();
            this.PnLayout1 = new System.Windows.Forms.Panel();
            this.PnHeader.SuspendLayout();
            this.PnContols.SuspendLayout();
            this.PnInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnHeader
            // 
            this.PnHeader.Controls.Add(this.LbHeader);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(0, 0);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(649, 79);
            this.PnHeader.TabIndex = 0;
            // 
            // LbHeader
            // 
            this.LbHeader.AutoSize = true;
            this.LbHeader.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.LbHeader.Location = new System.Drawing.Point(130, 19);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(387, 45);
            this.LbHeader.TabIndex = 0;
            this.LbHeader.Text = "Edit Student Information";
            // 
            // PnContols
            // 
            this.PnContols.Controls.Add(this.BtnUpdate);
            this.PnContols.Controls.Add(this.BtnCancel);
            this.PnContols.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnContols.Location = new System.Drawing.Point(0, 347);
            this.PnContols.Name = "PnContols";
            this.PnContols.Size = new System.Drawing.Size(649, 79);
            this.PnContols.TabIndex = 1;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnUpdate.Location = new System.Drawing.Point(365, 20);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(162, 39);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancel.Location = new System.Drawing.Point(122, 20);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(162, 39);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PnInformation
            // 
            this.PnInformation.Controls.Add(this.CbSemester);
            this.PnInformation.Controls.Add(this.TxtCredit);
            this.PnInformation.Controls.Add(this.TxtPassword);
            this.PnInformation.Controls.Add(this.TxtEmail);
            this.PnInformation.Controls.Add(this.TxtStudentName);
            this.PnInformation.Controls.Add(this.TxtStudentID);
            this.PnInformation.Controls.Add(this.LbCredit);
            this.PnInformation.Controls.Add(this.LbSemester);
            this.PnInformation.Controls.Add(this.LbPassword);
            this.PnInformation.Controls.Add(this.LbEmail);
            this.PnInformation.Controls.Add(this.LbStudentName);
            this.PnInformation.Controls.Add(this.LbStudentID);
            this.PnInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnInformation.Location = new System.Drawing.Point(0, 80);
            this.PnInformation.Name = "PnInformation";
            this.PnInformation.Size = new System.Drawing.Size(649, 267);
            this.PnInformation.TabIndex = 2;
            // 
            // CbSemester
            // 
            this.CbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSemester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbSemester.FormattingEnabled = true;
            this.CbSemester.Location = new System.Drawing.Point(255, 175);
            this.CbSemester.Name = "CbSemester";
            this.CbSemester.Size = new System.Drawing.Size(178, 32);
            this.CbSemester.TabIndex = 11;
            // 
            // TxtCredit
            // 
            this.TxtCredit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCredit.Location = new System.Drawing.Point(255, 216);
            this.TxtCredit.Name = "TxtCredit";
            this.TxtCredit.Size = new System.Drawing.Size(178, 32);
            this.TxtCredit.TabIndex = 10;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPassword.Location = new System.Drawing.Point(255, 135);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(262, 32);
            this.TxtPassword.TabIndex = 9;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEmail.Location = new System.Drawing.Point(255, 96);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(328, 32);
            this.TxtEmail.TabIndex = 8;
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.Enabled = false;
            this.TxtStudentName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStudentName.Location = new System.Drawing.Point(255, 58);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(328, 32);
            this.TxtStudentName.TabIndex = 7;
            // 
            // TxtStudentID
            // 
            this.TxtStudentID.Enabled = false;
            this.TxtStudentID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStudentID.Location = new System.Drawing.Point(255, 11);
            this.TxtStudentID.Name = "TxtStudentID";
            this.TxtStudentID.Size = new System.Drawing.Size(178, 32);
            this.TxtStudentID.TabIndex = 6;
            // 
            // LbCredit
            // 
            this.LbCredit.AutoSize = true;
            this.LbCredit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCredit.Location = new System.Drawing.Point(73, 224);
            this.LbCredit.Name = "LbCredit";
            this.LbCredit.Size = new System.Drawing.Size(71, 24);
            this.LbCredit.TabIndex = 5;
            this.LbCredit.Text = "Credit: ";
            // 
            // LbSemester
            // 
            this.LbSemester.AutoSize = true;
            this.LbSemester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbSemester.Location = new System.Drawing.Point(73, 183);
            this.LbSemester.Name = "LbSemester";
            this.LbSemester.Size = new System.Drawing.Size(97, 24);
            this.LbSemester.TabIndex = 4;
            this.LbSemester.Text = "Semester: ";
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPassword.Location = new System.Drawing.Point(73, 143);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(99, 24);
            this.LbPassword.TabIndex = 3;
            this.LbPassword.Text = "Password: ";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbEmail.Location = new System.Drawing.Point(73, 104);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(66, 24);
            this.LbEmail.TabIndex = 2;
            this.LbEmail.Text = "Email: ";
            // 
            // LbStudentName
            // 
            this.LbStudentName.AutoSize = true;
            this.LbStudentName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStudentName.Location = new System.Drawing.Point(73, 66);
            this.LbStudentName.Name = "LbStudentName";
            this.LbStudentName.Size = new System.Drawing.Size(138, 24);
            this.LbStudentName.TabIndex = 1;
            this.LbStudentName.Text = "Student name: ";
            // 
            // LbStudentID
            // 
            this.LbStudentID.AutoSize = true;
            this.LbStudentID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStudentID.Location = new System.Drawing.Point(73, 19);
            this.LbStudentID.Name = "LbStudentID";
            this.LbStudentID.Size = new System.Drawing.Size(120, 24);
            this.LbStudentID.TabIndex = 0;
            this.LbStudentID.Text = "Student\'s ID: ";
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLayout.Location = new System.Drawing.Point(0, 79);
            this.PnLayout.Name = "PnLayout";
            this.PnLayout.Size = new System.Drawing.Size(649, 1);
            this.PnLayout.TabIndex = 3;
            // 
            // PnLayout1
            // 
            this.PnLayout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnLayout1.Location = new System.Drawing.Point(0, 346);
            this.PnLayout1.Name = "PnLayout1";
            this.PnLayout1.Size = new System.Drawing.Size(649, 1);
            this.PnLayout1.TabIndex = 4;
            // 
            // FrmUniversityEditStudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 426);
            this.Controls.Add(this.PnLayout1);
            this.Controls.Add(this.PnInformation);
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.PnContols);
            this.Controls.Add(this.PnHeader);
            this.MaximumSize = new System.Drawing.Size(667, 473);
            this.MinimumSize = new System.Drawing.Size(667, 473);
            this.Name = "FrmUniversityEditStudentInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Student Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUniversityEditStudentInformation_FormClosing);
            this.Load += new System.EventHandler(this.FrmUniversityEditStudentInformation_Load);
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            this.PnContols.ResumeLayout(false);
            this.PnInformation.ResumeLayout(false);
            this.PnInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Label LbHeader;
        private System.Windows.Forms.Panel PnContols;
        private System.Windows.Forms.Panel PnInformation;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbStudentName;
        private System.Windows.Forms.Label LbStudentID;
        private System.Windows.Forms.Label LbCredit;
        private System.Windows.Forms.Label LbSemester;
        private System.Windows.Forms.ComboBox CbSemester;
        private System.Windows.Forms.TextBox TxtCredit;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.TextBox TxtStudentID;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel PnLayout;
        private System.Windows.Forms.Panel PnLayout1;
    }
}