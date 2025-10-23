using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalCardLibrary
{
    public class Patient
    {
        private string name { get; }

        public Patient (string name)
        {
            this.name = name;
        }

        public string Name { get => name; }
    }
}
