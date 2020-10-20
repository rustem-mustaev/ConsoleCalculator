using System;

namespace Lab1.Example
{
    public class CalculatorExample
    {
        private int value;

        public string Execute(string input)
        {
            const string error = "E";

            if (input.Length == null || 
                (input.Length != 1 && input != "AC"))
            {
                return error;
            }

            if (int.TryParse(input, out int number))
            {
                value = value * 10 + number;
                return value.ToString();
            }

            if (input == "=")
            {
                return value.ToString();
            }

            if (input == "AC")
            {
                value = 0;
                return value.ToString();
            }

            throw new NotImplementedException();
        }
    }
}
