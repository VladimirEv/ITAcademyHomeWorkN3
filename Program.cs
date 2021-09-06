using System;
using TaskItAcademy.Sweets;
using System.IO;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections;





namespace TaskItAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            SweetsInTheShop sweetsInTheShop = new SweetsInTheShop();
            LineWrireSweets lineWrireSweets = new LineWrireSweets();          
            Gift gift = new Gift();

            sweetsInTheShop.ShowSweets();
            lineWrireSweets.ReadLineSweet();
            Description1();
            gift.GiveSweetGift();

            

            Console.ReadLine();
        }

        public static void Description1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("Choose the candies that you would like to see in your New Year's gift.");
            Console.WriteLine("        P.S. Choose the candies your child loves!!!");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Instructions:");
            Console.WriteLine();
            Console.WriteLine("1. Enter the position number of the candy you want to select and indicate ");
            Console.WriteLine("        the weight of the given candy in your gift!");
            Console.WriteLine("2. You can finish your selection of sweets by entering the number 111.");
            Console.WriteLine("                     WITH THE BEST WISHES!!!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void Description2()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("BYE!!! GOOD LUCK !!!");
            Console.ForegroundColor = ConsoleColor.White;
           
        }
    }



    public class SweetsInTheShop
    {
        public static string FileRead { get; set; } = @".\Sweets.txt";

        public SweetsInTheShop()
        {
            
        }

        public void ShowSweets()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("        HELLO, DEAR BUYER ! ");
            Console.WriteLine(" We present you our product range!!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            //Console.WriteLine(" Position:  Name  : Weight,kg : Sugar,gram : Cost,euro :");
        }       
    }

    
}
