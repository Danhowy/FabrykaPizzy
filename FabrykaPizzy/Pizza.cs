
using System.Collections.Generic;

namespace Fabryka
{
    public abstract class Pizza
    {
       protected List<string> ingridients = new List<string>();

        public Pizza()
        {
            ingridients.Add("Ciasto");
            ingridients.Add("Sos pomidorowy");
            ingridients.Add("Przyprawy");
        }

        public void PrintIngridients()
        {
            foreach (var ingridient in ingridients)
            {

                System.Console.WriteLine(ingridient);
            }
        }
    }
}
