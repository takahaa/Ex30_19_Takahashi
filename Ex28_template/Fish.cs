using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 魚
    /// </summary>

    class Fish : Animal
    {
        //生息地
        public string _habitat;
        public string habitat
        {
            get { return _habitat; }
        }
        public Fish (int a ,DateTime bd, string n,int l,string ha) : base(a,bd, n,l)
        {
            _habitat = ha;
        }
    }
}
