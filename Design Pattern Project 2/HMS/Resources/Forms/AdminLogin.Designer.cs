namespace HMS
{
    partial class AdminLogin
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
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.lblAdminID = new System.Windows.Forms.Label();
            this.txtAdminID = new System.Windows.Forms.TextBox();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.btnCancelAdmin = new System.Windows.Forms.Button();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLoginAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoginAdmin.Location = new System.Drawing.Point(85, 214);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnLoginAdmin.TabIndex = 0;
            this.btnLoginAdmin.Text = "LOGIN";
            this.btnLoginAdmin.UseVisualStyleBackColor = false;
            this.btnLoginAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAdminID
            // 
            this.lblAdminID.AutoSize = true;
            this.lblAdminID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdminID.Location = new System.Drawing.Point(12, 145);
            this.lblAdminID.Name = "lblAdminID";
            this.lblAdminID.Size = new System.Drawing.Size(56, 13);
            this.lblAdminID.TabIndex = 1;
            this.lblAdminID.Text = "ADMIN ID";
            // 
            // txtAdminID
            // 
            this.txtAdminID.Location = new System.Drawing.Point(98, 138);
            this.txtAdminID.Name = "txtAdminID";
            this.txtAdminID.Size = new System.Drawing.Size(156, 20);
            this.txtAdminID.TabIndex = 2;
            this.txtAdminID.TextChanged += new System.EventHandler(this.txtAdminID_TextChanged);
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(98, 176);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PasswordChar = '$';
            this.txtAdminPassword.Size = new System.Drawing.Size(156, 20);
            this.txtAdminPassword.TabIndex = 3;
            // 
            // btnCancelAdmin
            // 
            this.btnCancelAdmin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancelAdmin.Location = new System.Drawing.Point(179, 214);
            this.btnCancelAdmin.Name = "btnCancelAdmin";
            this.btnCancelAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAdmin.TabIndex = 4;
            this.btnCancelAdmin.Text = "CANCEL";
            this.btnCancelAdmin.UseVisualStyleBackColor = false;
            this.btnCancelAdmin.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdminPassword.Location = new System.Drawing.Point(12, 183);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(70, 13);
            this.lblAdminPassword.TabIndex = 5;
            this.lblAdminPassword.Text = "PASSWORD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "ADMIN LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.login1;
            this.pictureBox1.Location = new System.Drawing.Point(283, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 302);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(631, 327);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdminPassword);
            this.Controls.Add(this.btnCancelAdmin);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.txtAdminID);
            this.Controls.Add(this.lblAdminID);
            this.Controls.Add(this.btnLoginAdmin);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.Label lblAdminID;
        private System.Windows.Forms.TextBox txtAdminID;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Button btnCancelAdmin;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}