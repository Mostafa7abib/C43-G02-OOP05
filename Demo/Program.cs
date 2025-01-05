namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            #region Operators Overloading _ Relational
            Complex C1 = new Complex(Real = 1, Imag = 2);
            Complex C2 = new Complex(Real = 2, Imag = 4);
            if (C1 > C2)
                Console.WriteLine("C1 Is Greater");
            else 
                Console.WriteLine("C2 Is Greater");

            if (C1 == C2)  // == Is compare ref to ref (not objrct state to object state)
                Console.WriteLine("C1 == C2");
            else 
                Console.WriteLine("C1 != C2");
            #endregion

        }
    }
}
