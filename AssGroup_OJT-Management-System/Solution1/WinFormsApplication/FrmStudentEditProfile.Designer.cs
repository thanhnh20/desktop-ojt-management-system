
namespace WinFormsApplication
{
    partial class FrmStudentEditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentEditProfile));
            this.LbFullName = new System.Windows.Forms.Label();
            this.LbHeader = new System.Windows.Forms.Label();
            this.LbStudentID = new System.Windows.Forms.Label();
            this.PnInformation = new System.Windows.Forms.Panel();
            this.PnLayoutBottom = new System.Windows.Forms.Panel();
            this.PnControls = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
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
            this.PnLayout = new System.Windows.Forms.Panel();
            this.PnHeader = new System.Windows.Forms.Panel();
            this.PnInformation.SuspendLayout();
            this.PnControls.SuspendLayout();
            this.PnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbFullName
            // 
            resources.ApplyResources(this.LbFullName, "LbFullName");
            this.LbFullName.Name = "LbFullName";
            // 
            // LbHeader
            // 
            resources.ApplyResources(this.LbHeader, "LbHeader");
            this.LbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.LbHeader.Name = "LbHeader";
            // 
            // LbStudentID
            // 
            resources.ApplyResources(this.LbStudentID, "LbStudentID");
            this.LbStudentID.Name = "LbStudentID";
            // 
            // PnInformation
            // 
            this.PnInformation.Controls.Add(this.PnLayoutBottom);
            this.PnInformation.Controls.Add(this.PnControls);
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
            resources.ApplyResources(this.PnInformation, "PnInformation");
            this.PnInformation.Name = "PnInformation";
            // 
            // PnLayoutBottom
            // 
            this.PnLayoutBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            resources.ApplyResources(this.PnLayoutBottom, "PnLayoutBottom");
            this.PnLayoutBottom.Name = "PnLayoutBottom";
            // 
            // PnControls
            // 
            this.PnControls.Controls.Add(this.BtnUpdate);
            this.PnControls.Controls.Add(this.BtnCancel);
            resources.ApplyResources(this.PnControls, "PnControls");
            this.PnControls.Name = "PnControls";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnUpdate, "BtnUpdate");
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BtnCancel, "BtnCancel");
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CbSemester
            // 
            resources.ApplyResources(this.CbSemester, "CbSemester");
            this.CbSemester.FormattingEnabled = true;
            this.CbSemester.Name = "CbSemester";
            // 
            // CbMajor
            // 
            resources.ApplyResources(this.CbMajor, "CbMajor");
            this.CbMajor.FormattingEnabled = true;
            this.CbMajor.Name = "CbMajor";
            // 
            // MtxtDateOfBirth
            // 
            resources.ApplyResources(this.MtxtDateOfBirth, "MtxtDateOfBirth");
            this.MtxtDateOfBirth.Name = "MtxtDateOfBirth";
            this.MtxtDateOfBirth.ValidatingType = typeof(System.DateTime);
            // 
            // CbGender
            // 
            resources.ApplyResources(this.CbGender, "CbGender");
            this.CbGender.FormattingEnabled = true;
            this.CbGender.Items.AddRange(new object[] {
            resources.GetString("CbGender.Items"),
            resources.GetString("CbGender.Items1")});
            this.CbGender.Name = "CbGender";
            // 
            // TxtAddress
            // 
            resources.ApplyResources(this.TxtAddress, "TxtAddress");
            this.TxtAddress.Name = "TxtAddress";
            // 
            // TxtPassword
            // 
            resources.ApplyResources(this.TxtPassword, "TxtPassword");
            this.TxtPassword.Name = "TxtPassword";
            // 
            // TxtEmail
            // 
            resources.ApplyResources(this.TxtEmail, "TxtEmail");
            this.TxtEmail.Name = "TxtEmail";
            // 
            // TxtStudentID
            // 
            resources.ApplyResources(this.TxtStudentID, "TxtStudentID");
            this.TxtStudentID.Name = "TxtStudentID";
            // 
            // TxtFullName
            // 
            resources.ApplyResources(this.TxtFullName, "TxtFullName");
            this.TxtFullName.Name = "TxtFullName";
            // 
            // LbAddress
            // 
            resources.ApplyResources(this.LbAddress, "LbAddress");
            this.LbAddress.Name = "LbAddress";
            // 
            // LbSemester
            // 
            resources.ApplyResources(this.LbSemester, "LbSemester");
            this.LbSemester.Name = "LbSemester";
            // 
            // LbMajor
            // 
            resources.ApplyResources(this.LbMajor, "LbMajor");
            this.LbMajor.Name = "LbMajor";
            // 
            // LbPassword
            // 
            resources.ApplyResources(this.LbPassword, "LbPassword");
            this.LbPassword.Name = "LbPassword";
            // 
            // LbGender
            // 
            resources.ApplyResources(this.LbGender, "LbGender");
            this.LbGender.Name = "LbGender";
            // 
            // LbDateOfBirth
            // 
            resources.ApplyResources(this.LbDateOfBirth, "LbDateOfBirth");
            this.LbDateOfBirth.Name = "LbDateOfBirth";
            // 
            // LbEmail
            // 
            resources.ApplyResources(this.LbEmail, "LbEmail");
            this.LbEmail.Name = "LbEmail";
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            resources.ApplyResources(this.PnLayout, "PnLayout");
            this.PnLayout.Name = "PnLayout";
            // 
            // PnHeader
            // 
            this.PnHeader.Controls.Add(this.LbHeader);
            resources.ApplyResources(this.PnHeader, "PnHeader");
            this.PnHeader.Name = "PnHeader";
            // 
            // FrmStudentEditProfile
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.PnHeader);
            this.Controls.Add(this.PnInformation);
            this.Name = "FrmStudentEditProfile";
            this.Load += new System.EventHandler(this.FrmStudentEditProfile_Load);
            this.PnInformation.ResumeLayout(false);
            this.PnInformation.PerformLayout();
            this.PnControls.ResumeLayout(false);
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbFullName;
        private System.Windows.Forms.Label LbHeader;
        private System.Windows.Forms.Label LbStudentID;
        private System.Windows.Forms.Panel PnInformation;
        private System.Windows.Forms.Label LbAddress;
        private System.Windows.Forms.Label LbSemester;
        private System.Windows.Forms.Label LbMajor;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.Label LbGender;
        private System.Windows.Forms.Label LbDateOfBirth;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Panel PnLayout;
        private System.Windows.Forms.ComboBox CbGender;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtStudentID;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.MaskedTextBox MtxtDateOfBirth;
        private System.Windows.Forms.Panel PnControls;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ComboBox CbSemester;
        private System.Windows.Forms.ComboBox CbMajor;
        private System.Windows.Forms.Panel PnLayoutBottom;
    }
}