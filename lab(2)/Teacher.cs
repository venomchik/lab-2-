using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_
{
    internal class Teacher:Human
    {        
        private string discipline;
        

        public void SetDiscipline(string discipline)
        {
            this.discipline = discipline;
        }

        public string GetDiscipline()
        {
            return discipline;
        }

    }
}
