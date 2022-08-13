
namespace WinFormsApplication
{
    partial class FrmUniversityAddNewCompany
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
            this.PnLayout = new System.Windows.Forms.Panel();
            this.PnInformation = new System.Windows.Forms.Panel();
            this.PnLayout1 = new System.Windows.Forms.Panel();
            this.PnControls = new System.Windows.Forms.Panel();
            this.BtnInsertANewCompany = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LbPassword = new System.Windows.Forms.Label();
            this.TxtCompanyEmail = new System.Windows.Forms.TextBox();
            this.LbCompanyEmail = new System.Windows.Forms.Label();
            this.TxtCompanyAddress = new System.Windows.Forms.TextBox();
            this.LbCompanyAddress = new System.Windows.Forms.Label();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.LbCompanyName = new System.Windows.Forms.Label();
            this.TxtCompanyTax = new System.Windows.Forms.TextBox();
            this.LbCompanyTax = new System.Windows.Forms.Label();
            this.PnHeader.SuspendLayout();
            this.PnInformation.SuspendLayout();
            this.PnControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnHeader
            // 
            this.PnHeader.Controls.Add(this.LbHeader);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(0, 0);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(650, 77);
            this.PnHeader.TabIndex = 0;
            // 
            // LbHeader
            // 
            this.LbHeader.AutoSize = true;
            this.LbHeader.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.LbHeader.Location = new System.Drawing.Point(151, 20);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(360, 45);
            this.LbHeader.TabIndex = 0;
            this.LbHeader.Text = "Insert A New Company";
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLayout.Location = new System.Drawing.Point(0, 77);
            this.PnLayout.Name = "PnLayout";
            this.PnLayout.Size = new System.Drawing.Size(650, 1);
            this.PnLayout.TabIndex = 1;
            // 
            // PnInformation
            // 
            this.PnInformation.Controls.Add(this.PnLayout1);
            this.PnInformation.Controls.Add(this.PnControls);
            this.PnInformation.Controls.Add(this.TxtPassword);
            this.PnInformation.Controls.Add(this.LbPassword);
            this.PnInformation.Controls.Add(this.TxtCompanyEmail);
            this.PnInformation.Controls.Add(this.LbCompanyEmail);
            this.PnInformation.Controls.Add(this.TxtCompanyAddress);
            this.PnInformation.Controls.Add(this.LbCompanyAddress);
            this.PnInformation.Controls.Add(this.TxtCompanyName);
            this.PnInformation.Controls.Add(this.LbCompanyName);
            this.PnInformation.Controls.Add(this.TxtCompanyTax);
            this.PnInformation.Controls.Add(this.LbCompanyTax);
            this.PnInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnInformation.Location = new System.Drawing.Point(0, 78);
            this.PnInformation.Name = "PnInformation";
            this.PnInformation.Size = new System.Drawing.Size(650, 509);
            this.PnInformation.TabIndex = 2;
            // 
            // PnLayout1
            // 
            this.PnLayout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnLayout1.Location = new System.Drawing.Point(0, 390);
            this.PnLayout1.Name = "PnLayout1";
            this.PnLayout1.Size = new System.Drawing.Size(650, 1);
            this.PnLayout1.TabIndex = 11;
            // 
            // PnControls
            // 
            this.PnControls.Controls.Add(this.BtnInsertANewCompany);
            this.PnControls.Controls.Add(this.BtnCancel);
            this.PnControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnControls.Location = new System.Drawing.Point(0, 391);
            this.PnControls.Name = "PnControls";
            this.PnControls.Size = new System.Drawing.Size(650, 118);
            this.PnControls.TabIndex = 10;
            // 
            // BtnInsertANewCompany
            // 
            this.BtnInsertANewCompany.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInsertANewCompany.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnInsertANewCompany.Location = new System.Drawing.Point(366, 40);
            this.BtnInsertANewCompany.Name = "BtnInsertANewCompany";
            this.BtnInsertANewCompany.Size = new System.Drawing.Size(162, 39);
            this.BtnInsertANewCompany.TabIndex = 5;
            this.BtnInsertANewCompany.Text = "Insert";
            this.BtnInsertANewCompany.UseVisualStyleBackColor = true;
            this.BtnInsertANewCompany.Click += new System.EventHandler(this.BtnInsertANewCompany_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancel.Location = new System.Drawing.Point(123, 40);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(162, 39);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtPassword.Location = new System.Drawing.Point(236, 76);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(241, 32);
            this.TxtPassword.TabIndex = 2;
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPassword.Location = new System.Drawing.Point(67, 84);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(99, 24);
            this.LbPassword.TabIndex = 8;
            this.LbPassword.Text = "Password: ";
            // 
            // TxtCompanyEmail
            // 
            this.TxtCompanyEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCompanyEmail.Location = new System.Drawing.Point(236, 23);
            this.TxtCompanyEmail.Name = "TxtCompanyEmail";
            this.TxtCompanyEmail.Size = new System.Drawing.Size(241, 32);
            this.TxtCompanyEmail.TabIndex = 1;
            // 
            // LbCompanyEmail
            // 
            this.LbCompanyEmail.AutoSize = true;
            this.LbCompanyEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCompanyEmail.Location = new System.Drawing.Point(67, 31);
            this.LbCompanyEmail.Name = "LbCompanyEmail";
            this.LbCompanyEmail.Size = new System.Drawing.Size(66, 24);
            this.LbCompanyEmail.TabIndex = 6;
            this.LbCompanyEmail.Text = "Email: ";
            // 
            // TxtCompanyAddress
            // 
            this.TxtCompanyAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCompanyAddress.Location = new System.Drawing.Point(236, 241);
            this.TxtCompanyAddress.Multiline = true;
            this.TxtCompanyAddress.Name = "TxtCompanyAddress";
            this.TxtCompanyAddress.Size = new System.Drawing.Size(366, 104);
            this.TxtCompanyAddress.TabIndex = 5;
            // 
            // LbCompanyAddress
            // 
            this.LbCompanyAddress.AutoSize = true;
            this.LbCompanyAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCompanyAddress.Location = new System.Drawing.Point(67, 249);
            this.LbCompanyAddress.Name = "LbCompanyAddress";
            this.LbCompanyAddress.Size = new System.Drawing.Size(87, 24);
            this.LbCompanyAddress.TabIndex = 4;
            this.LbCompanyAddress.Text = "Address: ";
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCompanyName.Location = new System.Drawing.Point(236, 184);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(366, 32);
            this.TxtCompanyName.TabIndex = 4;
            // 
            // LbCompanyName
            // 
            this.LbCompanyName.AutoSize = true;
            this.LbCompanyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCompanyName.Location = new System.Drawing.Point(67, 192);
            this.LbCompanyName.Name = "LbCompanyName";
            this.LbCompanyName.Size = new System.Drawing.Size(153, 24);
            this.LbCompanyName.TabIndex = 2;
            this.LbCompanyName.Text = "Company Name: ";
            // 
            // TxtCompanyTax
            // 
            this.TxtCompanyTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCompanyTax.Location = new System.Drawing.Point(236, 125);
            this.TxtCompanyTax.Name = "TxtCompanyTax";
            this.TxtCompanyTax.Size = new System.Drawing.Size(241, 32);
            this.TxtCompanyTax.TabIndex = 3;
            // 
            // LbCompanyTax
            // 
            this.LbCompanyTax.AutoSize = true;
            this.LbCompanyTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCompanyTax.Location = new System.Drawing.Point(67, 133);
            this.LbCompanyTax.Name = "LbCompanyTax";
            this.LbCompanyTax.Size = new System.Drawing.Size(131, 24);
            this.LbCompanyTax.TabIndex = 0;
            this.LbCompanyTax.Text = "Company Tax: ";
            // 
            // FrmUniversityAddNewCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 587);
            this.Controls.Add(this.PnInformation);
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.PnHeader);
            this.Name = "FrmUniversityAddNewCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert New Company";
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            this.PnInformation.ResumeLayout(false);
            this.PnInformation.PerformLayout();
            this.PnControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Label LbHeader;
        private System.Windows.Forms.Panel PnLayout;
        private System.Windows.Forms.Panel PnInformation;
        private System.Windows.Forms.TextBox TxtCompanyTax;
        private System.Windows.Forms.Label LbCompanyTax;
        private System.Windows.Forms.Panel PnLayout1;
        private System.Windows.Forms.Panel PnControls;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.TextBox TxtCompanyEmail;
        private System.Windows.Forms.Label LbCompanyEmail;
        private System.Windows.Forms.TextBox TxtCompanyAddress;
        private System.Windows.Forms.Label LbCompanyAddress;
        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.Label LbCompanyName;
        private System.Windows.Forms.Button BtnInsertANewCompany;
        private System.Windows.Forms.Button BtnCancel;
    }
}