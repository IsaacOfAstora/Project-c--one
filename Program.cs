// See https://aka.ms/new-console-template for more information

using System;

namespace Dice_roll // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
        //our vars
        int x=0, d1=0, d2=0, tries1=0, tries2=0;
        Random numGenerator = new Random();
        //..................................................................


    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Welcome to double dice game Player 1 & 2 !!");
    Console.ReadKey();
        // Game starts !!...................................................


    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Player 1's turn"); 
        while (x!=2)
        {
   
        d1 = numGenerator.Next(1, 7);
        d2 = numGenerator.Next(1, 7);
        x = d1+d2;
        Console.ReadKey();
        Console.WriteLine(" you rolled " + d1 + " and " + d2 + " ! ");
        tries1++;

        }
        x =0;
        d1=0;
        d2=0;

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nPlayer 2's turn"); 
         while(x!=2)
         {
           d1 = numGenerator.Next(1, 7);
           d2 = numGenerator.Next(1, 7);
           x = d1+d2;
           Console.ReadKey();
           Console.WriteLine(" you rolled " + d1 + " and " + d2 + " ! "); 
           tries2++;

         }

        if (tries1 < tries2)
        {
         Console.ForegroundColor = ConsoleColor.Blue;
         Console.WriteLine("\nPlayer 1 wins !");   
        }
        else if (tries1 != tries2)
        {
          Console.ForegroundColor = ConsoleColor.Magenta;
          Console.WriteLine("\nPlayer 2 wins !");  
        }





            Console.ReadKey();
        }
    }
}