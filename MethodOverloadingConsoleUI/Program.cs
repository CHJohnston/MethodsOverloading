using System;

namespace MethodOverloadingConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        { //C# Method Overloading - 6/24/2020 PM
            Console.WriteLine("Examples of Method Overloading");

            // #1 - Call the Method Sum passing the two integers
            Console.Write("Enter an Integer ");
            int firstInt = int.Parse(Console.ReadLine());
            Console.Write("Enter another Integer ");
            int secondInt = int.Parse(Console.ReadLine());            
            int integerSum = Sum(firstInt, secondInt);
            Console.WriteLine($"The Sum of these two Integers is {integerSum}");
            Console.WriteLine();

            // #2 - Call the Method Sum passing the two decimals
            Console.Write("Enter a Decimal Number ");
            decimal firstDec = Decimal.Parse(Console.ReadLine());
            Console.Write("Enter another Decimal Number ");
            decimal secondDec = Decimal.Parse(Console.ReadLine());
            decimal decimalSum = Sum(firstDec, secondDec);
            Console.WriteLine($"The Sum of these two Decimals is {decimalSum}");
            Console.WriteLine();

            //#3 - String Sum passed two intergers, and a boolen
            Console.Write("Do you have any Dollar Bills in your Wallet? (Enter Y/N) ");
            string yResponse = (Console.ReadLine());
            bool haveDollars = false;
            int bonusDollars = 0;
            int userDollars = 0;
            if ( yResponse == "Y" || yResponse == "y")                   
            {
                haveDollars = true;
                Console.Write("Enter Your Number of Dollar Bills  ");
                userDollars = int.Parse(Console.ReadLine());
               
                if (userDollars < 5 && userDollars != 1)
                {// Give a Bonus                    
                    bonusDollars = 4;
                    Console.WriteLine($"You get Four Extra Dollar Bills as a Bonus ");
                }
                else 
                {
                    Console.WriteLine($"No Bonus for you ");
                }
             }
            else
            {
                Console.WriteLine("Sorry you don't have any Dollar Bills");
            }
            string stringBonusSum = Sum(userDollars, bonusDollars, haveDollars);
            Console.WriteLine($"Your Total is {stringBonusSum}!!");
        }
        public static int Sum(int num1, int num2)
        // #1- This version of the Sum Method Accepts two integers and returns their sum
        {
            return num1 + num2;
        }
        public static decimal Sum(decimal num1, decimal num2)
        // #2- This version of the Sum Method Accepts two decimals and returns their sum
        {
            return num1 + num2;
        }
        public static string Sum(int num1, int num2, bool shouldAddDollars)
        // #3-This version of the Sum Method Returns a string and is passed two Intergers and a Boolen
        {
            if (shouldAddDollars == true)
                {
                int total = num1 + num2;
                if (total == 1) 
                {
                    return $"{total} dollar";
                }else
                {
                    return $"{total} dollars";
                }
            }
            return " No Dollars in your Wallet!! " ;
        }
    }
}
