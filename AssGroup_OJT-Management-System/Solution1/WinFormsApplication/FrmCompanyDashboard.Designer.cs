
namespace WinFormsApplication
{
    partial class FrmCompanyDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompanyDashboard));
            this.PnLogo = new System.Windows.Forms.Panel();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.BtnCompanyProfile = new FontAwesome.Sharp.IconButton();
            this.PnHeader = new System.Windows.Forms.Panel();
            this.LbWelcomeHeader = new System.Windows.Forms.Label();
            this.PicAvatar = new FontAwesome.Sharp.IconPictureBox();
            this.LbControlHeader = new System.Windows.Forms.Label();
            this.PicIconControlHeader = new FontAwesome.Sharp.IconPictureBox();
            this.PnDashBoard = new System.Windows.Forms.Panel();
            this.BtnLogOut = new FontAwesome.Sharp.IconButton();
            this.BtnInternsList = new FontAwesome.Sharp.IconButton();
            this.BtnStudentRegisterJob = new FontAwesome.Sharp.IconButton();
            this.BtnJobCompanyList = new FontAwesome.Sharp.IconButton();
            this.PnChildForm = new System.Windows.Forms.Panel();
            this.PnLayout = new System.Windows.Forms.Panel();
            this.PnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconControlHeader)).BeginInit();
            this.PnDashBoard.SuspendLayout();
            this.SuspendLayout();
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
            // BtnCompanyProfile
            // 
            this.BtnCompanyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCompanyProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCompanyProfile.FlatAppearance.BorderSize = 0;
            this.BtnCompanyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompanyProfile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCompanyProfile.ForeColor = System.Drawing.Color.White;
            this.BtnCompanyProfile.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.BtnCompanyProfile.IconColor = System.Drawing.Color.White;
            this.BtnCompanyProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCompanyProfile.IconSize = 40;
            this.BtnCompanyProfile.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnCompanyProfile.Location = new System.Drawing.Point(0, 150);
            this.BtnCompanyProfile.Name = "BtnCompanyProfile";
            this.BtnCompanyProfile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCompanyProfile.Size = new System.Drawing.Size(250, 60);
            this.BtnCompanyProfile.TabIndex = 1;
            this.BtnCompanyProfile.Text = "My Profile";
            this.BtnCompanyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompanyProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCompanyProfile.UseVisualStyleBackColor = true;
            this.BtnCompanyProfile.Click += new System.EventHandler(this.BtnCompanyProfile_Click);
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
            this.PnHeader.TabIndex = 4;
            // 
            // LbWelcomeHeader
            // 
            this.LbWelcomeHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbWelcomeHeader.AutoSize = true;
            this.LbWelcomeHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbWelcomeHeader.Location = new System.Drawing.Point(854, 18);
            this.LbWelcomeHeader.Name = "LbWelcomeHeader";
            this.LbWelcomeHeader.Size = new System.Drawing.Size(181, 24);
            this.LbWelcomeHeader.TabIndex = 3;
            this.LbWelcomeHeader.Text = "Welcome, Full Name";
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
            // PnDashBoard
            // 
            this.PnDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnDashBoard.Controls.Add(this.BtnLogOut);
            this.PnDashBoard.Controls.Add(this.BtnInternsList);
            this.PnDashBoard.Controls.Add(this.BtnStudentRegisterJob);
            this.PnDashBoard.Controls.Add(this.BtnJobCompanyList);
            this.PnDashBoard.Controls.Add(this.BtnCompanyProfile);
            this.PnDashBoard.Controls.Add(this.PnLogo);
            this.PnDashBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnDashBoard.Location = new System.Drawing.Point(0, 0);
            this.PnDashBoard.Name = "PnDashBoard";
            this.PnDashBoard.Size = new System.Drawing.Size(250, 700);
            this.PnDashBoard.TabIndex = 3;
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
            // BtnInternsList
            // 
            this.BtnInternsList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInternsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInternsList.FlatAppearance.BorderSize = 0;
            this.BtnInternsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInternsList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnInternsList.ForeColor = System.Drawing.Color.White;
            this.BtnInternsList.IconChar = FontAwesome.Sharp.IconChar.Readme;
            this.BtnInternsList.IconColor = System.Drawing.Color.White;
            this.BtnInternsList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnInternsList.IconSize = 40;
            this.BtnInternsList.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnInternsList.Location = new System.Drawing.Point(0, 330);
            this.BtnInternsList.Name = "BtnInternsList";
            this.BtnInternsList.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnInternsList.Size = new System.Drawing.Size(250, 60);
            this.BtnInternsList.TabIndex = 4;
            this.BtnInternsList.Text = "Interns List";
            this.BtnInternsList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInternsList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInternsList.UseVisualStyleBackColor = true;
            this.BtnInternsList.Click += new System.EventHandler(this.BtnInternsList_Click);
            // 
            // BtnStudentRegisterJob
            // 
            this.BtnStudentRegisterJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStudentRegisterJob.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStudentRegisterJob.FlatAppearance.BorderSize = 0;
            this.BtnStudentRegisterJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStudentRegisterJob.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStudentRegisterJob.ForeColor = System.Drawing.Color.White;
            this.BtnStudentRegisterJob.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.BtnStudentRegisterJob.IconColor = System.Drawing.Color.White;
            this.BtnStudentRegisterJob.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnStudentRegisterJob.IconSize = 40;
            this.BtnStudentRegisterJob.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnStudentRegisterJob.Location = new System.Drawing.Point(0, 270);
            this.BtnStudentRegisterJob.Name = "BtnStudentRegisterJob";
            this.BtnStudentRegisterJob.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnStudentRegisterJob.Size = new System.Drawing.Size(250, 60);
            this.BtnStudentRegisterJob.TabIndex = 3;
            this.BtnStudentRegisterJob.Text = "Interns Application";
            this.BtnStudentRegisterJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStudentRegisterJob.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStudentRegisterJob.UseVisualStyleBackColor = true;
            this.BtnStudentRegisterJob.Click += new System.EventHandler(this.BtnStudentRegisterJob_Click);
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
            this.BtnJobCompanyList.Click += new System.EventHandler(this.BtnJobCompanyList_Click);
            // 
            // PnChildForm
            // 
            this.PnChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnChildForm.Location = new System.Drawing.Point(250, 58);
            this.PnChildForm.Name = "PnChildForm";
            this.PnChildForm.Size = new System.Drawing.Size(1064, 642);
            this.PnChildForm.TabIndex = 5;
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLayout.Location = new System.Drawing.Point(250, 58);
            this.PnLayout.Name = "PnLayout";
            this.PnLayout.Size = new System.Drawing.Size(1064, 1);
            this.PnLayout.TabIndex = 6;
            // 
            // FrmCompanyDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 700);
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.PnChildForm);
            this.Controls.Add(this.PnHeader);
            this.Controls.Add(this.PnDashBoard);
            this.MaximumSize = new System.Drawing.Size(1332, 747);
            this.MinimumSize = new System.Drawing.Size(1332, 747);
            this.Name = "FrmCompanyDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCompanyDashboard";
            this.Load += new System.EventHandler(this.FrmCompanyDashboard_Load);
            this.PnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconControlHeader)).EndInit();
            this.PnDashBoard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnLogo;
        private System.Windows.Forms.PictureBox PicLogo;
        private FontAwesome.Sharp.IconButton BtnCompanyProfile;
        private System.Windows.Forms.Panel PnHeader;
        private FontAwesome.Sharp.IconPictureBox PicAvatar;
        private System.Windows.Forms.Label LbControlHeader;
        private FontAwesome.Sharp.IconPictureBox PicIconControlHeader;
        private System.Windows.Forms.Panel PnDashBoard;
        private FontAwesome.Sharp.IconButton BtnLogOut;
        private FontAwesome.Sharp.IconButton BtnInternsList;
        private FontAwesome.Sharp.IconButton BtnStudentRegisterJob;
        private FontAwesome.Sharp.IconButton BtnJobCompanyList;
        private System.Windows.Forms.Label LbWelcomeHeader;
        private System.Windows.Forms.Panel PnChildForm;
        private System.Windows.Forms.Panel PnLayout;
    }
}