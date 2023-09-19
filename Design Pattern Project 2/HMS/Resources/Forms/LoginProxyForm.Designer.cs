namespace HMS.Resources.Forms
{
    partial class LoginProxyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.ID1 = new System.Windows.Forms.TextBox();
            this.Password1 = new System.Windows.Forms.TextBox();
            this.btnLoginProxyAdmin = new System.Windows.Forms.Button();
            this.btnCancelAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "ADMIN LOGIN";
            // 
            // lblAdminID
            // 
            this.lblAdminID.AutoSize = true;
            this.lblAdminID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdminID.Location = new System.Drawing.Point(32, 98);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(56, 13);
            this.lblAdminID.TabIndex = 15;
            this.lblAdminID.Text = "ADMIN ID";
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdminPassword.Location = new System.Drawing.Point(32, 136);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(70, 13);
            this.lblAdminPassword.TabIndex = 16;
            this.lblAdminPassword.Text = "PASSWORD";
            // 
            // ID1
            // 
            this.ID1.Location = new System.Drawing.Point(116, 91);
            this.ID1.Name = "ID1";
            this.ID1.Size = new System.Drawing.Size(156, 20);
            this.ID1.TabIndex = 17;
            // 
            // Password1
            // 
            this.Password1.Location = new System.Drawing.Point(116, 133);
            this.Password1.Name = "Password1";
            this.Password1.PasswordChar = '$';
            this.Password1.Size = new System.Drawing.Size(156, 20);
            this.Password1.TabIndex = 18;
            // 
            // btnLoginProxyAdmin
            // 
            this.btnLoginProxyAdmin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLoginProxyAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoginProxyAdmin.Location = new System.Drawing.Point(74, 184);
            this.btnLoginProxyAdmin.Name = "btnLoginProxyAdmin";
            this.btnLoginProxyAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnLoginProxyAdmin.TabIndex = 19;
            this.btnLoginProxyAdmin.Text = "LOGIN";
            this.btnLoginProxyAdmin.UseVisualStyleBackColor = false;
            this.btnLoginProxyAdmin.Click += new System.EventHandler(this.btnLoginProxyAdmin_Click);
            // 
            // btnCancelAdmin
            // 
            this.btnCancelAdmin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancelAdmin.Location = new System.Drawing.Point(183, 184);
            this.btnCancelAdmin.Name = "btnCancelAdmin";
            this.btnCancelAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAdmin.TabIndex = 20;
            this.btnCancelAdmin.Text = "CANCEL";
            this.btnCancelAdmin.UseVisualStyleBackColor = false;
            // 
            // LoginProxyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(305, 261);
            this.Controls.Add(this.btnCancelAdmin);
            this.Controls.Add(this.btnLoginProxyAdmin);
            this.Controls.Add(this.Password1);
            this.Controls.Add(this.ID1);
            this.Controls.Add(this.lblAdminPassword);
            this.Controls.Add(this.lblAdminID);
            this.Controls.Add(this.label1);
            this.Name = "LoginProxyForm";
            this.Text = "LoginProxyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.TextBox ID1;
        private System.Windows.Forms.TextBox Password1;
        private System.Windows.Forms.Button btnLoginProxyAdmin;
        private System.Windows.Forms.Button btnCancelAdmin;
    }
}