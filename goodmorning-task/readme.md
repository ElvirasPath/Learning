# Custom Greeting Program

This project involves designing a program that returns a message to a user based on optional parameters. The program should determine the greeting dynamically, depending on certain conditions.

## Features:

1. Generates a custom greeting based on the current time.

2. Uses DateTime objects to manage program flow.

3. Implements a dictionary as a lookup table for different greetings.

4. Parses user input if necessary.

## Preudocode

GET current time
IF time is morning (06:00 - 12:00)
SET greeting = "Good morning!"
ELSE IF time is afternoon (12:00 - 18:00)
SET greeting = "Good afternoon!"
ELSE
SET greeting = "Good evening!"
PRINT greeting

## Steps

1. User starts the program.

2. The program fetchs the current system time.

3. The program determines the time range (morning, afternoon, evening).

4. The program looks up the corresponding greeting from a dictionary.

5. The console displays the greeting to the user.
