
namespace ArmenianExchange
{
    class AMD : Course, IUSD, IEUR, IRUB
    {
        public double ToEur(double value)
        {
            return value / eursell;
        }
        public double ToRub(double value)
        {
            return value / rubsell;
        }
        public double ToUsd(double value)
        {
            return value / usdsell;
        }
    }
}
