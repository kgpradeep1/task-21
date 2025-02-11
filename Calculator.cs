﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_21
{
    public class Calculator
    {
        public static void main()
        {
            int num1;
            int num2;
            string operand;
            float answer;

            Console.Write("Please enter the first integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter an operand (+, -, /, *): ");
            operand = Console.ReadLine();

            Console.Write("Please enter the second integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (operand)
            {

                case "-":
                    answer = num1 - num2;
                    break;

                case "+":
                    answer = num1 + num2;
                    break;

                case "/":
                    answer = num1 / num2;
                    break;

                case "*":
                    answer = num1 * num2;
                    break;

                default:
                    answer = 0;
                    break;
            }
            Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
            Console.ReadLine();
        }
    }
}
