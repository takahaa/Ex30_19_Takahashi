using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 猫
    /// </summary>

    class Cat : Animal
    {
        //猫の性格
        public string _character;
        public string character
        {
            get { return _character; }
        }

        public Cat (int a,DateTime bd, string n,int l,string c ) : base(a,bd, n,l)
        {
            _character = c;
        }
    }
}
