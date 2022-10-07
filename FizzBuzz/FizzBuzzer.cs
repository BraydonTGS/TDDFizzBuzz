using System;
using static System.Console;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        //when the number is divisible by 3 return the word fizz

        //when the number is divisible by 5 return the word buzz

        //when the number is divisible by both, return the word fizzbuzz

        public string FizzBuzzSolution(int num)
        {
            if ((num % 3 == 0) && (num % 5 == 0))
            {
                return "fizzbuzz";
            }

            else if (num % 3 == 0)
            {
                return "fizz";
            }

            else if (num % 5 == 0)
            {
                return "buzz";
            }

            return "Number is not divistible by 3 or by 5";
        }


    }
}

