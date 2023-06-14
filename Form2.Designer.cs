namespace TeacherLMSApp
{
    partial class Form2
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
            this.lblStuId = new System.Windows.Forms.Label();
            this.lblGpa = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtStuId = new System.Windows.Forms.TextBox();
            this.txtGpa = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnStarPupil = new System.Windows.Forms.Button();
            this.lblTopForm2 = new System.Windows.Forms.Label();
            this.grpLMS = new System.Windows.Forms.GroupBox();
            this.grdStudents = new System.Windows.Forms.DataGridView();
            this.btnShowGrid = new System.Windows.Forms.Button();
            this.grpLMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStuId
            // 
            this.lblStuId.AutoSize = true;
            this.lblStuId.Font = new System.Drawing.Font("Elephant", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuId.Location = new System.Drawing.Point(44, 76);
            this.lblStuId.Name = "lblStuId";
            this.lblStuId.Size = new System.Drawing.Size(184, 35);
            this.lblStuId.TabIndex = 2;
            this.lblStuId.Text = "Student ID: ";
            // 
            // lblGpa
            // 
            this.lblGpa.AutoSize = true;
            this.lblGpa.Font = new System.Drawing.Font("Elephant", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGpa.Location = new System.Drawing.Point(44, 251);
            this.lblGpa.Name = "lblGpa";
            this.lblGpa.Size = new System.Drawing.Size(212, 35);
            this.lblGpa.TabIndex = 3;
            this.lblGpa.Text = "Student GPA: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Elephant", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(44, 166);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(225, 35);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Student Name: ";
            // 
            // txtStuId
            // 
            this.txtStuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuId.Location = new System.Drawing.Point(264, 80);
            this.txtStuId.Name = "txtStuId";
            this.txtStuId.Size = new System.Drawing.Size(200, 30);
            this.txtStuId.TabIndex = 5;
            // 
            // txtGpa
            // 
            this.txtGpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGpa.Location = new System.Drawing.Point(264, 255);
            this.txtGpa.Name = "txtGpa";
            this.txtGpa.Size = new System.Drawing.Size(200, 30);
            this.txtGpa.TabIndex = 6;
            this.txtGpa.Validating += new System.ComponentModel.CancelEventHandler(this.txtGpa_Validating);
            // 
            // txtStuName
            // 
            this.txtStuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStuName.Location = new System.Drawing.Point(264, 170);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(200, 30);
            this.txtStuName.TabIndex = 7;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAddStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.Font = new System.Drawing.Font("Elephant", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddStudent.Location = new System.Drawing.Point(562, 104);
            this.btnAddStudent.MaximumSize = new System.Drawing.Size(200, 50);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(200, 50);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDeleteStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteStudent.FlatAppearance.BorderSize = 0;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Elephant", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteStudent.Location = new System.Drawing.Point(562, 223);
            this.btnDeleteStudent.MaximumSize = new System.Drawing.Size(200, 50);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(200, 50);
            this.btnDeleteStudent.TabIndex = 11;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnStarPupil
            // 
            this.btnStarPupil.BackColor = System.Drawing.Color.CadetBlue;
            this.btnStarPupil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStarPupil.FlatAppearance.BorderSize = 0;
            this.btnStarPupil.Font = new System.Drawing.Font("Elephant", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStarPupil.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnStarPupil.Location = new System.Drawing.Point(835, 104);
            this.btnStarPupil.Name = "btnStarPupil";
            this.btnStarPupil.Size = new System.Drawing.Size(258, 50);
            this.btnStarPupil.TabIndex = 12;
            this.btnStarPupil.Text = "Current Star Pupil";
            this.btnStarPupil.UseVisualStyleBackColor = false;
            this.btnStarPupil.Click += new System.EventHandler(this.btnStarPupil_Click);
            // 
            // lblTopForm2
            // 
            this.lblTopForm2.AutoSize = true;
            this.lblTopForm2.Font = new System.Drawing.Font("Elephant", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopForm2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTopForm2.Location = new System.Drawing.Point(380, 9);
            this.lblTopForm2.Name = "lblTopForm2";
            this.lblTopForm2.Size = new System.Drawing.Size(578, 35);
            this.lblTopForm2.TabIndex = 13;
            this.lblTopForm2.Text = "Student Management Learning System";
            // 
            // grpLMS
            // 
            this.grpLMS.BackColor = System.Drawing.Color.SkyBlue;
            this.grpLMS.Controls.Add(this.btnShowGrid);
            this.grpLMS.Controls.Add(this.grdStudents);
            this.grpLMS.Location = new System.Drawing.Point(25, 61);
            this.grpLMS.Name = "grpLMS";
            this.grpLMS.Size = new System.Drawing.Size(1114, 615);
            this.grpLMS.TabIndex = 14;
            this.grpLMS.TabStop = false;
            // 
            // grdStudents
            // 
            this.grdStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudents.Location = new System.Drawing.Point(25, 302);
            this.grdStudents.Name = "grdStudents";
            this.grdStudents.Size = new System.Drawing.Size(1069, 290);
            this.grdStudents.TabIndex = 0;
            this.grdStudents.Visible = false;
            // 
            // btnShowGrid
            // 
            this.btnShowGrid.BackColor = System.Drawing.Color.CadetBlue;
            this.btnShowGrid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShowGrid.FlatAppearance.BorderSize = 0;
            this.btnShowGrid.Font = new System.Drawing.Font("Elephant", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowGrid.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnShowGrid.Location = new System.Drawing.Point(810, 162);
            this.btnShowGrid.Name = "btnShowGrid";
            this.btnShowGrid.Size = new System.Drawing.Size(258, 50);
            this.btnShowGrid.TabIndex = 15;
            this.btnShowGrid.Text = "Show All Students";
            this.btnShowGrid.UseVisualStyleBackColor = false;
            this.btnShowGrid.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1356, 819);
            this.Controls.Add(this.lblTopForm2);
            this.Controls.Add(this.btnStarPupil);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtGpa);
            this.Controls.Add(this.txtStuId);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGpa);
            this.Controls.Add(this.lblStuId);
            this.Controls.Add(this.grpLMS);
            this.MaximumSize = new System.Drawing.Size(1372, 858);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form2";
            this.Text = "Student Management";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpLMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStuId;
        private System.Windows.Forms.Label lblGpa;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtStuId;
        private System.Windows.Forms.TextBox txtGpa;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnStarPupil;
        private System.Windows.Forms.Label lblTopForm2;
        private System.Windows.Forms.GroupBox grpLMS;
        private System.Windows.Forms.DataGridView grdStudents;
        private System.Windows.Forms.Button btnShowGrid;
    }
}