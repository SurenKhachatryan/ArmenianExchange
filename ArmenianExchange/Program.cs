using System;

namespace ArmenianExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Himikva kursna Tpum yst arjuytneri u heto poxum
            Course cs = new Course();

            foreach (var item in cs.CourseList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.Clear();

            EUR eu2 = new EUR(800, 950);

            foreach (var item in cs.CourseList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            #endregion

            #region USD,EUR,RUB To AMD
            Console.WriteLine(new string('=', 25) + " USD,EUR,RUB To AMD");

            IAMD am = new USD();
            Console.WriteLine(am.ToAmd(100) + " amd");

            am = new EUR();
            Console.WriteLine(am.ToAmd(100) + " amd");

            am = new RUB();
            Console.WriteLine(am.ToAmd(7000) + " amd");
            Console.ReadKey();
            #endregion

            #region AMD,EUR,RUB To USD
            Console.WriteLine(new string('=', 25) + " AMD,EUR,RUB To USD");

            IUSD us = new AMD();
            Console.WriteLine(us.ToUsd(25000) + " usd");

            us = new EUR();
            Console.WriteLine(us.ToUsd(100) + " usd");

            us = new RUB();
            Console.WriteLine(us.ToUsd(7000) + " usd");

            Console.ReadKey();
            #endregion

            #region AMD,USD,RUB To EUR
            Console.WriteLine(new string('=', 25) + " AMD,USD,RUB To EUR");

            IEUR eu = new AMD();
            Console.WriteLine(eu.ToEur(25000) + " eur");

            eu = new USD();
            Console.WriteLine(eu.ToEur(100) + " eur");

            eu = new RUB();
            Console.WriteLine(eu.ToEur(7000) + " eur");

            Console.ReadKey();
            #endregion

            #region AMD,USD,EUR To RUB
            Console.WriteLine(new string('=', 25) + " AMD,USD,EUR To RUB");

            IRUB ru = new AMD();
            Console.WriteLine(ru.ToRub(25000) + " rub");

            ru = new USD();
            Console.WriteLine(ru.ToRub(100) + " rub");

            ru = new EUR();
            Console.WriteLine(ru.ToRub(100) + " rub");

            Console.ReadKey();
            #endregion
        }
    }
}
