using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsByZuTa.Real_world_code
{
    class OrderDepartment
    {

        public double GetPrice(int pizzaAmount)
        {
            double price = pizzaAmount * 50;

            return price;
        }

    }
}
