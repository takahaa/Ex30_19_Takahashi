using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Worker : Person
    {
        public readonly string _industry;
        public string industry
        {
            get { return _industry; }
        }
        public Worker (int a,DateTime bd, string n,string i) : base(a, bd, n)
        {
            _industry = i;
        }
    }
}
