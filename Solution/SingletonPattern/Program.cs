using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SingletonPattern.Real_world_code;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is restaurant has table for 2 persons? {0}", Hostess.Instance.IsTableAvailable(2) ? "Yes" : "No");

            Console.WriteLine("Is restaurant has table for 5 persons near window? {0}", Hostess.Instance.IsTableAvailable(5, TableLocations.NearWindow) ? "Yes" : "No");

            Console.WriteLine("Is restaurant has table for 2 persons near window and fountain? {0}", Hostess.Instance.IsTableAvailable(2, TableLocations.NearWindow | TableLocations.NearFountain) ? "Yes" : "No");
        }
    }
}
