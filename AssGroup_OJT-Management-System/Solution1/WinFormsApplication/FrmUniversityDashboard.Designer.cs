
namespace WinFormsApplication
{
    partial class FrmUniversityDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUniversityDashboard));
            this.PnUniversityDashboard = new System.Windows.Forms.Panel();
            this.BtnLogout = new FontAwesome.Sharp.IconButton();
            this.BtnCompanyJobManagement = new FontAwesome.Sharp.IconButton();
            this.BtnCompanyManagement = new FontAwesome.Sharp.IconButton();
            this.BtnStudentManagement = new FontAwesome.Sharp.IconButton();
            this.PnUniversityLogo = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PnChildForm = new System.Windows.Forms.Panel();
            this.PnHeader = new System.Windows.Forms.Panel();
            this.TxtCurrentSemester = new System.Windows.Forms.Label();
            this.LbCurrentSemester = new System.Windows.Forms.Label();
            this.LbControlHeader = new System.Windows.Forms.Label();
            this.PicIconControlHeader = new FontAwesome.Sharp.IconPictureBox();
            this.PnLayout = new System.Windows.Forms.Panel();
            this.PnUniversityDashboard.SuspendLayout();
            this.PnUniversityLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconControlHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // PnUniversityDashboard
            // 
            this.PnUniversityDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnUniversityDashboard.Controls.Add(this.BtnLogout);
            this.PnUniversityDashboard.Controls.Add(this.BtnCompanyJobManagement);
            this.PnUniversityDashboard.Controls.Add(this.BtnCompanyManagement);
            this.PnUniversityDashboard.Controls.Add(this.BtnStudentManagement);
            this.PnUniversityDashboard.Controls.Add(this.PnUniversityLogo);
            this.PnUniversityDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnUniversityDashboard.Location = new System.Drawing.Point(0, 0);
            this.PnUniversityDashboard.Name = "PnUniversityDashboard";
            this.PnUniversityDashboard.Size = new System.Drawing.Size(250, 700);
            this.PnUniversityDashboard.TabIndex = 0;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnLogout.IconColor = System.Drawing.Color.White;
            this.BtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLogout.IconSize = 40;
            this.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnLogout.Location = new System.Drawing.Point(0, 330);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnLogout.Size = new System.Drawing.Size(250, 60);
            this.BtnLogout.TabIndex = 5;
            this.BtnLogout.Text = "Log out";
            this.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnCompanyJobManagement
            // 
            this.BtnCompanyJobManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCompanyJobManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCompanyJobManagement.FlatAppearance.BorderSize = 0;
            this.BtnCompanyJobManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompanyJobManagement.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCompanyJobManagement.ForeColor = System.Drawing.Color.White;
            this.BtnCompanyJobManagement.IconChar = FontAwesome.Sharp.IconChar.Paste;
            this.BtnCompanyJobManagement.IconColor = System.Drawing.Color.White;
            this.BtnCompanyJobManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCompanyJobManagement.IconSize = 40;
            this.BtnCompanyJobManagement.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnCompanyJobManagement.Location = new System.Drawing.Point(0, 270);
            this.BtnCompanyJobManagement.Name = "BtnCompanyJobManagement";
            this.BtnCompanyJobManagement.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCompanyJobManagement.Size = new System.Drawing.Size(250, 60);
            this.BtnCompanyJobManagement.TabIndex = 3;
            this.BtnCompanyJobManagement.Text = "Company Job";
            this.BtnCompanyJobManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompanyJobManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCompanyJobManagement.UseVisualStyleBackColor = true;
            this.BtnCompanyJobManagement.Click += new System.EventHandler(this.BtnCompanyPostManagement_Click);
            // 
            // BtnCompanyManagement
            // 
            this.BtnCompanyManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCompanyManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCompanyManagement.FlatAppearance.BorderSize = 0;
            this.BtnCompanyManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompanyManagement.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCompanyManagement.ForeColor = System.Drawing.Color.White;
            this.BtnCompanyManagement.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.BtnCompanyManagement.IconColor = System.Drawing.Color.White;
            this.BtnCompanyManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCompanyManagement.IconSize = 40;
            this.BtnCompanyManagement.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnCompanyManagement.Location = new System.Drawing.Point(0, 210);
            this.BtnCompanyManagement.Name = "BtnCompanyManagement";
            this.BtnCompanyManagement.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCompanyManagement.Size = new System.Drawing.Size(250, 60);
            this.BtnCompanyManagement.TabIndex = 2;
            this.BtnCompanyManagement.Text = "Company List";
            this.BtnCompanyManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompanyManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCompanyManagement.UseVisualStyleBackColor = true;
            this.BtnCompanyManagement.Click += new System.EventHandler(this.BtnCompanyManagement_Click);
            // 
            // BtnStudentManagement
            // 
            this.BtnStudentManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStudentManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStudentManagement.FlatAppearance.BorderSize = 0;
            this.BtnStudentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStudentManagement.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStudentManagement.ForeColor = System.Drawing.Color.White;
            this.BtnStudentManagement.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.BtnStudentManagement.IconColor = System.Drawing.Color.White;
            this.BtnStudentManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnStudentManagement.IconSize = 40;
            this.BtnStudentManagement.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnStudentManagement.Location = new System.Drawing.Point(0, 150);
            this.BtnStudentManagement.Name = "BtnStudentManagement";
            this.BtnStudentManagement.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnStudentManagement.Size = new System.Drawing.Size(250, 60);
            this.BtnStudentManagement.TabIndex = 1;
            this.BtnStudentManagement.Text = "Student List";
            this.BtnStudentManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStudentManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStudentManagement.UseVisualStyleBackColor = true;
            this.BtnStudentManagement.Click += new System.EventHandler(this.BtnStudentManagement_Click);
            // 
            // PnUniversityLogo
            // 
            this.PnUniversityLogo.BackColor = System.Drawing.Color.Black;
            this.PnUniversityLogo.Controls.Add(this.PicLogo);
            this.PnUniversityLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnUniversityLogo.Location = new System.Drawing.Point(0, 0);
            this.PnUniversityLogo.Name = "PnUniversityLogo";
            this.PnUniversityLogo.Size = new System.Drawing.Size(250, 150);
            this.PnUniversityLogo.TabIndex = 0;
            // 
            // PicLogo
            // 
            this.PicLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.InitialImage = null;
            this.PicLogo.Location = new System.Drawing.Point(0, 18);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(250, 117);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 1;
            this.PicLogo.TabStop = false;
            this.PicLogo.Click += new System.EventHandler(this.PicLogo_Click);
            // 
            // PnChildForm
            // 
            this.PnChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnChildForm.Location = new System.Drawing.Point(250, 58);
            this.PnChildForm.Name = "PnChildForm";
            this.PnChildForm.Size = new System.Drawing.Size(1064, 642);
            this.PnChildForm.TabIndex = 4;
            // 
            // PnHeader
            // 
            this.PnHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PnHeader.Controls.Add(this.TxtCurrentSemester);
            this.PnHeader.Controls.Add(this.LbCurrentSemester);
            this.PnHeader.Controls.Add(this.LbControlHeader);
            this.PnHeader.Controls.Add(this.PicIconControlHeader);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(250, 0);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(1064, 58);
            this.PnHeader.TabIndex = 3;
            // 
            // TxtCurrentSemester
            // 
            this.TxtCurrentSemester.AutoSize = true;
            this.TxtCurrentSemester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCurrentSemester.Location = new System.Drawing.Point(902, 18);
            this.TxtCurrentSemester.Name = "TxtCurrentSemester";
            this.TxtCurrentSemester.Size = new System.Drawing.Size(124, 24);
            this.TxtCurrentSemester.TabIndex = 3;
            this.TxtCurrentSemester.Text = "Summer 2022";
            // 
            // LbCurrentSemester
            // 
            this.LbCurrentSemester.AutoSize = true;
            this.LbCurrentSemester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCurrentSemester.Location = new System.Drawing.Point(788, 18);
            this.LbCurrentSemester.Name = "LbCurrentSemester";
            this.LbCurrentSemester.Size = new System.Drawing.Size(97, 24);
            this.LbCurrentSemester.TabIndex = 2;
            this.LbCurrentSemester.Text = "Semester: ";
            // 
            // LbControlHeader
            // 
            this.LbControlHeader.AutoSize = true;
            this.LbControlHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbControlHeader.Location = new System.Drawing.Point(65, 22);
            this.LbControlHeader.Name = "LbControlHeader";
            this.LbControlHeader.Size = new System.Drawing.Size(59, 24);
            this.LbControlHeader.TabIndex = 1;
            this.LbControlHeader.Text = "Home";
            // 
            // PicIconControlHeader
            // 
            this.PicIconControlHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PicIconControlHeader.ForeColor = System.Drawing.Color.Black;
            this.PicIconControlHeader.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.PicIconControlHeader.IconColor = System.Drawing.Color.Black;
            this.PicIconControlHeader.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PicIconControlHeader.IconSize = 40;
            this.PicIconControlHeader.Location = new System.Drawing.Point(19, 18);
            this.PicIconControlHeader.Name = "PicIconControlHeader";
            this.PicIconControlHeader.Size = new System.Drawing.Size(40, 40);
            this.PicIconControlHeader.TabIndex = 0;
            this.PicIconControlHeader.TabStop = false;
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLayout.Location = new System.Drawing.Point(250, 58);
            this.PnLayout.Name = "PnLayout";
            this.PnLayout.Size = new System.Drawing.Size(1064, 1);
            this.PnLayout.TabIndex = 5;
            // 
            // FrmUniversityDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 700);
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.PnChildForm);
            this.Controls.Add(this.PnHeader);
            this.Controls.Add(this.PnUniversityDashboard);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximumSize = new System.Drawing.Size(1332, 800);
            this.MinimumSize = new System.Drawing.Size(1332, 747);
            this.Name = "FrmUniversityDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University Management";
            this.Load += new System.EventHandler(this.FrmUniversityDashboard_Load);
            this.PnUniversityDashboard.ResumeLayout(false);
            this.PnUniversityLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconControlHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnUniversityDashboard;
        private System.Windows.Forms.Panel PnUniversityLogo;
        private FontAwesome.Sharp.IconButton BtnStudentManagement;
        private FontAwesome.Sharp.IconButton BtnLogout;
        private FontAwesome.Sharp.IconButton BtnCompanyJobManagement;
        private FontAwesome.Sharp.IconButton BtnCompanyManagement;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Panel PnChildForm;
        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Label LbControlHeader;
        private FontAwesome.Sharp.IconPictureBox PicIconControlHeader;
        private System.Windows.Forms.Panel PnLayout;
        private System.Windows.Forms.Label TxtCurrentSemester;
        private System.Windows.Forms.Label LbCurrentSemester;
    }
}