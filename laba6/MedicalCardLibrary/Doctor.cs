using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCardLibrary
{
    public class Doctor
    {
        private string name { get; }
        private DoctorSpecialty doctorSpecialty { get; }

        public Doctor (string name, DoctorSpecialty doctorSpecialty)
        {
            this.name = name;
            this.doctorSpecialty = doctorSpecialty;
        }

        public string Name  => name;
        public DoctorSpecialty DoctorSpecialty => doctorSpecialty;
    }
}
