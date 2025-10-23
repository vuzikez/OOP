using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCardLibrary
{
    public class MedicalCard
    {
        public List<Appointment> appointments = new List<Appointment>();

        public void Add(Appointment appointment)
        {
            appointments.Add(appointment);
        }
        public List<string> GetDoctorsDate(string date)
        {
            List<string> result = new List<string>();
            foreach (Appointment appointment in appointments)
            {
                if (appointment.Date == date)
                {
                    switch (appointment.Doctor.DoctorSpecialty)
                    {
                        case DoctorSpecialty.cardiologist:
                            result.Add("cardiologist");
                            break;
                        case DoctorSpecialty.dentist:
                            result.Add("dentist");
                            break;
                        case DoctorSpecialty.psychiatrist:
                            result.Add("psychiatrist");
                            break;
                        case DoctorSpecialty.oncologist:
                            result.Add("oncologist");
                            break;
                        case DoctorSpecialty.dermatologist:
                            result.Add("dermatologist");
                            break;
                    }
                }
            }
            return result;
        }

        public List<int> GetCountPatientsDoctor(string date)
        {
            int countsCardiologist = 0;
            int countsDentist = 0;
            int countsPsychiatrist = 0;
            int countsOncologist = 0;
            int countsDermatologist = 0;
            List<int> result = new List<int>();
            foreach (Appointment appointment in appointments)
            {
                if (appointment.Date == date)
                {
                    switch (appointment.Doctor.DoctorSpecialty)
                    {
                        case DoctorSpecialty.cardiologist:
                            countsCardiologist++;
                            break;
                        case DoctorSpecialty.dentist:
                            countsDentist++;
                            break;
                        case DoctorSpecialty.psychiatrist:
                            countsPsychiatrist++;
                            break;
                        case DoctorSpecialty.oncologist:
                            countsOncologist++;
                            break;
                        case DoctorSpecialty.dermatologist:
                            countsDermatologist++;
                            break;
                    }
                }
            }
            result.Add(countsCardiologist);
            result.Add(countsDentist);
            result.Add(countsPsychiatrist);
            result.Add(countsOncologist);
            result.Add(countsDermatologist);
            return result;
        }


        public List<double> GetAveragePatientsPerDay()
        {
            var specialties = appointments.GroupBy(a => a.Doctor.DoctorSpecialty);

            List<double> result = new List<double>();

            foreach (DoctorSpecialty specialty in Enum.GetValues(typeof(DoctorSpecialty)))
            {
                var dailyCounts = appointments
                    .Where(a => a.Doctor.DoctorSpecialty == specialty)
                    .GroupBy(a => a.Date)
                    .Select(g => g.Count())
                    .ToList();

                double average = dailyCounts.Count > 0 ? dailyCounts.Average() : 0;
                result.Add(Math.Round(average, 2));
            }

            return result;
        }
    }
}
