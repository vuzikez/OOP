namespace MedicalCardApplication
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblDate = new Label();
            txtDate = new TextBox();
            btnGetDoctorsDate = new Button();
            btnGetCountPatients = new Button();
            btnGetAveragePatients = new Button();
            txtResult = new TextBox();
            btnAddAppointment = new Button();
            btnDeleteAppointment = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(327, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(283, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Медицинская карта";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F);
            lblDate.Location = new Point(30, 90);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(191, 21);
            lblDate.TabIndex = 1;
            lblDate.Text = "Введите дату (дд.мм.гггг):";
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Segoe UI", 12F);
            txtDate.Location = new Point(300, 87);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(200, 29);
            txtDate.TabIndex = 2;
            txtDate.Text = "22.10.2025";
            // 
            // btnGetDoctorsDate
            // 
            btnGetDoctorsDate.Font = new Font("Segoe UI", 10F);
            btnGetDoctorsDate.Location = new Point(30, 150);
            btnGetDoctorsDate.Name = "btnGetDoctorsDate";
            btnGetDoctorsDate.Size = new Size(180, 60);
            btnGetDoctorsDate.TabIndex = 3;
            btnGetDoctorsDate.Text = "Метод 1: Список врачей по дате";
            btnGetDoctorsDate.UseVisualStyleBackColor = true;
            btnGetDoctorsDate.Click += btnGetDoctorsDate_Click;
            // 
            // btnGetCountPatients
            // 
            btnGetCountPatients.Font = new Font("Segoe UI", 10F);
            btnGetCountPatients.Location = new Point(230, 150);
            btnGetCountPatients.Name = "btnGetCountPatients";
            btnGetCountPatients.Size = new Size(180, 60);
            btnGetCountPatients.TabIndex = 4;
            btnGetCountPatients.Text = "Метод 2: Количество пациентов по дате";
            btnGetCountPatients.UseVisualStyleBackColor = true;
            btnGetCountPatients.Click += btnGetCountPatients_Click;
            // 
            // btnGetAveragePatients
            // 
            btnGetAveragePatients.Font = new Font("Segoe UI", 10F);
            btnGetAveragePatients.Location = new Point(430, 150);
            btnGetAveragePatients.Name = "btnGetAveragePatients";
            btnGetAveragePatients.Size = new Size(180, 60);
            btnGetAveragePatients.TabIndex = 5;
            btnGetAveragePatients.Text = "Метод 3: Среднее количество пациентов";
            btnGetAveragePatients.UseVisualStyleBackColor = true;
            btnGetAveragePatients.Click += btnGetAveragePatients_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Courier New", 11F);
            txtResult.Location = new Point(30, 280);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(840, 260);
            txtResult.TabIndex = 6;
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddAppointment.Location = new Point(630, 110);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(240, 60);
            btnAddAppointment.TabIndex = 7;
            btnAddAppointment.Text = "Добавить запись";
            btnAddAppointment.UseVisualStyleBackColor = false;
            btnAddAppointment.Click += btnAddAppointment_Click;
            // 
            // btnDeleteAppointment
            // 
            btnDeleteAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDeleteAppointment.Location = new Point(630, 194);
            btnDeleteAppointment.Name = "btnDeleteAppointment";
            btnDeleteAppointment.Size = new Size(240, 60);
            btnDeleteAppointment.TabIndex = 8;
            btnDeleteAppointment.Text = "Удалить запись";
            btnDeleteAppointment.UseVisualStyleBackColor = false;
            btnDeleteAppointment.Click += btnDeleteAppointment_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 580);
            Controls.Add(btnDeleteAppointment);
            Controls.Add(btnAddAppointment);
            Controls.Add(txtResult);
            Controls.Add(btnGetAveragePatients);
            Controls.Add(btnGetCountPatients);
            Controls.Add(btnGetDoctorsDate);
            Controls.Add(txtDate);
            Controls.Add(lblDate);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Medical Card";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnGetDoctorsDate;
        private System.Windows.Forms.Button btnGetCountPatients;
        private System.Windows.Forms.Button btnGetAveragePatients;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAddAppointment;
        private Button btnDeleteAppointment;
    }
}
