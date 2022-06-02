using System;

namespace MoneyFilter
{
    class MoneyFilter
    {
        static void Main(string[] args)
        {
            /*Condition - if the customer gives you 8962 rupees then you have to show how much 2000
             500,100,10 change you have to give */


            //initializing variable and giving them a value 
            int num, a, b, c, d;

            //reciving a value from the employee and putting in num variable
            Console.WriteLine("Enter the Amount = ");
            num = Convert.ToInt32(Console.ReadLine());

            a = num / 2000;                                     // num = 8967 , num (8967) / 2000 = 4 r =967
            Console.WriteLine($"you have to give {a} notes of 2000rs.");

            b = (num % 2000) / 500;                              // num = 8967 , (8967 % 2000)= 967 / 500 = 1, r = 467  
            Console.WriteLine($"you have to give {b} notes of 500rs.");

            c = (num % 2000) % 500 / 100;                       // num = 8967 , (8967 % 2000)= 967 % 500 =467 / 100 = 4 , r =67
            Console.WriteLine($"you have to give {c} notes of 100rs.");

            d = (num % 2000) % 500 % 100 / 10;                  // num = 8967 , (8967 % 2000)= 967 % 500 = 467 % 100 = 67 / 10 = 6, r = 7
            Console.WriteLine($"you have to give {d} notes of 10rs.");

        }
    }
}
