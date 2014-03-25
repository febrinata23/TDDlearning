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

            MathsOperation mathOperation = new MathsOperation();
            int numberAdd = mathOperation.Add(number1, number2);
            Console.WriteLine(numberAdd);
            Console.ReadKey();
            int numberSubtract = mathOperation.Subtract(number1, number2);
            Console.WriteLine(numberSubtract);
            Console.ReadKey();
        }
    }
    public class MathsOperation
    {
        public MathsOperation() { }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Devide(int number1, int number2)
        {
            return number1 / number2;
        }
    }

    public class NumbersInWords
    {
        public NumbersInWords() { }

        public string IntegerToString(int number)
        {
            if (number == 0)
                return "zero";

            string flag = "";
            if (number < 0)
                flag = "negative ";

            return string.Concat(flag, NumberUnderOneHundredToString(Math.Abs(number)));

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

            if (satuan != 0)
            {
                result = string.Concat(result, " ", NumberUnderNineteenToString(satuan));
            }

            return result;
        }
    }

    public class FibonacciSequence
    {
        private int _firstNumber;
        private int _secondNumber;
        private int _thirdNumber;

        public FibonacciSequence()
        {
            _firstNumber = 0;
            _secondNumber = 1;
            _thirdNumber = 0;
        }

        public string DisplayFibonacciSequence(int number)
        {
            string result = "";

            for (int iteration = 0; iteration < number; iteration++)
            {
                result += _secondNumber.ToString();
                _thirdNumber = GenerateFibonacciNumber(_firstNumber, _secondNumber);
                _firstNumber = _secondNumber;
                _secondNumber = _thirdNumber;
            }

            return result;
        }

        public int GenerateFibonacciNumber(int number1, int number2)
        {
            return number1 + number2;
        }
    }

    public class PrimeSequence
    {
        private int _firstNumber;

        public PrimeSequence()
        {
            _firstNumber = 2;
        }

        public string DisplayPrimeSequence(int number)
        {
            string result = "";

            while (number > 0)
            {
                if (CheckingNumber(_firstNumber))
                {
                    result += _firstNumber.ToString();
                    number--;
                }
                _firstNumber++;
            }
            return result;
        }

        public bool CheckingNumber(int number)
        {
            int numberClone = number;
            int numberOfModulo = 0;
            bool result = true;

            while (numberClone > 1)
            {
                if ((number % numberClone) == 0)
                {
                    numberOfModulo++;
                    numberClone--;
                    if (numberOfModulo > 1)
                    {
                        result = false;
                        return result;
                    }
                }
                else
                {
                    numberClone--;
                }
            }

            return result;
        }
    }
}
