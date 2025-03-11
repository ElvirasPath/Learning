# Assignment Password Checker
A simple task for checking passwords using C#

## Program description:

1. The program asks the user to enter a password.
2. The input is stored in a variable
3. A loop is used to allow the user to re-enter the password if it does not meet the requirements.

## Conditions:

1. The password must be at least 5 characters long
2. The password must contain both uppercase and lowercase letters
3. The password must include at least one special character (`!?.@:`)

## Steps:

1. Create 3 booleans to check if password meets each condition (bool hasUpper; bool hasLower; bool hasSpecial; bool isLongEnough)
2. Create a string of the spesial characters allowed: `string specialChars = "!?.@:"`
3. Check each condition using `if-else` and a `foreach` loop (directly accesses every character) to check every character in the created password until the user creates a strong password 
    1. if `password < 5` it will be immedialy rejected
    2. if `password >= 5` the program will check it for remaining requirements: `hasUpper = true;` `hasLower = true;` `hasSpecialcharacters = true;`.
4. If password doesn't meet all 3 conditions the program prints an error and asks for a new password.
