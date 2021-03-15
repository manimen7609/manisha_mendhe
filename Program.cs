using System;

namespace MasyCoda
{
    class SingleDigit
    {
      
        public static void Main()
        {
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (number > 0 || sum > 9)//here I am using while loop to check whether a number which is taken from user is greater than 0 & there sum should be greater than 9(Suppose i have taken a number 786 then I have to add 7+ 8 + 6 = 21 this sum should be greater than 9)
            {
                if (number == 0)
                {
                    number = sum;
                    sum = 0;
                }
                sum = sum + number % 10;
                number /= 10;
            }
            Console.WriteLine("Number is: " + sum);

        }
    }
}


