
namespace WinFormsApplication
{
    partial class FrmCompanyHome
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
            this.TblLayoutHome = new System.Windows.Forms.TableLayoutPanel();
            this.PnNumberOfInterns = new System.Windows.Forms.Panel();
            this.TxtNumberOfStudents = new System.Windows.Forms.Label();
            this.PicNumberOfStudents = new FontAwesome.Sharp.IconPictureBox();
            this.LbNumberOfStudent = new System.Windows.Forms.Label();
            this.PnNumberOfJobs = new System.Windows.Forms.Panel();
            this.TxtNumberOfJobs = new System.Windows.Forms.Label();
            this.PicNumberOfJobs = new FontAwesome.Sharp.IconPictureBox();
            this.LbNumberOfJobs = new System.Windows.Forms.Label();
            this.PnNumberOfApplication = new System.Windows.Forms.Panel();
            this.TxtNumberOfApplications = new System.Windows.Forms.Label();
            this.PicNumberOfApplication = new FontAwesome.Sharp.IconPictureBox();
            this.LnNumberOfApplication = new System.Windows.Forms.Label();
            this.PnCompanyInformation = new System.Windows.Forms.Panel();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LbEmail = new System.Windows.Forms.Label();
            this.TxtCompanyTax = new System.Windows.Forms.TextBox();
            this.LbCompanyTax = new System.Windows.Forms.Label();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LbCompanyInformation = new System.Windows.Forms.Label();
            this.LbCompanyName = new System.Windows.Forms.Label();
            this.TblLayoutHome.SuspendLayout();
            this.PnNumberOfInterns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNumberOfStudents)).BeginInit();
            this.PnNumberOfJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNumberOfJobs)).BeginInit();
            this.PnNumberOfApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNumberOfApplication)).BeginInit();
            this.PnCompanyInformation.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblLayoutHome
            // 
            this.TblLayoutHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TblLayoutHome.ColumnCount = 3;
            this.TblLayoutHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TblLayoutHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TblLayoutHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TblLayoutHome.Controls.Add(this.PnNumberOfInterns, 0, 0);
            this.TblLayoutHome.Controls.Add(this.PnNumberOfJobs, 1, 0);
            this.TblLayoutHome.Controls.Add(this.PnNumberOfApplication, 2, 0);
            this.TblLayoutHome.Location = new System.Drawing.Point(189, 99);
            this.TblLayoutHome.Name = "TblLayoutHome";
            this.TblLayoutHome.RowCount = 1;
            this.TblLayoutHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblLayoutHome.Size = new System.Drawing.Size(810, 149);
            this.TblLayoutHome.TabIndex = 0;
            // 
            // PnNumberOfInterns
            // 
            this.PnNumberOfInterns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.PnNumberOfInterns.Controls.Add(this.TxtNumberOfStudents);
            this.PnNumberOfInterns.Controls.Add(this.PicNumberOfStudents);
            this.PnNumberOfInterns.Controls.Add(this.LbNumberOfStudent);
            this.PnNumberOfInterns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnNumberOfInterns.Location = new System.Drawing.Point(3, 3);
            this.PnNumberOfInterns.Name = "PnNumberOfInterns";
            this.PnNumberOfInterns.Size = new System.Drawing.Size(264, 143);
            this.PnNumberOfInterns.TabIndex = 0;
            // 
            // TxtNumberOfStudents
            // 
            this.TxtNumberOfStudents.AutoSize = true;
            this.TxtNumberOfStudents.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumberOfStudents.Location = new System.Drawing.Point(107, 99);
            this.TxtNumberOfStudents.Name = "TxtNumberOfStudents";
            this.TxtNumberOfStudents.Size = new System.Drawing.Size(20, 24);
            this.TxtNumberOfStudents.TabIndex = 3;
            this.TxtNumberOfStudents.Text = "0";
            // 
            // PicNumberOfStudents
            // 
            this.PicNumberOfStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.PicNumberOfStudents.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PicNumberOfStudents.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.PicNumberOfStudents.IconColor = System.Drawing.SystemColors.ControlText;
            this.PicNumberOfStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PicNumberOfStudents.IconSize = 40;
            this.PicNumberOfStudents.Location = new System.Drawing.Point(98, 6);
            this.PicNumberOfStudents.Name = "PicNumberOfStudents";
            this.PicNumberOfStudents.Size = new System.Drawing.Size(40, 40);
            this.PicNumberOfStudents.TabIndex = 2;
            this.PicNumberOfStudents.TabStop = false;
            // 
            // LbNumberOfStudent
            // 
            this.LbNumberOfStudent.AutoSize = true;
            this.LbNumberOfStudent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbNumberOfStudent.Location = new System.Drawing.Point(34, 49);
            this.LbNumberOfStudent.Name = "LbNumberOfStudent";
            this.LbNumberOfStudent.Size = new System.Drawing.Size(171, 24);
            this.LbNumberOfStudent.TabIndex = 1;
            this.LbNumberOfStudent.Text = "Number of Student";
            // 
            // PnNumberOfJobs
            // 
            this.PnNumberOfJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.PnNumberOfJobs.Controls.Add(this.TxtNumberOfJobs);
            this.PnNumberOfJobs.Controls.Add(this.PicNumberOfJobs);
            this.PnNumberOfJobs.Controls.Add(this.LbNumberOfJobs);
            this.PnNumberOfJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnNumberOfJobs.Location = new System.Drawing.Point(273, 3);
            this.PnNumberOfJobs.Name = "PnNumberOfJobs";
            this.PnNumberOfJobs.Size = new System.Drawing.Size(264, 143);
            this.PnNumberOfJobs.TabIndex = 1;
            // 
            // TxtNumberOfJobs
            // 
            this.TxtNumberOfJobs.AutoSize = true;
            this.TxtNumberOfJobs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumberOfJobs.Location = new System.Drawing.Point(124, 99);
            this.TxtNumberOfJobs.Name = "TxtNumberOfJobs";
            this.TxtNumberOfJobs.Size = new System.Drawing.Size(20, 24);
            this.TxtNumberOfJobs.TabIndex = 4;
            this.TxtNumberOfJobs.Text = "0";
            // 
            // PicNumberOfJobs
            // 
            this.PicNumberOfJobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.PicNumberOfJobs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PicNumberOfJobs.IconChar = FontAwesome.Sharp.IconChar.BusinessTime;
            this.PicNumberOfJobs.IconColor = System.Drawing.SystemColors.ControlText;
            this.PicNumberOfJobs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PicNumberOfJobs.IconSize = 40;
            this.PicNumberOfJobs.Location = new System.Drawing.Point(115, 6);
            this.PicNumberOfJobs.Name = "PicNumberOfJobs";
            this.PicNumberOfJobs.Size = new System.Drawing.Size(40, 40);
            this.PicNumberOfJobs.TabIndex = 3;
            this.PicNumberOfJobs.TabStop = false;
            // 
            // LbNumberOfJobs
            // 
            this.LbNumberOfJobs.AutoSize = true;
            this.LbNumberOfJobs.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbNumberOfJobs.Location = new System.Drawing.Point(53, 49);
            this.LbNumberOfJobs.Name = "LbNumberOfJobs";
            this.LbNumberOfJobs.Size = new System.Drawing.Size(141, 24);
            this.LbNumberOfJobs.TabIndex = 2;
            this.LbNumberOfJobs.Text = "Number of Jobs";
            // 
            // PnNumberOfApplication
            // 
            this.PnNumberOfApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.PnNumberOfApplication.Controls.Add(this.TxtNumberOfApplications);
            this.PnNumberOfApplication.Controls.Add(this.PicNumberOfApplication);
            this.PnNumberOfApplication.Controls.Add(this.LnNumberOfApplication);
            this.PnNumberOfApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnNumberOfApplication.Location = new System.Drawing.Point(543, 3);
            this.PnNumberOfApplication.Name = "PnNumberOfApplication";
            this.PnNumberOfApplication.Size = new System.Drawing.Size(264, 143);
            this.PnNumberOfApplication.TabIndex = 2;
            // 
            // TxtNumberOfApplications
            // 
            this.TxtNumberOfApplications.AutoSize = true;
            this.TxtNumberOfApplications.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtNumberOfApplications.Location = new System.Drawing.Point(121, 99);
            this.TxtNumberOfApplications.Name = "TxtNumberOfApplications";
            this.TxtNumberOfApplications.Size = new System.Drawing.Size(20, 24);
            this.TxtNumberOfApplications.TabIndex = 4;
            this.TxtNumberOfApplications.Text = "0";
            // 
            // PicNumberOfApplication
            // 
            this.PicNumberOfApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.PicNumberOfApplication.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PicNumberOfApplication.IconChar = FontAwesome.Sharp.IconChar.Pager;
            this.PicNumberOfApplication.IconColor = System.Drawing.SystemColors.ControlText;
            this.PicNumberOfApplication.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PicNumberOfApplication.IconSize = 40;
            this.PicNumberOfApplication.Location = new System.Drawing.Point(112, 6);
            this.PicNumberOfApplication.Name = "PicNumberOfApplication";
            this.PicNumberOfApplication.Size = new System.Drawing.Size(40, 40);
            this.PicNumberOfApplication.TabIndex = 3;
            this.PicNumberOfApplication.TabStop = false;
            // 
            // LnNumberOfApplication
            // 
            this.LnNumberOfApplication.AutoSize = true;
            this.LnNumberOfApplication.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LnNumberOfApplication.Location = new System.Drawing.Point(22, 49);
            this.LnNumberOfApplication.Name = "LnNumberOfApplication";
            this.LnNumberOfApplication.Size = new System.Drawing.Size(208, 24);
            this.LnNumberOfApplication.TabIndex = 2;
            this.LnNumberOfApplication.Text = "Number of Applications";
            // 
            // PnCompanyInformation
            // 
            this.PnCompanyInformation.BackColor = System.Drawing.Color.White;
            this.PnCompanyInformation.Controls.Add(this.TxtEmail);
            this.PnCompanyInformation.Controls.Add(this.LbEmail);
            this.PnCompanyInformation.Controls.Add(this.TxtCompanyTax);
            this.PnCompanyInformation.Controls.Add(this.LbCompanyTax);
            this.PnCompanyInformation.Controls.Add(this.TxtCompanyName);
            this.PnCompanyInformation.Controls.Add(this.panel2);
            this.PnCompanyInformation.Controls.Add(this.LbCompanyName);
            this.PnCompanyInformation.Location = new System.Drawing.Point(192, 291);
            this.PnCompanyInformation.Name = "PnCompanyInformation";
            this.PnCompanyInformation.Size = new System.Drawing.Size(754, 243);
            this.PnCompanyInformation.TabIndex = 1;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEmail.Location = new System.Drawing.Point(201, 179);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(384, 32);
            this.TxtEmail.TabIndex = 15;
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbEmail.Location = new System.Drawing.Point(34, 187);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(66, 24);
            this.LbEmail.TabIndex = 14;
            this.LbEmail.Text = "Email: ";
            // 
            // TxtCompanyTax
            // 
            this.TxtCompanyTax.Enabled = false;
            this.TxtCompanyTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCompanyTax.Location = new System.Drawing.Point(201, 138);
            this.TxtCompanyTax.Name = "TxtCompanyTax";
            this.TxtCompanyTax.Size = new System.Drawing.Size(246, 32);
            this.TxtCompanyTax.TabIndex = 13;
            // 
            // LbCompanyTax
            // 
            this.LbCompanyTax.AutoSize = true;
            this.LbCompanyTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCompanyTax.Location = new System.Drawing.Point(34, 146);
            this.LbCompanyTax.Name = "LbCompanyTax";
            this.LbCompanyTax.Size = new System.Drawing.Size(130, 24);
            this.LbCompanyTax.TabIndex = 12;
            this.LbCompanyTax.Text = "Company tax: ";
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Enabled = false;
            this.TxtCompanyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCompanyName.Location = new System.Drawing.Point(201, 94);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(384, 32);
            this.TxtCompanyName.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panel2.Controls.Add(this.LbCompanyInformation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 80);
            this.panel2.TabIndex = 0;
            // 
            // LbCompanyInformation
            // 
            this.LbCompanyInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbCompanyInformation.AutoSize = true;
            this.LbCompanyInformation.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCompanyInformation.ForeColor = System.Drawing.Color.White;
            this.LbCompanyInformation.Location = new System.Drawing.Point(230, 22);
            this.LbCompanyInformation.Name = "LbCompanyInformation";
            this.LbCompanyInformation.Size = new System.Drawing.Size(284, 37);
            this.LbCompanyInformation.TabIndex = 1;
            this.LbCompanyInformation.Text = "Company Information";
            // 
            // LbCompanyName
            // 
            this.LbCompanyName.AutoSize = true;
            this.LbCompanyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCompanyName.Location = new System.Drawing.Point(34, 102);
            this.LbCompanyName.Name = "LbCompanyName";
            this.LbCompanyName.Size = new System.Drawing.Size(151, 24);
            this.LbCompanyName.TabIndex = 10;
            this.LbCompanyName.Text = "Company name: ";
            // 
            // FrmCompanyHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 577);
            this.Controls.Add(this.PnCompanyInformation);
            this.Controls.Add(this.TblLayoutHome);
            this.Name = "FrmCompanyHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmCompanyHome_Load);
            this.TblLayoutHome.ResumeLayout(false);
            this.PnNumberOfInterns.ResumeLayout(false);
            this.PnNumberOfInterns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNumberOfStudents)).EndInit();
            this.PnNumberOfJobs.ResumeLayout(false);
            this.PnNumberOfJobs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNumberOfJobs)).EndInit();
            this.PnNumberOfApplication.ResumeLayout(false);
            this.PnNumberOfApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNumberOfApplication)).EndInit();
            this.PnCompanyInformation.ResumeLayout(false);
            this.PnCompanyInformation.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblLayoutHome;
        private System.Windows.Forms.Panel PnNumberOfInterns;
        private System.Windows.Forms.Label TxtNumberOfStudents;
        private FontAwesome.Sharp.IconPictureBox PicNumberOfStudents;
        private System.Windows.Forms.Label LbNumberOfStudent;
        private System.Windows.Forms.Panel PnNumberOfJobs;
        private System.Windows.Forms.Label TxtNumberOfJobs;
        private FontAwesome.Sharp.IconPictureBox PicNumberOfJobs;
        private System.Windows.Forms.Label LbNumberOfJobs;
        private System.Windows.Forms.Panel PnNumberOfApplication;
        private System.Windows.Forms.Label TxtNumberOfApplications;
        private FontAwesome.Sharp.IconPictureBox PicNumberOfApplication;
        private System.Windows.Forms.Label LnNumberOfApplication;
        private System.Windows.Forms.Panel PnCompanyInformation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LbCompanyInformation;
        private System.Windows.Forms.TextBox TxtStudentName;
        private System.Windows.Forms.Label LbCompanyName;
        private System.Windows.Forms.TextBox TxtCompanyTax;
        private System.Windows.Forms.Label LbCompanyTax;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.TextBox TxtCompanyName;
    }
}