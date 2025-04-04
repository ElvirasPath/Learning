# Calculator Program with Method Overloading (C#)

In this task, we will design a C# program that models a class with method overloads and creates a program flow that executes the different overloads based on user input. The goal is to design a calculator that can perform various mathematical operations based on the user's request.

## Overview

The program will:

- Prompt the user to input a mathematical operation (e.g., addition, subtraction, multiplication, etc.).
- Ask the user for the data (numbers) they want to perform the operation on.
- The user will input a series of numbers separated by a delimiter (e.g., comma or space). The program will parse this input and use it for calculation.

### Key Features:

- **User input parsing**: Handle input parsing and string manipulation to convert user input into numbers.
- **Method overloading**: Implement method overloading for different mathematical operations.
- **Program flow**: Use a loop to continuously ask the user for operations until they choose to exit.

## Pseudocode

```plaintext
1. Start program
2. Display welcome message
3. Start while loop
    4. Ask user for the operation they want to perform (+, -, *, /)
    5. Parse the operation input
    6. Ask the user for the numbers they want to operate on
    7. Parse the numbers (split by a delimiter and convert to floats/integers)
    8. Call the corresponding overloaded method based on the operation
    9. Display the result of the operation
    10. Ask if they want to perform another operation or quit
    11. Exit loop if user chooses to quit
12. End program
```
