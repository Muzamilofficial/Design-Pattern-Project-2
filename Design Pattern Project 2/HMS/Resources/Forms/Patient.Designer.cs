namespace HMS
{
    partial class Patient
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
            this.btnRegisterforAppointment = new System.Windows.Forms.Button();
            this.btnPayFee = new System.Windows.Forms.Button();
            this.btnAddHistory = new System.Windows.Forms.Button();
            this.dataGridPatient = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegisterforAppointment
            // 
            this.btnRegisterforAppointment.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRegisterforAppointment.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterforAppointment.Location = new System.Drawing.Point(13, 13);
            this.btnRegisterforAppointment.Name = "btnRegisterforAppointment";
            this.btnRegisterforAppointment.Size = new System.Drawing.Size(220, 63);
            this.btnRegisterforAppointment.TabIndex = 0;
            this.btnRegisterforAppointment.Text = "Register for appointment";
            this.btnRegisterforAppointment.UseVisualStyleBackColor = false;
            this.btnRegisterforAppointment.Click += new System.EventHandler(this.btnRegisterforAppointment_Click);
            // 
            // btnPayFee
            // 
            this.btnPayFee.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPayFee.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayFee.Location = new System.Drawing.Point(265, 13);
            this.btnPayFee.Name = "btnPayFee";
            this.btnPayFee.Size = new System.Drawing.Size(220, 63);
            this.btnPayFee.TabIndex = 1;
            this.btnPayFee.Text = "Pay fees ";
            this.btnPayFee.UseVisualStyleBackColor = false;
            this.btnPayFee.Click += new System.EventHandler(this.btnPayFee_Click);
            // 
            // btnAddHistory
            // 
            this.btnAddHistory.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddHistory.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHistory.Location = new System.Drawing.Point(517, 13);
            this.btnAddHistory.Name = "btnAddHistory";
            this.btnAddHistory.Size = new System.Drawing.Size(220, 63);
            this.btnAddHistory.TabIndex = 2;
            this.btnAddHistory.Text = "Add History";
            this.btnAddHistory.UseVisualStyleBackColor = false;
            this.btnAddHistory.Click += new System.EventHandler(this.btnAddHistory_Click);
            // 
            // dataGridPatient
            // 
            this.dataGridPatient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPatient.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridPatient.Location = new System.Drawing.Point(12, 151);
            this.dataGridPatient.Name = "dataGridPatient";
            this.dataGridPatient.Size = new System.Drawing.Size(751, 279);
            this.dataGridPatient.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Medicine";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(265, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 63);
            this.button2.TabIndex = 5;
            this.button2.Text = "View Test";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(778, 442);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridPatient);
            this.Controls.Add(this.btnAddHistory);
            this.Controls.Add(this.btnPayFee);
            this.Controls.Add(this.btnRegisterforAppointment);
            this.Name = "Patient";
            this.Text = "Patient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterforAppointment;
        private System.Windows.Forms.Button btnPayFee;
        private System.Windows.Forms.Button btnAddHistory;
        private System.Windows.Forms.DataGridView dataGridPatient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}