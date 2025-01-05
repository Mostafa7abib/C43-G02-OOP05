using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static
{
    internal class Utility
    {
        public  int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"X = {X} , Y = {Y}";
        }
        public static double CmInch(double cm)
        {
            return cm / 2.54;
        }

        //private static double pi = 3.14;
        private const double pi = 3.14;

        public static double Pi
        {
            get { return pi; }
        }

        public static double AreaCircle(double redius)
        {
            return redius * redius * Pi;
        }
    }
}
