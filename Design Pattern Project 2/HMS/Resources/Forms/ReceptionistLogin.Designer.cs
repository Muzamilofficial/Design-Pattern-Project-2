namespace HMS
{
    partial class ReceptionistLogin
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
            this.txtReceptionistID = new System.Windows.Forms.TextBox();
            this.txtReceptionistPassword = new System.Windows.Forms.TextBox();
            this.lblReceptionistID = new System.Windows.Forms.Label();
            this.lblReceptionistPassword = new System.Windows.Forms.Label();
            this.btnReceptionistLogin = new System.Windows.Forms.Button();
            this.btnReceptionistCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtReceptionistID
            // 
            this.txtReceptionistID.Location = new System.Drawing.Point(173, 106);
            this.txtReceptionistID.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceptionistID.Name = "txtReceptionistID";
            this.txtReceptionistID.Size = new System.Drawing.Size(207, 22);
            this.txtReceptionistID.TabIndex = 10;
            // 
            // txtReceptionistPassword
            // 
            this.txtReceptionistPassword.Location = new System.Drawing.Point(173, 160);
            this.txtReceptionistPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceptionistPassword.Name = "txtReceptionistPassword";
            this.txtReceptionistPassword.PasswordChar = '$';
            this.txtReceptionistPassword.Size = new System.Drawing.Size(207, 22);
            this.txtReceptionistPassword.TabIndex = 11;
            // 
            // lblReceptionistID
            // 
            this.lblReceptionistID.AutoSize = true;
            this.lblReceptionistID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionistID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReceptionistID.Location = new System.Drawing.Point(24, 112);
            this.lblReceptionistID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceptionistID.Name = "lblReceptionistID";
            this.lblReceptionistID.Size = new System.Drawing.Size(123, 16);
            this.lblReceptionistID.TabIndex = 12;
            this.lblReceptionistID.Text = "RECEPTIONIST ID";
            // 
            // lblReceptionistPassword
            // 
            this.lblReceptionistPassword.AutoSize = true;
            this.lblReceptionistPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceptionistPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReceptionistPassword.Location = new System.Drawing.Point(60, 166);
            this.lblReceptionistPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceptionistPassword.Name = "lblReceptionistPassword";
            this.lblReceptionistPassword.Size = new System.Drawing.Size(87, 16);
            this.lblReceptionistPassword.TabIndex = 13;
            this.lblReceptionistPassword.Text = "PASSWORD";
            // 
            // btnReceptionistLogin
            // 
            this.btnReceptionistLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReceptionistLogin.Location = new System.Drawing.Point(151, 222);
            this.btnReceptionistLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceptionistLogin.Name = "btnReceptionistLogin";
            this.btnReceptionistLogin.Size = new System.Drawing.Size(100, 28);
            this.btnReceptionistLogin.TabIndex = 14;
            this.btnReceptionistLogin.Text = "LOGIN";
            this.btnReceptionistLogin.UseVisualStyleBackColor = true;
            this.btnReceptionistLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReceptionistCancel
            // 
            this.btnReceptionistCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReceptionistCancel.Location = new System.Drawing.Point(281, 222);
            this.btnReceptionistCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceptionistCancel.Name = "btnReceptionistCancel";
            this.btnReceptionistCancel.Size = new System.Drawing.Size(100, 28);
            this.btnReceptionistCancel.TabIndex = 15;
            this.btnReceptionistCancel.Text = "CANCEL";
            this.btnReceptionistCancel.UseVisualStyleBackColor = true;
            this.btnReceptionistCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(78, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "RECEPTIONIST LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(408, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 343);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ReceptionistLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(760, 367);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReceptionistCancel);
            this.Controls.Add(this.btnReceptionistLogin);
            this.Controls.Add(this.lblReceptionistPassword);
            this.Controls.Add(this.lblReceptionistID);
            this.Controls.Add(this.txtReceptionistPassword);
            this.Controls.Add(this.txtReceptionistID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReceptionistLogin";
            this.Text = "ReceptionistLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReceptionistID;
        private System.Windows.Forms.TextBox txtReceptionistPassword;
        private System.Windows.Forms.Label lblReceptionistID;
        private System.Windows.Forms.Label lblReceptionistPassword;
        private System.Windows.Forms.Button btnReceptionistLogin;
        private System.Windows.Forms.Button btnReceptionistCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}