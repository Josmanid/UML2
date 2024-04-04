using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    public class Pizza
    {

        #region properties
        public int Id { get; private set; }
        public string Name { get; private set; } 
        public decimal Price { get; private set; }
        #endregion
        public Pizza(int ID,string name, decimal price)
        {
            Id = ID;
            Name = name;
            Price = price;
            
        }

        public override string ToString() 
        {
            return $"Pizza number: {Id}, Name: {Name}, Price: {Price}";
        }

    }
}
