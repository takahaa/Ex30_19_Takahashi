using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal : Life
    {
        /// <summary>
        /// 動物
        /// </summary>

        public int _age; //年齢
        public int age
        {
            get { return _age; }
        }

        public Animal(int a,DateTime bd, string n, int l) : base(bd,n,l)
        {
            _age = a;
        }
    }
}
