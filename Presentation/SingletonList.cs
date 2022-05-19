using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class SingletonList
    {
        public List<double> vs = new List<double>();
        string inicio;
        string final;
        private static SingletonList instance = null;
        protected SingletonList()
        {

        }
        public static SingletonList instance1
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonList();
                }
                return instance;
            }
        }
    }
}
