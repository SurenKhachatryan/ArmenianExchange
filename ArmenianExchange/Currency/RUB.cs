
namespace ArmenianExchange
{
    class RUB : Course, IAMD, IEUR, IUSD
    {
        public RUB()
        { }

        public RUB(double rubbuy, double rubsell) : base(rubbuy: rubbuy, rubsell: rubsell)
        { }

        public double ToAmd(double value)
        {
            return value * rubbuy;
        }

        public double ToEur(double value)
        {
            return (value * rubbuy) / eursell;
        }

        public double ToUsd(double value)
        {
            return (value * rubbuy) / usdsell;
        }
    }
}
