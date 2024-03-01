﻿using System;

namespace TarteebTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator ");
            Console.WriteLine("You can enter any number in this format: (2/2, 2*2....)");
            Console.Write("Enter your combination:");

            string userStringInput = Console.ReadLine();
            int operatorIndex = userStringInput.IndexOf('+');
            if (operatorIndex == -1)
            {
                operatorIndex = userStringInput.IndexOf('-');
            }
            else if (operatorIndex == -1)
            {
                operatorIndex = userStringInput.IndexOf('*');
            }
           else if (operatorIndex == -1)
            {
                operatorIndex = userStringInput.IndexOf('/');
            }

            if (operatorIndex == -1)
            {
                Console.WriteLine("Operator not found!");
            }
            string sign = userStringInput.Substring(operatorIndex, 1);

            int firstNumber = int.Parse(userStringInput.Substring(0, operatorIndex));

            int secondNumber = int.Parse(userStringInput.Substring(operatorIndex + 1));

            int result = sign switch
            {
                "+" => firstNumber + secondNumber,
                "*" => firstNumber * secondNumber,
                "/" => firstNumber / secondNumber,
                "-" => firstNumber - secondNumber,
                _ => throw new ArgumentException("Invalid operator"),
            };

            Console.WriteLine($"{firstNumber} {sign} {secondNumber} = {result}");
        }
    }
}