using System;
using System.Drawing;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace Stars
{
    internal class Program
    {
         static void Main(string[] args)

        {
            //one (slow and not reusable) way to print each other character in different color
            Console.ForegroundColor = ConsoleColor.Red; Console.Write("D");
            Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("I");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("A");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("M");
            Console.ForegroundColor = ConsoleColor.Yellow; Console.Write("O");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("N");
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("D");
            Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("S\n");
            //Resets the color to default==white
            Console.ResetColor();


            

            //One way to print EVERY color the console has, so be mindful what to print inside
            foreach (var item in Enum.GetValues(typeof(ConsoleColor)))
            {

                 Console.ForegroundColor = (ConsoleColor)item;
                 Console.Write("_");

            }
            Console.WriteLine(" ");





            

            //this prints every other char in different colour, took it from stackoverflow 
            //and modified it a bit
            //you could put a "image" here as well
            string[] str = new string[]
              {
          
            " Print diamonds and get rich!",
            " But remember not to get too greedy...",
            "                                      ",
            };

            var index = 2;
            foreach (var item in str)
            {
                for (int i = 0; i < item.Length; i++)
                {

                    Console.Write(item[i]);

                    Console.ForegroundColor = (ConsoleColor)index;
                    index++;
                    //there are only 15 colors and error will occur after that so we have to start from beginning
                    if (index == 15)
                        index = 2;

                }
            }

            //THE COOLEST thing! Finally figured out (not from upper loop, but elsewhere (took time) :D) how to get access to ConsoleColors with variable.
            //the colorIndex starts from 1 to avoid 0(black) and is updated as many times as the user wants to print
            //diamonds, so the color will change every time
            var colorIndex = 1;
            Console.ForegroundColor = (ConsoleColor)colorIndex;
            Console.ResetColor();

            //user inputs
            Console.WriteLine(" ");
            Console.WriteLine("How big diamonds would you like to print? Type a number between 3 or greater: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 100)
            {
                Console.WriteLine("Our factory does not make that big diamonds...");
            }

            Console.WriteLine(" ");


            Console.WriteLine("How many diamonds would you like to print? Type a number: ");
            int howMany = Convert.ToInt32(Console.ReadLine());




            //For loop prints as many diamonds as the user wants
            for (int i = 0; i < howMany; i++)
            {

                //the color gets updated
                colorIndex++;
                Console.ForegroundColor = (ConsoleColor)colorIndex;

                //If user prints more than 15, we have to start the colorIndex from beginning, otherwise a error occurs because 
                //there are no more colors
                if (colorIndex == 15)
                    colorIndex = 1;

                //Calling the method that prints diamonds if under 15
                if(howMany <15)
                {
                    DrawStar(n);
                }
                


                //if user prints 15+ diamonds, the message will trigger
                if (howMany >= 15)
                {
                    Console.WriteLine("TOO GREEDY!");
                }


            }


        }


        //This prints the diamonds, here the method takes the user input n == how big diamonds
        static void DrawStar(int n)

        {
            


            Console.WriteLine(" ");
            
            
            //upper
            for (int i = 1; i < n-1; i++)
            {

                for (int j = 1; j < (n*2)-1; j++)
                {


                    if (j >= (n+1)-i && j <= (n-1)+i)
                    {

                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
            

            //lower
            for (int i = 1; i <= n-1; i++)
            {

                for (int j = 1; j < (n * 2) - 1; j++)
                {


                    if (j >= (n-(n-1))+i && j<= ((n * 2) - 1 )- i)
                    {

                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }



                Console.WriteLine();
            }






        }
        }





    }
