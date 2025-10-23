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
    public partial class Form1 : Form
    {
        private MedicalCard medicalCard = new MedicalCard();

        public Form1()
        {
            InitializeComponent();
            InitializeSampleData();
        }

        // ������������� �������� ������
        private void InitializeSampleData()
        {
            // ������� ������
            Doctor cardiologist = new Doctor("Dr. Ivanov", DoctorSpecialty.cardiologist);
            Doctor dentist = new Doctor("Dr. Petrov", DoctorSpecialty.dentist);
            Doctor psychiatrist = new Doctor("Dr. Sidorov", DoctorSpecialty.psychiatrist);
            Doctor oncologist = new Doctor("Dr. Kuznetsov", DoctorSpecialty.oncologist);
            Doctor dermatologist = new Doctor("Dr. Sokolov", DoctorSpecialty.dermatologist);
            Doctor dentist1 = new Doctor("���", DoctorSpecialty.dentist);

            // ������� ���������
            Patient patient1 = new Patient("Anna");
            Patient patient2 = new Patient("Boris");
            Patient patient3 = new Patient("Vera");
            Patient patient4 = new Patient("Grigory");
            Patient patient5 = new Patient("Diana");
            Patient patient6 = new Patient("Elena");
            Patient patient7 = new Patient("Zakhar");
            Patient patient8 = new Patient("����");

            // ��������� ������ �� ����� ��� 22.10.2025
            medicalCard.Add(new Appointment(new DateTime(2025, 10, 22), cardiologist, patient1));
            medicalCard.Add(new Appointment(new DateTime(2025, 10, 22), cardiologist, patient2));
            medicalCard.Add(new Appointment(new DateTime(2025, 10, 22), dentist, patient3));
            medicalCard.Add(new Appointment(new DateTime(2025, 10, 22), psychiatrist, patient4));

            // ��������� ������ �� ����� ��� 23.10.2025
            medicalCard.Add(new Appointment(new DateTime(2025, 10, 23), cardiologist, patient5));
            medicalCard.Add(new Appointment(new DateTime(2025, 10, 23), dentist, patient6));
            medicalCard.Add(new Appointment(new DateTime(2025, 10, 23), dentist, patient7));
            medicalCard.Add(new Appointment(new DateTime(2025, 10, 23), oncologist, patient1));

            // ��������� ������ �� ����� ��� 24.10.2025
            medicalCard.Add(new Appointment(new DateTime(2025, 10, 24), dermatologist, patient2));
            medicalCard.Add(new Appointment(new DateTime(2025, 10, 24), cardiologist, patient3));

            medicalCard.Add(new Appointment(new DateTime(2025, 12, 17), dentist1, patient8));
        }

        // �������� ������ ������ �� ����
        private void btnGetDoctorsDate_Click(object sender, EventArgs e)
        {
            string date = txtDate.Text.Trim();
            if (string.IsNullOrEmpty(date))
            {
                MessageBox.Show("������� ���� � ������� ��.��.����", "������");
                return;
            }

            List<string> doctors = medicalCard.GetDoctorsDate(date);

            if (doctors.Count == 0)
            {
                txtResult.Text = $"�� ���� {date} �� ������� ������� � ������.";
            }
            else
            {
                txtResult.Text = $"����� �� {date}:\r\n" + string.Join("\r\n", doctors);
            }
        }

        // �������� ���������� ��������� ��� ������� ����� �� ����
        private void btnGetCountPatients_Click(object sender, EventArgs e)
        {
            string date = txtDate.Text.Trim();
            if (string.IsNullOrEmpty(date))
            {
                MessageBox.Show("������� ���� � ������� ��.��.����", "������");
                return;
            }

            List<int> counts = medicalCard.GetCountPatientsDoctor(date);

            string[] specialties = { "Cardiologist", "Dentist", "Psychiatrist", "Oncologist", "Dermatologist" };
            string result = $"���������� ��������� �� {date}:\r\n\r\n";

            for (int i = 0; i < counts.Count; i++)
            {
                result += $"{specialties[i]}: {counts[i]} ���������\r\n";
            }

            txtResult.Text = result;
        }

        // �������� ������� ���������� ��������� � ���� ��� ������� �����
        private void btnGetAveragePatients_Click(object sender, EventArgs e)
        {
            List<double> averages = medicalCard.GetAveragePatientsPerDay();

            string[] specialties = { "Cardiologist", "Dentist", "Psychiatrist", "Oncologist", "Dermatologist" };
            string result = "������� ���������� ��������� � ����:\r\n\r\n";

            for (int i = 0; i < averages.Count; i++)
            {
                result += $"{specialties[i]}: {averages[i]:F2} ���������/����\r\n";
            }

            txtResult.Text = result;
        }

        // ������� ���� ���������� ������
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(medicalCard);
            form2.ShowDialog(); 
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(medicalCard);
            form3.ShowDialog();
        }
    }
}