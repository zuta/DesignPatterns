using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Real_world_code
{
    enum TableLocations
    {
        Standard = 0,
        NearWindow = 1,
        NearPiano = 2,
        NearFountain = 4,
        NearBar = 8
    }
     
    class Hostess
    {
        private static Hostess instance = new Hostess();
        public static Hostess Instance
        {
            get { return instance; }
        }

        static Hostess() { }

        private Hostess()
        {
        }

        public bool IsTableAvailable(int amountOfPersons)
        {
            return (from t in Restaurant.Tables
                    where t.Roominess == amountOfPersons && t.IsAvailable
                    select t).Any();
        }

        public bool IsTableAvailable(int amountOfPersons, TableLocations desirableLocation)
        {
            return (from t in Restaurant.Tables
                    where t.Roominess == amountOfPersons && t.IsAvailable && t.Location == desirableLocation
                    select t).Any();

        }

    }
}
