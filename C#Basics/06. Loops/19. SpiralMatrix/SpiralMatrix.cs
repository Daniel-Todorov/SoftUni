﻿//Write a program that reads from the console a positive integer number n (1 < n < 20) 
//and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below. 

using System;

public class Number
{
    public int YCoordinate { get; set; }
    public int XCoordinate { get; set; }
    public int Direction { get; set; }
    public int Value { get; set; }
    public Number(int yCoordinate, int xCoordinate, int direction, int value)
    {
        YCoordinate = yCoordinate;
        XCoordinate = xCoordinate;
        Direction = direction;
        Value = value;
    }
}

class SpiralMatrix
{
    static void Main()
    {
        int N = 0;
        Number cell = new Number(0, 0, 1, 1);

        Console.Write("Please, type a positive integer number N (N < 20) and press Enter: ");
        N = int.Parse(Console.ReadLine());
        Console.Clear();

        while (cell.Value <= N)
        {
            cell.YCoordinate = cell.YCoordinate + 4;
            Console.SetCursorPosition(cell.YCoordinate, cell.XCoordinate);
            Console.WriteLine(cell.Value);
            cell.Value = cell.Value + 1;
        }
        cell.Direction = cell.Direction + 1;

        int a = 1;
        int b = 1;
        int c = 0;

        while (c < 20)
        {
            while (a <= N - b)
            {
                cell.YCoordinate = cell.YCoordinate;
                cell.XCoordinate = cell.XCoordinate + 2;
                Console.SetCursorPosition(cell.YCoordinate, cell.XCoordinate);
                Console.WriteLine(cell.Value);
                cell.Value = cell.Value + 1;
                a++;
            }
            a = 1;

            while (a <= N - b)
            {
                cell.YCoordinate = cell.YCoordinate - 4;
                cell.XCoordinate = cell.XCoordinate;
                Console.SetCursorPosition(cell.YCoordinate, cell.XCoordinate);
                Console.WriteLine(cell.Value);
                cell.Value = cell.Value + 1;
                a++;
            }
            a = 1;
            b++;

            while (a <= N - b)
            {
                cell.YCoordinate = cell.YCoordinate;
                cell.XCoordinate = cell.XCoordinate - 2;
                Console.SetCursorPosition(cell.YCoordinate, cell.XCoordinate);
                Console.WriteLine(cell.Value);
                cell.Value = cell.Value + 1;
                a++;
            }
            a = 1;

            while (a <= N - b)
            {
                cell.YCoordinate = cell.YCoordinate + 4;
                cell.XCoordinate = cell.XCoordinate;
                Console.SetCursorPosition(cell.YCoordinate, cell.XCoordinate);
                Console.WriteLine(cell.Value);
                cell.Value = cell.Value + 1;
                a++;
            }
            a = 1;
            b++;
            c++;
        }

        Console.SetCursorPosition(0, N * 2);
    }
}