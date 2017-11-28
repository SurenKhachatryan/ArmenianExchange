using System.Collections.Generic;

namespace ArmenianExchange
{
    class Course
    {
        protected static double usdbuy { get; private set; }
        protected static double usdsell { get; private set; }
        protected static double rubbuy { get; private set; }
        protected static double rubsell { get; private set; }
        protected static double eurbuy { get; private set; }
        protected static double eursell { get; private set; }
        private static List<string> courselist = new List<string>();

        public List<string> CourseList { get { return courselist; } }

        static Course()
        {
            AddListCourse(483.10, 485.60, 8.09, 8.40, 576.50, 570);
        }

        public Course()
        {

        }

        public Course(double usdbuy = 483.10, double usdsell = 485.60,
                      double rubbuy = 8.09, double rubsell = 8.40,
                      double eurbuy = 576.50, double eursell = 570)
        {
            AddListCourse(usdbuy, usdsell, rubbuy, rubsell, eurbuy, eursell);
        }

        private static void AddListCourse(double usdbuy, double usdsell,
                                          double rubbuy, double rubsell,
                                          double eurbuy, double eursell)
        {
            courselist.Clear();

            courselist.Add($"USD - Buy = {(Course.usdbuy = usdbuy)}");
            courselist.Add($"USD - Sell= {(Course.usdsell = usdsell)}");
            courselist.Add($"RUB - Buy = {(Course.rubbuy = rubbuy)}");
            courselist.Add($"RUB - Sell= {(Course.rubsell = rubsell)}");
            courselist.Add($"EUR - Buy = {(Course.eurbuy = eurbuy)}");
            courselist.Add($"EUR - Sell= {(Course.eursell = eursell)}");
        }
    }

}
