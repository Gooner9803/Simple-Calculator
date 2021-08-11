using System;
using static System.Console;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Write first number: ");
            bool IfCorrect1=Double.TryParse(ReadLine(), out double Num1);
            while(!IfCorrect1)
            {
                WriteLine("Wrong format! Try again!.");
                Write("Write first number: ");
                IfCorrect1 = Double.TryParse(ReadLine(), out Num1);
            }
            Write("Write operator (+,-,/,*,%): ");
            char Operator = Char.Parse(ReadLine());
            while(!(Operator=='+'|| Operator == '*'|| Operator == '/'|| Operator == '-'|| Operator == '%'))
            {
                WriteLine("Wrong format! Try again!.");
                Write("Write operator (+,-,/,*,%): ");
                Operator = Char.Parse(ReadLine());
            }
            Write("Write second number: ");
            bool IfCorrect2 = Double.TryParse(ReadLine(), out double Num2);
            while (!IfCorrect2)
            {
                WriteLine("Wrong format! Try again!.");
                Write("Write second number: ");
                IfCorrect2 = Double.TryParse(ReadLine(), out Num2);
            }
            double Result = 0;
            switch (Operator)
            {
                case '+':
                    Result = Num1 + Num2;
                    break;
                case '-':
                    Result = Num1 - Num2;
                    break;
                case '*':
                    Result = Num1 * Num2;
                    break;
                case '/':
                    Result = Num1 / Num2;
                    break;
                case '%':
                    Result = Num1 % Num2;
                    break;
                default:
                    break;
            }
            WriteLine($"Your result: {Result}");
        }
    }
}
