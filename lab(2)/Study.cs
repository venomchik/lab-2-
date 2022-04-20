using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_
{
    internal class Study
    {
        
        private int chanceStudent=0;
        private int chanceTeacher=0;


        public void StudyEnglish(int week, int random_, List<Student> students,Teacher teacher,List<string> equipments)
        {
            Random random = new Random(random_);
            chanceTeacher = random.Next(0,100);
            if (chanceTeacher > teacher.GetChance())
            {
                foreach (Student student in students)
                {
                    chanceStudent = random.Next(0, 100);
                    if (chanceStudent > student.GetChance())
                    {
                        double mark = random.Next(40,100);
                        mark = mark * CofEng(student ,teacher, equipments);
                        if(mark>100)
                        {
                            mark = 100;
                        }
                        student.SetMarkEnglish(Convert.ToString(Math.Round(mark, 0)), week);
                        
                    }
                    else
                    {
                        student.SetMarkEnglish("0", week);
                    }
                }

            }
            else
            {
                foreach (Student student in students)
                {
                    student.SetMarkEnglish("0", week);
                }
            }
        }
        private double CofEng(Student student,Teacher teacher, List<string> equipments)
        {
            double cof = 1;
            foreach (string skill in student.GetSkills())
            {
                if (skill == "English")
                {
                    cof = cof * 1.2;
                }
                if (skill == "Ability to learn")
                {
                    cof = cof * 1.05;
                }
                if (skill == "Good memory")
                {
                    cof = cof * 1.05;
                }

            }
            foreach (string skill in teacher.GetSkills())
            {
                if (skill == "English")
                {
                    cof = cof * 1.1;
                }
                if (skill == "Diligence")
                {
                    cof = cof * 1.05;
                }
                if (skill == "Good memory")
                {
                    cof = cof * 1.05;
                }

            }
            foreach (string equip in equipments)
            {
                if (equip == "AudioPlayer")
                {
                    cof = cof * 1.1;
                }
            }
            return cof;
        }


        public void StudyPrograming(int week, int random_, List<Student> students, Teacher teacher, List<string> equipments)
        {
            Random random = new Random(random_);
            chanceTeacher = random.Next(0, 100);
            if (chanceTeacher > teacher.GetChance())
            {
                foreach (Student student in students)
                {
                    chanceStudent = random.Next(0, 100);
                    if (chanceStudent > student.GetChance())
                    {
                        double mark = random.Next(40, 100);
                        mark = mark * CofProg(student, teacher, equipments);
                        if (mark > 100)
                        {
                            mark = 100;
                        }
                        student.SetMarkPrograming(Convert.ToString(Math.Round(mark, 0)), week);

                    }
                    else
                    {
                        student.SetMarkPrograming("0", week);
                    }
                }

            }
            else
            {
                foreach (Student student in students)
                {
                    student.SetMarkPrograming("0", week);
                }
            }
        }
        private double CofProg(Student student, Teacher teacher, List<string> equipments)
        {
            double cof = 1;
            foreach (string skill in student.GetSkills())
            {
                if (skill == "Programing")
                {
                    cof = cof * 1.2;
                }
                if (skill == "Ability to learn")
                {
                    cof = cof * 1.05;
                }
                if (skill == "Knowledge of mathematics")
                {
                    cof = cof * 1.05;
                }

            }
            foreach (string skill in teacher.GetSkills())
            {
                if (skill == "Programing")
                {
                    cof = cof * 1.1;
                }
                if (skill == "Diligence")
                {
                    cof = cof * 1.05;
                }
                if (skill == "Knowledge of mathematics")
                {
                    cof = cof * 1.05;
                }

            }
            foreach (string equip in equipments)
            {
                if (equip == "Computer")
                {
                    cof = cof * 1.3;
                }
            }
            return cof;
        }


        public void StudyMath(int week, int random_, List<Student> students, Teacher teacher, List<string> equipments)
        {
            Random random = new Random(random_);
            chanceTeacher = random.Next(0, 100);
            if (chanceTeacher > teacher.GetChance())
            {
                foreach (Student student in students)
                {
                    chanceStudent = random.Next(0, 100);
                    if (chanceStudent > student.GetChance())
                    {
                        double mark = random.Next(40, 100);
                        mark = mark * CofMath(student, teacher, equipments);
                        if (mark > 100)
                        {
                            mark = 100;
                        }
                        student.SetMarkMath(Convert.ToString(Math.Round(mark, 0)), week);

                    }
                    else
                    {
                        student.SetMarkMath("0", week);
                    }
                }
            }
            else
            {
                foreach (Student student in students)
                {
                    student.SetMarkMath("0", week);
                }
            }
        }
        private double CofMath(Student student, Teacher teacher, List<string> equipments)
        {
            double cof = 1;
            foreach (string skill in student.GetSkills())
            {
                if (skill == "Knowledge of mathematics")
                {
                    cof = cof * 1.2;
                }
                if (skill == "Ability to learn")
                {
                    cof = cof * 1.05;
                }
                if (skill == "Knowledge of physics")
                {
                    cof = cof * 1.05;
                }

            }
            foreach (string skill in teacher.GetSkills())
            {
                if (skill == "Knowledge of mathematics")
                {
                    cof = cof * 1.1;
                }
                if (skill == "Diligence")
                {
                    cof = cof * 1.05;
                }
                if (skill == "Good memory")
                {
                    cof = cof * 1.05;
                }

            }
            foreach (string equip in equipments)
            {
                if (equip == "Computer")
                {
                    cof = cof * 1.05;
                }
            }
            return cof;
        }


        public void StudyPhysics(int week, int random_, List<Student> students, Teacher teacher, List<string> equipments)
        {
            Random random = new Random(random_);
            chanceTeacher = random.Next(0, 100);
            if (chanceTeacher > teacher.GetChance())
            {
                foreach (Student student in students)
                {
                    chanceStudent = random.Next(0, 100);
                    if (chanceStudent > student.GetChance())
                    {
                        double mark = random.Next(40, 100);
                        mark = mark *CofPhys(student, teacher, equipments);
                        if (mark > 100)
                        {
                            mark = 100;
                        }
                        student.SetMarkPhysics(Convert.ToString(Math.Round(mark, 0)), week);

                    }
                    else
                    {
                        student.SetMarkPhysics("0", week);
                    }
                }
            }
            else
            {
                foreach (Student student in students)
                {
                    student.SetMarkPhysics("0", week);
                }
            }
        }
        private double CofPhys(Student student, Teacher teacher, List<string> equipments)
        {
            double cof = 1; 
            foreach (string skill in student.GetSkills())
            {
                if (skill == "Knowledge of mathematics")
                {
                    cof = cof * 1.2;
                }
                if (skill == "Ability to learn")
                {
                    cof = cof * 1.05;
                }
                if (skill == "Knowledge of physics")
                {
                    cof = cof * 1.05;
                }

            }
            foreach (string skill in teacher.GetSkills())
            {
                if (skill == "Knowledge of physics")
                {
                    cof = cof * 1.1;
                }
                if (skill == "Diligence")
                {
                    cof = cof * 1.05;
                }
                if (skill == "Good memory")
                {
                    cof = cof * 1.05;
                }

            }
            foreach (string equip in equipments)
            {
                if (equip == "Computer")
                {
                    cof = cof * 1.1;
                }
            }
            return cof;
        }
    }
}
