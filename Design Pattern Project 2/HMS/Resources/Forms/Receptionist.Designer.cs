namespace HMS
{
    partial class Receptionist
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
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnViewDoctor = new System.Windows.Forms.Button();
            this.btnRecievePatientCharges = new System.Windows.Forms.Button();
            this.dataGridReceptionist = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceptionist)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddPatient.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(34, 6);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(199, 45);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnViewDoctor
            // 
            this.btnViewDoctor.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnViewDoctor.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDoctor.Location = new System.Drawing.Point(359, 6);
            this.btnViewDoctor.Name = "btnViewDoctor";
            this.btnViewDoctor.Size = new System.Drawing.Size(174, 45);
            this.btnViewDoctor.TabIndex = 2;
            this.btnViewDoctor.Text = "View Doctor";
            this.btnViewDoctor.UseVisualStyleBackColor = false;
            this.btnViewDoctor.Click += new System.EventHandler(this.btnViewDoctor_Click);
            // 
            // btnRecievePatientCharges
            // 
            this.btnRecievePatientCharges.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRecievePatientCharges.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecievePatientCharges.Location = new System.Drawing.Point(674, 6);
            this.btnRecievePatientCharges.Name = "btnRecievePatientCharges";
            this.btnRecievePatientCharges.Size = new System.Drawing.Size(259, 45);
            this.btnRecievePatientCharges.TabIndex = 5;
            this.btnRecievePatientCharges.Text = "Recieve Patient\'s charges";
            this.btnRecievePatientCharges.UseVisualStyleBackColor = false;
            this.btnRecievePatientCharges.Click += new System.EventHandler(this.btnRecievePatientCharges_Click);
            // 
            // dataGridReceptionist
            // 
            this.dataGridReceptionist.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridReceptionist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReceptionist.Location = new System.Drawing.Point(13, 180);
            this.dataGridReceptionist.Name = "dataGridReceptionist";
            this.dataGridReceptionist.Size = new System.Drawing.Size(618, 229);
            this.dataGridReceptionist.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "View Salary";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::HMS.Properties.Resources.customer_at_reception_concept_in_flat_vector_8959632;
            this.ClientSize = new System.Drawing.Size(943, 499);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridReceptionist);
            this.Controls.Add(this.btnRecievePatientCharges);
            this.Controls.Add(this.btnViewDoctor);
            this.Controls.Add(this.btnAddPatient);
            this.Name = "Receptionist";
            this.Text = "Receptionist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReceptionist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnViewDoctor;
        private System.Windows.Forms.Button btnRecievePatientCharges;
        private System.Windows.Forms.DataGridView dataGridReceptionist;
        private System.Windows.Forms.Button button1;
    }
}