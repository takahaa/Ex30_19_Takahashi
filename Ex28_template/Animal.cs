﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal : Life
    {
        public int _age; //年齢
        public int age
        {
            get { return _age; }
        }

        public Animal(int a,DateTime bd, string n, float w = 0, float h = 0, float d = 0) : base(bd, n, w, h, d)
        {
            _age = a;
        }
    }
}
