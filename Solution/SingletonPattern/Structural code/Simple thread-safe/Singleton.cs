using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Structural_code.Simple_thread_safe
{
    class Singleton
    {
        private static object lockObject = new object();

        private static Singleton instance = null;
        public static Singleton Instance
        {
            get 
            {
                lock (lockObject)
                {
                    if (instance == null)
                        instance = new Singleton();

                    return instance;
                }
            }
        }

        private Singleton() { }

    }
}
