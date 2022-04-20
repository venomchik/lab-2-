using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_
{
    internal class Human
    {
        private string Name;
        private string FirstName;
        private string LastName;
        private string[] skills;
        private int chance;

        public void SetName(string discipline)
        {
            this.Name = discipline;
        }
        public void SetFirstName(string FirstName)
        {
            this.FirstName = FirstName;
        }
        public void SetLastName(string LastName)
        {
            this.LastName = LastName;
        }
        public void SetSkills(string[] skills)
        {
            this.skills = skills;
        }
        public void SetChance(int chance_)
        {
            this.chance = chance_;
        }



        public string GetName()
        {
            return Name;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public string[] GetSkills()
        {
            return skills;
        }
        public int GetChance()
        {
            return chance; 
        }

    }
}
