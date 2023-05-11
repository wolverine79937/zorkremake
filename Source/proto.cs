﻿using System;

class Program
{
    static void Main(string[] args)
    {
        // We are going to use this block to initialize our interface.
        int score = 0;
        int moves = 0;
        const int bufferSize = 100;
        string[] outputBuffer = new string[bufferSize];
        int bufferPos = 0;
        int width = Console.WindowWidth;
        int height = Console.WindowHeight;
        string room = string.Format("West of House");

        // This just prints something out so that we know how the program will respond when output is encountered.
        UpdateStatusBar(0, 0);
    }

    // This function is going to be for managing the status bar at the top of the screen.
    static void UpdateStatusBar(int score, int moves)
    {
        // First we have to clear the status bar area.
        string room = string.Format("West of House");
        Console.SetCursorPosition(0, 0);
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(new string(' ', Console.WindowWidth));

        // And now we are going to start writing to our status bar. Starting with the player's current location.
        Console.SetCursorPosition(0, 0);
        Console.Write(" " + room.ToString().PadLeft(5)); // This line write the player's current location to the top left corner of the status bar at the top of the screen.

        // This is where we finally print out the current score to the status bar.
        Console.SetCursorPosition(Console.WindowWidth / 2 - 5, 0);
        Console.Write("Score: " + score.ToString());

        // And now we are going to write the number of moves in the right column.
        Console.SetCursorPosition(Console.WindowWidth - 16, 0);
        Console.Write("Moves: " + moves.ToString().PadLeft(5));
        
        // This is the very end of the status bar line.
        Console.Write("\n");

        // And now we have to remember to reset the console colors so we don't accidentally blind someone. LOL
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Gray;
        
    }
}