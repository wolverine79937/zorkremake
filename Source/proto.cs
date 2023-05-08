/* This is my original source. I didn't want to dump it just yet.
 * using System;

class Program
{
    static void Main(string[] args)
    {
        // Set up the console window
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Clear();
        int totalWidth = Console.WindowWidth;
        int columnWidth = (totalWidth - 2) / 3;
        int score = 0;
        int moves = 0;

        // Initialize variables for status line
        string tScore = "$Score: " + score;
        string title = "The Bio Game";
        string tMoves = "Moves: " + moves;

        // Set up the status bar at the top of the console window
        Console.SetCursorPosition(0, 0);
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Black;
        string status = tScore.PadRight(columnWidth) + " " + title.PadRight(columnWidth) + " " + tMoves.PadRight(columnWidth);
        Console.WriteLine(status);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.DarkGray;

        // Prompt the user for their name
        Console.SetCursorPosition(0, 2);
        Console.Write($"The current width of this console is: { totalWidth}\nWhat is your name? ");
        string name = Console.ReadLine();

        // Prompt the user for their age
        Console.SetCursorPosition(0, 4);
        Console.WriteLine("How old are you? ");
        int age = int.Parse(Console.ReadLine());
        score += 1;
        status = tScore.PadRight(columnWidth) + " " + title.PadRight(columnWidth) + " " + tMoves.PadRight(columnWidth);

        // Update the status bar with the player's initial score
        Console.SetCursorPosition(0, 0);
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(status);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.DarkGray;

        // Set the console colors back to gray and white
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.DarkGray;

        // Print a personalized message
        Console.SetCursorPosition(0, 6);
        Console.WriteLine($"Hello, {name}! You are {age} years old.\nBy the way, your score just went up 1 point.");
        Console.ReadLine();
    }
}
*/

using System;

class Program
{
    static void Main()
    {
        // Here we will initializ ethe integer variables for score and moves.
        int score = 0;
        int moves = 0;

        // And now we write the initial status bar to the console
        UpdateStatusBar(score, moves);

        // This is where the game loop will eventually goe.
        // REMEMBER: Whenever we upchange the score or number of moves, we have to call UpdateStatusBar()

        // And now we will make an example of updating the score and moves.
        //        score += 10;
        //      moves += 1;
        //    UpdateStatusBar(score, moves);

        // We are going to prompt the user for their name:
        Console.SetCursorPosition(0, 2);
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        // Here, we will update the move snad score by 1 each.
        score += 1;
        moves += 1;
        UpdateStatusBar(score, moves);

        // For now, we still have to move the cursor manually. This is going to be fixed in the near future.
        Console.SetCursorPosition(0, 4);
        Console.Write("How old are you? ");
        int age = int.Parse(Console.ReadLine());

        // Now, we are going to set the score to 100 points for solving the game in 2 moves.
        score = 100;
        moves += 1;
        UpdateStatusBar(score, moves);

        Console.SetCursorPosition(0, 6);

        // Now to tkeep the console open until we press a key to close it.
        Console.ReadKey(true);
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
        Console.Write("The BIO Game");

        // Finally, we write the number of moves in the right column
        Console.SetCursorPosition(Console.WindowWidth - 16, 0);
        Console.Write("Moves: " + moves.ToString().PadLeft(5));

        // Reset the console colors
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}