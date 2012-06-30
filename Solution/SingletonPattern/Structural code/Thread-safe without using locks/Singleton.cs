using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Structural_code.Thread_safe_without_using_locks
{
    class Singleton
    {
        private static Singleton instance = new Singleton();
        public static Singleton Instance
        {
            get 
            {
                return instance;
            }
        }

        static Singleton()
        {
        }

        private Singleton() { }
    }
}
