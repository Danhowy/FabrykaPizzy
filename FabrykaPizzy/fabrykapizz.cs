
using System;

namespace Fabryka
{
    public class FabrykaPizzy
    {
        public Pizza GetPizza(string name)
        {

            Pizza pizza = null;
            if (name == "pepperoni")
            {
                Console.WriteLine("\nOto Pizza Pepperoni:\n");
                pizza = new Pepperoni();
            }
            else if (name == "margherita")
            {
                Console.WriteLine("\nOto Pizza Margherita:\n");
                pizza = new Margherita();
            }
            else if (name == "prosciutto")
            {
                Console.WriteLine("\nOto Pizza Prosciutto:\n");
                pizza = new Prosciutto();
            }
            else if (name == "cztery sery")
            {
                Console.WriteLine("\nOto Pizza QuattroFormaggi:\n");
                pizza = new QuattroFormaggi();
            }
            else
            {
                Console.WriteLine("\nNie wybrałeś żadnej więc wybieramy za Ciebie. Oto Pizza Pepperoni:\n");
                pizza = new Pepperoni();
            }
            return pizza;
        }


    }
}
