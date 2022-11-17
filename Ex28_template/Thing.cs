using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 物体
    /// </summary>
    
    //１番最初の基底クラス
    class Thing
    {
        public readonly string _name;
        public float _width;
        public float _height;
        public float _depth;
        public float _weight;
        public float _size;

        public string Name
        {
            get { return _name; }
        }

        public float width
        {
            get { return _width; }
        }

        public float height
        {
            get { return _height; }
        }

        public float depth
        {
            get { return _depth; }
        }

        public float weight
        {
            get { return _weight; }
        }

        public float size
        {
            get { return _size; }
        }



        public Thing(string n = null, float w = 0, float h = 0, float d = 0, float we = 0, float si = 0)
        {
            _name = n;
            _width = w;
            _height = h;
            _depth = d;
            _weight = we;
            _size = si;
        }
    }
}
