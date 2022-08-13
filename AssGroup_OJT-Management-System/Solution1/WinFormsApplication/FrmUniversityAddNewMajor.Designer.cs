
namespace WinFormsApplication
{
    partial class FrmUniversityAddNewMajor
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAddNewMajor = new System.Windows.Forms.Button();
            this.LbMajorName = new System.Windows.Forms.Label();
            this.txtMajorName = new System.Windows.Forms.TextBox();
            this.PnLayout = new System.Windows.Forms.Panel();
            this.PnLayout1 = new System.Windows.Forms.Panel();
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
            this.PnHeader.Size = new System.Drawing.Size(595, 56);
            this.PnHeader.TabIndex = 0;
            // 
            // LbHeader
            // 
            this.LbHeader.AutoSize = true;
            this.LbHeader.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.LbHeader.Location = new System.Drawing.Point(142, 9);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(284, 45);
            this.LbHeader.TabIndex = 0;
            this.LbHeader.Text = "Add A New Major";
            // 
            // PnControls
            // 
            this.PnControls.Controls.Add(this.BtnCancel);
            this.PnControls.Controls.Add(this.BtnAddNewMajor);
            this.PnControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnControls.Location = new System.Drawing.Point(0, 159);
            this.PnControls.Name = "PnControls";
            this.PnControls.Size = new System.Drawing.Size(595, 66);
            this.PnControls.TabIndex = 1;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.Location = new System.Drawing.Point(104, 17);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(112, 37);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAddNewMajor
            // 
            this.BtnAddNewMajor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddNewMajor.Location = new System.Drawing.Point(349, 17);
            this.BtnAddNewMajor.Name = "BtnAddNewMajor";
            this.BtnAddNewMajor.Size = new System.Drawing.Size(112, 37);
            this.BtnAddNewMajor.TabIndex = 0;
            this.BtnAddNewMajor.Text = "Insert";
            this.BtnAddNewMajor.UseVisualStyleBackColor = true;
            this.BtnAddNewMajor.Click += new System.EventHandler(this.BtnAddNewMajor_Click);
            // 
            // LbMajorName
            // 
            this.LbMajorName.AutoSize = true;
            this.LbMajorName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbMajorName.Location = new System.Drawing.Point(81, 97);
            this.LbMajorName.Name = "LbMajorName";
            this.LbMajorName.Size = new System.Drawing.Size(122, 24);
            this.LbMajorName.TabIndex = 2;
            this.LbMajorName.Text = "Major name: ";
            // 
            // txtMajorName
            // 
            this.txtMajorName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMajorName.Location = new System.Drawing.Point(222, 89);
            this.txtMajorName.Name = "txtMajorName";
            this.txtMajorName.Size = new System.Drawing.Size(316, 32);
            this.txtMajorName.TabIndex = 3;
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLayout.Location = new System.Drawing.Point(0, 56);
            this.PnLayout.Name = "PnLayout";
            this.PnLayout.Size = new System.Drawing.Size(595, 1);
            this.PnLayout.TabIndex = 4;
            // 
            // PnLayout1
            // 
            this.PnLayout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnLayout1.Location = new System.Drawing.Point(0, 158);
            this.PnLayout1.Name = "PnLayout1";
            this.PnLayout1.Size = new System.Drawing.Size(595, 1);
            this.PnLayout1.TabIndex = 5;
            // 
            // FrmUniversityAddNewMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 225);
            this.Controls.Add(this.PnLayout1);
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.txtMajorName);
            this.Controls.Add(this.LbMajorName);
            this.Controls.Add(this.PnControls);
            this.Controls.Add(this.PnHeader);
            this.Name = "FrmUniversityAddNewMajor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new major";
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
        private System.Windows.Forms.Label LbMajorName;
        private System.Windows.Forms.TextBox txtMajorName;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAddNewMajor;
        private System.Windows.Forms.Panel PnLayout;
        private System.Windows.Forms.Panel PnLayout1;
    }
}