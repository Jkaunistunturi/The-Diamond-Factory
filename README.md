# The Diamond Factory / D1AMOND5

This is exercise 3 from C# course.


This program was build to test loops and how to draw patterns with it.  



### Other

-Prints whole diamonds based on user input, but limits it to 14 .There could be a hint of the limit in the title D1AMOND5 ;).
If user tries to print more, no diamonds will be printed but instead the user gets a message.
-The program is also build for testing colors and how to print text where every other letter is in different color
-The program prints every diamond in different color with this (the coolest thing I figured out, this gives access to ConsoleColor with variable):

            var colorIndex = 1;
            Console.ForegroundColor = (ConsoleColor)colorIndex;
            Console.ResetColor();

Updatind the colorIndex will give another color. 


#### Comments

Personally I think that knowing what kind of loops to use and how to use them can sometimes be easy/straightforward in other 
contexts, but to truly, really deeply understand them especially in this context takes time.
I used multiple tutorials to get better understanding of the concept and got some ideas to make tests with
colors as well. I learned and solved many new things but still need more practise.
I would like to learn more to use loops this way and make a program that prints different shapes 
and maybe put this kind of printer in some text adventures.
