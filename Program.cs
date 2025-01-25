using System;
using Mission3._2;

internal class Program
{
    private static void Main(string[] args)
    {
        List<FoodItem> Inventory = new List<FoodItem>();

        int choice = 0;

        Console.WriteLine("Welcome to the food bank system!");

        while (choice != 4)
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a new food item");
            Console.WriteLine("2. Delete Food Items");
            Console.WriteLine("3. Print List of Current Food Items");
            Console.WriteLine("4. Exit the Program");

            choice = int.Parse(Console.ReadLine());



            // add food item
            if (choice == 1)
            {
                string name = "";
                string category = "";
                int quantity = 0;
                string expirationDate = "";


                // food name
                Console.WriteLine();
                Console.WriteLine("Please enter the name of the food item");
                name = Console.ReadLine();
                while (name == "")
                {
                    Console.WriteLine("Please enter a valid name of the food item");
                    name = Console.ReadLine();
                }

                // food category
                Console.WriteLine();
                Console.WriteLine("Please enter the category of the food item");
                category = Console.ReadLine();


                // food quantity
                Console.WriteLine();
                Console.WriteLine("Please enter the quantity of the food item");
                quantity = int.Parse(Console.ReadLine());
                while (quantity < 0)
                {
                    Console.WriteLine("Please enter a valid quantity of the food item");
                    quantity = int.Parse(Console.ReadLine());
                }

                // food expiration date
                Console.WriteLine();
                Console.WriteLine("Please enter the expiration date of the food item (MM/DD/YYYY)");
                expirationDate = Console.ReadLine();
                while (expirationDate == "")
                {
                    Console.WriteLine("Please enter a valid expiration date of the food item");
                    expirationDate = Console.ReadLine();
                }

                FoodItem food = new FoodItem(name, category, quantity, expirationDate);  // Corrected object instantiation

                Inventory.Add(food);
            }




            // deletes a food item
            else if (choice == 2)
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {Inventory[i].Name}     Count: {Inventory[i].Quantity}");
                }
                Console.WriteLine();
                Console.WriteLine("Please enter the NUMBER of the food you would like to delete (1,2,3...)");
                int deleteFoodNum = int.Parse(Console.ReadLine());
                FoodItem deleteFood = Inventory[deleteFoodNum - 1];
                Console.WriteLine($"You have deleted {deleteFood.Name} from the inventory.");

                Inventory.Remove(deleteFood);
            }



            // prints the list of food items
            else if (choice == 3)
            {
                Console.WriteLine("Current Inventory:");
                if (Inventory.Count == 0)
                {
                    Console.WriteLine("No items in inventory.");
                }
                else
                {
                    for (int i = 0; i < Inventory.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {Inventory[i].Name}    Count: {Inventory[i].Quantity}");  // Displaying food name instead of the whole object
                    }
                }
            }


            // exits the program
            else if (choice == 4)
            {
                Console.WriteLine("Goodbye!");
            }


            // error handeling
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}
