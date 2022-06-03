using System;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initial field size
            int filedSize = int.Parse(Console.ReadLine());

            int[] ladBugsField = new int[filedSize]; // [0 0 0]

            string[] occupiedIndexes = Console.ReadLine().Split(); // 0 1 => [1 1 0]

            for (int i = 0; i < occupiedIndexes.Length; i++)
            {
                int currentIndex = int.Parse(occupiedIndexes[i]);
                if (currentIndex >= 0 && currentIndex < filedSize)
                {
                    ladBugsField[currentIndex] = 1; // [1 0 0]
                                                    // [1 1 0]
                }
            }

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                bool isFirst = true;
                int currentIndex = int.Parse(commands[0]);
                while (currentIndex >= 0 && currentIndex < filedSize && ladBugsField[currentIndex] != 0)
                {
                    if (isFirst)
                    {
                        ladBugsField[currentIndex] = 0;
                        isFirst = false;
                    }

                    string direction = commands[1];
                    int flightLenght = int.Parse(commands[2]);
                    if (direction == "left")
                    {
                        currentIndex -= flightLenght;
                        if (currentIndex >= 0 && currentIndex < filedSize)
                        {
                            if (ladBugsField[currentIndex] == 0)
                            {
                                ladBugsField[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        currentIndex += flightLenght;
                        if (currentIndex >= 0 && currentIndex < filedSize)
                        {
                            if (ladBugsField[currentIndex] == 0)
                            {
                                ladBugsField[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", ladBugsField));
        }
    }
}
