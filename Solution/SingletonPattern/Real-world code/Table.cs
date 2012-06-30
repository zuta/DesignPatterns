using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Real_world_code
{
    class Table
    {
        public int ID { get; private set; }

        public int Roominess { get; private set; } // how many chairs can be around table?

        public bool IsAvailable { get; set; }

        public TableLocations Location { get; set; }

        public Table(int id,int tableRoominess)
        {
            this.ID = id;
            this.Roominess = tableRoominess;
        }
    }
}
