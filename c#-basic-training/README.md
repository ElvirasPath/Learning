# Prime number checker

A simple console application for checking whether number is prime or not

## Program description

1. The program asks the user to enter a number.
2. The input stored in a variable(`string` converted to `int` using `Try.Parse` method).
3. A `for` loop is used to find out if the number is prime and `do/while` loop allows the user to enter as many numbers as the user want.

## Steps:

1.Use `TryParse()` method to convert a `string` from `Console.ReadLine()` to `int`. If it returns `true`, we have a successfull conversion. If it returns `false`, console prints an error and asks the user to enter a valid number and continue; Use `if/else` statement to control the behavior.

2. Use `for` loop that starts from `i = 2` ends when `i <= result`. The loop increases `i++` in every round.

3. Use operator `%` to find an existense of `remainder` after the division. If `remainder != 0` - a prime number, the loop breaks `break;` when `remainder !=0`. Else - it's a not prime number. Use `if/else` statement to control the behavior.

4. Use `do/while` to allow the user to enter as many number as possible. Console `Console.ReadLine()` asks the user whether to continue or not. If the user enter Yes the loop breaks `break`;.
