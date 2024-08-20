# WeekFiveClosed
We are producing cars in a car factory.

Car -> Production Date, Serial Number, Brand, Model, Color, Number of Doors

Let's define a Car class with the above properties.

Program flow:

1- Let's ask the user from the console screen whether they want to produce a car. If they want to produce, they should respond with the letter e, if they don't, they should respond with the letter h. Let's eliminate case sensitivity. If they give an invalid answer, let's say that this answer is invalid and ask the same question again.

2- Let's end the program if the user's answer is no, if yes, let's produce a car object and enter its properties to the user from the console screen.

3- The Production Date value will be automatically assigned as the current time when the car is being produced.

4- If a non-numeric value is attempted to be assigned for the Number of Doors, let's prevent the program from throwing an exception, give a warning message and direct the user back to that line. (Research the goto command.)

5- Assign the created car object to a list named cars.

6- Ask the user if he/she wants to create another car, if yes, go back to step 2 in the program flow and create a new car and add it to the list. If the answer is no, print the serial numbers and brands of all elements of the cars list.

*** C# language was used in the construction of this project.
