using System;
using static System.Console;
using FizzBuzz;

var fizz = new FizzBuzzer();


int num = 3;
int num1 = 5;
int num2 = 7;
int num3 = 15;
int num4 = 25;
int num5 = 9;

WriteLine(fizz.FizzBuzzSolution(num));
WriteLine(fizz.FizzBuzzSolution(num1));
WriteLine(fizz.FizzBuzzSolution(num2));
WriteLine(fizz.FizzBuzzSolution(num3));
WriteLine(fizz.FizzBuzzSolution(num4));
WriteLine(fizz.FizzBuzzSolution(num5));

ReadKey();



