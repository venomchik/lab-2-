using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_
{
    internal class Program
    {
        public static void Main()
        {
            
            var e = new Program();
            Console.OutputEncoding=Encoding.UTF8;
            Operation operation = new Operation();
            Student student = new Student();
            
            Teacher teacherEng = new Teacher();
            Teacher teacherProg = new Teacher();
            Teacher teacherMath = new Teacher();
            Teacher teacherPhys = new Teacher();
            string[] teacherEngSkills = { "Diligence", "English", "Knowledge of mathematics" };
            string[] teacherProgSkills = { "Diligence", "Programing", "Knowledge of mathematics" };
            string[] teacherMathSkills = { "Diligence", "Programing", "Knowledge of mathematics" };
            string[] teacherPhysSkills = { "Diligence", "Knowledge of physics", "Knowledge of mathematics" };
            teacherEng.SetName("Oleg"); teacherEng.SetFirstName("Petrenko"); teacherEng.SetLastName("Mihaylovich"); teacherEng.SetChance(5);teacherEng.SetSkills(teacherEngSkills);
            teacherProg.SetName("Vitaliy"); teacherProg.SetFirstName("Kravchuk"); teacherProg.SetLastName("Mihaylovich"); teacherProg.SetChance(5); teacherProg.SetSkills(teacherProgSkills);
            teacherMath.SetName("Victor"); teacherMath.SetFirstName("Mihlyuk"); teacherMath.SetLastName("Andriyovich"); teacherMath.SetChance(5); teacherMath.SetSkills(teacherMathSkills);
            teacherPhys.SetName("Anton"); teacherPhys.SetFirstName("Kliek"); teacherPhys.SetLastName("Antonovich"); teacherPhys.SetChance(5); teacherPhys.SetSkills(teacherPhysSkills);
            
            List<Student> listStudent = new List<Student>();
            List<Student> Subgroup1 = new List<Student>();
            List<Student> Subgroup2 = new List<Student>();
            Console.WriteLine("Введіть кількість студентів");
            int num=int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                student = operation.GetStudent();
             
                listStudent.Add(student);
            }
            Subgroup1 = operation.GetSubgroups(1, listStudent);
            Subgroup2= operation.GetSubgroups(2, listStudent);
            Console.Clear();
            Console.WriteLine("Виберіть предмет для навчання студентів:");
            Console.WriteLine("1. Англійська     |");
            Console.WriteLine("2. Програмування  |");
            Console.WriteLine("3. Математика     |");
            Console.WriteLine("4. Фізика         |");
            Console.WriteLine("5. Всі предмети   |");
            string dis=Console.ReadLine();
            Console.Clear();
            switch (dis)
            {
                case "1":

                    e.Education(Subgroup1, Subgroup2, teacherEng, "Англійська мова");
                    break;

                case "2":
                    e.Education(Subgroup1, Subgroup2, teacherProg, "Програмування");
                    break;
                case "3":
                    e.Education(Subgroup1, Subgroup2, teacherMath, "Математика");
                    break;
                case "4":
                    e.Education(Subgroup1, Subgroup2, teacherPhys, "Фізика");
                    break;
                case "5":

                    e.Education(Subgroup1, Subgroup2, teacherEng, "Англійська мова");
                    e.Education(Subgroup1, Subgroup2, teacherProg, "Програмування");
                    e.Education(Subgroup1, Subgroup2, teacherMath, "Математика");
                    e.Education(Subgroup1, Subgroup2, teacherPhys, "Фізика");
                    break;
            }


            Console.ReadKey();


        }
        void Education(List<Student> Subgroup1, List<Student> Subgroup2, Teacher teacher, string discipline )
        {
            Study study = new Study();
            Random random = new Random();
            List<string> equipments = new List<string>() { "AudioPlayer","Computer"};



            for (int i = 0; i < 10; i++)
            {
                study.StudyEnglish(i + 1, random.Next(), Subgroup1, teacher, equipments);
                study.StudyEnglish(1 + i, random.Next(), Subgroup2, teacher, equipments);
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            
            Console.Write("Перша підгрупа----------------------------");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,25}", "Прізвище", "Ім'я", "По-батькові", discipline);
            Console.WriteLine("{0,-45}|{1,5}|{2,5}|{3,5}|{4,5}|{5,5}|{6,5}|{7,5}|{8,5}|{9,5}|{10,5}|", "Тиждень", "І", "ІІ", "ІІІ", "ІV", "V", "VI", "VII", "VIII", "IX", "X");
            
            Console.ResetColor();
            foreach (Student student1 in Subgroup1)
            {
                
                
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("{0,-15}{1,-15}{2,-15}", student1.GetFirstName(), student1.GetName(), student1.GetLastName());
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Blue;
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("|{0,5}", student1.GetMarkEnglish(i + 1));
                }
                Console.Write("|");
                Console.WriteLine();
                Console.ResetColor();
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            
            Console.Write("Друга підгрупа----------------------------");
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,25}", "Прізвище", "Ім'я", "По-батькові", discipline);
            Console.WriteLine("{0,-45}|{1,5}|{2,5}|{3,5}|{4,5}|{5,5}|{6,5}|{7,5}|{8,5}|{9,5}|{10,5}|", "Тиждень", "І", "ІІ", "ІІІ", "ІV", "V", "VI", "VII", "VIII", "IX", "X");
            Console.ResetColor();
            foreach (Student student2 in Subgroup2)
            {

                
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("{0,-15}{1,-15}{2,-15}", student2.GetFirstName(), student2.GetName(), student2.GetLastName());
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Blue;
                
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("|{0,5}", student2.GetMarkEnglish(i + 1));
                }
                Console.Write("|");
                Console.WriteLine();
                Console.ResetColor();
            }
        }

        void FinalEducation(List<Student> Subgroup1, List<Student> Subgroup2, Teacher teacher)
        {

        }
        
    }
}
