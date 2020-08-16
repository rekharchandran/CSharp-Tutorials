﻿using System;

namespace _55
{
    class Program
    {
        static void Main(string[] args)

        {
            
            // To demonstrate the use of ToLower() method
            String str = "WorldPeaceFoundation";
            string lowerstr = str.ToLower();

            Console.WriteLine(lowerstr);

           

            //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            // Display the result on the console.



            
            int count = 0;
            for (int i = 1; i == 100; i++)
            {
                
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100", count);

           

            // Write a program and continuously ask the user to enter a number. The loop terminates when the user
            // enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.

            
            var sum = 0;

                while(true)

            {
                Console.WriteLine("Enter a number (or'ok' to exit");
                var input = Console.ReadLine();

                if
                    (input.ToLower() == "ok")

                    break;

                sum += Convert.ToInt32(input);
            }

            Console.WriteLine("Sum all numbers is :" + sum);



            // Write a program which takes a single argument from the console, computes the factorial and prints the
            // value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1
            // and display it as 5! = 120.

           

            Console.Write("Enter a number: ");

            var number = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine("{0}! = {1}", number, factorial);


            
            //Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
           // numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
            // display 8 on the console.

            

            Console.Write("Enter commoa separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number= Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);




        }
    }
}
