
namespace WinFormsApplication
{
    partial class FrmCompanyEvaluateInterns
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
            this.PnControls = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LbStudentID = new System.Windows.Forms.Label();
            this.LbStudentName = new System.Windows.Forms.Label();
            this.LbJobName = new System.Windows.Forms.Label();
            this.LbGrade = new System.Windows.Forms.Label();
            this.LbComment = new System.Windows.Forms.Label();
            this.TxtStudentID = new System.Windows.Forms.TextBox();
            this.TxtStudentName = new System.Windows.Forms.TextBox();
            this.TxtJobName = new System.Windows.Forms.TextBox();
            this.TxtComment = new System.Windows.Forms.TextBox();
            this.CbGrade = new System.Windows.Forms.ComboBox();
            this.PnLayout = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.PnHeader.Size = new System.Drawing.Size(493, 92);
            this.PnHeader.TabIndex = 0;
            // 
            // LbHeader
            // 
            this.LbHeader.AutoSize = true;
            this.LbHeader.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.LbHeader.Location = new System.Drawing.Point(87, 24);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(334, 45);
            this.LbHeader.TabIndex = 0;
            this.LbHeader.Text = "Internship Evaluation";
            // 
            // PnControls
            // 
            this.PnControls.Controls.Add(this.BtnUpdate);
            this.PnControls.Controls.Add(this.BtnCancel);
            this.PnControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnControls.Location = new System.Drawing.Point(0, 497);
            this.PnControls.Name = "PnControls";
            this.PnControls.Size = new System.Drawing.Size(493, 108);
            this.PnControls.TabIndex = 1;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnUpdate.Location = new System.Drawing.Point(287, 35);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(162, 39);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Evaluate";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancel.Location = new System.Drawing.Point(44, 35);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(162, 39);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LbStudentID
            // 
            this.LbStudentID.AutoSize = true;
            this.LbStudentID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStudentID.Location = new System.Drawing.Point(42, 123);
            this.LbStudentID.Name = "LbStudentID";
            this.LbStudentID.Size = new System.Drawing.Size(120, 24);
            this.LbStudentID.TabIndex = 2;
            this.LbStudentID.Text = "Student\'s ID: ";
            // 
            // LbStudentName
            // 
            this.LbStudentName.AutoSize = true;
            this.LbStudentName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbStudentName.Location = new System.Drawing.Point(42, 175);
            this.LbStudentName.Name = "LbStudentName";
            this.LbStudentName.Size = new System.Drawing.Size(140, 24);
            this.LbStudentName.TabIndex = 3;
            this.LbStudentName.Text = "Student Name: ";
            // 
            // LbJobName
            // 
            this.LbJobName.AutoSize = true;
            this.LbJobName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbJobName.Location = new System.Drawing.Point(42, 220);
            this.LbJobName.Name = "LbJobName";
            this.LbJobName.Size = new System.Drawing.Size(100, 24);
            this.LbJobName.TabIndex = 4;
            this.LbJobName.Text = "Job name: ";
            // 
            // LbGrade
            // 
            this.LbGrade.AutoSize = true;
            this.LbGrade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbGrade.Location = new System.Drawing.Point(42, 268);
            this.LbGrade.Name = "LbGrade";
            this.LbGrade.Size = new System.Drawing.Size(71, 24);
            this.LbGrade.TabIndex = 5;
            this.LbGrade.Text = "Grade: ";
            // 
            // LbComment
            // 
            this.LbComment.AutoSize = true;
            this.LbComment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbComment.Location = new System.Drawing.Point(42, 319);
            this.LbComment.Name = "LbComment";
            this.LbComment.Size = new System.Drawing.Size(102, 24);
            this.LbComment.TabIndex = 6;
            this.LbComment.Text = "Comment: ";
            // 
            // TxtStudentID
            // 
            this.TxtStudentID.Enabled = false;
            this.TxtStudentID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStudentID.Location = new System.Drawing.Point(197, 109);
            this.TxtStudentID.Name = "TxtStudentID";
            this.TxtStudentID.Size = new System.Drawing.Size(189, 32);
            this.TxtStudentID.TabIndex = 7;
            // 
            // TxtStudentName
            // 
            this.TxtStudentName.Enabled = false;
            this.TxtStudentName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtStudentName.Location = new System.Drawing.Point(197, 167);
            this.TxtStudentName.Name = "TxtStudentName";
            this.TxtStudentName.Size = new System.Drawing.Size(266, 32);
            this.TxtStudentName.TabIndex = 8;
            // 
            // TxtJobName
            // 
            this.TxtJobName.Enabled = false;
            this.TxtJobName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtJobName.Location = new System.Drawing.Point(197, 212);
            this.TxtJobName.Name = "TxtJobName";
            this.TxtJobName.Size = new System.Drawing.Size(266, 32);
            this.TxtJobName.TabIndex = 9;
            // 
            // TxtComment
            // 
            this.TxtComment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtComment.Location = new System.Drawing.Point(197, 311);
            this.TxtComment.Multiline = true;
            this.TxtComment.Name = "TxtComment";
            this.TxtComment.Size = new System.Drawing.Size(266, 159);
            this.TxtComment.TabIndex = 10;
            // 
            // CbGrade
            // 
            this.CbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbGrade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbGrade.FormattingEnabled = true;
            this.CbGrade.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CbGrade.Location = new System.Drawing.Point(197, 260);
            this.CbGrade.Name = "CbGrade";
            this.CbGrade.Size = new System.Drawing.Size(107, 32);
            this.CbGrade.TabIndex = 11;
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLayout.Location = new System.Drawing.Point(0, 92);
            this.PnLayout.Name = "PnLayout";
            this.PnLayout.Size = new System.Drawing.Size(493, 1);
            this.PnLayout.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 496);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 1);
            this.panel1.TabIndex = 13;
            // 
            // FrmCompanyEvaluateInterns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.CbGrade);
            this.Controls.Add(this.TxtComment);
            this.Controls.Add(this.TxtJobName);
            this.Controls.Add(this.TxtStudentName);
            this.Controls.Add(this.TxtStudentID);
            this.Controls.Add(this.LbComment);
            this.Controls.Add(this.LbGrade);
            this.Controls.Add(this.LbJobName);
            this.Controls.Add(this.LbStudentName);
            this.Controls.Add(this.LbStudentID);
            this.Controls.Add(this.PnControls);
            this.Controls.Add(this.PnHeader);
            this.MaximumSize = new System.Drawing.Size(511, 652);
            this.MinimumSize = new System.Drawing.Size(511, 652);
            this.Name = "FrmCompanyEvaluateInterns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluate Inernship";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCompanyEvaluateInterns_FormClosing);
            this.Load += new System.EventHandler(this.FrmCompanyEvaluateInterns_Load);
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            this.PnControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Label LbHeader;
        private System.Windows.Forms.Panel PnControls;
        private System.Windows.Forms.Label LbStudentID;
        private System.Windows.Forms.Label LbStudentName;
        private System.Windows.Forms.Label LbJobName;
        private System.Windows.Forms.Label LbGrade;
        private System.Windows.Forms.Label LbComment;
        private System.Windows.Forms.TextBox TxtStudentID;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.TextBox TxtJobName;
        private System.Windows.Forms.TextBox TxtComment;
        private System.Windows.Forms.ComboBox CbGrade;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel PnLayout;
        private System.Windows.Forms.Panel panel1;
    }
}