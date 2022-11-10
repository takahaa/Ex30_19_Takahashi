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
        public float _life_span;

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

        public float life_span
        {
            get { return _life_span; }
        }


        public Thing(string n = null, float w = 0, float h = 0, float d = 0, float we = 0, float s = 0, float l = 0 )
        {
            _name = n;
            _width = w;
            _height = h;
            _depth = d;
            _weight = w;
            _size = s;
            _life_span = l;
        }
    }
}
