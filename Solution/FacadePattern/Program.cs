using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsByZuTa.Real_world_code;
using DesignPatternsByZuTa.Structural_code;

namespace DesignPatternsByZuTa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using structural code : ");
            Console.WriteLine();
            
            Facade facade = new Facade();

            facade.MethodOne();
            facade.MethodTwo();

            Console.ReadLine();

            Console.WriteLine("Using real-world code : ");
            Console.WriteLine();

            PizzaCallCenter pizzaCallCenter = new PizzaCallCenter();

            string address = "1/2, Khreshchatyk, Kyiv";
            int pizzaAmount = 3;
            int desirableDeliveryTime = 20;

            Console.WriteLine("Calling ...");
            var price = pizzaCallCenter.GetPrice(address, pizzaAmount, desirableDeliveryTime);
            
            Console.WriteLine("Address : {0}\nAmount of pizza : {1}\nDelivery time : {2}\nPrice : {3}", address, pizzaAmount, desirableDeliveryTime, price);
            Console.WriteLine();

            address = "201 Varick Street, 12th floor, New York";

            Console.WriteLine("Calling ...");
            var deliveryTime = pizzaCallCenter.GetTimeForDelivering(address);
            Console.WriteLine("Address : {0}\nDelivery time : {1}", address, deliveryTime);

            Console.ReadLine();
        }
    }
}
