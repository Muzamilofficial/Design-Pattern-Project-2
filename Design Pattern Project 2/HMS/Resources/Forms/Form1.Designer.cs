namespace HMS
{
    partial class HMS
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnReceptionist = new System.Windows.Forms.Button();
            this.lblHMS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdmin.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(29, 55);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(262, 62);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDoctor.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.Location = new System.Drawing.Point(29, 123);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(262, 61);
            this.btnDoctor.TabIndex = 1;
            this.btnDoctor.Text = "DOCTOR";
            this.btnDoctor.UseVisualStyleBackColor = false;
            this.btnDoctor.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPatient.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.Location = new System.Drawing.Point(29, 190);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(262, 67);
            this.btnPatient.TabIndex = 2;
            this.btnPatient.Text = "PATIENT";
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReceptionist
            // 
            this.btnReceptionist.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnReceptionist.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceptionist.Location = new System.Drawing.Point(29, 263);
            this.btnReceptionist.Name = "btnReceptionist";
            this.btnReceptionist.Size = new System.Drawing.Size(262, 58);
            this.btnReceptionist.TabIndex = 4;
            this.btnReceptionist.Text = "RECEPTIONIST";
            this.btnReceptionist.UseVisualStyleBackColor = false;
            this.btnReceptionist.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblHMS
            // 
            this.lblHMS.AutoSize = true;
            this.lblHMS.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHMS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHMS.Location = new System.Drawing.Point(40, 9);
            this.lblHMS.Name = "lblHMS";
            this.lblHMS.Size = new System.Drawing.Size(571, 43);
            this.lblHMS.TabIndex = 5;
            this.lblHMS.Text = "HOSPITAL MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.sonyericss_1k33uy7f;
            this.pictureBox1.Location = new System.Drawing.Point(305, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 280);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // HMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(622, 381);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHMS);
            this.Controls.Add(this.btnReceptionist);
            this.Controls.Add(this.btnPatient);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnAdmin);
            this.Name = "HMS";
            this.Text = "Hospital Management System";
            this.Load += new System.EventHandler(this.HMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnReceptionist;
        private System.Windows.Forms.Label lblHMS;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

