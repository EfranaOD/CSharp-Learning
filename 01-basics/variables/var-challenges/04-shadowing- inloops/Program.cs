using System;

namespace shadowing_inLoops
{
    internal class Program
    {
        class ShadowExample
        {
            public int counter = 100;

            public void ShowShadowing()
            {
                int counter = 50;
                Console.WriteLine($"Initially, field variable value is {this.counter}, local variable value is {counter}.");
                for (int i = 1; i < 6; i++)
                {
                    counter = counter + 10;
                    if (i % 2 == 0)
                    {
                        this.counter = this.counter + 2;
                    }
                    Console.WriteLine($"Local Variable: {counter}, Field Variable: {this.counter}.");
                }
                Console.WriteLine($"Final, field variable value is {this.counter}, local variable value is {counter}.");
            }
        }
        static void Main(string[] args)
        {
            //Have a field variable int counter = 100;
            //Inside a for loop from 1 to 5, declare a local counter and manipulate it separately from the field.
            //At the end, show both values and explain the difference.

            ShadowExample shadowExampleOne = new ShadowExample();
            shadowExampleOne.ShowShadowing();
            shadowExampleOne.ShowShadowing(); //for checking the lifespan of fields.

        }
    }
}
