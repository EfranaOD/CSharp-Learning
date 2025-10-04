using System;

namespace _02_optional_named_local_expression_bodied
{
    internal class Program
    {
        public static string GetUserDetails()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            string FullName(string firstName, string lastName) => $"Customer name is {firstName} {lastName}.";

            return FullName(firstName, lastName);
        }
        public static bool InputValidation()
        {
            Console.Write("Please enter your pizza price: ");
            bool isSuccess = int.TryParse(Console.ReadLine(), out int userAmtInput);
            if (!isSuccess) { Console.WriteLine("Invalid input"); return false; }
            bool Validate(int amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Price cannot be zero or negative.");
                    return false;
                }
                return true;
            }
            return Validate(userAmtInput);
        }
        public static string OrderPizza(string size = "Medium", string toppings = "Cheese")
        {
            return "Your order for pizza of size: '" + size + "' and toppings: '" + toppings + "' has been recieved.\nIt will be ready shortly.\nKindly wait.";
        }
        public static void Main(string[] args)
        {
            //A method OrderPizza with optional parameters(size = "Medium", toppings = "Cheese").
            //Call it using named parameters (only override toppings, leave size default).
            //Inside another method, use a local function to validate input(e.g., price must be positive).
            //Write at least one expression-bodied method(e.g., Square or GetFullName).

            Console.WriteLine(GetUserDetails());

            bool isValid = InputValidation();

            if (isValid)
            {
                Console.WriteLine(OrderPizza(toppings: "Olives"));
            }
        }
    }
}