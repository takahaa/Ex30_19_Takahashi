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
        //入れる箱の大きさ
        public float _box;
        public float box
        {
            get { return _box; }
        }
        public Appliances(string n, float w, float h, float d, float we, float si) : base(n, w, h, d, we, si)
        {
            _box = si;
        }

    }
}
