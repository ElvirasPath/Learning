# Inventory System Task

Create an inventory system that can store products, update their quantity, and display information about the available products.

## Program Requirements

1. Define a class for each type of product.

2. Store these products in a collection that can be iterated over.

3. Have the ability to increase or decrease the quantity of products.

4. Include a loop that allows modification of product quantities.

## Each class should have:

1. Name

2. Price

3. Quantity

## Implement validation to ensure data integrity:

1. A product cannot have a negative quantity `productName > 0`.

2. Every product must have a name `string name != IsNullOrEmptySpaces`

3. Use `<List> or <Dictionary>` to hold multiple products.

4. Include a method to display all products and their details.

5. Ensure that product quantity can be increased or decreased but never go below zero `producQuantity > 0`.

## Extra Challenge

1. Add a method to calculate the total number of products and their total value.

2. Implement `userInput` functionality to allow interactive inventory management.

## How to Run:

1. Compile and run the program.

2. Use the interactive menu to add, update, and view products.

3. Ensure that all validation rules are followed.
