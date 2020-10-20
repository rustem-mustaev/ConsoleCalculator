using System;
using System.Threading;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
           
            string input = "";
           
            while(true)
            {
                input = Console.ReadKey().KeyChar.ToString();
                if (input == "\u001b") // Escape
                    break;
                if (input == "A")
                {
                    Console.Clear();
                    Console.Write("A");
                    input += Console.ReadKey().KeyChar.ToString();
                    Thread.Sleep(200);
                }
                Console.Clear();
                Console.WriteLine(calc.Execute(input));
                
            }
            
        }
    }
}
