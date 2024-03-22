using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Fraction
    {
        public int Top { get; }
        public int Bottom { get; }
        /**
        * This constructor takes two optional int
        * arguments and assigns them to the 
        * appropriate properties
        */
        public Fraction(int top = 0, int bottom = 1)
        => (Top, Bottom) = (top, bottom);
        /**
        * Add another constructor that takes two optional string
        * arguments and assigns them to the appropriate
        * properties (of course after conversion).
        */
        public Fraction(string top = "0", string bottom = "1") => (Top, Bottom) = (Convert.ToInt32(top), Convert.ToInt32(bottom));
        public static Fraction operator +(Fraction lhs, Fraction rhs)
        => new Fraction(lhs.Top * rhs.Bottom + rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom);
        public static Fraction operator -(Fraction lhs, Fraction rhs)
        => new Fraction(lhs.Top * rhs.Bottom - rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom);

        public static Fraction operator*(Fraction lhs, Fraction rhs)
        => new Fraction(lhs.Top * rhs.Top, lhs.Bottom * rhs.Bottom);

        public static Fraction operator /(Fraction lhs, Fraction rhs)
        => new Fraction(lhs.Top * rhs.Bottom, lhs.Bottom * rhs.Top);

        public override string ToString() => $"[{Top}, {Bottom}]";
        /**
        * This Deconstructor allows you to get both properties
        * with a single statement.
        */
        private int Simplify(int a, int b)
        {
            if(b == 0)
            {
                return a;
            }
            else
            {
                return Simplify(b, a%b);
            }

        }
        public void Deconstruct(out string top, out string bottom) { 
            int gcd = Simplify(Convert.ToInt32(Top),Convert.ToInt32(Bottom));
            (top, bottom) = ($"{Top/gcd}", $"{Bottom/gcd}"); }
    }
}
