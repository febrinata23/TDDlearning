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
            int num1;
            int num2;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            Mathsx xx = new Mathsx();
            int x = xx.Add(num1, num2);
            Console.WriteLine(x);
            Console.ReadKey();
            int y = xx.Subtract(num1, num2);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
    public class Mathsx
    {
        public Mathsx() { }
        public int Add(int a, int b)
        {
            int x = a + b;
            return x;
        }

        public int Subtract(int a, int b)
        {
            int x = a - b;
            return x;
        }

        public int Adding(int a, int b) 
        {
            return a + b;
        }
        public int devide(int a, int b)
        {
            return a / b;
        }
    }

    public class covertinttostring
    {
        public covertinttostring() { }
        
        public string InttoEnglish(int num)
        {
            if (num == 0)
                return "zero";

            string flag = "";
            if (num < 0)
                flag = "negative ";
            
            return string.Concat(flag,numunderonehundred(Math.Abs(num)));

        }

        public string numundernineteen(int num)
        {
            switch (num)
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

        public string numunderonehundred(int num)
        {
            if (num < 20)
                return numundernineteen(num);

            int satuan = num % 10;
            int puluhan = num / 10;
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
                result = string.Concat(result, " ", numundernineteen(satuan));
            }

            return result;
        }
    }
}
