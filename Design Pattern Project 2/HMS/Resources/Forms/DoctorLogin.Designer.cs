namespace HMS
{
    partial class DoctorLogin
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
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.txtPasswordDoctor = new System.Windows.Forms.TextBox();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.lblPasswordDoctor = new System.Windows.Forms.Label();
            this.btnLoginDoctor = new System.Windows.Forms.Button();
            this.btnCancelDoctor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(105, 131);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(166, 20);
            this.txtDoctorID.TabIndex = 3;
            this.txtDoctorID.TextChanged += new System.EventHandler(this.txtDoctorID_TextChanged);
            // 
            // txtPasswordDoctor
            // 
            this.txtPasswordDoctor.Location = new System.Drawing.Point(105, 169);
            this.txtPasswordDoctor.Name = "txtPasswordDoctor";
            this.txtPasswordDoctor.PasswordChar = '$';
            this.txtPasswordDoctor.Size = new System.Drawing.Size(166, 20);
            this.txtPasswordDoctor.TabIndex = 4;
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDoctorID.Location = new System.Drawing.Point(12, 135);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(82, 16);
            this.lblDoctorID.TabIndex = 5;
            this.lblDoctorID.Text = "DOCTOR ID";
            // 
            // lblPasswordDoctor
            // 
            this.lblPasswordDoctor.AutoSize = true;
            this.lblPasswordDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordDoctor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPasswordDoctor.Location = new System.Drawing.Point(12, 173);
            this.lblPasswordDoctor.Name = "lblPasswordDoctor";
            this.lblPasswordDoctor.Size = new System.Drawing.Size(87, 16);
            this.lblPasswordDoctor.TabIndex = 6;
            this.lblPasswordDoctor.Text = "PASSWORD";
            // 
            // btnLoginDoctor
            // 
            this.btnLoginDoctor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLoginDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginDoctor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoginDoctor.Location = new System.Drawing.Point(77, 211);
            this.btnLoginDoctor.Name = "btnLoginDoctor";
            this.btnLoginDoctor.Size = new System.Drawing.Size(86, 32);
            this.btnLoginDoctor.TabIndex = 7;
            this.btnLoginDoctor.Text = "LOGIN";
            this.btnLoginDoctor.UseVisualStyleBackColor = false;
            this.btnLoginDoctor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelDoctor
            // 
            this.btnCancelDoctor.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCancelDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDoctor.Location = new System.Drawing.Point(186, 211);
            this.btnCancelDoctor.Name = "btnCancelDoctor";
            this.btnCancelDoctor.Size = new System.Drawing.Size(85, 32);
            this.btnCancelDoctor.TabIndex = 8;
            this.btnCancelDoctor.Text = "CANCEL";
            this.btnCancelDoctor.UseVisualStyleBackColor = false;
            this.btnCancelDoctor.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "DOCTOR LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.login2;
            this.pictureBox1.Location = new System.Drawing.Point(295, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 345);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // DoctorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(647, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelDoctor);
            this.Controls.Add(this.btnLoginDoctor);
            this.Controls.Add(this.lblPasswordDoctor);
            this.Controls.Add(this.lblDoctorID);
            this.Controls.Add(this.txtPasswordDoctor);
            this.Controls.Add(this.txtDoctorID);
            this.Name = "DoctorLogin";
            this.Text = "DoctorLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.TextBox txtPasswordDoctor;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.Label lblPasswordDoctor;
        private System.Windows.Forms.Button btnLoginDoctor;
        private System.Windows.Forms.Button btnCancelDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}