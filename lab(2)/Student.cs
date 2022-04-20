using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_
{
    internal class Student : Human
    {
        private string status;
        private string[] MarkEnglish = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        private string[] MarkPrograming = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        private string[] MarkMath= { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
        private string[] MarkPhysics = { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };


        public void SetStatus(string status_)
        {
            status = status_;
        }
        public string GetStatus()
        {
            return status;
        }

        public void SetMarkEnglish(string mark,int week)
        {
            MarkEnglish[week - 1] = mark;
        }
        public void SetMarkPrograming(string mark, int week)
        {
            MarkEnglish[week - 1] = mark;
        }
        public void SetMarkMath(string mark, int week)
        {
            MarkEnglish[week - 1] = mark;
        }
        public void SetMarkPhysics(string mark, int week)
        {
            MarkEnglish[week - 1] = mark;
        }

        public string GetMarkEnglish(int week)
        {
            return MarkEnglish[week - 1];
        }
        public string GetMarkPrograming(int week)
        {
            return MarkEnglish[week - 1];
        }
        public string GetMarkMath(int week)
        {
            return MarkEnglish[week - 1];
        }
        public string GetMarkPhysics(int week)
        {
            return MarkEnglish[week - 1];
        }

    }
}
