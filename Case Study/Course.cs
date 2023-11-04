using Case_Study.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    public class Course : IEnrollable
    {
        public int CourseCode { get; set; }
        public string? Title { get; set; }
        public string? Instructor { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();

        public void CourseReg(Student student, Course course)
        {
            EnrollementRec enroll = new EnrollementRec(student, course);
            int count = 10;
            if (count <= 10)
            {
                EnrollementRec stud = EnrollementRec.enrollementRecrds.FirstOrDefault(s => s.Student.Name == student.Name);
                if (stud == null)
                {
                    EnrollementRec.enrollementRecrds.Add(enroll);
                }
                else
                {
                    throw new EnrollmentException("Student Already Exists");
                }
            }
            else
            {
                throw new EnrollmentException("Course is Full");
            }
        }

        public void CourseWithdraw(EnrollementRec enrollrec)
        {
            EnrollementRec stud = EnrollementRec.enrollementRecrds.FirstOrDefault(s => s.Student.StudentID == enrollrec.Student.StudentID);
            if (stud != null)
            {
                EnrollementRec.enrollementRecrds.Remove(stud);
            }
            else
            {
                throw new EnrollmentException("Can't Find Student");
            }
        }
    }
}