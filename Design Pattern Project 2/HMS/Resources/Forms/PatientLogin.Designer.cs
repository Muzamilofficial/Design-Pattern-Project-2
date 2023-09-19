namespace HMS
{
    partial class PatientLogin
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
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtPatientPassword = new System.Windows.Forms.TextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPatientPassword = new System.Windows.Forms.Label();
            this.btnLoginPatient = new System.Windows.Forms.Button();
            this.btnCancelPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(124, 186);
            this.txtPatientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(207, 22);
            this.txtPatientID.TabIndex = 4;
            this.txtPatientID.TextChanged += new System.EventHandler(this.txtPatientID_TextChanged);
            // 
            // txtPatientPassword
            // 
            this.txtPatientPassword.Location = new System.Drawing.Point(124, 240);
            this.txtPatientPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPatientPassword.Name = "txtPatientPassword";
            this.txtPatientPassword.PasswordChar = '$';
            this.txtPatientPassword.Size = new System.Drawing.Size(207, 22);
            this.txtPatientPassword.TabIndex = 5;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPatientID.Location = new System.Drawing.Point(16, 194);
            this.lblPatientID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(83, 17);
            this.lblPatientID.TabIndex = 6;
            this.lblPatientID.Text = "PATIENT ID";
            // 
            // lblPatientPassword
            // 
            this.lblPatientPassword.AutoSize = true;
            this.lblPatientPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPatientPassword.Location = new System.Drawing.Point(16, 249);
            this.lblPatientPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientPassword.Name = "lblPatientPassword";
            this.lblPatientPassword.Size = new System.Drawing.Size(88, 17);
            this.lblPatientPassword.TabIndex = 7;
            this.lblPatientPassword.Text = "PASSWORD";
            // 
            // btnLoginPatient
            // 
            this.btnLoginPatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoginPatient.Location = new System.Drawing.Point(109, 292);
            this.btnLoginPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoginPatient.Name = "btnLoginPatient";
            this.btnLoginPatient.Size = new System.Drawing.Size(100, 28);
            this.btnLoginPatient.TabIndex = 8;
            this.btnLoginPatient.Text = "LOGIN";
            this.btnLoginPatient.UseVisualStyleBackColor = true;
            this.btnLoginPatient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelPatient
            // 
            this.btnCancelPatient.Location = new System.Drawing.Point(232, 292);
            this.btnCancelPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelPatient.Name = "btnCancelPatient";
            this.btnCancelPatient.Size = new System.Drawing.Size(100, 28);
            this.btnCancelPatient.TabIndex = 9;
            this.btnCancelPatient.Text = "CANCEL";
            this.btnCancelPatient.UseVisualStyleBackColor = true;
            this.btnCancelPatient.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(77, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "PATIENT LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.login2;
            this.pictureBox1.Location = new System.Drawing.Point(368, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 416);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // PatientLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(835, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelPatient);
            this.Controls.Add(this.btnLoginPatient);
            this.Controls.Add(this.lblPatientPassword);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.txtPatientPassword);
            this.Controls.Add(this.txtPatientID);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PatientLogin";
            this.Text = "PatientLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtPatientPassword;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPatientPassword;
        private System.Windows.Forms.Button btnLoginPatient;
        private System.Windows.Forms.Button btnCancelPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}