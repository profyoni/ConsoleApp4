using System; // import // convenience  to refer to classes without having to use the FULLY QUALIFIED NAMESPACE
// Resharper FREE for students - help you learn C#
// NCrunch - code autotester



namespace ConsoleApp4 // package (internal access)
{
    internal class Program // may be non-public
    {
        static void Main(String[] args) // methods are Caps
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = MathLibrary.Calc.Add(num1, num2);
            Console.WriteLine("Hello World!" + sum);
        }
    }
}



// UROAR
// pUblic
// PROtected
// pAckage      internal
// pRivate      
