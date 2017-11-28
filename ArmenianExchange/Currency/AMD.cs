
namespace ArmenianExchange
{
    class AMD : Course, IUSD, IEUR, IRUB
    {
        public double ToEur(double value)
        {
            return value / eurbuy;
        }
        public double ToRub(double value)
        {
            return value / rubbuy;
        }
        public double ToUsd(double value)
        {
            return value / usdbuy;
        }
    }
}
