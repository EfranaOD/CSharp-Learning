using System;

namespace _02RightAngledTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Right-angled triangle of stars
            //*
            //**
            //***
            //****

            for(int row = 1; row <= 4; row++)
            {
                for(int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
