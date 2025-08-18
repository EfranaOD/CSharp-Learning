using System;

namespace shadow_var_hunt
{
    internal class Program
    {
        class Books
        {
            public const string author = "Osamu Dazai";
            public readonly int price;

            public Books(int bookPrice)
            {
                price = bookPrice;
            }

            public void BookDetails()
            {
                int price = 500;

                if (this.price != price)
                {
                    Console.WriteLine($"local variable price: {price} is hiding field variable price: {this.price}");
                }

                Console.WriteLine(this.price);
                Console.WriteLine(price);
                Console.WriteLine($"Author of the book is, {author}");
            }
        }
        static void Main(string[] args)
        {
            //Create a class with a const field and a readonly field.
            //Inside a method, declare a local variable that shadows the readonly field.
            //Write logic to detect if the local variable is hiding a field(hint: compare this.variableName and the shadowed name).
            //Print both values to show the difference.

            Books book1 = new Books(400);
            book1.BookDetails();

            Books book2 = new Books(700);
            book2.BookDetails();

            Books book3 = new Books(900);
            book3.BookDetails();

        }
    }
}
