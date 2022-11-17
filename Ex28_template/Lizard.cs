using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    /// <summary>
    /// トカゲ
    /// </summary>

    class Lizard : Animal
    {
        public string _taste;
        public string taste
        {
            get { return _taste; }
        }
        public Lizard(int a,DateTime bd, string n, int l, string ta) : base(a,bd,n,l)
        {
            _taste = ta;
        }
    }
}
