using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Lab1
{
    public class Calculator
    {
        private int value;
        private int value2;
        private string operation = "";
        private bool lastSimbolOper = false;
        public string Execute(string input)
        {
            const string error = "E";

            if (!CorrectnessCheck(input))
                return error;

            if (int.TryParse(input, out int number))
            {
                lastSimbolOper = false;
                if(operation == "")
                {
                    value = value * 10 + number;
                    return value.ToString();
                }
                else
                {
                    value2 = value2 * 10 + number;
                    return value2.ToString();
                }
            }
            else
            {
                if(lastSimbolOper && input != "AC")
                {
                    return error;
                }

                if(input == "AC")
                {
                    ClearMemory();
                    return value.ToString();
                }

                if(input == "+" || input == "-" || input == "/" || input== "*" || input == "=")
                {
                    if (input != "=")
                    {
                        lastSimbolOper = true;
                    }
                    
                    if(operation == "")
                    {
                        if (input != "=")
                        {
                            operation = input;
                        }
                           
                        return value.ToString();
                    }
                    else
                    {
                        if (TryOperate(operation))
                        {
                            if (input == "=")
                            {
                                operation = "";
                            }
                            else
                            {
                                operation = input;
                            }
                            value2 = 0;
                            return value.ToString();
                        }
                        else
                        {
                            return error;
                        }
                    }
                }
                return error;
            }
        }

        private bool TryOperate(string oper)
        {
            bool success = true;
            if (oper == "+")
            {
                value += value2;
            }
            if (oper == "-")
            {
                value -= value2;
            }
            if (oper == "/")
            {
                if (value2 == 0)
                {
                    success = false;
                }
                else
                {
                    value /= value2;
                }
            }
            if (oper == "*")
            {
                value *= value2;
            }
            return success;
        }
        private bool CorrectnessCheck(string data)
        {
            return !(data == null || (data.Length != 1 && data != "AC"));
        }

        private void ClearMemory()
        {
            value = 0;
            value2 = 0;
            operation = "";
            lastSimbolOper = false;
        }
    }
}
