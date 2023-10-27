using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalHistory
    {
        public MedicalHistory(int recordId, int patientId, string? description, string? date)
        {
            RecordId = recordId;
            PatientId = patientId;
            Description = description;
            Date = date;
        }

        public int RecordId { get; set; }
        public int PatientId { get; set; }
        public string? Description { get; set; }
        public string? Date { get; set; }
        public static List<MedicalHistory> mh=new List<MedicalHistory>();
        public static void CreateFile()
        {
            FileStream file = new FileStream("D:\\Training handson\\Basic soultion\\Assignments\\PatientDetail\\Medicalhistorydetail.txt", FileMode.Create, FileAccess.Write);

        }
        public static void AddMedicalHistory(MedicalHistory mediclhis)
        {
            FileInfo fi = new FileInfo("D:\\Training handson\\Basic soultion\\Assignments\\PatientDetail\\Medicalhistorydetail.txt");
            if (!fi.Exists)
                CreateFile();
            else
            {
              
                FileStream fs = new FileStream("D:\\Training handson\\Basic soultion\\Assignments\\PatientDetail\\Medicalhistorydetail.txt", FileMode.Append, FileAccess.Write);
                mh.Add(mediclhis);
                Console.WriteLine("Medical History added");
                StreamWriter stw = new StreamWriter(fs);
                stw.Write(mediclhis.RecordId + "\t");
                stw.Write(mediclhis.PatientId + "\t");
                stw.Write(mediclhis.Description + "\t");
                stw.Write(mediclhis.Date + "\t");
                stw.WriteLine(" ");
                stw.Flush();
                stw.Close();
                fs.Close();
            }
        }
        public static void ViewMHData()
        {
            FileStream fs = new FileStream("D:\\Training handson\\Basic soultion\\Assignments\\PatientDetail\\Medicalhistorydetail.txt", FileMode.Open, FileAccess.Read);
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
