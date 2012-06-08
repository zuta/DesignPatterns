using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsByZuTa.Real_world_code
{
    class DiscountDepartment
    {
        public double GetDiscount(int pizzaAmount)
        {
            if (pizzaAmount == 0)
                throw new Exception("At least one pizza must be");

            switch (pizzaAmount)
            {
                case 1:
                    return 0;
                case 2:
                    return 10;
                case 3:
                    return 25;
                default:
                    return 50;
            }
        }
    }
}
