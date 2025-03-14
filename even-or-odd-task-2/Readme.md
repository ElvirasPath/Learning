# Even or Odd Number Checker

Making a simple even or odd number checker in a different and less efficient way

## Program description:

1. The program asks the user to enter a number
2. The input is stored in a variable and converts from variable `string` to `int` using the method `int.TryParse`.
3. We check if the last index ends on 0, 2, 4, 6, 8, then it is even number; else - odd number.
4. A do/while loop is used to allow the user to enter as many number as the user want, intil the user enters "yes" to exit.

## Steps:

1. Use `TryParse()` method to convert a string from `Console.ReadLine()` to `int`. If it returns `true`, we have a successfull conversion. If it returns `false`, console prints an error and asks the user to enter a valid number and continue; Use `if/else` statement to control the behavior.

2. Use if/else to check if the number is even ot odd. If the last idex `[userInput.Length - 1]` ends on `'0', '2', '4', '6', '8'` - it is an even number; else - odd number.

3. Use `do/while` to allow the user to enter as many number as possible. Console `Console.ReadLine` ask the user whether to continue or not. If the user enter `Yes` the loop breaks `break;`.
