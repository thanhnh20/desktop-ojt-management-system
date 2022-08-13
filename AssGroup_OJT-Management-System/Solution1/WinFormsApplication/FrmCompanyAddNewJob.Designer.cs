
namespace WinFormsApplication
{
    partial class FrmCompanyAddNewJob
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
            this.BtnInsertANewJob = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PnLayout1 = new System.Windows.Forms.Panel();
            this.LbJobName = new System.Windows.Forms.Label();
            this.TxtJobName = new System.Windows.Forms.TextBox();
            this.LbNumberOfInterns = new System.Windows.Forms.Label();
            this.TxtNumberOfInterns = new System.Windows.Forms.TextBox();
            this.LbExpirationDate = new System.Windows.Forms.Label();
            this.MTxtExpirationDate = new System.Windows.Forms.MaskedTextBox();
            this.LbJobDescription = new System.Windows.Forms.Label();
            this.TxtJobDescription = new System.Windows.Forms.TextBox();
            this.LbMajorName = new System.Windows.Forms.Label();
            this.cbMajorName = new System.Windows.Forms.ComboBox();
            this.PnHeader.SuspendLayout();
            this.PnControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnHeader
            // 
            this.PnHeader.Controls.Add(this.LbHeader);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(0, 0);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(653, 82);
            this.PnHeader.TabIndex = 0;
            // 
            // LbHeader
            // 
            this.LbHeader.AutoSize = true;
            this.LbHeader.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.LbHeader.Location = new System.Drawing.Point(204, 21);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(243, 45);
            this.LbHeader.TabIndex = 0;
            this.LbHeader.Text = "Add A New Job";
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLayout.Location = new System.Drawing.Point(0, 82);
            this.PnLayout.Name = "PnLayout";
            this.PnLayout.Size = new System.Drawing.Size(653, 1);
            this.PnLayout.TabIndex = 1;
            // 
            // PnControls
            // 
            this.PnControls.Controls.Add(this.BtnInsertANewJob);
            this.PnControls.Controls.Add(this.BtnCancel);
            this.PnControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnControls.Location = new System.Drawing.Point(0, 531);
            this.PnControls.Name = "PnControls";
            this.PnControls.Size = new System.Drawing.Size(653, 105);
            this.PnControls.TabIndex = 2;
            // 
            // BtnInsertANewJob
            // 
            this.BtnInsertANewJob.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnInsertANewJob.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInsertANewJob.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnInsertANewJob.Location = new System.Drawing.Point(367, 33);
            this.BtnInsertANewJob.Name = "BtnInsertANewJob";
            this.BtnInsertANewJob.Size = new System.Drawing.Size(162, 39);
            this.BtnInsertANewJob.TabIndex = 7;
            this.BtnInsertANewJob.Text = "Insert";
            this.BtnInsertANewJob.UseVisualStyleBackColor = true;
            this.BtnInsertANewJob.Click += new System.EventHandler(this.BtnInsertANewJob_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancel.Location = new System.Drawing.Point(124, 33);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(162, 39);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PnLayout1
            // 
            this.PnLayout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnLayout1.Location = new System.Drawing.Point(0, 530);
            this.PnLayout1.Name = "PnLayout1";
            this.PnLayout1.Size = new System.Drawing.Size(653, 1);
            this.PnLayout1.TabIndex = 3;
            // 
            // LbJobName
            // 
            this.LbJobName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbJobName.AutoSize = true;
            this.LbJobName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbJobName.Location = new System.Drawing.Point(92, 127);
            this.LbJobName.Name = "LbJobName";
            this.LbJobName.Size = new System.Drawing.Size(100, 24);
            this.LbJobName.TabIndex = 4;
            this.LbJobName.Text = "Job name: ";
            // 
            // TxtJobName
            // 
            this.TxtJobName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtJobName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtJobName.Location = new System.Drawing.Point(285, 119);
            this.TxtJobName.Name = "TxtJobName";
            this.TxtJobName.Size = new System.Drawing.Size(329, 32);
            this.TxtJobName.TabIndex = 5;
            // 
            // LbNumberOfInterns
            // 
            this.LbNumberOfInterns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbNumberOfInterns.AutoSize = true;
            this.LbNumberOfInterns.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbNumberOfInterns.Location = new System.Drawing.Point(92, 178);
            this.LbNumberOfInterns.Name = "LbNumberOfInterns";
            this.LbNumberOfInterns.Size = new System.Drawing.Size(174, 24);
            this.LbNumberOfInterns.TabIndex = 6;
            this.LbNumberOfInterns.Text = "Number of Interns: ";
            // 
            // TxtNumberOfInterns
            // 
            this.TxtNumberOfInterns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtNumberOfInterns.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumberOfInterns.Location = new System.Drawing.Point(285, 170);
            this.TxtNumberOfInterns.Name = "TxtNumberOfInterns";
            this.TxtNumberOfInterns.Size = new System.Drawing.Size(96, 32);
            this.TxtNumberOfInterns.TabIndex = 7;
            // 
            // LbExpirationDate
            // 
            this.LbExpirationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbExpirationDate.AutoSize = true;
            this.LbExpirationDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbExpirationDate.Location = new System.Drawing.Point(92, 235);
            this.LbExpirationDate.Name = "LbExpirationDate";
            this.LbExpirationDate.Size = new System.Drawing.Size(149, 24);
            this.LbExpirationDate.TabIndex = 8;
            this.LbExpirationDate.Text = "Expiration Date: ";
            // 
            // MTxtExpirationDate
            // 
            this.MTxtExpirationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MTxtExpirationDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MTxtExpirationDate.Location = new System.Drawing.Point(285, 227);
            this.MTxtExpirationDate.Mask = "00/00/0000";
            this.MTxtExpirationDate.Name = "MTxtExpirationDate";
            this.MTxtExpirationDate.Size = new System.Drawing.Size(157, 32);
            this.MTxtExpirationDate.TabIndex = 9;
            this.MTxtExpirationDate.ValidatingType = typeof(System.DateTime);
            // 
            // LbJobDescription
            // 
            this.LbJobDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbJobDescription.AutoSize = true;
            this.LbJobDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbJobDescription.Location = new System.Drawing.Point(92, 286);
            this.LbJobDescription.Name = "LbJobDescription";
            this.LbJobDescription.Size = new System.Drawing.Size(147, 24);
            this.LbJobDescription.TabIndex = 10;
            this.LbJobDescription.Text = "Job Description: ";
            // 
            // TxtJobDescription
            // 
            this.TxtJobDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtJobDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtJobDescription.Location = new System.Drawing.Point(285, 278);
            this.TxtJobDescription.Multiline = true;
            this.TxtJobDescription.Name = "TxtJobDescription";
            this.TxtJobDescription.Size = new System.Drawing.Size(329, 148);
            this.TxtJobDescription.TabIndex = 11;
            // 
            // LbMajorName
            // 
            this.LbMajorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbMajorName.AutoSize = true;
            this.LbMajorName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbMajorName.Location = new System.Drawing.Point(92, 451);
            this.LbMajorName.Name = "LbMajorName";
            this.LbMajorName.Size = new System.Drawing.Size(122, 24);
            this.LbMajorName.TabIndex = 12;
            this.LbMajorName.Text = "Major name: ";
            // 
            // cbMajorName
            // 
            this.cbMajorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMajorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMajorName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbMajorName.FormattingEnabled = true;
            this.cbMajorName.Location = new System.Drawing.Point(285, 443);
            this.cbMajorName.Name = "cbMajorName";
            this.cbMajorName.Size = new System.Drawing.Size(329, 32);
            this.cbMajorName.TabIndex = 13;
            // 
            // FrmCompanyAddNewJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 636);
            this.Controls.Add(this.cbMajorName);
            this.Controls.Add(this.LbMajorName);
            this.Controls.Add(this.TxtJobDescription);
            this.Controls.Add(this.LbJobDescription);
            this.Controls.Add(this.MTxtExpirationDate);
            this.Controls.Add(this.LbExpirationDate);
            this.Controls.Add(this.TxtNumberOfInterns);
            this.Controls.Add(this.LbNumberOfInterns);
            this.Controls.Add(this.TxtJobName);
            this.Controls.Add(this.LbJobName);
            this.Controls.Add(this.PnLayout1);
            this.Controls.Add(this.PnControls);
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.PnHeader);
            this.MaximumSize = new System.Drawing.Size(671, 683);
            this.MinimumSize = new System.Drawing.Size(671, 683);
            this.Name = "FrmCompanyAddNewJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Job";
            this.Load += new System.EventHandler(this.FrmCompanyAddNewJob_Load);
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            this.PnControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Label LbHeader;
        private System.Windows.Forms.Panel PnLayout;
        private System.Windows.Forms.Panel PnControls;
        private System.Windows.Forms.Panel PnLayout1;
        private System.Windows.Forms.Label LbJobName;
        private System.Windows.Forms.TextBox TxtJobName;
        private System.Windows.Forms.Label LbNumberOfInterns;
        private System.Windows.Forms.TextBox TxtNumberOfInterns;
        private System.Windows.Forms.Label LbExpirationDate;
        private System.Windows.Forms.MaskedTextBox MTxtExpirationDate;
        private System.Windows.Forms.Label LbJobDescription;
        private System.Windows.Forms.TextBox TxtJobDescription;
        private System.Windows.Forms.Label LbMajorName;
        private System.Windows.Forms.ComboBox cbMajorName;
        private System.Windows.Forms.Button BtnInsertANewJob;
        private System.Windows.Forms.Button BtnCancel;
    }
}