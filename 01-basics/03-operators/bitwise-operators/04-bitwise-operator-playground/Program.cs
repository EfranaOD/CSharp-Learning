using System;

namespace _04_bitwise_operator_playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask user to enter two integers (a and b).
            //Show a menu:
            //  1. AND (&)
            //  2.OR(|)
            //  3.XOR(^)
            //  4.Left Shift(a << k)
            //  5.Right Shift(a >> k)
            //  6.NOT(~a and ~b)
            //  7.Exit
            //Let them choose one option at a time.
            //  For shift operations, ask for k (how many positions).
            //  Show decimal + binary result.
            //Keep looping until user chooses 7. Exit.

            Console.Write("Enter first number(a): ");
            bool inputOneSucces = sbyte.TryParse(Console.ReadLine(), out sbyte a);
            Console.Write("Enter second number(b): ");
            bool inputTwoSucces = sbyte.TryParse(Console.ReadLine(), out sbyte b);

            if(!inputOneSucces && !inputTwoSucces)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            Console.WriteLine("Choose operation:");
            Console.WriteLine("\n1. AND\n2. OR\n3. XOR\n4. Left shift(a << k)\n5. Right shift(a >> k)\n6. NOT(~a and ~b)\n7. Exit\n");


            while (true)
            {
                Console.Write("Your choice: ");
                string userOperChoice = Console.ReadLine();
                switch (userOperChoice)
                {
                    case "1":
                        Console.WriteLine($"{a} & {b} = {a & b} (binary: {Convert.ToString((byte)a, 2).PadLeft(8, '0')} & {Convert.ToString((byte)b, 2).PadLeft(8, '0')} = {Convert.ToString((byte)(a & b), 2).PadLeft(8, '0')})\n");
                        break;

                    case "2":
                        Console.WriteLine($"{a} | {b} = {a | b} (binary: {Convert.ToString((byte)a, 2).PadLeft(8, '0')} | {Convert.ToString((byte)b, 2).PadLeft(8, '0')} = {Convert.ToString((byte)(a | b), 2).PadLeft(8, '0')})\n");
                        break;

                    case "3":
                        Console.WriteLine($"{a} ^ {b} = {a ^ b} (binary: {Convert.ToString((byte)a, 2).PadLeft(8, '0')} ^ {Convert.ToString((byte)b, 2).PadLeft(8, '0')} = {Convert.ToString((byte)(a ^ b), 2).PadLeft(8, '0')})\n");
                        break;

                    case "4":
                        Console.Write("Enter shift amount k: ");
                        bool kShiftOne = int.TryParse(Console.ReadLine(), out int k1);
                        if (!kShiftOne)
                        {
                            Console.WriteLine("Invalid!");
                            return;
                        }
                        Console.WriteLine($"{a} << {k1} = {a << k1} (binary: {Convert.ToString((byte)a, 2).PadLeft(8, '0')} << {k1} = {Convert.ToString(((byte)a << k1), 2).PadLeft(8, '0')})");
                        Console.WriteLine($"{b} << {k1} = {b << k1} (binary: {Convert.ToString((byte)b, 2).PadLeft(8, '0')} << {k1} = {Convert.ToString(((byte)b << k1), 2).PadLeft(8, '0')})\n");
                        break;

                    case "5":
                        Console.Write("Enter shift amount k: ");
                        bool kShiftTwo = int.TryParse(Console.ReadLine(), out int k2);
                        if (!kShiftTwo)
                        {
                            Console.WriteLine("Invalid!");
                            break;
                        }
                        Console.WriteLine($"{a} >> {k2} = {a >> k2} (binary: {Convert.ToString((byte)a, 2).PadLeft(8, '0')} >> {k2} = {Convert.ToString(((byte)a >> k2), 2).PadLeft(8, '0')})");
                        Console.WriteLine($"{b} >> {k2} = {b >> k2} (binary: {Convert.ToString((byte)b, 2).PadLeft(8, '0')} >> {k2} = {Convert.ToString(((byte)b >> k2), 2).PadLeft(8, '0')})\n");
                        break;

                    case "6":
                        Console.WriteLine($"~a = {~a} (binary: {Convert.ToString((byte)~a, 2).PadLeft(8, '0')})");
                        Console.WriteLine($"~b = {~b} (binary: {Convert.ToString((byte)~b, 2).PadLeft(8, '0')})\n");
                        break;

                    case "7":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid!");
                        break;
                }
            }
        }
    }
}
