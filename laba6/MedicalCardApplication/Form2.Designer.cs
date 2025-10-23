namespace MedicalCardApplication
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
            labelPatientName = new Label();
            textBoxPatientName = new TextBox();
            labelDoctorName = new Label();
            textBoxDoctorName = new TextBox();
            labelSpecialty = new Label();
            comboBoxSpecialty = new ComboBox();
            labelDate = new Label();
            dateTimePicker = new DateTimePicker();
            buttonAdd = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // labelPatientName
            // 
            labelPatientName.AutoSize = true;
            labelPatientName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPatientName.Location = new Point(50, 50);
            labelPatientName.Name = "labelPatientName";
            labelPatientName.Size = new Size(123, 21);
            labelPatientName.TabIndex = 0;
            labelPatientName.Text = "Имя пациента:";
            // 
            // textBoxPatientName
            // 
            textBoxPatientName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPatientName.Location = new Point(180, 47);
            textBoxPatientName.Name = "textBoxPatientName";
            textBoxPatientName.Size = new Size(250, 29);
            textBoxPatientName.TabIndex = 1;
            // 
            // labelDoctorName
            // 
            labelDoctorName.AutoSize = true;
            labelDoctorName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDoctorName.Location = new Point(50, 100);
            labelDoctorName.Name = "labelDoctorName";
            labelDoctorName.Size = new Size(97, 21);
            labelDoctorName.TabIndex = 2;
            labelDoctorName.Text = "Имя врача:";
            // 
            // textBoxDoctorName
            // 
            textBoxDoctorName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxDoctorName.Location = new Point(180, 97);
            textBoxDoctorName.Name = "textBoxDoctorName";
            textBoxDoctorName.Size = new Size(250, 29);
            textBoxDoctorName.TabIndex = 3;
            // 
            // labelSpecialty
            // 
            labelSpecialty.AutoSize = true;
            labelSpecialty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSpecialty.Location = new Point(50, 150);
            labelSpecialty.Name = "labelSpecialty";
            labelSpecialty.Size = new Size(109, 21);
            labelSpecialty.TabIndex = 4;
            labelSpecialty.Text = "Специальность:";
            // 
            // comboBoxSpecialty
            // 
            comboBoxSpecialty.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecialty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxSpecialty.FormattingEnabled = true;
            comboBoxSpecialty.Location = new Point(180, 147);
            comboBoxSpecialty.Name = "comboBoxSpecialty";
            comboBoxSpecialty.Size = new Size(250, 29);
            comboBoxSpecialty.TabIndex = 5;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDate.Location = new Point(50, 200);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(51, 21);
            labelDate.TabIndex = 6;
            labelDate.Text = "Дата:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker.Location = new Point(180, 197);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 29);
            dateTimePicker.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAdd.Location = new Point(100, 270);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 50);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonBack.Location = new Point(280, 270);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(150, 50);
            buttonBack.TabIndex = 9;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 350);
            Controls.Add(buttonBack);
            Controls.Add(buttonAdd);
            Controls.Add(dateTimePicker);
            Controls.Add(labelDate);
            Controls.Add(comboBoxSpecialty);
            Controls.Add(labelSpecialty);
            Controls.Add(textBoxDoctorName);
            Controls.Add(labelDoctorName);
            Controls.Add(textBoxPatientName);
            Controls.Add(labelPatientName);
            Name = "Form2";
            Text = "Добавить запись";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPatientName;
        private TextBox textBoxPatientName;
        private Label labelDoctorName;
        private TextBox textBoxDoctorName;
        private Label labelSpecialty;
        private ComboBox comboBoxSpecialty;
        private Label labelDate;
        private DateTimePicker dateTimePicker;
        private Button buttonAdd;
        private Button buttonBack;
    }
}