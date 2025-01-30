using System;
using static System.Console;
using System.Globalization;
class DebugOne4
{
   static void Main()
   {
      Console.WriteLine("How to play tic tac toe:");
      Console.WriteLine("Draw a three by three grid.");
      Console.WriteLine("The first player puts an X in any of the nine locations.");
      Console.WriteLine("The second player puts an O in any remaining location.");
      Console.WriteLine("Players alternate turns until one has three of the same symbol in a row");
      Console.WriteLine("    vertically, horizontally, or diagonally.");
      Console.WriteLine("If all nine squares are filled without three in a row,");
      Console.WriteLine("    the game ends in a tie.");
   }
}
