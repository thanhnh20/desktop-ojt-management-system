
namespace WinFormsApplication
{
    partial class FrmCompanyProfile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtCompanyTax = new System.Windows.Forms.TextBox();
            this.LbAddress = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbCompanyTax = new System.Windows.Forms.Label();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.LbCompanyName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.TxtEmail);
            this.panel1.Controls.Add(this.TxtCompanyTax);
            this.panel1.Controls.Add(this.LbAddress);
            this.panel1.Controls.Add(this.LbEmail);
            this.panel1.Controls.Add(this.LbCompanyTax);
            this.panel1.Controls.Add(this.TxtFullName);
            this.panel1.Controls.Add(this.LbCompanyName);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 551);
            this.panel1.TabIndex = 0;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEdit.Location = new System.Drawing.Point(498, 430);
            this.BtnEdit.MaximumSize = new System.Drawing.Size(173, 58);
            this.BtnEdit.MinimumSize = new System.Drawing.Size(135, 39);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(135, 39);
            this.BtnEdit.TabIndex = 17;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(404, 214);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(415, 133);
            this.txtAddress.TabIndex = 16;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEmail.Location = new System.Drawing.Point(404, 166);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(415, 32);
            this.TxtEmail.TabIndex = 15;
            // 
            // TxtCompanyTax
            // 
            this.TxtCompanyTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCompanyTax.Enabled = false;
            this.TxtCompanyTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCompanyTax.Location = new System.Drawing.Point(404, 115);
            this.TxtCompanyTax.Name = "TxtCompanyTax";
            this.TxtCompanyTax.Size = new System.Drawing.Size(302, 32);
            this.TxtCompanyTax.TabIndex = 14;
            // 
            // LbAddress
            // 
            this.LbAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbAddress.AutoSize = true;
            this.LbAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbAddress.Location = new System.Drawing.Point(223, 222);
            this.LbAddress.Name = "LbAddress";
            this.LbAddress.Size = new System.Drawing.Size(87, 24);
            this.LbAddress.TabIndex = 13;
            this.LbAddress.Text = "Address: ";
            // 
            // LbEmail
            // 
            this.LbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbEmail.Location = new System.Drawing.Point(223, 174);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(66, 24);
            this.LbEmail.TabIndex = 12;
            this.LbEmail.Text = "Email: ";
            // 
            // LbCompanyTax
            // 
            this.LbCompanyTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbCompanyTax.AutoSize = true;
            this.LbCompanyTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCompanyTax.Location = new System.Drawing.Point(223, 123);
            this.LbCompanyTax.Name = "LbCompanyTax";
            this.LbCompanyTax.Size = new System.Drawing.Size(130, 24);
            this.LbCompanyTax.TabIndex = 11;
            this.LbCompanyTax.Text = "Company tax: ";
            // 
            // TxtFullName
            // 
            this.TxtFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtFullName.Enabled = false;
            this.TxtFullName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFullName.Location = new System.Drawing.Point(404, 64);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(415, 32);
            this.TxtFullName.TabIndex = 10;
            // 
            // LbCompanyName
            // 
            this.LbCompanyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbCompanyName.AutoSize = true;
            this.LbCompanyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCompanyName.Location = new System.Drawing.Point(223, 72);
            this.LbCompanyName.Name = "LbCompanyName";
            this.LbCompanyName.Size = new System.Drawing.Size(151, 24);
            this.LbCompanyName.TabIndex = 9;
            this.LbCompanyName.Text = "Company name: ";
            // 
            // FrmCompanyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 551);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1332, 747);
            this.MinimumSize = new System.Drawing.Size(1111, 598);
            this.Name = "FrmCompanyProfile";
            this.Text = "Company Profile";
            this.Load += new System.EventHandler(this.FrmCompanyProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.Label LbCompanyName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtCompanyTax;
        private System.Windows.Forms.Label LbAddress;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbCompanyTax;
        private System.Windows.Forms.Button BtnEdit;
    }
}