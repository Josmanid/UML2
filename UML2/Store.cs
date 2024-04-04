using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    public class Store
    {
        //In the class Store implement code to test the implemented classes and methods in step 2. 


        public static void Test() {
            // Create a new menu catalog
            MenuCatalog menuCatalog = new MenuCatalog();

            // Add some pizzas to the menu
            menuCatalog.AddPizza(new Pizza(1, "Margherita", 59.99m));
            menuCatalog.AddPizza(new Pizza(2, "Pepperoni", 59.99m));
            menuCatalog.AddPizza(new Pizza(3, "Ufo", 69.99m));


            // Print the menu
            Console.WriteLine("Printing Menu:");
            menuCatalog.PrintMenu();
            /* Find mig den første pizza i menuen, hvor pizzaens ID er lig med 2, og gem den i variablen pizzaIdSearch.*/

            Pizza pizzaIdSearch = menuCatalog.SearchPizza(p => p.Id == 2);

            Console.WriteLine("Search for pizza by ID: ");
            Console.WriteLine(pizzaIdSearch.ToString());

            // Let delete a pizza

            menuCatalog.DeletePizza(1);

            Console.WriteLine("Remaining Menu after deleting pizza 1:");
            menuCatalog.PrintMenu();

            

            
        }
        // Create a user dialog and run the application
        public static void Run() {
                // Create a new menu catalog
                MenuCatalog menuCatalog = new MenuCatalog();

                // Add some pizzas to the menu
                menuCatalog.AddPizza(new Pizza(1, "Margherita", 59.99m));
                menuCatalog.AddPizza(new Pizza(2, "Pepperoni", 59.99m));
                menuCatalog.AddPizza(new Pizza(3, "Ufo", 69.99m));

                // Display a message to the user to continue with the application
                Console.WriteLine("Press any key to start the application");
                Console.ReadKey();

                // Start the application
                StartApplication(menuCatalog);
            }

            public static void StartApplication(MenuCatalog menuCatalog) {
                bool exit = false;
                while (!exit)
                {
                    // Print the menu
                    Console.WriteLine("Printing Menu:");
                    menuCatalog.PrintMenu();

                    // Display a message to the user to choose an option
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1) Add a pizza");
                    Console.WriteLine("2) Search for a pizza");
                    Console.WriteLine("3) Delete a pizza");
                    Console.WriteLine("4) Exit");

                // Read the user's choice
                
                    int choice = int.Parse(Console.ReadLine());
                
               
                    // Perform the selected action
                    switch (choice)
                    {
                        case 1:
                        
                            // Add a pizza
                            Console.Write("Enter the ID of the pizza: ");
                            
                        try
                        {
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Enter the name of the pizza: ");
                            string name = Console.ReadLine();
                            if (int.TryParse(name, out _))
                            {
                                Console.WriteLine("Please enter a valid name (not a number).");
                            }
                            else
                            {
                                Console.Write("Enter the price of the pizza: ");
                                decimal price = decimal.Parse(Console.ReadLine());
                                menuCatalog.AddPizza(new Pizza(id, name, price));
                            }
                          
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Enter a whole NEW number for the ID)");
                            Console.WriteLine("Enter a number for price");
                            Console.WriteLine("Enter the name in text for pizza");
                            
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Something went wrong!");
                        }
                        break;
                        case 2:
                            // Search for a pizza
                            Console.Write("Enter the ID of the pizza: ");
                        try
                        {
                            int idSearch = int.Parse(Console.ReadLine());
                            Pizza pizza = menuCatalog.SearchPizza(p => p.Id == idSearch);
                            Console.WriteLine(pizza.ToString());
                        }
                        catch(FormatException) 
                        { 
                            Console.WriteLine("In Whole numbers please"); 
                        }
                            break;
                        case 3:
                            // Delete a pizza
                            Console.Write("Enter the ID of the pizza: ");
                        try
                        {
                            int idDelete = int.Parse(Console.ReadLine());
                            menuCatalog.DeletePizza(idDelete);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("In Whole numbers please");
                        }
                            break;
                        case 4:
                            // Exit
                            exit = true;
                            break;
                        default:
                            // Invalid choice
                            Console.WriteLine("Invalid choice. Please choose a valid option.");
                            break;
                    }
                }
            }

        }

       
    
    }

