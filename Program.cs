using System;

namespace Nelilaskin
{
    class Program
    {
        static void Main(string[] args)

        {
            Calculator calc = new Calculator();

            Console.WriteLine("Anna ensimmäinen luku:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Anna toinen luku:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valitse laskutoimitus (+, -, *, /):");
            string op = Console.ReadLine();

            try
            {
                double result = 0;
                switch (op)
                {
                    case "+":
                        result = calc.Sum(a, b);
                        break;
                    case "-":
                        result = calc.Subtract(a, b);
                        break;
                    case "*":
                        result = calc.Multiply(a, b);
                        break;
                    case "/":
                        result = calc.Divide(a, b);
                        break;
                    default:
                        Console.WriteLine("Tuntematon operaatio.");
                        return;
                }

                Console.WriteLine($"Tulos: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Virhe: {ex.Message}");
            }
        }
    }
}
