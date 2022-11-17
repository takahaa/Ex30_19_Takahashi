using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 家電
    /// </summary>

    class Appliances : Lifeless
    {
        public Appliances(string n, float w, float h, float d, float we, float si) : base(n, w, h, d, we, si)
        {

        }

    }
}
