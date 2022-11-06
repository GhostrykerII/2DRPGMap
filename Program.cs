﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DRPGMAP2
{
    internal class Program
    {
        static int scale;
        static int x, y, origx, origy;
        static string p;
        static int rows, columns;

        static char[,] map = new char[,] // dimensions defined by following data:
    {
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
    };
        static void Main(string[] args)
        {
            scale = 3;
            x = 0;
            y = 0;
            origx = Console.CursorLeft;
            origy = Console.CursorTop;
            p = "P";
            rows = map.GetLength(0);
            columns = map.GetLength(1);

            Console.WriteLine("The array is " + rows + " rows tall and " + columns + " columns wide.");
            Console.WriteLine();

            DisplayMap();

            Console.WriteLine();

            DisplayMap(scale);

            Console.ReadKey();
        }
        static void DisplayMap()
        {
            Console.BackgroundColor = ConsoleColor.Black;

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    ColourCode(x, y);
                    Console.Write(map[x, y]); //writes the single character located at array index x, y
                }
                Console.WriteLine(); //line breaks when the current row is done being written
            }

            Console.ResetColor();
        }
        static void DisplayMap(int scale)
        {
            int bordersize = columns * scale;
            Console.BackgroundColor = ConsoleColor.Black;
            for (int r = 0; r < bordersize; r++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
            for (int x = 0; x < rows; x++)
            {
                for (int m = 0; m < scale; m++)
                {
                    for (int y = 0; y < columns; y++)
                    {
                        for (int z = 0; z < scale; z++)
                        {
                            ColourCode(x, y);
                            Console.Write(map[x, y]);
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            for (int r = 0; r < bordersize; r++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
        static void ColourCode(int x, int y)
        {
            switch (map[x, y]) //checks the characters in the array and assigns them colours
            {
                case '^':
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;
                case '`':
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
                case '~':
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    break;
                case '*':
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
        }
        static void PlayerChoice()
        {

        }
    }
}