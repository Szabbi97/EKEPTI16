using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class LazySingleton
    {
        private static LazySingleton Instance = null;

        public static LazySingleton GetInstance()
        {
            if (Instance == null) Instance = new LazySingleton();
            return Instance;
        }

        private LazySingleton() { }
    }
}
