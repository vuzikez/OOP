namespace MedicalCardApplication
{
    partial class Form3
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
            buttonBack = new Button();
            buttonDelete = new Button();
            dateTimePicker = new DateTimePicker();
            labelDate = new Label();
            comboBoxSpecialty = new ComboBox();
            labelSpecialty = new Label();
            textBoxDoctorName = new TextBox();
            labelDoctorName = new Label();
            textBoxPatientName = new TextBox();
            labelPatientName = new Label();
            SuspendLayout();
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonBack.Location = new Point(290, 262);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(150, 50);
            buttonBack.TabIndex = 19;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDelete.Location = new Point(110, 262);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 50);
            buttonDelete.TabIndex = 18;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePicker.Location = new Point(190, 189);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 29);
            dateTimePicker.TabIndex = 17;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDate.Location = new Point(60, 192);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(47, 21);
            labelDate.TabIndex = 16;
            labelDate.Text = "Дата:";
            // 
            // comboBoxSpecialty
            // 
            comboBoxSpecialty.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecialty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxSpecialty.FormattingEnabled = true;
            comboBoxSpecialty.Location = new Point(190, 139);
            comboBoxSpecialty.Name = "comboBoxSpecialty";
            comboBoxSpecialty.Size = new Size(250, 29);
            comboBoxSpecialty.TabIndex = 15;
            // 
            // labelSpecialty
            // 
            labelSpecialty.AutoSize = true;
            labelSpecialty.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSpecialty.Location = new Point(60, 142);
            labelSpecialty.Name = "labelSpecialty";
            labelSpecialty.Size = new Size(123, 21);
            labelSpecialty.TabIndex = 14;
            labelSpecialty.Text = "Специальность:";
            // 
            // textBoxDoctorName
            // 
            textBoxDoctorName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxDoctorName.Location = new Point(190, 89);
            textBoxDoctorName.Name = "textBoxDoctorName";
            textBoxDoctorName.Size = new Size(250, 29);
            textBoxDoctorName.TabIndex = 13;
            // 
            // labelDoctorName
            // 
            labelDoctorName.AutoSize = true;
            labelDoctorName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelDoctorName.Location = new Point(60, 92);
            labelDoctorName.Name = "labelDoctorName";
            labelDoctorName.Size = new Size(90, 21);
            labelDoctorName.TabIndex = 12;
            labelDoctorName.Text = "Имя врача:";
            // 
            // textBoxPatientName
            // 
            textBoxPatientName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPatientName.Location = new Point(190, 39);
            textBoxPatientName.Name = "textBoxPatientName";
            textBoxPatientName.Size = new Size(250, 29);
            textBoxPatientName.TabIndex = 11;
            // 
            // labelPatientName
            // 
            labelPatientName.AutoSize = true;
            labelPatientName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPatientName.Location = new Point(60, 42);
            labelPatientName.Name = "labelPatientName";
            labelPatientName.Size = new Size(116, 21);
            labelPatientName.TabIndex = 10;
            labelPatientName.Text = "Имя пациента:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 350);
            Controls.Add(buttonBack);
            Controls.Add(buttonDelete);
            Controls.Add(dateTimePicker);
            Controls.Add(labelDate);
            Controls.Add(comboBoxSpecialty);
            Controls.Add(labelSpecialty);
            Controls.Add(textBoxDoctorName);
            Controls.Add(labelDoctorName);
            Controls.Add(textBoxPatientName);
            Controls.Add(labelPatientName);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBack;
        private Button buttonDelete;
        private DateTimePicker dateTimePicker;
        private Label labelDate;
        private ComboBox comboBoxSpecialty;
        private Label labelSpecialty;
        private TextBox textBoxDoctorName;
        private Label labelDoctorName;
        private TextBox textBoxPatientName;
        private Label labelPatientName;
    }
}