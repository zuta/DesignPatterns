using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsByZuTa.Real_world_code
{
    class PizzaCallCenter
    {
        OrderDepartment orderDepartment;
        DiscountDepartment discountDepartment;
        DeliveryDepartment deliveryDepartment;

        public PizzaCallCenter()
        {
            orderDepartment = new OrderDepartment();
            discountDepartment = new DiscountDepartment();
            deliveryDepartment = new DeliveryDepartment();
        }

        public double GetPrice(string address, int pizzaAmount, int desirableDeliveryTime)
        {
            var discount = discountDepartment.GetDiscount(pizzaAmount);
            var deliveryTime = deliveryDepartment.GetTimeForDelivering(address);

            var pizzaPrice = orderDepartment.GetPrice(pizzaAmount);
            var deliveryPrice = deliveryTime * 5; 
            
            var priceWithDiscount = pizzaPrice - (pizzaPrice * discount) / 100.0;
            var desirableDeliveryPrice = deliveryPrice + Math.Max(deliveryTime - desirableDeliveryTime, 0) * 0.1;

            var totalPrice = priceWithDiscount + desirableDeliveryPrice;

            return totalPrice;
        }

        public int GetTimeForDelivering(string address)
        {
            return deliveryDepartment.GetTimeForDelivering(address);
        }

    }
}
