using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_
{
    internal class Group
    {
        private Student[] students;

        public void SetStudents(Student[] students_)
        {
            this.students= students_;
        }
        public Student[] GetStudents()
        {
            return students;
        }
    }
}
