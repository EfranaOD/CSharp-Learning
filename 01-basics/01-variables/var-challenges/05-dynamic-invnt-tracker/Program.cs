using System;
using System.Linq;

namespace dynamic_inventory_tracker
{
    internal class Program
    {
        class DynamicInventory
        {
            public int ShadowVarCheck = 40; //for shadowing check
            public dynamic[] inventory;
            public DynamicInventory(dynamic[] initialInventory)
            {
                inventory = initialInventory;
            }
            public void DisplayItems()
            {
                for (int i = 0; i < inventory.Length; i++)
                {
                    var item = inventory[i].GetType();
                    string covtItem = item.ToString();
                    Console.WriteLine(inventory[i] + ": " + covtItem.Replace("System.", ""));
                }
                Console.WriteLine();
            }
            public void AddItems(dynamic item)
            {
                dynamic[] invent = new dynamic[inventory.Length + 1];
                for (int i = 0; i < inventory.Length; i++)
                {
                    invent[i] = inventory[i];
                }
                invent[invent.Length - 1] = item;
                inventory = invent;
            }
            public void SearchItems()
            {
                dynamic userInput;
                Console.Write("Enter what you want to search for: ");
                userInput = Console.ReadLine();
                bool searchFoundExecuted = false;

                for (int i = 0; i < inventory.Length; i++)
                {
                    if (inventory[i].ToString() == userInput)
                    {
                        var inputItemType = inventory[i].GetType();
                        string convtItemType = inputItemType.ToString();
                        Console.WriteLine($"Search found at index {i}. The item details, {inventory[i]}: {convtItemType.Replace("System.", "")}");
                        searchFoundExecuted = true;
                    }
                }
                if (!searchFoundExecuted)
                {
                    Console.WriteLine("Search not found");
                }

                //shadow variables
                int ShadowVarCheck = 5;
                Console.WriteLine("Local Variable: " + ShadowVarCheck + ", Field Variable: " + this.ShadowVarCheck);
            }
            public void RemoveItems(int indexToRemove)
            {
                if (indexToRemove < 0 || indexToRemove >= inventory.Length)
                {
                    Console.WriteLine("The index you wanted remove was out of range.");
                    return;
                }
                dynamic[] invent = new dynamic[inventory.Length - 1];
                int j = 0;
                for (int i = 0; i < inventory.Length; i++)
                {
                    if (i == indexToRemove)
                        continue;

                    invent[j] = inventory[i];
                    j++;
                }
                inventory = invent;
            }
        }
        static void Main(string[] args)
        {
            //Use dynamic[] inventory to store mixed types(e.g., "Apple", 10, true, 5.6).
            //Write methods to:
            //Display all items with type info.
            //Add items dynamically.
            //Remove items by index.
            //Search for a value.
            //Must use var in loops when iterating over inventory.
            //Demonstrate shadowing inside one of the methods.

            DynamicInventory invnt = new DynamicInventory(new dynamic[] { "apple", 10, true, 5.6 });

            invnt.AddItems("dazai");
            invnt.DisplayItems();
            invnt.SearchItems();
            invnt.RemoveItems(5); //testing mechanics...
            invnt.DisplayItems();
        }
    }
}
