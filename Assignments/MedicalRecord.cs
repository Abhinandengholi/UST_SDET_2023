using Assignments.ExceptionMesages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalRecord:Patient
    {
      
        public MedicalRecord(int patiendId, string? name, int age, string? diagnosis, int recordId, double treatmentCost) : base(patiendId, name, age, diagnosis)
        {
            RecordId = recordId;
            TreatmentCost = treatmentCost;
        }

        public int RecordId { get; set; }
        public double TreatmentCost { get; set; }
        public static List<MedicalRecord>medrec = new List<MedicalRecord>();
       
        public static void AddRecord(MedicalRecord medicalrecord)
        {
            if (medicalrecord.Name == "" || medicalrecord.Diagnosis == "")
            {
                throw new InvalidPatientDataException(MyException.excpmsg[0]);
            }
            else if (medicalrecord.TreatmentCost<0)
            {
                throw new InvalidMedicalDataException(MyException.excpmsg[1]);
            }
            else
            {
                medrec.Add(medicalrecord);
                Console.WriteLine("medical record added");
            }

        }
    }
}
