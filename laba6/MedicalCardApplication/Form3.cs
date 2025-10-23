using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalCardLibrary;

namespace MedicalCardApplication
{
    public partial class Form3 : Form
    {
        private MedicalCard medicalCard;

        public Form3(MedicalCard card)
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

        private void buttonDelete_Click(object sender, EventArgs e)
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
                bool foundDeleted = false;

                foreach (var appm in medicalCard.appointments)
                {
                    if (appm.Doctor.Name.ToLower() == appointment.Doctor.Name.ToLower() 
                        && appm.Date.ToLower() == appointment.Date.ToLower()
                        && appm.Doctor.DoctorSpecialty == appointment.Doctor.DoctorSpecialty
                        && appm.Patient.Name.ToLower() == appointment.Patient.Name.ToLower())
                    {
                        medicalCard.Delete(appm);
                        foundDeleted = true;
                        break;
                    }
                }
                if (foundDeleted)
                {
                    MessageBox.Show("Запись успешно удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPatientName.Clear();
                    textBoxDoctorName.Clear();
                    dateTimePicker.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Запись НЕ найдена, проверьте данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении удалении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
