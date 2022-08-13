
namespace WinFormsApplication
{
    partial class FrmStudentDetailJobCompany
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
            this.LbCompanyName = new System.Windows.Forms.Label();
            this.LbJobName = new System.Windows.Forms.Label();
            this.TxtJobName = new System.Windows.Forms.TextBox();
            this.LbAddress = new System.Windows.Forms.Label();
            this.LbNumberOfInterns = new System.Windows.Forms.Label();
            this.LbExpirationDate = new System.Windows.Forms.Label();
            this.LbJobDescription = new System.Windows.Forms.Label();
            this.LbMajorJob = new System.Windows.Forms.Label();
            this.TxtAddressCompany = new System.Windows.Forms.TextBox();
            this.TxtJobDescriptio = new System.Windows.Forms.TextBox();
            this.TxtNumberOfInterns = new System.Windows.Forms.TextBox();
            this.MTextExpirationDate = new System.Windows.Forms.MaskedTextBox();
            this.CbMajorJob = new System.Windows.Forms.ComboBox();
            this.BtnApply = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LbStatusApplied = new System.Windows.Forms.Label();
            this.TxtAppliedStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbCompanyName
            // 
            this.LbCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbCompanyName.AutoSize = true;
            this.LbCompanyName.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.LbCompanyName.Location = new System.Drawing.Point(418, 31);
            this.LbCompanyName.Name = "LbCompanyName";
            this.LbCompanyName.Size = new System.Drawing.Size(275, 58);
            this.LbCompanyName.TabIndex = 0;
            this.LbCompanyName.Text = "FPT Software";
            this.LbCompanyName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LbJobName
            // 
            this.LbJobName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbJobName.AutoSize = true;
            this.LbJobName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbJobName.Location = new System.Drawing.Point(45, 111);
            this.LbJobName.Name = "LbJobName";
            this.LbJobName.Size = new System.Drawing.Size(102, 24);
            this.LbJobName.TabIndex = 1;
            this.LbJobName.Text = "Job Name: ";
            // 
            // TxtJobName
            // 
            this.TxtJobName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtJobName.Enabled = false;
            this.TxtJobName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtJobName.Location = new System.Drawing.Point(248, 103);
            this.TxtJobName.MaximumSize = new System.Drawing.Size(337, 32);
            this.TxtJobName.MinimumSize = new System.Drawing.Size(337, 32);
            this.TxtJobName.Name = "TxtJobName";
            this.TxtJobName.Size = new System.Drawing.Size(337, 32);
            this.TxtJobName.TabIndex = 2;
            // 
            // LbAddress
            // 
            this.LbAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbAddress.AutoSize = true;
            this.LbAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbAddress.Location = new System.Drawing.Point(45, 167);
            this.LbAddress.Name = "LbAddress";
            this.LbAddress.Size = new System.Drawing.Size(87, 24);
            this.LbAddress.TabIndex = 3;
            this.LbAddress.Text = "Address: ";
            // 
            // LbNumberOfInterns
            // 
            this.LbNumberOfInterns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbNumberOfInterns.AutoSize = true;
            this.LbNumberOfInterns.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbNumberOfInterns.Location = new System.Drawing.Point(636, 111);
            this.LbNumberOfInterns.Name = "LbNumberOfInterns";
            this.LbNumberOfInterns.Size = new System.Drawing.Size(174, 24);
            this.LbNumberOfInterns.TabIndex = 4;
            this.LbNumberOfInterns.Text = "Number of Interns: ";
            // 
            // LbExpirationDate
            // 
            this.LbExpirationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbExpirationDate.AutoSize = true;
            this.LbExpirationDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbExpirationDate.Location = new System.Drawing.Point(45, 215);
            this.LbExpirationDate.Name = "LbExpirationDate";
            this.LbExpirationDate.Size = new System.Drawing.Size(149, 24);
            this.LbExpirationDate.TabIndex = 5;
            this.LbExpirationDate.Text = "Expiration Date: ";
            // 
            // LbJobDescription
            // 
            this.LbJobDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbJobDescription.AutoSize = true;
            this.LbJobDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbJobDescription.Location = new System.Drawing.Point(45, 272);
            this.LbJobDescription.Name = "LbJobDescription";
            this.LbJobDescription.Size = new System.Drawing.Size(159, 24);
            this.LbJobDescription.TabIndex = 6;
            this.LbJobDescription.Text = "Job\'s Description: ";
            // 
            // LbMajorJob
            // 
            this.LbMajorJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbMajorJob.AutoSize = true;
            this.LbMajorJob.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbMajorJob.Location = new System.Drawing.Point(636, 215);
            this.LbMajorJob.Name = "LbMajorJob";
            this.LbMajorJob.Size = new System.Drawing.Size(70, 24);
            this.LbMajorJob.TabIndex = 7;
            this.LbMajorJob.Text = "Major: ";
            // 
            // TxtAddressCompany
            // 
            this.TxtAddressCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtAddressCompany.Enabled = false;
            this.TxtAddressCompany.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAddressCompany.Location = new System.Drawing.Point(248, 159);
            this.TxtAddressCompany.MaximumSize = new System.Drawing.Size(747, 32);
            this.TxtAddressCompany.MinimumSize = new System.Drawing.Size(747, 32);
            this.TxtAddressCompany.Name = "TxtAddressCompany";
            this.TxtAddressCompany.Size = new System.Drawing.Size(747, 32);
            this.TxtAddressCompany.TabIndex = 8;
            // 
            // TxtJobDescriptio
            // 
            this.TxtJobDescriptio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtJobDescriptio.Enabled = false;
            this.TxtJobDescriptio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtJobDescriptio.Location = new System.Drawing.Point(248, 264);
            this.TxtJobDescriptio.MaximumSize = new System.Drawing.Size(747, 122);
            this.TxtJobDescriptio.MinimumSize = new System.Drawing.Size(747, 122);
            this.TxtJobDescriptio.Multiline = true;
            this.TxtJobDescriptio.Name = "TxtJobDescriptio";
            this.TxtJobDescriptio.Size = new System.Drawing.Size(747, 122);
            this.TxtJobDescriptio.TabIndex = 9;
            // 
            // TxtNumberOfInterns
            // 
            this.TxtNumberOfInterns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtNumberOfInterns.Enabled = false;
            this.TxtNumberOfInterns.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumberOfInterns.Location = new System.Drawing.Point(816, 103);
            this.TxtNumberOfInterns.MaximumSize = new System.Drawing.Size(179, 32);
            this.TxtNumberOfInterns.MinimumSize = new System.Drawing.Size(179, 32);
            this.TxtNumberOfInterns.Name = "TxtNumberOfInterns";
            this.TxtNumberOfInterns.Size = new System.Drawing.Size(179, 32);
            this.TxtNumberOfInterns.TabIndex = 10;
            // 
            // MTextExpirationDate
            // 
            this.MTextExpirationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MTextExpirationDate.Enabled = false;
            this.MTextExpirationDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MTextExpirationDate.Location = new System.Drawing.Point(250, 210);
            this.MTextExpirationDate.Mask = "00/00/0000";
            this.MTextExpirationDate.MaximumSize = new System.Drawing.Size(188, 32);
            this.MTextExpirationDate.MinimumSize = new System.Drawing.Size(188, 32);
            this.MTextExpirationDate.Name = "MTextExpirationDate";
            this.MTextExpirationDate.Size = new System.Drawing.Size(188, 32);
            this.MTextExpirationDate.TabIndex = 11;
            this.MTextExpirationDate.ValidatingType = typeof(System.DateTime);
            // 
            // CbMajorJob
            // 
            this.CbMajorJob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbMajorJob.Enabled = false;
            this.CbMajorJob.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbMajorJob.FormattingEnabled = true;
            this.CbMajorJob.Location = new System.Drawing.Point(737, 207);
            this.CbMajorJob.MaximumSize = new System.Drawing.Size(258, 0);
            this.CbMajorJob.MinimumSize = new System.Drawing.Size(258, 0);
            this.CbMajorJob.Name = "CbMajorJob";
            this.CbMajorJob.Size = new System.Drawing.Size(258, 32);
            this.CbMajorJob.TabIndex = 12;
            // 
            // BtnApply
            // 
            this.BtnApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnApply.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnApply.Location = new System.Drawing.Point(659, 438);
            this.BtnApply.MaximumSize = new System.Drawing.Size(123, 46);
            this.BtnApply.MinimumSize = new System.Drawing.Size(123, 46);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(123, 46);
            this.BtnApply.TabIndex = 13;
            this.BtnApply.Text = "Apply";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.Location = new System.Drawing.Point(376, 438);
            this.BtnExit.MaximumSize = new System.Drawing.Size(123, 46);
            this.BtnExit.MinimumSize = new System.Drawing.Size(123, 46);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(123, 46);
            this.BtnExit.TabIndex = 14;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LbStatusApplied
            // 
            this.LbStatusApplied.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbStatusApplied.AutoSize = true;
            this.LbStatusApplied.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStatusApplied.Location = new System.Drawing.Point(816, 57);
            this.LbStatusApplied.Name = "LbStatusApplied";
            this.LbStatusApplied.Size = new System.Drawing.Size(142, 24);
            this.LbStatusApplied.TabIndex = 15;
            this.LbStatusApplied.Text = "Applied Status: ";
            // 
            // TxtAppliedStatus
            // 
            this.TxtAppliedStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAppliedStatus.Enabled = false;
            this.TxtAppliedStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAppliedStatus.Location = new System.Drawing.Point(953, 49);
            this.TxtAppliedStatus.Name = "TxtAppliedStatus";
            this.TxtAppliedStatus.Size = new System.Drawing.Size(107, 32);
            this.TxtAppliedStatus.TabIndex = 16;
            this.TxtAppliedStatus.Text = "Not Yet";
            this.TxtAppliedStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmStudentDetailJobCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 515);
            this.Controls.Add(this.TxtAppliedStatus);
            this.Controls.Add(this.LbStatusApplied);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.CbMajorJob);
            this.Controls.Add(this.MTextExpirationDate);
            this.Controls.Add(this.TxtNumberOfInterns);
            this.Controls.Add(this.TxtJobDescriptio);
            this.Controls.Add(this.TxtAddressCompany);
            this.Controls.Add(this.LbMajorJob);
            this.Controls.Add(this.LbJobDescription);
            this.Controls.Add(this.LbExpirationDate);
            this.Controls.Add(this.LbNumberOfInterns);
            this.Controls.Add(this.LbAddress);
            this.Controls.Add(this.TxtJobName);
            this.Controls.Add(this.LbJobName);
            this.Controls.Add(this.LbCompanyName);
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(1080, 562);
            this.Name = "FrmStudentDetailJobCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail Job";
            this.Load += new System.EventHandler(this.FrmStudentDetailJobCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbCompanyName;
        private System.Windows.Forms.Label LbJobName;
        private System.Windows.Forms.TextBox TxtJobName;
        private System.Windows.Forms.Label LbAddress;
        private System.Windows.Forms.Label LbNumberOfInterns;
        private System.Windows.Forms.Label LbExpirationDate;
        private System.Windows.Forms.Label LbJobDescription;
        private System.Windows.Forms.Label LbMajorJob;
        private System.Windows.Forms.TextBox TxtAddressCompany;
        private System.Windows.Forms.TextBox TxtJobDescriptio;
        private System.Windows.Forms.TextBox TxtNumberOfInterns;
        private System.Windows.Forms.MaskedTextBox MTextExpirationDate;
        private System.Windows.Forms.ComboBox CbMajorJob;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LbStatusApplied;
        private System.Windows.Forms.TextBox TxtAppliedStatus;
    }
}