using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsByZuTa.Real_world_code
{
    class DeliveryDepartment
    {
        public int GetTimeForDelivering(string address)
        {
            if (address.ToLower().Contains("kyiv"))
                return 30;

            return 100;
        }
    }
}
