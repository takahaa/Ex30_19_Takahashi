using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 車
    /// </summary>

    class Car : Lifeless
    {
        //色
        public string _carcolor;
        public string carcolor
        {
            get { return _carcolor; }
        }
        public Car(string n, string cc, float w, float h, float d, float we, float si) : base(n, w, h, d,we,si)
        {
            _carcolor = cc;
        }

    }
}
