
namespace WinFormsApplication
{
    partial class FrmCompanyManageJobList
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
            this.DgvCompanyJobList = new System.Windows.Forms.DataGridView();
            this.PnFilter = new System.Windows.Forms.Panel();
            this.BtnAddNewCompany = new FontAwesome.Sharp.IconButton();
            this.LbFilterJobCompanyList = new System.Windows.Forms.Label();
            this.CbFilterJobCompanyList = new System.Windows.Forms.ComboBox();
            this.BtnSearchJobList = new FontAwesome.Sharp.IconButton();
            this.TxtSearchJobCompanyName = new System.Windows.Forms.TextBox();
            this.PnLayout = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompanyJobList)).BeginInit();
            this.PnFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvCompanyJobList
            // 
            this.DgvCompanyJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCompanyJobList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCompanyJobList.Location = new System.Drawing.Point(0, 130);
            this.DgvCompanyJobList.Name = "DgvCompanyJobList";
            this.DgvCompanyJobList.RowHeadersWidth = 51;
            this.DgvCompanyJobList.RowTemplate.Height = 29;
            this.DgvCompanyJobList.Size = new System.Drawing.Size(1066, 421);
            this.DgvCompanyJobList.TabIndex = 5;
            this.DgvCompanyJobList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCompanyJobList_CellDoubleClick);
            this.DgvCompanyJobList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvCompanyJobList_CellFormatting);
            // 
            // PnFilter
            // 
            this.PnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.PnFilter.Controls.Add(this.BtnAddNewCompany);
            this.PnFilter.Controls.Add(this.LbFilterJobCompanyList);
            this.PnFilter.Controls.Add(this.CbFilterJobCompanyList);
            this.PnFilter.Controls.Add(this.BtnSearchJobList);
            this.PnFilter.Controls.Add(this.TxtSearchJobCompanyName);
            this.PnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnFilter.Location = new System.Drawing.Point(0, 0);
            this.PnFilter.Name = "PnFilter";
            this.PnFilter.Size = new System.Drawing.Size(1066, 130);
            this.PnFilter.TabIndex = 4;
            // 
            // BtnAddNewCompany
            // 
            this.BtnAddNewCompany.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddNewCompany.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAddNewCompany.IconColor = System.Drawing.Color.Black;
            this.BtnAddNewCompany.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddNewCompany.IconSize = 25;
            this.BtnAddNewCompany.Location = new System.Drawing.Point(959, 100);
            this.BtnAddNewCompany.Name = "BtnAddNewCompany";
            this.BtnAddNewCompany.Size = new System.Drawing.Size(106, 31);
            this.BtnAddNewCompany.TabIndex = 5;
            this.BtnAddNewCompany.Text = "Insert";
            this.BtnAddNewCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddNewCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddNewCompany.UseVisualStyleBackColor = true;
            this.BtnAddNewCompany.Click += new System.EventHandler(this.BtnAddNewCompany_Click);
            // 
            // LbFilterJobCompanyList
            // 
            this.LbFilterJobCompanyList.AutoSize = true;
            this.LbFilterJobCompanyList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFilterJobCompanyList.Location = new System.Drawing.Point(93, 45);
            this.LbFilterJobCompanyList.Name = "LbFilterJobCompanyList";
            this.LbFilterJobCompanyList.Size = new System.Drawing.Size(100, 24);
            this.LbFilterJobCompanyList.TabIndex = 3;
            this.LbFilterJobCompanyList.Text = "Search By: ";
            // 
            // CbFilterJobCompanyList
            // 
            this.CbFilterJobCompanyList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbFilterJobCompanyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterJobCompanyList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFilterJobCompanyList.FormattingEnabled = true;
            this.CbFilterJobCompanyList.Location = new System.Drawing.Point(199, 37);
            this.CbFilterJobCompanyList.Name = "CbFilterJobCompanyList";
            this.CbFilterJobCompanyList.Size = new System.Drawing.Size(178, 32);
            this.CbFilterJobCompanyList.TabIndex = 2;
            // 
            // BtnSearchJobList
            // 
            this.BtnSearchJobList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchJobList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchJobList.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearchJobList.IconColor = System.Drawing.Color.Black;
            this.BtnSearchJobList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearchJobList.IconSize = 25;
            this.BtnSearchJobList.Location = new System.Drawing.Point(934, 37);
            this.BtnSearchJobList.Name = "BtnSearchJobList";
            this.BtnSearchJobList.Size = new System.Drawing.Size(64, 32);
            this.BtnSearchJobList.TabIndex = 1;
            this.BtnSearchJobList.UseVisualStyleBackColor = true;
            this.BtnSearchJobList.Click += new System.EventHandler(this.BtnSearchJobList_Click);
            // 
            // TxtSearchJobCompanyName
            // 
            this.TxtSearchJobCompanyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchJobCompanyName.Location = new System.Drawing.Point(411, 37);
            this.TxtSearchJobCompanyName.Name = "TxtSearchJobCompanyName";
            this.TxtSearchJobCompanyName.Size = new System.Drawing.Size(490, 32);
            this.TxtSearchJobCompanyName.TabIndex = 0;
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLayout.Location = new System.Drawing.Point(0, 130);
            this.PnLayout.Name = "PnLayout";
            this.PnLayout.Size = new System.Drawing.Size(1066, 1);
            this.PnLayout.TabIndex = 6;
            // 
            // FrmCompanyManageJobList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 551);
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.DgvCompanyJobList);
            this.Controls.Add(this.PnFilter);
            this.MaximumSize = new System.Drawing.Size(1332, 747);
            this.MinimumSize = new System.Drawing.Size(1084, 598);
            this.Name = "FrmCompanyManageJobList";
            this.Text = "Jobs List";
            this.Load += new System.EventHandler(this.FrmCompanyManageJobList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompanyJobList)).EndInit();
            this.PnFilter.ResumeLayout(false);
            this.PnFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCompanyJobList;
        private System.Windows.Forms.Panel PnFilter;
        private System.Windows.Forms.Label LbFilterJobCompanyList;
        private System.Windows.Forms.ComboBox CbFilterJobCompanyList;
        private FontAwesome.Sharp.IconButton BtnSearchJobList;
        private System.Windows.Forms.TextBox TxtSearchJobCompanyName;
        private FontAwesome.Sharp.IconButton BtnAddNewCompany;
        private System.Windows.Forms.Panel PnLayout;
    }
}