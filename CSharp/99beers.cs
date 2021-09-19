using System;

namespace ninetyNineBeers
{
    class ninetyNineBeers
    {
        static int bottles = 99;

        static int random()
        {
            var rand = new Random();
            return rand.Next(0, 101);
        }

        static void Main()
        {
            while (bottles != 0)
            {
                bool ifWaste = false;
                while (bottles > 1 || bottles <= -1)
                {
                    verse(bottles);
                    bottles--;
                }

                Console.WriteLine($"{bottles} bottle of beer on the wall,");
                Console.WriteLine($"{bottles} bottle of beer.");
                if (random() > 80)
                {
                    Console.Write("If that one bottle should happens to ");
                    Console.WriteLine("fall,");
                    if (random() < 20)
                    {
                        ifWaste = true;
                    }
                }
                else
                {
                    Console.WriteLine("Take one down and pass it around.");
                }

                bottles = Endings.ending(bottles, ifWaste);
            }
        }

        static void verse(int bottles)
        {
            Console.WriteLine($"{bottles} bottle of beer on the wall,");
            Console.WriteLine($"{bottles} bottle of beer.");
            if (random() > 80)
            {
                Console.Write("If one of those bottles should happen to");
                Console.WriteLine("fall,");
                Console.Write($"{bottles - 1} bottles of beer on the");
                Console.WriteLine("wall.\n");
            }
            else if (random() < 20)
            {
                Console.WriteLine("If that one bottle should happens to fall,");
                Console.WriteLine("what a waste of alcohol!\n");
            }
            else
            {
                Console.WriteLine("Take one down and pass it around.");
                Console.Write($"{bottles - 1} bottles of beer on the");
                Console.WriteLine("wall.\n");
            }
        }

        static int infiniteBottles()
        {
            verse(0);
            return -1;
        }
    }

    class Endings
    {
        static int endingPartOne(int bottles, bool waste)
        {
            if (random() == 100 && bottles == 1)
            {
                if (waste)
                {
                    Console.WriteLine("what a waste of alcohol!\n");
                }
                else
                {
                    Console.WriteLine("No more bottles of beer on the wall.\n");
                }

                bottles = infiniteBottles();
            }
            else
            {
                if (waste)
                {
                    Console.WriteLine("what a waste of alcohol!\n");
                }
                else
                {
                    Console.WriteLine("No more bottles of beer on the wall.\n");
                }

                Console.WriteLine("No more bottles of beer on the wall,");
                Console.WriteLine("no more bottles of beer.");
            }

            return endingPartTwo();
        }

        static int endingPartTwo()
        {
            if (random() <= 60)
            {
                bottles = 0;
                if (random() <= 10)
                {
                    Console.WriteLine("There's nothing else to fall,");
                    Console.Write("because there's no more bottles of ");
                    Console.WriteLine("beer on the wall.\n");
                }
                else
                {
                    Console.Write("We've taken them down and passed them");
                    Console.WriteLine("around;");
                    Console.WriteLine("now we're drunk and passed out!\n");
                }
            }
            else
            {
                bottles = 99;
                Console.WriteLine("Go to the store and buy some more,");
                Console.Write($"{bottles} bottles of beer on the");
                Console.WriteLine("wall.\n");
            }
            return bottles;
        }
    }
}
