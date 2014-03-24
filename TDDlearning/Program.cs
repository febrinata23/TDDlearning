using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDlearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers\n");
            int number1;
            int number2;
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());

            MathsOperation testMathOperation = new MathsOperation();
            int x = testMathOperation.Add(number1, number2);
            Console.WriteLine(x);
            Console.ReadKey();
            int y = testMathOperation.Subtract(number1, number2);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
    public class MathsOperation
    {
        public MathsOperation() { }

        public int Subtract(int a, int b)
        {
            int x = a - b;
            return x;
        }

        public int Add(int a, int b) 
        {
            return a + b;
        }

        public int Devide(int a, int b)
        {
            return a / b;
        }
    }

    public class CovertIntegerToString
    {
        public CovertIntegerToString() { }
        
        public string IntegerToString(int number)
        {
            if (number == 0)
                return "zero";

            string flag = "";
            if (number < 0)
                flag = "negative ";
            
            return string.Concat(flag,NumberUnderOneHundredToString(Math.Abs(number)));

        }

        public string NumberUnderNineteenToString(int number)
        {
            switch (number)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eighteen";
                default:
                    return "nineteen";
            }
        }

        public string NumberUnderOneHundredToString(int number)
        {
            if (number < 20)
                return NumberUnderNineteenToString(number);

            int satuan = number % 10;
            int puluhan = number / 10;
            string result = "";

            switch (puluhan)
            {
                case 2:
                    result = "twenty";
                    break;
                case 3:
                    result = "thirty";
                    break;
                case 4:
                    result = "forty";
                    break;
                case 5:
                    result = "fifty";
                    break;
                case 6:
                    result = "sixty";
                    break;
                case 7:
                    result = "seventy";
                    break;
                case 8:
                    result = "eighty";
                    break;
                default:
                    result = "ninety";
                    break;
            }

            if (satuan!=0)
            {
                result = string.Concat(result, " ", NumberUnderNineteenToString(satuan));
            }

            return result;
        }
    }
}
