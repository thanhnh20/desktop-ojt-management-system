
namespace WinFormsApplication
{
    partial class FrmCompanyManageInternshipList
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
            this.DgvStudentList = new System.Windows.Forms.DataGridView();
            this.LbFilterStudentList = new System.Windows.Forms.Label();
            this.CbFilterStudentList = new System.Windows.Forms.ComboBox();
            this.BtnSearchStudentList = new FontAwesome.Sharp.IconButton();
            this.TxtSearchStudentFollowingFilter = new System.Windows.Forms.TextBox();
            this.PnFilter = new System.Windows.Forms.Panel();
            this.PnLayout = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudentList)).BeginInit();
            this.PnFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvStudentList
            // 
            this.DgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvStudentList.Location = new System.Drawing.Point(0, 130);
            this.DgvStudentList.Name = "DgvStudentList";
            this.DgvStudentList.RowHeadersWidth = 51;
            this.DgvStudentList.RowTemplate.Height = 29;
            this.DgvStudentList.Size = new System.Drawing.Size(1063, 421);
            this.DgvStudentList.TabIndex = 7;
            this.DgvStudentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudentList_CellClick);
            this.DgvStudentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudentList_CellDoubleClick);
            // 
            // LbFilterStudentList
            // 
            this.LbFilterStudentList.AutoSize = true;
            this.LbFilterStudentList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFilterStudentList.Location = new System.Drawing.Point(93, 45);
            this.LbFilterStudentList.Name = "LbFilterStudentList";
            this.LbFilterStudentList.Size = new System.Drawing.Size(100, 24);
            this.LbFilterStudentList.TabIndex = 3;
            this.LbFilterStudentList.Text = "Search By: ";
            // 
            // CbFilterStudentList
            // 
            this.CbFilterStudentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbFilterStudentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterStudentList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFilterStudentList.FormattingEnabled = true;
            this.CbFilterStudentList.Items.AddRange(new object[] {
            "Student code",
            "Student name",
            "Status"});
            this.CbFilterStudentList.Location = new System.Drawing.Point(199, 37);
            this.CbFilterStudentList.Name = "CbFilterStudentList";
            this.CbFilterStudentList.Size = new System.Drawing.Size(178, 32);
            this.CbFilterStudentList.TabIndex = 2;
            this.CbFilterStudentList.SelectionChangeCommitted += new System.EventHandler(this.CbFilterStudentList_SelectionChangeCommitted);
            // 
            // BtnSearchStudentList
            // 
            this.BtnSearchStudentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchStudentList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchStudentList.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearchStudentList.IconColor = System.Drawing.Color.Black;
            this.BtnSearchStudentList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearchStudentList.IconSize = 25;
            this.BtnSearchStudentList.Location = new System.Drawing.Point(934, 37);
            this.BtnSearchStudentList.Name = "BtnSearchStudentList";
            this.BtnSearchStudentList.Size = new System.Drawing.Size(64, 32);
            this.BtnSearchStudentList.TabIndex = 1;
            this.BtnSearchStudentList.UseVisualStyleBackColor = true;
            this.BtnSearchStudentList.Click += new System.EventHandler(this.BtnSearchStudentList_Click);
            // 
            // TxtSearchStudentFollowingFilter
            // 
            this.TxtSearchStudentFollowingFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchStudentFollowingFilter.Location = new System.Drawing.Point(411, 37);
            this.TxtSearchStudentFollowingFilter.Name = "TxtSearchStudentFollowingFilter";
            this.TxtSearchStudentFollowingFilter.Size = new System.Drawing.Size(490, 32);
            this.TxtSearchStudentFollowingFilter.TabIndex = 0;
            // 
            // PnFilter
            // 
            this.PnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.PnFilter.Controls.Add(this.LbFilterStudentList);
            this.PnFilter.Controls.Add(this.CbFilterStudentList);
            this.PnFilter.Controls.Add(this.BtnSearchStudentList);
            this.PnFilter.Controls.Add(this.TxtSearchStudentFollowingFilter);
            this.PnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnFilter.Location = new System.Drawing.Point(0, 0);
            this.PnFilter.Name = "PnFilter";
            this.PnFilter.Size = new System.Drawing.Size(1063, 130);
            this.PnFilter.TabIndex = 6;
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLayout.Location = new System.Drawing.Point(0, 130);
            this.PnLayout.Name = "PnLayout";
            this.PnLayout.Size = new System.Drawing.Size(1063, 1);
            this.PnLayout.TabIndex = 8;
            // 
            // FrmCompanyManageInternshipList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 551);
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.DgvStudentList);
            this.Controls.Add(this.PnFilter);
            this.MaximumSize = new System.Drawing.Size(1332, 747);
            this.MinimumSize = new System.Drawing.Size(1081, 598);
            this.Name = "FrmCompanyManageInternshipList";
            this.Text = "Internship List";
            this.Load += new System.EventHandler(this.FrmCompanyManageInternshipList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudentList)).EndInit();
            this.PnFilter.ResumeLayout(false);
            this.PnFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvStudentList;
        private System.Windows.Forms.Label LbFilterStudentList;
        private System.Windows.Forms.ComboBox CbFilterStudentList;
        private FontAwesome.Sharp.IconButton BtnSearchStudentList;
        private System.Windows.Forms.TextBox TxtSearchStudentFollowingFilter;
        private System.Windows.Forms.Panel PnFilter;
        private System.Windows.Forms.Panel PnLayout;
    }
}