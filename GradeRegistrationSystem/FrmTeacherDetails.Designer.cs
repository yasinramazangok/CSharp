namespace GradeRegistrationSystem
{
    partial class FrmTeacherDetails
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTeacher_StudentSurname = new System.Windows.Forms.TextBox();
            this.txtTeacher_StudentName = new System.Windows.Forms.TextBox();
            this.mtbxTeacher_StudentNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTeacher_ExamThird = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTeacher_ExamFirst = new System.Windows.Forms.TextBox();
            this.txtTeacher_ExamSecond = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTeacher_UnsuccesStudent = new System.Windows.Forms.Label();
            this.lblTeacher_SuccessStudent = new System.Windows.Forms.Label();
            this.lblTeacher_Average = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examFirstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examSecondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examThirdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeRegistrationSystemDataSet = new GradeRegistrationSystem.GradeRegistrationSystemDataSet();
            this.lessonTableAdapter = new GradeRegistrationSystem.GradeRegistrationSystemDataSetTableAdapters.LessonTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeRegistrationSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtTeacher_StudentSurname);
            this.groupBox1.Controls.Add(this.txtTeacher_StudentName);
            this.groupBox1.Controls.Add(this.mtbxTeacher_StudentNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ekle";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(202, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Öğrenciyi Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTeacher_StudentSurname
            // 
            this.txtTeacher_StudentSurname.Location = new System.Drawing.Point(202, 230);
            this.txtTeacher_StudentSurname.Name = "txtTeacher_StudentSurname";
            this.txtTeacher_StudentSurname.Size = new System.Drawing.Size(172, 30);
            this.txtTeacher_StudentSurname.TabIndex = 5;
            // 
            // txtTeacher_StudentName
            // 
            this.txtTeacher_StudentName.Location = new System.Drawing.Point(202, 156);
            this.txtTeacher_StudentName.Name = "txtTeacher_StudentName";
            this.txtTeacher_StudentName.Size = new System.Drawing.Size(172, 30);
            this.txtTeacher_StudentName.TabIndex = 4;
            // 
            // mtbxTeacher_StudentNumber
            // 
            this.mtbxTeacher_StudentNumber.Location = new System.Drawing.Point(202, 82);
            this.mtbxTeacher_StudentNumber.Mask = "0000";
            this.mtbxTeacher_StudentNumber.Name = "mtbxTeacher_StudentNumber";
            this.mtbxTeacher_StudentNumber.Size = new System.Drawing.Size(172, 30);
            this.mtbxTeacher_StudentNumber.TabIndex = 3;
            this.mtbxTeacher_StudentNumber.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(24, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Öğrenci Soyadı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(56, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(7, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numarası :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTeacher_ExamThird);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtTeacher_ExamFirst);
            this.groupBox2.Controls.Add(this.txtTeacher_ExamSecond);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(434, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 359);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Not Düzenleme";
            // 
            // txtTeacher_ExamThird
            // 
            this.txtTeacher_ExamThird.Location = new System.Drawing.Point(119, 230);
            this.txtTeacher_ExamThird.Name = "txtTeacher_ExamThird";
            this.txtTeacher_ExamThird.Size = new System.Drawing.Size(172, 30);
            this.txtTeacher_ExamThird.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumPurple;
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(119, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Notu Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTeacher_ExamFirst
            // 
            this.txtTeacher_ExamFirst.Location = new System.Drawing.Point(119, 82);
            this.txtTeacher_ExamFirst.Name = "txtTeacher_ExamFirst";
            this.txtTeacher_ExamFirst.Size = new System.Drawing.Size(172, 30);
            this.txtTeacher_ExamFirst.TabIndex = 5;
            // 
            // txtTeacher_ExamSecond
            // 
            this.txtTeacher_ExamSecond.Location = new System.Drawing.Point(119, 156);
            this.txtTeacher_ExamSecond.Name = "txtTeacher_ExamSecond";
            this.txtTeacher_ExamSecond.Size = new System.Drawing.Size(172, 30);
            this.txtTeacher_ExamSecond.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(24, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sınav 1 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(24, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sınav 2 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(21, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sınav 3 : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTeacher_UnsuccesStudent);
            this.groupBox3.Controls.Add(this.lblTeacher_SuccessStudent);
            this.groupBox3.Controls.Add(this.lblTeacher_Average);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(778, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 359);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınıf İstatistikleri";
            // 
            // lblTeacher_UnsuccesStudent
            // 
            this.lblTeacher_UnsuccesStudent.AutoSize = true;
            this.lblTeacher_UnsuccesStudent.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTeacher_UnsuccesStudent.Location = new System.Drawing.Point(260, 202);
            this.lblTeacher_UnsuccesStudent.Name = "lblTeacher_UnsuccesStudent";
            this.lblTeacher_UnsuccesStudent.Size = new System.Drawing.Size(34, 25);
            this.lblTeacher_UnsuccesStudent.TabIndex = 9;
            this.lblTeacher_UnsuccesStudent.Text = "00";
            // 
            // lblTeacher_SuccessStudent
            // 
            this.lblTeacher_SuccessStudent.AutoSize = true;
            this.lblTeacher_SuccessStudent.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTeacher_SuccessStudent.Location = new System.Drawing.Point(260, 142);
            this.lblTeacher_SuccessStudent.Name = "lblTeacher_SuccessStudent";
            this.lblTeacher_SuccessStudent.Size = new System.Drawing.Size(34, 25);
            this.lblTeacher_SuccessStudent.TabIndex = 8;
            this.lblTeacher_SuccessStudent.Text = "00";
            // 
            // lblTeacher_Average
            // 
            this.lblTeacher_Average.AutoSize = true;
            this.lblTeacher_Average.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTeacher_Average.Location = new System.Drawing.Point(257, 82);
            this.lblTeacher_Average.Name = "lblTeacher_Average";
            this.lblTeacher_Average.Size = new System.Drawing.Size(34, 25);
            this.lblTeacher_Average.TabIndex = 7;
            this.lblTeacher_Average.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Coral;
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(88, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sınıf Ortalaması : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SpringGreen;
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(35, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Başarılı Öğrenci Sayısı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(14, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Başarısız Öğrenci Sayısı : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 388);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1106, 303);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.studentNumberDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentSurnameDataGridViewTextBoxColumn,
            this.examFirstDataGridViewTextBoxColumn,
            this.examSecondDataGridViewTextBoxColumn,
            this.examThirdDataGridViewTextBoxColumn,
            this.averageDataGridViewTextBoxColumn,
            this.stateDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.lessonBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1100, 274);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "Student_Id";
            this.studentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNumberDataGridViewTextBoxColumn
            // 
            this.studentNumberDataGridViewTextBoxColumn.DataPropertyName = "Student_Number";
            this.studentNumberDataGridViewTextBoxColumn.HeaderText = "Student_Number";
            this.studentNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNumberDataGridViewTextBoxColumn.Name = "studentNumberDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentSurnameDataGridViewTextBoxColumn
            // 
            this.studentSurnameDataGridViewTextBoxColumn.DataPropertyName = "Student_Surname";
            this.studentSurnameDataGridViewTextBoxColumn.HeaderText = "Student_Surname";
            this.studentSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentSurnameDataGridViewTextBoxColumn.Name = "studentSurnameDataGridViewTextBoxColumn";
            // 
            // examFirstDataGridViewTextBoxColumn
            // 
            this.examFirstDataGridViewTextBoxColumn.DataPropertyName = "Exam_First";
            this.examFirstDataGridViewTextBoxColumn.HeaderText = "Exam_First";
            this.examFirstDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.examFirstDataGridViewTextBoxColumn.Name = "examFirstDataGridViewTextBoxColumn";
            // 
            // examSecondDataGridViewTextBoxColumn
            // 
            this.examSecondDataGridViewTextBoxColumn.DataPropertyName = "Exam_Second";
            this.examSecondDataGridViewTextBoxColumn.HeaderText = "Exam_Second";
            this.examSecondDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.examSecondDataGridViewTextBoxColumn.Name = "examSecondDataGridViewTextBoxColumn";
            // 
            // examThirdDataGridViewTextBoxColumn
            // 
            this.examThirdDataGridViewTextBoxColumn.DataPropertyName = "Exam_Third";
            this.examThirdDataGridViewTextBoxColumn.HeaderText = "Exam_Third";
            this.examThirdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.examThirdDataGridViewTextBoxColumn.Name = "examThirdDataGridViewTextBoxColumn";
            // 
            // averageDataGridViewTextBoxColumn
            // 
            this.averageDataGridViewTextBoxColumn.DataPropertyName = "Average";
            this.averageDataGridViewTextBoxColumn.HeaderText = "Average";
            this.averageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.averageDataGridViewTextBoxColumn.Name = "averageDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewCheckBoxColumn
            // 
            this.stateDataGridViewCheckBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewCheckBoxColumn.HeaderText = "State";
            this.stateDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewCheckBoxColumn.Name = "stateDataGridViewCheckBoxColumn";
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataMember = "Lesson";
            this.lessonBindingSource.DataSource = this.gradeRegistrationSystemDataSet;
            // 
            // gradeRegistrationSystemDataSet
            // 
            this.gradeRegistrationSystemDataSet.DataSetName = "GradeRegistrationSystemDataSet";
            this.gradeRegistrationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lessonTableAdapter
            // 
            this.lessonTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTeacherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1131, 705);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTeacherDetails";
            this.Text = "Öğretmen İşlemleri";
            this.Load += new System.EventHandler(this.FrmTeacherDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeRegistrationSystemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTeacher_StudentSurname;
        private System.Windows.Forms.TextBox txtTeacher_StudentName;
        private System.Windows.Forms.MaskedTextBox mtbxTeacher_StudentNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTeacher_ExamThird;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTeacher_ExamFirst;
        private System.Windows.Forms.TextBox txtTeacher_ExamSecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTeacher_UnsuccesStudent;
        private System.Windows.Forms.Label lblTeacher_SuccessStudent;
        private System.Windows.Forms.Label lblTeacher_Average;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GradeRegistrationSystemDataSet gradeRegistrationSystemDataSet;
        private System.Windows.Forms.BindingSource lessonBindingSource;
        private GradeRegistrationSystemDataSetTableAdapters.LessonTableAdapter lessonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examFirstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examSecondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examThirdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stateDataGridViewCheckBoxColumn;
    }
}