namespace Hospital_Project
{
    partial class FrmPatientDashboard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMakeAppointment = new System.Windows.Forms.Button();
            this.rtbSymptoms = new System.Windows.Forms.RichTextBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAppointmentHistory = new System.Windows.Forms.DataGridView();
            this.dgvActiveAppointments = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lnkEditProfile = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentHistory)).BeginInit();
            this.dgvActiveAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkEditProfile);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblFullName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(444, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(189, 78);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 28);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "xxxxxxxx";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(189, 43);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(117, 28);
            this.lblFullName.TabIndex = 17;
            this.lblFullName.Text = "NULL NULL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Email Address:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMakeAppointment);
            this.groupBox2.Controls.Add(this.rtbSymptoms);
            this.groupBox2.Controls.Add(this.cmbDoctor);
            this.groupBox2.Controls.Add(this.cmbDepartment);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(15, 219);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(444, 394);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Panel";
            // 
            // btnMakeAppointment
            // 
            this.btnMakeAppointment.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeAppointment.Location = new System.Drawing.Point(189, 314);
            this.btnMakeAppointment.Name = "btnMakeAppointment";
            this.btnMakeAppointment.Size = new System.Drawing.Size(220, 40);
            this.btnMakeAppointment.TabIndex = 24;
            this.btnMakeAppointment.Text = "Make Appointment";
            this.btnMakeAppointment.UseVisualStyleBackColor = true;
            // 
            // rtbSymptoms
            // 
            this.rtbSymptoms.Location = new System.Drawing.Point(189, 144);
            this.rtbSymptoms.Name = "rtbSymptoms";
            this.rtbSymptoms.Size = new System.Drawing.Size(220, 143);
            this.rtbSymptoms.TabIndex = 22;
            this.rtbSymptoms.Text = "";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(189, 97);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(221, 36);
            this.cmbDoctor.TabIndex = 21;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(189, 49);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(221, 36);
            this.cmbDepartment.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 28);
            this.label9.TabIndex = 19;
            this.label9.Text = "Symptoms:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Department:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Doctor:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAppointmentHistory);
            this.groupBox3.Location = new System.Drawing.Point(493, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(947, 275);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment History";
            // 
            // dgvAppointmentHistory
            // 
            this.dgvAppointmentHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointmentHistory.Location = new System.Drawing.Point(3, 32);
            this.dgvAppointmentHistory.Name = "dgvAppointmentHistory";
            this.dgvAppointmentHistory.RowHeadersWidth = 51;
            this.dgvAppointmentHistory.RowTemplate.Height = 24;
            this.dgvAppointmentHistory.Size = new System.Drawing.Size(941, 240);
            this.dgvAppointmentHistory.TabIndex = 0;
            // 
            // dgvActiveAppointments
            // 
            this.dgvActiveAppointments.Controls.Add(this.dataGridView2);
            this.dgvActiveAppointments.Location = new System.Drawing.Point(493, 338);
            this.dgvActiveAppointments.Name = "dgvActiveAppointments";
            this.dgvActiveAppointments.Size = new System.Drawing.Size(947, 275);
            this.dgvActiveAppointments.TabIndex = 21;
            this.dgvActiveAppointments.TabStop = false;
            this.dgvActiveAppointments.Text = "Active Appointments";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(941, 240);
            this.dataGridView2.TabIndex = 0;
            // 
            // lnkEditProfile
            // 
            this.lnkEditProfile.AutoSize = true;
            this.lnkEditProfile.Location = new System.Drawing.Point(293, 128);
            this.lnkEditProfile.Name = "lnkEditProfile";
            this.lnkEditProfile.Size = new System.Drawing.Size(113, 28);
            this.lnkEditProfile.TabIndex = 19;
            this.lnkEditProfile.TabStop = true;
            this.lnkEditProfile.Text = "Edit Profile";
            // 
            // FrmPatientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1467, 656);
            this.Controls.Add(this.dgvActiveAppointments);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPatientDashboard";
            this.Text = "Patient Dashboard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentHistory)).EndInit();
            this.dgvActiveAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbSymptoms;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMakeAppointment;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvAppointmentHistory;
        private System.Windows.Forms.GroupBox dgvActiveAppointments;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel lnkEditProfile;
    }
}