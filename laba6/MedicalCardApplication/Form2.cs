using MedicalCardLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalCardApplication
{
    public partial class Form2 : Form
    {
        private MedicalCard medicalCard;

        public Form2(MedicalCard card)
        {
            InitializeComponent();
            this.medicalCard = card;
            InitializeSpecialtiesComboBox();
        }

        private void InitializeSpecialtiesComboBox()
        {
            // Заполняем комбобокс специальностями из enum
            foreach (DoctorSpecialty specialty in Enum.GetValues(typeof(DoctorSpecialty)))
            {
                comboBoxSpecialty.Items.Add(specialty.ToString());
            }
            comboBoxSpecialty.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем данные из полей ввода
                string patientName = textBoxPatientName.Text;
                string doctorName = textBoxDoctorName.Text;
                DateTime date = dateTimePicker.Value;
                DoctorSpecialty specialty = (DoctorSpecialty)Enum.Parse(typeof(DoctorSpecialty), comboBoxSpecialty.SelectedItem.ToString());

                // Создаем объекты
                Patient patient = new Patient(patientName);
                Doctor doctor = new Doctor(doctorName, specialty);
                Appointment appointment = new Appointment(date, doctor, patient);

                // Добавляем запись в медицинскую карту
                medicalCard.Add(appointment);

                MessageBox.Show("Запись успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очищаем поля для новой записи
                textBoxPatientName.Clear();
                textBoxDoctorName.Clear();
                dateTimePicker.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрываем форму добавления
        }
    }
}