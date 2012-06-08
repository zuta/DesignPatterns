using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsByZuTa.Structural_code
{
    class Facade
    {
        SubSystemA subSystemA;
        SubSystemB subSystemB;
        SubSystemC subSystemC;

        public Facade()
        {
            subSystemA = new SubSystemA();
            subSystemB = new SubSystemB();
            subSystemC = new SubSystemC();
        }

        public void MethodOne()
        {
            Console.WriteLine("*** Facade.MethodOne ***");
            subSystemA.MethodA();
            subSystemB.MethodB();
            subSystemC.MethodC();
        }

        public void MethodTwo()
        {
            Console.WriteLine("*** Facade.MethodTwo ***");
            subSystemC.MethodC();
            subSystemA.MethodA();            
        }
    }
}
