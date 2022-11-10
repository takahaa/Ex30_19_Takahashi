using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Cat : Animal
    {
        public string _typecat;
        public string typecat
        {
            get { return _typecat; }
        }

        public Cat (int a,DateTime bd, string n,string t ) : base(a,bd, n)
        {
            _typecat = t;
        }
    }
}
