using System;
namespace Fabryka
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Witamy w naszej fabryce pizz. \nPodaj jaką pizze chcesz stworzyć. \nJesli chcesz włączyć MENU wpisz tak/nie");
            string menu = Console.ReadLine();
            string[] Menu = { "Pepperoni -> wpisz pepperoni", "Margherita -> wpisz margherita", "QuattroFormaggi -> wpisz cztery sery", "Prosciutto -> wpisz prosciutto" };
            do
            {
                if (menu == "tak")
                {
                    Console.WriteLine("\nOto menu:\n");
                    foreach (string i in Menu)
                    {
                        Console.WriteLine("{0} ", i);
                    }
                    break;
                }
                else if (menu == "nie")
                {
                    Console.WriteLine("\nWidzę, że znasz już nazwy pizz. \nPodaj jaką pizze chcesz stworzyć.\n");
                    break;
                }
                else
                {
                    Console.WriteLine("\nJesli chcesz włączyć MENU wpisz tak / nie\n");
                }
            } while (menu=="tak" || menu=="nie");


            var TypPizzy = Console.ReadLine();
            var fabrykaPizzy=new FabrykaPizzy();
            var pizza = fabrykaPizzy.GetPizza(TypPizzy);
            pizza.PrintIngridients();

            Console.WriteLine("\nSmacznego! Zapraszamy ponownie! :)");


            Console.ReadKey();
        }
    }
}
