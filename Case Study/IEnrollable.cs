using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_Study
{
    internal interface IEnrollable
    {
         void CourseReg(Student student, Course course);
        void CourseWithdraw(EnrollementRec enrollrec);
    }
}
