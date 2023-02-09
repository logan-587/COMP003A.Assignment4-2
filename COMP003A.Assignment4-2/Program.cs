/*
 * Author: Logan Smith
 * Course: COMP-003A
 * Purpose: Week 4 Assignment
 */

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(75, '*'));
            Console.WriteLine("For-Loop Section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("".PadRight(75, '*'));

            int limit;


            string? triangleInput;
            Console.Write("\tPlease Enter An Integer: ");
            triangleInput = Console.ReadLine();

            if (!(int.TryParse(triangleInput, out limit)))
            {
                Random randNum = new Random();
                int random = randNum.Next(1, 50);
                Console.WriteLine($"\tGood job failing. Your triangle number is: {random}");
                limit = random;
            }
            else
            {
                limit = Convert.ToInt32(triangleInput);
            }

            Console.WriteLine("\n\tYour triangle: ");
            string output = "#";

            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine($"\t{output}");
                output += "#";
            }

            //*************************************************************************
            Console.WriteLine("\n\n".PadRight(75, '*'));
            Console.WriteLine("For-Each Section");
            Console.WriteLine("Output all the friends from Friends");
            Console.WriteLine("".PadRight(75, '*'));

            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };

            foreach (var friend in friends)
            {
                Console.WriteLine($"\tHere's a friend: {friend}");
            }

            //*************************************************************************
            Console.WriteLine("\n\n".PadRight(75, '*'));
            Console.WriteLine("Do-While Section");
            Console.WriteLine("Count Down From A Number By A Number!");
            Console.WriteLine("".PadRight(75, '*'));

            Console.Write("\n\tCounting up to: ");
            int topGuy = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\tCounting up by: ");
            int counter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n\tHere we go:");
            int increm = 0;

            do
            {
                Console.WriteLine($"\t{increm}");
                increm = increm + counter;

            } while (increm <= topGuy);

            //*************************************************************************
            Console.WriteLine("\n\n".PadRight(75, '*'));
            Console.WriteLine("While-Loop Section");
            Console.WriteLine("Gives An Output Based On Divisibility");
            Console.WriteLine("".PadRight(75, '*'));

            int j = 0;
            int counter2 = 0;
            int newCount = 0;
            int k = 0;
            while (j < 2)
            {
                Console.Write($"\n\tInput an upper limit (You have {2 - j} more chance(s) to input correctly): ");
                string? input2 = Console.ReadLine();

                if (!(int.TryParse(input2, out newCount)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tbruh");
                    Console.ForegroundColor = ConsoleColor.White;
                    j++;
                }
                else
                {
                    j = 3;
                }

            }

            if (j == 2)
            {
                Random randNum = new Random();
                counter2 = randNum.Next(100, 500);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\tYou Disappoint Me");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"\tYour upper limit is: {counter2}");
            }
            else
            {
                counter2 = newCount;
                Console.WriteLine($"\tYour upper limit is: {counter2}");
            }

            Console.WriteLine("\n\tHere we go: ");

            while (k <= counter2)
            {
                if ((k % 2 == 0) && (k % 5 == 0))
                {
                    Console.WriteLine($"\t{k}: FooBar");
                }
                else if (k % 2 == 0)
                {
                    Console.WriteLine($"\t{k}: Foo");
                }
                else if (k % 5 == 0)
                {
                    Console.WriteLine($"\t{k}: Bar");
                }
                else
                {
                    Console.WriteLine($"\t{k}");
                }
                k++;
            }


            //*************************************************************************
            //DON'T READ PAST THIS POINT BEFORE YOU EXECUTE
            //*************************************************************************
            Console.WriteLine("\n\n\n\n".PadRight(75, '*'));
            Console.WriteLine("Riddle Time!");
            Console.WriteLine("".PadRight(75, '*'));

            int answer = 0;
            while (answer == 0)
            {
                Console.Write("\tDavid's father has three sons: Snap, Crackle, and: ");
                string? son = Console.ReadLine();

                if (String.Equals(son, "David"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\tGood Job!");
                    Console.ForegroundColor = ConsoleColor.White;
                    answer = 1;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tTry Again!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
        }
    }
}