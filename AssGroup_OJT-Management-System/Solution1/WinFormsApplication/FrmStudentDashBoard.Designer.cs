
namespace WinFormsApplication
{
    partial class FrmStudentDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentDashBoard));
            this.PnDashBoard = new System.Windows.Forms.Panel();
            this.BtnLogOut = new FontAwesome.Sharp.IconButton();
            this.BtnInternshipResult = new FontAwesome.Sharp.IconButton();
            this.BtnStudentApplication = new FontAwesome.Sharp.IconButton();
            this.BtnJobCompanyList = new FontAwesome.Sharp.IconButton();
            this.BtnStudentProfile = new FontAwesome.Sharp.IconButton();
            this.PnLogo = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PnHeader = new System.Windows.Forms.Panel();
            this.PicAvatar = new FontAwesome.Sharp.IconPictureBox();
            this.LbControlHeader = new System.Windows.Forms.Label();
            this.PicIconControlHeader = new FontAwesome.Sharp.IconPictureBox();
            this.PnChildForm = new System.Windows.Forms.Panel();
            this.LbLayout = new System.Windows.Forms.Panel();
            this.LbWelcomeHeader = new System.Windows.Forms.Label();
            this.PnDashBoard.SuspendLayout();
            this.PnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconControlHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // PnDashBoard
            // 
            this.PnDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnDashBoard.Controls.Add(this.BtnLogOut);
            this.PnDashBoard.Controls.Add(this.BtnInternshipResult);
            this.PnDashBoard.Controls.Add(this.BtnStudentApplication);
            this.PnDashBoard.Controls.Add(this.BtnJobCompanyList);
            this.PnDashBoard.Controls.Add(this.BtnStudentProfile);
            this.PnDashBoard.Controls.Add(this.PnLogo);
            this.PnDashBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnDashBoard.Location = new System.Drawing.Point(0, 0);
            this.PnDashBoard.Name = "PnDashBoard";
            this.PnDashBoard.Size = new System.Drawing.Size(250, 700);
            this.PnDashBoard.TabIndex = 0;
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLogOut.FlatAppearance.BorderSize = 0;
            this.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLogOut.ForeColor = System.Drawing.Color.White;
            this.BtnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnLogOut.IconColor = System.Drawing.Color.White;
            this.BtnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnLogOut.IconSize = 40;
            this.BtnLogOut.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnLogOut.Location = new System.Drawing.Point(0, 390);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnLogOut.Size = new System.Drawing.Size(250, 60);
            this.BtnLogOut.TabIndex = 5;
            this.BtnLogOut.Text = "Log out";
            this.BtnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // BtnInternshipResult
            // 
            this.BtnInternshipResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInternshipResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInternshipResult.FlatAppearance.BorderSize = 0;
            this.BtnInternshipResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInternshipResult.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnInternshipResult.ForeColor = System.Drawing.Color.White;
            this.BtnInternshipResult.IconChar = FontAwesome.Sharp.IconChar.Readme;
            this.BtnInternshipResult.IconColor = System.Drawing.Color.White;
            this.BtnInternshipResult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInternshipResult.IconSize = 40;
            this.BtnInternshipResult.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnInternshipResult.Location = new System.Drawing.Point(0, 330);
            this.BtnInternshipResult.Name = "BtnInternshipResult";
            this.BtnInternshipResult.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnInternshipResult.Size = new System.Drawing.Size(250, 60);
            this.BtnInternshipResult.TabIndex = 4;
            this.BtnInternshipResult.Text = "Internship Result";
            this.BtnInternshipResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInternshipResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInternshipResult.UseVisualStyleBackColor = true;
            this.BtnInternshipResult.Click += new System.EventHandler(this.BtnInternshipResult_Click);
            // 
            // BtnStudentApplication
            // 
            this.BtnStudentApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStudentApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStudentApplication.FlatAppearance.BorderSize = 0;
            this.BtnStudentApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStudentApplication.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStudentApplication.ForeColor = System.Drawing.Color.White;
            this.BtnStudentApplication.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.BtnStudentApplication.IconColor = System.Drawing.Color.White;
            this.BtnStudentApplication.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnStudentApplication.IconSize = 40;
            this.BtnStudentApplication.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnStudentApplication.Location = new System.Drawing.Point(0, 270);
            this.BtnStudentApplication.Name = "BtnStudentApplication";
            this.BtnStudentApplication.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnStudentApplication.Size = new System.Drawing.Size(250, 60);
            this.BtnStudentApplication.TabIndex = 3;
            this.BtnStudentApplication.Text = "My Application";
            this.BtnStudentApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStudentApplication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStudentApplication.UseVisualStyleBackColor = true;
            this.BtnStudentApplication.Click += new System.EventHandler(this.BtnStudentApplication_Click);
            // 
            // BtnJobCompanyList
            // 
            this.BtnJobCompanyList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnJobCompanyList.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnJobCompanyList.FlatAppearance.BorderSize = 0;
            this.BtnJobCompanyList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJobCompanyList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnJobCompanyList.ForeColor = System.Drawing.Color.White;
            this.BtnJobCompanyList.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.BtnJobCompanyList.IconColor = System.Drawing.Color.White;
            this.BtnJobCompanyList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnJobCompanyList.IconSize = 40;
            this.BtnJobCompanyList.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnJobCompanyList.Location = new System.Drawing.Point(0, 210);
            this.BtnJobCompanyList.Name = "BtnJobCompanyList";
            this.BtnJobCompanyList.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnJobCompanyList.Size = new System.Drawing.Size(250, 60);
            this.BtnJobCompanyList.TabIndex = 2;
            this.BtnJobCompanyList.Text = "Jobs List";
            this.BtnJobCompanyList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnJobCompanyList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnJobCompanyList.UseVisualStyleBackColor = true;
            this.BtnJobCompanyList.Click += new System.EventHandler(this.BtnJobsList_Click);
            // 
            // BtnStudentProfile
            // 
            this.BtnStudentProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStudentProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStudentProfile.FlatAppearance.BorderSize = 0;
            this.BtnStudentProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStudentProfile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStudentProfile.ForeColor = System.Drawing.Color.White;
            this.BtnStudentProfile.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.BtnStudentProfile.IconColor = System.Drawing.Color.White;
            this.BtnStudentProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnStudentProfile.IconSize = 40;
            this.BtnStudentProfile.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnStudentProfile.Location = new System.Drawing.Point(0, 150);
            this.BtnStudentProfile.Name = "BtnStudentProfile";
            this.BtnStudentProfile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnStudentProfile.Size = new System.Drawing.Size(250, 60);
            this.BtnStudentProfile.TabIndex = 1;
            this.BtnStudentProfile.Text = "My Profile";
            this.BtnStudentProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStudentProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStudentProfile.UseVisualStyleBackColor = true;
            this.BtnStudentProfile.Click += new System.EventHandler(this.BtnStudentProfile_Click);
            // 
            // PnLogo
            // 
            this.PnLogo.BackColor = System.Drawing.Color.Black;
            this.PnLogo.Controls.Add(this.PicLogo);
            this.PnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLogo.Location = new System.Drawing.Point(0, 0);
            this.PnLogo.Name = "PnLogo";
            this.PnLogo.Size = new System.Drawing.Size(250, 150);
            this.PnLogo.TabIndex = 0;
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
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            this.PicLogo.Click += new System.EventHandler(this.PicLogo_Click);
            // 
            // PnHeader
            // 
            this.PnHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PnHeader.Controls.Add(this.LbWelcomeHeader);
            this.PnHeader.Controls.Add(this.PicAvatar);
            this.PnHeader.Controls.Add(this.LbControlHeader);
            this.PnHeader.Controls.Add(this.PicIconControlHeader);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(250, 0);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(1064, 58);
            this.PnHeader.TabIndex = 1;
            // 
            // PicAvatar
            // 
            this.PicAvatar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PicAvatar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PicAvatar.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.PicAvatar.IconColor = System.Drawing.SystemColors.ControlText;
            this.PicAvatar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PicAvatar.IconSize = 40;
            this.PicAvatar.Location = new System.Drawing.Point(792, 12);
            this.PicAvatar.Name = "PicAvatar";
            this.PicAvatar.Size = new System.Drawing.Size(40, 40);
            this.PicAvatar.TabIndex = 0;
            this.PicAvatar.TabStop = false;
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
            // PnChildForm
            // 
            this.PnChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnChildForm.Location = new System.Drawing.Point(250, 58);
            this.PnChildForm.Name = "PnChildForm";
            this.PnChildForm.Size = new System.Drawing.Size(1064, 642);
            this.PnChildForm.TabIndex = 2;
            // 
            // LbLayout
            // 
            this.LbLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.LbLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbLayout.Location = new System.Drawing.Point(250, 58);
            this.LbLayout.Name = "LbLayout";
            this.LbLayout.Size = new System.Drawing.Size(1064, 1);
            this.LbLayout.TabIndex = 3;
            // 
            // LbWelcomeHeader
            // 
            this.LbWelcomeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbWelcomeHeader.AutoSize = true;
            this.LbWelcomeHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbWelcomeHeader.Location = new System.Drawing.Point(838, 18);
            this.LbWelcomeHeader.Name = "LbWelcomeHeader";
            this.LbWelcomeHeader.Size = new System.Drawing.Size(181, 24);
            this.LbWelcomeHeader.TabIndex = 4;
            this.LbWelcomeHeader.Text = "Welcome, Full Name";
            // 
            // FrmStudentDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 700);
            this.Controls.Add(this.LbLayout);
            this.Controls.Add(this.PnChildForm);
            this.Controls.Add(this.PnHeader);
            this.Controls.Add(this.PnDashBoard);
            this.MaximumSize = new System.Drawing.Size(1332, 800);
            this.MinimumSize = new System.Drawing.Size(1329, 747);
            this.Name = "FrmStudentDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management";
            this.Load += new System.EventHandler(this.FrmStudentDashBoard_Load);
            this.PnDashBoard.ResumeLayout(false);
            this.PnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconControlHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnDashBoard;
        private System.Windows.Forms.Panel PnLogo;
        private System.Windows.Forms.PictureBox PicLogo;
        private FontAwesome.Sharp.IconButton BtnLogOut;
        private FontAwesome.Sharp.IconButton BtnInternshipResult;
        private FontAwesome.Sharp.IconButton BtnStudentApplication;
        private FontAwesome.Sharp.IconButton BtnJobCompanyList;
        private FontAwesome.Sharp.IconButton BtnStudentProfile;
        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Panel PnChildForm;
        private System.Windows.Forms.Label LbControlHeader;
        private FontAwesome.Sharp.IconPictureBox PicIconControlHeader;
        private System.Windows.Forms.Panel LbLayout;
        private FontAwesome.Sharp.IconPictureBox PicAvatar;
        private System.Windows.Forms.Label LbWelcomeHeader;
    }
}