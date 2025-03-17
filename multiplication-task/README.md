# Multiplication table task

A simple console application for number multiplication

## Program description

1. The program asks the user to enter a number for further multiplication
2. The input is stored in a variable and converts from variable `string` to `int` using the method `int.TryParse`
3. Use `for` loop to get all the results for multiplication table from 1 to 9

## Steps:

1. Use `TryParse()` method to convert a `string` from `Console.ReadLine()` to `int`. If it returns `true`, we have a successfull conversion. If it returns `false`, console prints an error and asks the user to enter a valid number.Use `if/else` statement to control the behavior.

2. Use `for` loop to get all the results from 1 to 9 for the multiplication table.

3. Use `try` statemet to to define a block of code to be tested for errors while it is being executed. Use `catch` statement to to define a block of code to be executed, if an error occurs in the try block.
