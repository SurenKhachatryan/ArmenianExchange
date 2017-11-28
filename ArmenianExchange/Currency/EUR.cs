
namespace ArmenianExchange
{
    class EUR : Course, IAMD, IUSD, IRUB
    {
        public EUR()
        { }

        public EUR(double eurbuy, double eursell) : base(eurbuy: eurbuy, eursell: eursell)
        { }

        public double ToAmd(double value)
        {
            return value * eurbuy;
        }

        public double ToRub(double value)
        {
            return (value * eurbuy) / rubsell;
        }

        public double ToUsd(double value)
        {
            return (value * eurbuy) / usdsell;
        }
    }
}
