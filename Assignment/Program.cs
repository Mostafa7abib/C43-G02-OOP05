using Assignment.Second_Project;
using Assignment.First_Project;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            #region First Project
            #region Test
            Maths m1 = new Maths(5, 4);
            int Result1 = m1.Sum();
            Maths m2 = new Maths(5, 4);
            int Result2 = m2.Subtract();
            Maths maths3 = new Maths(5, 4);
            int Result3 = maths3.Multiply();
            Maths maths4 = new Maths(5, 4);
            int Result4 = maths4.Divided();
            Console.WriteLine($"Sum: {Result1}");
            Console.WriteLine($"Subtract: {Result2}");
            Console.WriteLine($"Multiply: {Result3}");
            Console.WriteLine($"Divided: {Result4}");
            #endregion

            //Use Static Keyword
            //Maths maths = new Maths();  // Invalid
            //Maths maths;  // Invalid
            Console.WriteLine($"Addition: {Maths.Sum(3, 4)}");
            Console.WriteLine($"Subtract: {Maths.Subtract(6, 2)}");
            Console.WriteLine($"Multiply: {Maths.Multiply(5, 8)}");
            Console.WriteLine($"Divided: {Maths.Divided(8, 2)}");
            Console.WriteLine($"Divided: {Maths.Divided(8, 33)}");
            Console.WriteLine(Maths.Divided(8, 0));
            #endregion

            #region Second Project
            Duration d1 = new Duration(1, 10, 15);
            Console.WriteLine(d1.ToString());
            Duration d2 = new Duration(3600);
            Console.WriteLine(d2.ToString());
            Duration d3 = new Duration(7800);
            Console.WriteLine(d3.ToString()); 
            Duration d4 = new Duration(666);
            Console.WriteLine(d4.ToString());

            d3 = d1 + d2;
            Console.WriteLine(d3);
            d3 = d1 + 7800;
            Console.WriteLine(d3);
            d3 = 666 + d3;
            Console.WriteLine(d3);
            d1 = d1 - d2;
            Console.WriteLine(d1);
            d3 = ++d1;  // In Minutes
            Console.WriteLine(d3);
            d3 = --d2;  // In Minutes
            Console.WriteLine(d3);

            if (d1 > d2)
                Console.WriteLine($"Duration 1 is bigger!");
            else
                Console.WriteLine($"Duration 2 is bigger!");

            if (d1 <= d2)
                Console.WriteLine($"Duration 2 is greater than or equal Duration1!");
            else
                Console.WriteLine($"Duration 1 is bigger!");

            DateTime obj = (DateTime)d1;  // Valid
            Console.WriteLine(obj);
            #endregion 


        }
    }
}
