using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_
{
    internal class Operation
    {
        Random random = new Random();
        private string[] DataName = { "Vitaliy", "Ivan", "Vlad", "Olexandr", "Illya", "Anton", "Max", "Nazar", "Victor",
                                      "Taras", "Rostislav", "Kostyantin", "Mikola", "Andriy", "Oleg", "Ostap", "Denis"};
        private string[] DataFirstName = { "Kravchuk", "Kucheruk", "Oliverchuk", "Dmitruk", "Gopanchuk", "Korolchuk", "Korol",
                                           "Denisuk", "Virniy", "Nakonechiy", "Opalko", "Bereza", "Malinskiy", "Kliek"};
        private string[] DataLastName = { "Mihaylovich", "Ivanovich", "Olexandrovich", "Illich", "Antonovich", "Maximovich", "Nazarovich",
                                          "Victorovich", "Tarasovich", "Rostislavovich", "Kostyantinovich", "Mikolayovich", "Andriyovich", "Olegovich", "Ostapovich", "Denisivich"};
        private string[] DataSkills = { "English", "Programing", "Diligence", "Ability to learn", "Good memory", "Intuition",
                                        "Knowledge of physics","Knowledge of mathematics","Ability to communicate" };

        public Student GetStudent()
        {
            Student student = new Student();
            student.SetName(DataName[random.Next(17)]);
            student.SetFirstName(DataFirstName[random.Next(14)]);
            student.SetLastName(DataLastName[random.Next(16)]);
            string[] skill = { DataSkills[random.Next(9)], DataSkills[random.Next(9)], DataSkills[random.Next(9)] };
            student.SetSkills(skill);
            student.SetChance(random.Next(15));
            return student;
        }

        public List<Student> GetSubgroups(int num, List<Student> students)
        {
            List<Student> returnStudents = new List<Student>();
            int i = 0;
            foreach(Student student in students)
            {
                
                if (num == 1)
                {

                    if (i % 2 == 0)
                    {
                        returnStudents.Add(student);

                    }
                    


                }
                if (num == 2)
                {

                    if (i % 2 == 1)
                    {
                        returnStudents.Add(student);

                    }
                    

                }

                i++;
                
            }

            return returnStudents;
            
        }

        

    }
}
