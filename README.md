# The Diamond Factory / D1AMOND5

This is (the hardest) exercise 3 from C# course.


The program makes diamond patterns based on user inputs.



### Other

-Prints whole diamonds based on user input, but limits it to 14 .There could be a hint in the title D1AMOND5 ;).
If user tries to print more, no diamonds will be printed but instead the user gets a message.
-The program is also build for testing colors and how to print text where every other letter is in different color
-The program prints every diamond in different color with this (the coolest thing, this gives access to ConsoleColor with variable):

            var colorIndex = 1;
            Console.ForegroundColor = (ConsoleColor)colorIndex;
            Console.ResetColor();

Updatind the colorIndex will give another color. 