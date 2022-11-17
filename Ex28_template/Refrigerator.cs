using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 冷蔵庫
    /// </summary>

    class Refrigerator : Appliances
    {
        //ドアの数
        public int _doornum;
        public int doornum
        {
            get { return _doornum; }
        }
        public Refrigerator(string n, float w, float h, float d, float we, float si,int dn) : base(n, w, h, d, we, si)
        {
            _doornum = dn;
        }
    }
}
