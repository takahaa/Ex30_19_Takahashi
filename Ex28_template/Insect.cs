using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Insect : Animal
    {
        /// <summary>
        /// 虫
        /// </summary>

        public string _color;
        public string color
        {
            get { return _color; }
        }

        public Insect (int a,DateTime bd, string n, int l,string co) : base(a,bd, n,l)
        {
            _color = co;
        }
    }
}
