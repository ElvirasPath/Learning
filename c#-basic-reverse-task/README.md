# Word reverser

A simple console application that reverses words

## Steps:

1. The program asks the user to enter a word. The input stores in a variable `string` and gets from `Console.ReadLine()`.

2. We work with an empty line further because we do not know anything about `reversed string` from the start `string reversed = string.Empty;`

3. Use `for` to find extract all the characters from the `userInput`. The loop starts from the last character.

4. To save all the indexes from every loop use a variable `char` named character. To collect all the characters from every loop, use `reversed = reversed + character` (`i = i + 1`)

5. `Console.WriteLine` prints the reversed word.

6. `do/while` loop allows the user to enter as many words as the user want.
