
namespace WinFormsApplication
{
    partial class FrmUniversityManageStudentList
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
            this.CbSesmester = new System.Windows.Forms.ComboBox();
            this.BtnAddNewStudent = new FontAwesome.Sharp.IconButton();
            this.LbFilterStudentList = new System.Windows.Forms.Label();
            this.CbFilterStudentList = new System.Windows.Forms.ComboBox();
            this.BtnSearchStudentList = new FontAwesome.Sharp.IconButton();
            this.TxtSearchStudentFollowingFilter = new System.Windows.Forms.TextBox();
            this.PnLayout = new System.Windows.Forms.Panel();
            this.DgvStudentList = new System.Windows.Forms.DataGridView();
            this.PnFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // PnFilter
            // 
            this.PnFilter.BackColor = System.Drawing.SystemColors.Control;
            this.PnFilter.Controls.Add(this.CbSesmester);
            this.PnFilter.Controls.Add(this.BtnAddNewStudent);
            this.PnFilter.Controls.Add(this.LbFilterStudentList);
            this.PnFilter.Controls.Add(this.CbFilterStudentList);
            this.PnFilter.Controls.Add(this.BtnSearchStudentList);
            this.PnFilter.Controls.Add(this.TxtSearchStudentFollowingFilter);
            this.PnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnFilter.Location = new System.Drawing.Point(0, 0);
            this.PnFilter.Name = "PnFilter";
            this.PnFilter.Size = new System.Drawing.Size(1063, 116);
            this.PnFilter.TabIndex = 3;
            // 
            // CbSesmester
            // 
            this.CbSesmester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CbSesmester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSesmester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbSesmester.FormattingEnabled = true;
            this.CbSesmester.Location = new System.Drawing.Point(0, 85);
            this.CbSesmester.Name = "CbSesmester";
            this.CbSesmester.Size = new System.Drawing.Size(178, 32);
            this.CbSesmester.TabIndex = 5;
            this.CbSesmester.SelectionChangeCommitted += new System.EventHandler(this.CbSesmester_SelectionChangeCommitted);
            // 
            // BtnAddNewStudent
            // 
            this.BtnAddNewStudent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddNewStudent.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAddNewStudent.IconColor = System.Drawing.Color.Black;
            this.BtnAddNewStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddNewStudent.IconSize = 25;
            this.BtnAddNewStudent.Location = new System.Drawing.Point(957, 86);
            this.BtnAddNewStudent.Name = "BtnAddNewStudent";
            this.BtnAddNewStudent.Size = new System.Drawing.Size(106, 31);
            this.BtnAddNewStudent.TabIndex = 4;
            this.BtnAddNewStudent.Text = "Insert";
            this.BtnAddNewStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAddNewStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddNewStudent.UseVisualStyleBackColor = true;
            this.BtnAddNewStudent.Click += new System.EventHandler(this.BtnAddNewStudent_Click);
            // 
            // LbFilterStudentList
            // 
            this.LbFilterStudentList.AutoSize = true;
            this.LbFilterStudentList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbFilterStudentList.Location = new System.Drawing.Point(83, 31);
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
            "Address",
            "Major name",
            "Credit"});
            this.CbFilterStudentList.Location = new System.Drawing.Point(189, 23);
            this.CbFilterStudentList.Name = "CbFilterStudentList";
            this.CbFilterStudentList.Size = new System.Drawing.Size(178, 32);
            this.CbFilterStudentList.TabIndex = 2;
            // 
            // BtnSearchStudentList
            // 
            this.BtnSearchStudentList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchStudentList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSearchStudentList.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearchStudentList.IconColor = System.Drawing.Color.Black;
            this.BtnSearchStudentList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSearchStudentList.IconSize = 25;
            this.BtnSearchStudentList.Location = new System.Drawing.Point(924, 23);
            this.BtnSearchStudentList.Name = "BtnSearchStudentList";
            this.BtnSearchStudentList.Size = new System.Drawing.Size(64, 32);
            this.BtnSearchStudentList.TabIndex = 1;
            this.BtnSearchStudentList.UseVisualStyleBackColor = true;
            this.BtnSearchStudentList.Click += new System.EventHandler(this.BtnSearchStudentList_Click);
            // 
            // TxtSearchStudentFollowingFilter
            // 
            this.TxtSearchStudentFollowingFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtSearchStudentFollowingFilter.Location = new System.Drawing.Point(401, 23);
            this.TxtSearchStudentFollowingFilter.Name = "TxtSearchStudentFollowingFilter";
            this.TxtSearchStudentFollowingFilter.Size = new System.Drawing.Size(490, 32);
            this.TxtSearchStudentFollowingFilter.TabIndex = 0;
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLayout.Location = new System.Drawing.Point(0, 116);
            this.PnLayout.Name = "PnLayout";
            this.PnLayout.Size = new System.Drawing.Size(1063, 1);
            this.PnLayout.TabIndex = 4;
            // 
            // DgvStudentList
            // 
            this.DgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvStudentList.Location = new System.Drawing.Point(0, 117);
            this.DgvStudentList.Name = "DgvStudentList";
            this.DgvStudentList.RowHeadersWidth = 51;
            this.DgvStudentList.RowTemplate.Height = 29;
            this.DgvStudentList.Size = new System.Drawing.Size(1063, 434);
            this.DgvStudentList.TabIndex = 5;
            this.DgvStudentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudentList_CellClick);
            this.DgvStudentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudentList_CellDoubleClick);
            // 
            // FrmUniversityManageStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 551);
            this.Controls.Add(this.DgvStudentList);
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.PnFilter);
            this.MaximumSize = new System.Drawing.Size(1332, 747);
            this.MinimumSize = new System.Drawing.Size(1081, 598);
            this.Name = "FrmUniversityManageStudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.FrmUniversityManageStudentList_Load);
            this.PnFilter.ResumeLayout(false);
            this.PnFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnFilter;
        private FontAwesome.Sharp.IconButton BtnAddNewStudent;
        private System.Windows.Forms.Label LbFilterStudentList;
        private System.Windows.Forms.ComboBox CbFilterStudentList;
        private FontAwesome.Sharp.IconButton BtnSearchStudentList;
        private System.Windows.Forms.TextBox TxtSearchStudentFollowingFilter;
        private System.Windows.Forms.ComboBox CbSesmester;
        private System.Windows.Forms.Panel PnLayout;
        private System.Windows.Forms.DataGridView DgvStudentList;
    }
}