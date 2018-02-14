using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class TesztSingleton
    {
        private static TesztSingleton Instance = null;

        public static TesztSingleton GetInstance()
        {
            if (Instance == null) Instance = new TesztSingleton();
            return Instance;
        }

        private TesztSingleton(){}

        int _Ertek;
        public int Ertek
        {
            get
            {
                return _Ertek;
            }
            set
            {
                _Ertek = value;
            }
        }
    }
}
