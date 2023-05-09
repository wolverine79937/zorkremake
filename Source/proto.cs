using System;

class Program
{
    static void Main(string[] args)
    {
        // Here we will initializ ethe integer variables for score and moves.
        int score = 0;
        int moves = 0;
        const int bufferSize = 20;
        string[] outputBuffer = new string[bufferSize];
        int bufferPos = 0;

        // And now we write the initial status bar to the console
        UpdateStatusBar(score, moves);

        // This is where the game loop will eventually goe.
        // REMEMBER: Whenever we change the score or number of moves, we have to call UpdateStatusBar()
        Console.SetCursorPosition(0, 3);
        Console.Write("ZORK I: The Great Underground Empire" + "\n" + "Copyright (c) 1981, 1982, 1983 Infocom, Inc. All rights reserved."
                      + "\n" + "ZORK is a registered trademark of Infocom, Inc." + "\n" + "Revision 99 / Serial number 501724" + "\n"
                      + "This copy of the game is a hobby remake." + "\n" + "All intelectual material used by this programmer is copyrighted by Infocom." + "\n");

        while (true)
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 1); // Set cursor position to the last row
            Console.Write("> "); // And display the input prompt. It looks funny if you don't include the input line next.

            string input = Console.ReadLine();

            // Clear the previous output before displaying new output
            Console.SetCursorPosition(0, 3); // set cursor position to row 3
            Console.Write(new string(' ', Console.WindowWidth)); // This clears row 3
            Console.SetCursorPosition(0, 4); // And now we move the cursor to row 4 of the console
            Console.Write(new string(' ', Console.WindowWidth)); // Clear row 4.

            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (input.ToLower() == "help")
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine("Commands: quit, help, look, go <direction>");
                UpdateStatusBar(score, moves);
            }
        }
    }

    static void UpdateStatusBar(int score, int moves)
    {
        // Clear the status bar area
        Console.SetCursorPosition(0, 0);
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(new string(' ', Console.WindowWidth));

        // And now we write the score in the left column:
        Console.SetCursorPosition(0, 0);
        Console.Write(" Score: " + score.ToString().PadLeft(5));

        // Now we write the name of the game in the center column:
        Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 0);
        Console.Write("Zork I: The Great Underground Empire");

        // Finally, we write the number of moves in the right column
        Console.SetCursorPosition(Console.WindowWidth - 16, 0);
        Console.Write("Moves: " + moves.ToString().PadLeft(5) + "\n");
        // Reset the console colors
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}