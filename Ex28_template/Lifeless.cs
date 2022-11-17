using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 無生物
    /// </summary>
    class Lifeless : Thing
    {
        public string name
        {
            get { return _name; }
        }
        public Lifeless( string n, float w , float h , float d ,float we , float si ) : base(n, w, h, d, we,si)
        {
            _width = w;
            _height = h;
            _depth = d;
            _weight = we;
            //入れる箱の大きさを求める
            _size = w + h + d;
        }
    }
}
