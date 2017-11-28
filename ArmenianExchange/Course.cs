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
            AddListCourse(483.10, 485.60, 8.09, 8.40, 576.50, 570, "ALL");
        }

        public Course()
        {

        }

        protected Course(double usdbuy = 483.10, double usdsell = 485.60,
                         double rubbuy = 8.09, double rubsell = 8.40,
                         double eurbuy = 576.50, double eursell = 570,
                         string currency = "ALL")
        {
            AddListCourse(usdbuy, usdsell, rubbuy, rubsell, eurbuy, eursell, currency);
        }

        private static void AddListCourse(double usdbuy, double usdsell,
                                          double rubbuy, double rubsell,
                                          double eurbuy, double eursell,
                                          string currency)
        {
            if (currency == "ALL" || currency == "USD")
            {
                if (courselist.Count == 0)
                {
                    courselist.Add($"USD - Buy = {(Course.usdbuy = usdbuy)}");
                    courselist.Add($"USD - Sell= {(Course.usdsell = usdsell)}");
                }
                else
                {
                    courselist[0] = $"USD - Buy = {(Course.usdbuy = usdbuy)}";
                    courselist[1] = $"USD - Sell= {(Course.usdsell = usdsell)}";
                }
            }
            if (currency == "ALL" || currency == "RUB")
            {
                if (courselist.Count == 2)
                {
                    courselist.Add($"RUB - Buy = {(Course.rubbuy = rubbuy)}");
                    courselist.Add($"RUB - Sell= {(Course.rubsell = rubsell)}");
                }
                else
                {
                    courselist[2] = $"RUB - Buy = {(Course.rubbuy = rubbuy)}";
                    courselist[3] = $"RUB - Sell= {(Course.rubsell = rubsell)}";
                }
            }
            if (currency == "ALL" || currency == "EUR")
            {
                if (courselist.Count == 4)
                {
                    courselist.Add($"EUR - Buy = {(Course.eurbuy = eurbuy)}");
                    courselist.Add($"EUR - Sell= {(Course.eursell = eursell)}");
                }
                else
                {
                    courselist[4] = $"EUR - Buy = {(Course.eurbuy = eurbuy)}";
                    courselist[5] = $"EUR - Sell= {(Course.eursell = eursell)}";
                }

            }
        }
    }

}
