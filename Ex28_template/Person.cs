using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 人間
    /// </summary>

    class Person :Animal
    {

        public Person(int a,DateTime bd, string n ,int l) : base(a,bd, n, l)
        {

        }
    }
}
