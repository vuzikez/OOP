using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCardLibrary
{
    public class Appointment
    {
        private DateTime date {  get; }
        private Doctor doctor {  get; }
        private Patient patient { get; }
        public Appointment(DateTime date,Doctor doctor, Patient patient)
        {
            this.date = date;
            this.patient = patient;
            this.doctor = doctor;
        }

        public Doctor Doctor => doctor;

        public string Date => date.ToShortDateString();
        public Patient Patient => patient;
    }
}
