
namespace WinFormsApplication
{
    partial class FrmUniversityManageCompanyList
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
            this.PnFilter = new System.Windows.Forms.Panel();
            this.BtnAddNewCompany = new FontAwesome.Sharp.IconButton();
            this.LbFilterCompanyList = new System.Windows.Forms.Label();
            this.CbFilterCompanyList = new System.Windows.Forms.ComboBox();
            this.BtnSearchCompanyList = new FontAwesome.Sharp.IconButton();
            this.TxtSearchCompanyFollowingFilter = new System.Windows.Forms.TextBox();
            this.DgvCompanyList = new System.Windows.Forms.DataGridView();
            this.PnLayout = new System.Windows.Forms.Panel();
            this.PnFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompanyList)).BeginInit();
            this.SuspendLayout();
            // 
            // PnFilter
            // 
            this.PnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.PnFilter.Controls.Add(this.BtnAddNewCompany);
            this.PnFilter.Controls.Add(this.LbFilterCompanyList);
            this.PnFilter.Controls.Add(this.CbFilterCompanyList);
            this.PnFilter.Controls.Add(this.BtnSearchCompanyList);
            this.PnFilter.Controls.Add(this.TxtSearchCompanyFollowingFilter);
            this.PnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnFilter.Location = new System.Drawing.Point(0, 0);
            this.PnFilter.Name = "PnFilter";
            this.PnFilter.Size = new System.Drawing.Size(1064, 116);
            this.PnFilter.TabIndex = 4;
            // 
            // BtnAddNewCompany
            // 
            this.BtnAddNewCompany.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddNewCompany.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAddNewCompany.IconColor = System.Drawing.Color.Black;
            this.BtnAddNewCompany.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddNewCompany.IconSize = 25;
            this.BtnAddNewCompany.Location = new System.Drawing.Point(955, 86);
            this.BtnAddNewCompany.Name = "BtnAddNewCompany";
            this.BtnAddNewCompany.Size = new System.Drawing.Size(106, 31);
            this.BtnAddNewCompany.TabIndex = 4;
            this.BtnAddNewCompany.Text = "Insert";
            this.BtnAddNewCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddNewCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddNewCompany.UseVisualStyleBackColor = true;
            this.BtnAddNewCompany.Click += new System.EventHandler(this.BtnAddNewCompany_Click);
            // 
            // LbFilterCompanyList
            // 
            this.LbFilterCompanyList.AutoSize = true;
            this.LbFilterCompanyList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFilterCompanyList.Location = new System.Drawing.Point(83, 31);
            this.LbFilterCompanyList.Name = "LbFilterCompanyList";
            this.LbFilterCompanyList.Size = new System.Drawing.Size(100, 24);
            this.LbFilterCompanyList.TabIndex = 3;
            this.LbFilterCompanyList.Text = "Search By: ";
            // 
            // CbFilterCompanyList
            // 
            this.CbFilterCompanyList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbFilterCompanyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterCompanyList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFilterCompanyList.FormattingEnabled = true;
            this.CbFilterCompanyList.Items.AddRange(new object[] {
            "Company Name"});
            this.CbFilterCompanyList.Location = new System.Drawing.Point(189, 23);
            this.CbFilterCompanyList.Name = "CbFilterCompanyList";
            this.CbFilterCompanyList.Size = new System.Drawing.Size(178, 32);
            this.CbFilterCompanyList.TabIndex = 2;
            // 
            // BtnSearchCompanyList
            // 
            this.BtnSearchCompanyList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchCompanyList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchCompanyList.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearchCompanyList.IconColor = System.Drawing.Color.Black;
            this.BtnSearchCompanyList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearchCompanyList.IconSize = 25;
            this.BtnSearchCompanyList.Location = new System.Drawing.Point(924, 23);
            this.BtnSearchCompanyList.Name = "BtnSearchCompanyList";
            this.BtnSearchCompanyList.Size = new System.Drawing.Size(64, 32);
            this.BtnSearchCompanyList.TabIndex = 1;
            this.BtnSearchCompanyList.UseVisualStyleBackColor = true;
            this.BtnSearchCompanyList.Click += new System.EventHandler(this.BtnSearchStudentList_Click);
            // 
            // TxtSearchCompanyFollowingFilter
            // 
            this.TxtSearchCompanyFollowingFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchCompanyFollowingFilter.Location = new System.Drawing.Point(401, 23);
            this.TxtSearchCompanyFollowingFilter.Name = "TxtSearchCompanyFollowingFilter";
            this.TxtSearchCompanyFollowingFilter.Size = new System.Drawing.Size(490, 32);
            this.TxtSearchCompanyFollowingFilter.TabIndex = 0;
            // 
            // DgvCompanyList
            // 
            this.DgvCompanyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCompanyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCompanyList.Location = new System.Drawing.Point(0, 116);
            this.DgvCompanyList.Name = "DgvCompanyList";
            this.DgvCompanyList.RowHeadersWidth = 51;
            this.DgvCompanyList.RowTemplate.Height = 29;
            this.DgvCompanyList.Size = new System.Drawing.Size(1064, 435);
            this.DgvCompanyList.TabIndex = 5;
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLayout.Location = new System.Drawing.Point(0, 116);
            this.PnLayout.Name = "PnLayout";
            this.PnLayout.Size = new System.Drawing.Size(1064, 1);
            this.PnLayout.TabIndex = 6;
            // 
            // FrmUniversityManageCompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 551);
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.DgvCompanyList);
            this.Controls.Add(this.PnFilter);
            this.Name = "FrmUniversityManageCompanyList";
            this.Text = "Company List";
            this.Load += new System.EventHandler(this.FrmUniversityManageCompanyList_Load);
            this.PnFilter.ResumeLayout(false);
            this.PnFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompanyList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnFilter;
        private FontAwesome.Sharp.IconButton BtnAddNewCompany;
        private System.Windows.Forms.Label LbFilterCompanyList;
        private System.Windows.Forms.ComboBox CbFilterCompanyList;
        private FontAwesome.Sharp.IconButton BtnSearchCompanyList;
        private System.Windows.Forms.TextBox TxtSearchCompanyFollowingFilter;
        private System.Windows.Forms.DataGridView DgvCompanyList;
        private System.Windows.Forms.Panel PnLayout;
    }
}