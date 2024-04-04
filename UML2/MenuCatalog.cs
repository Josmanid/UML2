using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    public class MenuCatalog 
    {
        //CRUD operations (Create, Read, Update and Delete). need to be implemeted here!
        // Create a class MenuCatalog, that contains pizzas
        List<Pizza> _pizzaList;

        public MenuCatalog()
        {
            _pizzaList = new List<Pizza>();
        }


        //Create: method to add a pizza to the menu  
        public void AddPizza(Pizza p) 
        {
            _pizzaList.Add(p);
        
        }
        //Read: Implement a method, PrintMenu, that can print out the menu card (to the screen)
        public void PrintMenu() {
            foreach (var p in _pizzaList) 
        { 
                Console.WriteLine(p);
            
        }

        }

      

        /*Implement a method SearchPizza(criteria), that searches for a pizza and returns a Pizza object.
        Note til mig selv: Find mig den første pizza i menuen, der opfylder de angivne kriterier, som er beskrevet af den givne 'regel', og returner den pizza.*/
        public Pizza SearchPizza(Func<Pizza, bool> predicate) 
        {
            Pizza pizza = _pizzaList.FirstOrDefault(p => predicate(p));
           
            return pizza;
        }

        //Delete: Deleting a pizza based on ID
        public bool DeletePizza(int pizzaId) {
            // Find the index of the pizza with the specified ID
            int i = _pizzaList.FindIndex(p => p.Id == pizzaId);

            if (i != -1)
            {
                // If pizza with the specified ID is found, remove it from the list
                _pizzaList.RemoveAt(i);
                return true; // Indicate that deletion was successful
            }
            else
            {
                // If pizza with the specified ID is not found, return false to indicate failure
                return false;
            }
        }

    }

}
