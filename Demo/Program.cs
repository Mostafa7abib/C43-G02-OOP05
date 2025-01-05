using Demo.Abstraction;
using Demo.CastingOperatorOverloading;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            #region Operators Overloading _ Relational
            //Complex C1 = new Complex(Real = 1, Imag = 2);
            //Complex C2 = new Complex(Real = 2, Imag = 4);
            //if (C1 > C2)
            //    Console.WriteLine("C1 Is Greater");
            //else 
            //    Console.WriteLine("C2 Is Greater");

            //if (C1 == C2)  // == Is compare ref to ref (not objrct state to object state)
            //    Console.WriteLine("C1 == C2");
            //else 
            //    Console.WriteLine("C1 != C2");
            #endregion

            #region Casting Operators Overloading 
            //object obj = 4;
            //int y = (int)obj; // Explicit Casting
            //Complex complex = new Complex() { real = 10, imag = 20 };
            //int X = (int)complex;
            //Console.WriteLine(X);

            //string s = complex;
            //Console.WriteLine(s);
            #endregion

            #region Casting Operatpor Overloading - Mapping
            //User user = new User()
            //{
            //    FullName = "Mostafa Habib",
            //    Email = "Mostafa7abib@gmail.com",
            //    Password = "saasaa",
            //    SecurityStamp = Guid.NewGuid(),
            //    Id = 4
            //};
            //USerViewModel userViewModel = (USerViewModel)user;
            //Console.WriteLine(userViewModel.FirstName);
            //Console.WriteLine(userViewModel.LastName);
            //Console.WriteLine(userViewModel.Email);
            #endregion

            #region Abstraction
            Shape shape = new Shape();  // invalid
            shape.CalcArea();
            Rectangle rectangle = new Rectangle(10, 20);
            rectangle.Dim1 = 10;
            rectangle.Dim2 = 21;
            Console.WriteLine(rectangle.CalcArea());
            Console.WriteLine(rectangle.Premiter);

            Square square = new Square(3);
            Console.WriteLine(square.Premiter);
            Console.WriteLine(square.CalcArea());

            Circle circle = new Circle(4.57m);
            Console.WriteLine(circle.CalcArea());
            Console.WriteLine(circle.Premiter);
            #endregion

        }
    }
}
