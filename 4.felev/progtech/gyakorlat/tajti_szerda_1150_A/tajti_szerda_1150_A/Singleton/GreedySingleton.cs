using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class GreedySingleton
    {
        private static GreedySingleton Instance = new GreedySingleton();

        public static GreedySingleton GetInstance()
        {
            return Instance;
        }

        private GreedySingleton() { }
    }
}