
namespace WinFormsApplication
{
    partial class FrmCompanyManageInternsApplicaton
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
            this.DgvApplicationList = new System.Windows.Forms.DataGridView();
            this.LbFilterJobCompanyList = new System.Windows.Forms.Label();
            this.BtnSearchApplication = new FontAwesome.Sharp.IconButton();
            this.TxtSearchApplication = new System.Windows.Forms.TextBox();
            this.PnFilter = new System.Windows.Forms.Panel();
            this.txtStudentCodeInvisible = new System.Windows.Forms.TextBox();
            this.txtJobCodeInvisible = new System.Windows.Forms.TextBox();
            this.CbFilterApplicationList = new System.Windows.Forms.ComboBox();
            this.PnLayout = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvApplicationList)).BeginInit();
            this.PnFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvApplicationList
            // 
            this.DgvApplicationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvApplicationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvApplicationList.Location = new System.Drawing.Point(0, 130);
            this.DgvApplicationList.Name = "DgvApplicationList";
            this.DgvApplicationList.RowHeadersWidth = 51;
            this.DgvApplicationList.RowTemplate.Height = 29;
            this.DgvApplicationList.Size = new System.Drawing.Size(1097, 465);
            this.DgvApplicationList.TabIndex = 7;
            this.DgvApplicationList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvApplicationList_CellDoubleClick);
            this.DgvApplicationList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvApplicationList_CellFormatting);
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
            // BtnSearchApplication
            // 
            this.BtnSearchApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchApplication.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchApplication.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearchApplication.IconColor = System.Drawing.Color.Black;
            this.BtnSearchApplication.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearchApplication.IconSize = 25;
            this.BtnSearchApplication.Location = new System.Drawing.Point(934, 37);
            this.BtnSearchApplication.Name = "BtnSearchApplication";
            this.BtnSearchApplication.Size = new System.Drawing.Size(64, 32);
            this.BtnSearchApplication.TabIndex = 1;
            this.BtnSearchApplication.UseVisualStyleBackColor = true;
            this.BtnSearchApplication.Click += new System.EventHandler(this.BtnSearchApplication_Click);
            // 
            // TxtSearchApplication
            // 
            this.TxtSearchApplication.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchApplication.Location = new System.Drawing.Point(411, 37);
            this.TxtSearchApplication.Name = "TxtSearchApplication";
            this.TxtSearchApplication.Size = new System.Drawing.Size(490, 32);
            this.TxtSearchApplication.TabIndex = 0;
            // 
            // PnFilter
            // 
            this.PnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.PnFilter.Controls.Add(this.txtStudentCodeInvisible);
            this.PnFilter.Controls.Add(this.txtJobCodeInvisible);
            this.PnFilter.Controls.Add(this.LbFilterJobCompanyList);
            this.PnFilter.Controls.Add(this.CbFilterApplicationList);
            this.PnFilter.Controls.Add(this.BtnSearchApplication);
            this.PnFilter.Controls.Add(this.TxtSearchApplication);
            this.PnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnFilter.Location = new System.Drawing.Point(0, 0);
            this.PnFilter.Name = "PnFilter";
            this.PnFilter.Size = new System.Drawing.Size(1097, 130);
            this.PnFilter.TabIndex = 6;
            // 
            // txtStudentCodeInvisible
            // 
            this.txtStudentCodeInvisible.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStudentCodeInvisible.Location = new System.Drawing.Point(291, 92);
            this.txtStudentCodeInvisible.Name = "txtStudentCodeInvisible";
            this.txtStudentCodeInvisible.Size = new System.Drawing.Size(86, 32);
            this.txtStudentCodeInvisible.TabIndex = 5;
            this.txtStudentCodeInvisible.Visible = false;
            // 
            // txtJobCodeInvisible
            // 
            this.txtJobCodeInvisible.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJobCodeInvisible.Location = new System.Drawing.Point(176, 92);
            this.txtJobCodeInvisible.Name = "txtJobCodeInvisible";
            this.txtJobCodeInvisible.Size = new System.Drawing.Size(86, 32);
            this.txtJobCodeInvisible.TabIndex = 4;
            this.txtJobCodeInvisible.Visible = false;
            // 
            // CbFilterApplicationList
            // 
            this.CbFilterApplicationList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbFilterApplicationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterApplicationList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbFilterApplicationList.FormattingEnabled = true;
            this.CbFilterApplicationList.Items.AddRange(new object[] {
            "Job name",
            "Status"});
            this.CbFilterApplicationList.Location = new System.Drawing.Point(199, 37);
            this.CbFilterApplicationList.Name = "CbFilterApplicationList";
            this.CbFilterApplicationList.Size = new System.Drawing.Size(178, 32);
            this.CbFilterApplicationList.TabIndex = 2;
            this.CbFilterApplicationList.TextChanged += new System.EventHandler(this.CbFilterApplicationList_TextChanged);
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLayout.Location = new System.Drawing.Point(0, 130);
            this.PnLayout.Name = "PnLayout";
            this.PnLayout.Size = new System.Drawing.Size(1097, 1);
            this.PnLayout.TabIndex = 8;
            // 
            // FrmCompanyManageInternsApplicaton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 595);
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.DgvApplicationList);
            this.Controls.Add(this.PnFilter);
            this.Name = "FrmCompanyManageInternsApplicaton";
            this.Text = "Interns Application";
            this.Load += new System.EventHandler(this.FrmCompanyManageInternsApplicaton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvApplicationList)).EndInit();
            this.PnFilter.ResumeLayout(false);
            this.PnFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvApplicationList;
        private System.Windows.Forms.Label LbFilterJobCompanyList;
        private FontAwesome.Sharp.IconButton BtnSearchApplication;
        private System.Windows.Forms.TextBox TxtSearchApplication;
        private System.Windows.Forms.Panel PnFilter;
        private System.Windows.Forms.ComboBox CbFilterApplicationList;
        private System.Windows.Forms.Panel PnLayout;
        private System.Windows.Forms.TextBox txtStudentCodeInvisible;
        private System.Windows.Forms.TextBox txtJobCodeInvisible;
    }
}