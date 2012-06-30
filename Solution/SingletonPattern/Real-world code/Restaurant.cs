using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Real_world_code
{
    static class Restaurant
    {
        private static List<Table> tables;
        public static List<Table> Tables
        {
            get { return tables; }
            set { tables = value; }
        }

        static Restaurant()
        {
            tables = new List<Table>();

            tables.Add(new Table(101, 2) { IsAvailable = true, Location = TableLocations.NearPiano | TableLocations.NearFountain });
            tables.Add(new Table(234, 2) { IsAvailable = true, Location = TableLocations.NearWindow | TableLocations.NearFountain | TableLocations.NearPiano });
            tables.Add(new Table(341, 3) { IsAvailable = false, Location = TableLocations.Standard });
            tables.Add(new Table(11, 5) { IsAvailable = true,Location = TableLocations.NearWindow });
            tables.Add(new Table(187, 8) { IsAvailable = true, Location = TableLocations.NearPiano | TableLocations.NearBar });
        }
    }
}
