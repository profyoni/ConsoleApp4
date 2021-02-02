using System; // import // convenience  to refer to classes without having to use the FULLY QUALIFIED NAMESPACE
// Resharper FREE for students - help you learn C#
// NCrunch - code autotester



namespace ConsoleApp4 // package (internal access)
{
    class Person
    {

    }
    internal class Program // may be non-public
    {
        static void Main(String[] args) // methods are Caps
        {
            var num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = MathLibrary.Calc.Plus(num1, num2);
            Console.WriteLine("Hello World!" + sum);

            // data types
            // int, double, float, bool, long, short,char, byte
            UInt16 x; // unsigned Int 0..4b (vs -2b...+2b)
            UInt16 age;

            var text = "My name is Larry"; // implicit typing - determines type based on context
            text = 78.ToString(); // imp typing is particular useful when you dont knw the return type / or dont want to be bothered

            var q = 2m;

            var d = 4.3;
            var TOLERANCE = 0.00001;
            if (Math.Abs(d - 4.3) < TOLERANCE)
            {

            }


            var xyz = new Person();


            // string vs String
        }
    }
}



// UROAR
// pUblic
// PROtected
// pAckage      internal
// pRivate      
