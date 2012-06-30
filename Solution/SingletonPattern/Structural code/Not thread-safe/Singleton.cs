using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Structural_code.Not_thread_safe
{
    class Singleton
    {
        private static Singleton instance = null;
        internal static Singleton Instance
        {
            get 
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }

        private Singleton() { }
    }
}
