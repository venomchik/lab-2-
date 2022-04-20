using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_
{
    internal class Discipline
    {
        private string[] discipline;
        private string[] Marks;

        public void SetMark(string[] marks)
        {
            Marks = marks;
        }
        public void SetDiscipline(string[] disciplines)
        {
            discipline = disciplines;
        }

        public string[] GetDiscipline()
        {
            return discipline;
        }
        public string[] GetMark()
        {
            return Marks;
        }


    }
}
