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
        int width = Console.WindowWidth;

        // And now we write the initial status bar to the console
        UpdateStatusBar(score, moves);

        // This is where the game loop will eventually goe.
        // REMEMBER: Whenever we change the score or number of moves, we have to call UpdateStatusBar()
        Console.SetCursorPosition(0, 1);
        Console.Write("ZORK I: The Great Underground Empire" + "\n" + "Copyright (c) 1981, 1982, 1983 Infocom, Inc. All rights reserved."
                      + "\n" + "ZORK is a registered trademark of Infocom, Inc." + "\n" + "Revision 99 / Serial number 501724" + "\n"
                      + "This copy of the game is a hobby remake." + "\n" + "All intelectual material used by this programmer is copyrighted by Infocom." + "\n"
                      + "Press any key to play...");

        ConsoleKeyInfo key = Console.ReadKey();
        Console.Clear();

        while (true)
        {
            UpdateStatusBar(score, moves);

            // display the last n lines of the output buffer
            int n = Console.WindowHeight - 3;
            for (int i = Math.Max(bufferPos -n, 0); i < bufferPos; i++)
            {
                Console.WriteLine(outputBuffer[i % bufferSize]);
            }

            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write("> ");

            ConsoleKeyInfo keyInfo = Console.ReadKey(); // This is where we read a single key.

            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                outputBuffer[bufferPos % bufferSize] = "You cannot go north at this time.";
                bufferPos++;
            }
            else if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                outputBuffer[bufferPos % bufferSize] = "You cannot go south at this time.";
                bufferPos++;
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                outputBuffer[bufferPos % bufferSize] = "You cannot go west at this time.";
                bufferPos++;
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                outputBuffer[bufferPos % bufferSize] = "You cannot go east at this time.";
                bufferPos++;
            }
            else if (keyInfo.Key == ConsoleKey.PageUp)
            {
                outputBuffer[bufferPos % bufferSize] = "You cannot go up a this time.";
                bufferPos++;
            }
            else if (keyInfo.Key == ConsoleKey.PageDown)
            {
                outputBuffer[bufferPos % bufferSize] = "You cannot go down at this time.";
                bufferPos++;
            }
            else
            {
                string command = keyInfo.KeyChar + Console.ReadLine();

                if (command.ToLower() == "quit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else if (command.ToLower() == "help")
                {
                   outputBuffer[bufferPos % bufferSize] = "Welcome to Zork retold version 0.0.0. This is a prototype. And in this prototype, there is not much you can do yet. You can use the standard four arrow keys to move: North (up), South (down), East (right) and West (left). You can also go up (pageup) and down (pagedown) as well as a handful of commands: 'quit' will end the game.";
                   bufferPos++;
                }
                else if (command.ToLower() == "debug")
                {
                    Console.WriteLine(width);
                    bufferPos++;
                }
            }

/*          else if (input.ToLower() == "help")
            {
                outputBuffer[bufferPos % bufferSize] = "Commands: quit, help, look, go <direction>";
                bufferPos++;
            }
*/        }
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