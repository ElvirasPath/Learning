# Even or Odd Number Checker

A simple task for checking password using C#

## Program descriprion:

1. The program asks the user to enter a number
2. The input is stored in a variable and converts from variable `string` to `int` using the method `int.TryParse`
3. A do/while loop is usen to allow the user to enter as many number as the user want, intil the user enters "yes" to exit.

## Steps:

1. Use `TryParse()` method to convert a `string` from `Console.ReadLine()` to `int`. If it returns `true`, we have a successfull conversion. If it returns `false`, console prints an error and asks the user to enter a valid number. Use `if/else` statement to control the behavior.

2. Use operator `int remainder` to check if a number even or odd. If console prints remainder of `0`, then we have an even number.If console prints `int remainder > 0`, then we have an odd number. Use `if/else` statement to control the behavior.

3. Use `do/while` to allow the user to enter as many number as possible. Console `Console.ReadLine` ask the user whether to continue or not. If the user enter `Yes` the loop breaks `break;`.
