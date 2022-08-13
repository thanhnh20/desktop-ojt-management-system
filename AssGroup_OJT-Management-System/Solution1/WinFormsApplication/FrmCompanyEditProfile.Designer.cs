
namespace WinFormsApplication
{
    partial class FrmCompanyEditProfile
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtCompanyTax = new System.Windows.Forms.TextBox();
            this.LbAddress = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbCompanyTax = new System.Windows.Forms.Label();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.LbCompanyName = new System.Windows.Forms.Label();
            this.PnHeader = new System.Windows.Forms.Panel();
            this.LbHeader = new System.Windows.Forms.Label();
            this.PnControls = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PnLayout = new System.Windows.Forms.Panel();
            this.PnLayout1 = new System.Windows.Forms.Panel();
            this.PnHeader.SuspendLayout();
            this.PnControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(283, 300);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(415, 133);
            this.txtAddress.TabIndex = 24;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtEmail.Location = new System.Drawing.Point(283, 252);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(415, 32);
            this.TxtEmail.TabIndex = 23;
            // 
            // TxtCompanyTax
            // 
            this.TxtCompanyTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCompanyTax.Enabled = false;
            this.TxtCompanyTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtCompanyTax.Location = new System.Drawing.Point(283, 201);
            this.TxtCompanyTax.Name = "TxtCompanyTax";
            this.TxtCompanyTax.Size = new System.Drawing.Size(302, 32);
            this.TxtCompanyTax.TabIndex = 22;
            // 
            // LbAddress
            // 
            this.LbAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbAddress.AutoSize = true;
            this.LbAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbAddress.Location = new System.Drawing.Point(102, 308);
            this.LbAddress.Name = "LbAddress";
            this.LbAddress.Size = new System.Drawing.Size(87, 24);
            this.LbAddress.TabIndex = 21;
            this.LbAddress.Text = "Address: ";
            // 
            // LbEmail
            // 
            this.LbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbEmail.Location = new System.Drawing.Point(102, 260);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(66, 24);
            this.LbEmail.TabIndex = 20;
            this.LbEmail.Text = "Email: ";
            // 
            // LbCompanyTax
            // 
            this.LbCompanyTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbCompanyTax.AutoSize = true;
            this.LbCompanyTax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCompanyTax.Location = new System.Drawing.Point(102, 209);
            this.LbCompanyTax.Name = "LbCompanyTax";
            this.LbCompanyTax.Size = new System.Drawing.Size(130, 24);
            this.LbCompanyTax.TabIndex = 19;
            this.LbCompanyTax.Text = "Company tax: ";
            // 
            // TxtFullName
            // 
            this.TxtFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtFullName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFullName.Location = new System.Drawing.Point(283, 150);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(415, 32);
            this.TxtFullName.TabIndex = 18;
            // 
            // LbCompanyName
            // 
            this.LbCompanyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbCompanyName.AutoSize = true;
            this.LbCompanyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbCompanyName.Location = new System.Drawing.Point(102, 158);
            this.LbCompanyName.Name = "LbCompanyName";
            this.LbCompanyName.Size = new System.Drawing.Size(151, 24);
            this.LbCompanyName.TabIndex = 17;
            this.LbCompanyName.Text = "Company name: ";
            // 
            // PnHeader
            // 
            this.PnHeader.Controls.Add(this.LbHeader);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(0, 0);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(800, 92);
            this.PnHeader.TabIndex = 25;
            // 
            // LbHeader
            // 
            this.LbHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbHeader.AutoSize = true;
            this.LbHeader.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.LbHeader.Location = new System.Drawing.Point(270, 21);
            this.LbHeader.Name = "LbHeader";
            this.LbHeader.Size = new System.Drawing.Size(267, 45);
            this.LbHeader.TabIndex = 0;
            this.LbHeader.Text = "Company Profile";
            // 
            // PnControls
            // 
            this.PnControls.Controls.Add(this.BtnUpdate);
            this.PnControls.Controls.Add(this.BtnCancel);
            this.PnControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnControls.Location = new System.Drawing.Point(0, 495);
            this.PnControls.Name = "PnControls";
            this.PnControls.Size = new System.Drawing.Size(800, 88);
            this.PnControls.TabIndex = 26;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnUpdate.Location = new System.Drawing.Point(441, 25);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(162, 39);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancel.Location = new System.Drawing.Point(198, 25);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(162, 39);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PnLayout
            // 
            this.PnLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnLayout.Location = new System.Drawing.Point(0, 92);
            this.PnLayout.Name = "PnLayout";
            this.PnLayout.Size = new System.Drawing.Size(800, 1);
            this.PnLayout.TabIndex = 27;
            // 
            // PnLayout1
            // 
            this.PnLayout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(113)))), ((int)(((byte)(36)))));
            this.PnLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnLayout1.Location = new System.Drawing.Point(0, 494);
            this.PnLayout1.Name = "PnLayout1";
            this.PnLayout1.Size = new System.Drawing.Size(800, 1);
            this.PnLayout1.TabIndex = 28;
            // 
            // FrmCompanyEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.PnLayout1);
            this.Controls.Add(this.PnLayout);
            this.Controls.Add(this.PnControls);
            this.Controls.Add(this.PnHeader);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtCompanyTax);
            this.Controls.Add(this.LbAddress);
            this.Controls.Add(this.LbEmail);
            this.Controls.Add(this.LbCompanyTax);
            this.Controls.Add(this.TxtFullName);
            this.Controls.Add(this.LbCompanyName);
            this.MaximumSize = new System.Drawing.Size(818, 630);
            this.MinimumSize = new System.Drawing.Size(818, 630);
            this.Name = "FrmCompanyEditProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Company Profile";
            this.Load += new System.EventHandler(this.FrmCompanyEditProfile_Load);
            this.PnHeader.ResumeLayout(false);
            this.PnHeader.PerformLayout();
            this.PnControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtCompanyTax;
        private System.Windows.Forms.Label LbAddress;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbCompanyTax;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.Label LbCompanyName;
        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Label LbHeader;
        private System.Windows.Forms.Panel PnControls;
        private System.Windows.Forms.Panel PnLayout;
        private System.Windows.Forms.Panel PnLayout1;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnCancel;
    }
}