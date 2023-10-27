using System;
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
       public static  List<Patient> PatDeatils = new List<Patient>();
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
        public static void CreateFile()
        {
            FileStream file = new FileStream("D:\\Training handson\\Basic soultion\\Assignments\\PatientDetail\\PatientDetailson.txt", FileMode.Create, FileAccess.Write);
            // using StreamWriter str = file.CreateText();
            


        }
        public static void PatientDetail(Patient patient)
        {
            FileInfo fi = new FileInfo("D:\\Training handson\\Basic soultion\\Assignments\\PatientDetail\\PatientDetailson.txt");
            if (!fi.Exists)
                CreateFile();
            else
            {
                PatDeatils.Add(patient);
                Console.WriteLine("patient added");
                FileStream fs = new FileStream("D:\\Training handson\\Basic soultion\\Assignments\\PatientDetail\\PatientDetailson.txt", FileMode.Append, FileAccess.Write);
               
                StreamWriter stw = new StreamWriter(fs);
                stw.Write(patient.PatiendId + "\t");
                stw.Write(patient.Name + "\t");
                stw.Write(patient.Age + "\t");
                stw.Write(patient.Diagnosis + "\t");
                stw.WriteLine(" ");
                stw.Flush();
                stw.Close();
                fs.Close();
            }
        }
        public static void ViewPatientData()
        {
            FileStream fs = new FileStream("D:\\Training handson\\Basic soultion\\Assignments\\PatientDetail\\PatientDetailson.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
    }

}
    
