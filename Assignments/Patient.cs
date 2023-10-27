﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Patient
    {
        public Patient(int patiendId, string? name, int age, string? diagnosis)
        {
            PatiendId = patiendId;
            Name = name;
            Age = age;
            Diagnosis = diagnosis;
        }

        public int PatiendId { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Diagnosis { get; set; }
        List<Patient> PatDeatils = new List<Patient>();
        public void AddPatient(Patient patient)
        {
            if ((patient.Age < 0 || patient.Age > 120))
            {
                throw new ArgumentException("age should be in 0-120");
            }
            else if (patient.Name == "" || patient.Diagnosis == "")
            {
                throw new ArgumentException("patient name and diagnosis should not be null");
            }
            else
            {
                PatDeatils.Add(patient);
                Console.WriteLine("patient added");
            }

        }
    }
}