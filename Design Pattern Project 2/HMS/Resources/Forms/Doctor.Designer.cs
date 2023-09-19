namespace HMS
{
    partial class Doctor
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
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.dataGridDoctor = new System.Windows.Forms.DataGridView();
            this.btn_AddTest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.Location = new System.Drawing.Point(12, 13);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(224, 57);
            this.btnAddMedicine.TabIndex = 1;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.UseVisualStyleBackColor = true;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // dataGridDoctor
            // 
            this.dataGridDoctor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDoctor.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridDoctor.Location = new System.Drawing.Point(12, 76);
            this.dataGridDoctor.Name = "dataGridDoctor";
            this.dataGridDoctor.Size = new System.Drawing.Size(454, 254);
            this.dataGridDoctor.TabIndex = 4;
            // 
            // btn_AddTest
            // 
            this.btn_AddTest.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTest.Location = new System.Drawing.Point(242, 13);
            this.btn_AddTest.Name = "btn_AddTest";
            this.btn_AddTest.Size = new System.Drawing.Size(224, 57);
            this.btn_AddTest.TabIndex = 5;
            this.btn_AddTest.Text = "Add Test";
            this.btn_AddTest.UseVisualStyleBackColor = true;
            this.btn_AddTest.Click += new System.EventHandler(this.btn_AddTest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.pexels_photo_415825;
            this.pictureBox1.Location = new System.Drawing.Point(472, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 254);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(472, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "View Salary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(962, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_AddTest);
            this.Controls.Add(this.dataGridDoctor);
            this.Controls.Add(this.btnAddMedicine);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.DataGridView dataGridDoctor;
        private System.Windows.Forms.Button btn_AddTest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}