using System;
using System.Collections.Generic;

namespace SquaredRandoms
{
    class Program
    {
        public static void Main()
        {
            Random genRan = new Random();
            // Create a list
            var randList = new List<int>();

            // Populate the list and add random numbers
            for (int i = 0; i < 20; i++)
            {
                randList.Add(genRan.Next(1, 51));
            }

            //write list to console
            foreach(int number in randList)
            {
                Console.WriteLine(number);
                //Console.Read();
            }

            //square numbers
            //create list
            var squaredList = new List<int>();
            //make numbers squared in list
            foreach (int number in randList)
            {
                var square = number * number;
                squaredList.Add(square);
            }

            //write the squared numbers in the squared List
            foreach(int number in squaredList)
            {
                Console.WriteLine(number);
                Console.WriteLine("------", "square #");
                
            }

            //print only even
            var evenList = new List<int>();
           
                squaredList.RemoveAll(SquareNumber => SquareNumber % 2 == 1);

            foreach(int SquareNumber in squaredList)
            {
                Console.WriteLine(SquareNumber);
                Console.WriteLine("++++++++");
                Console.Read();
            }

        }
    }
}
