using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Worker : Person
    {
        /// <summary>
        /// 社会人
        /// </summary>

        //業界
        public readonly string _industry;
        public string industry
        {
            get { return _industry; }
        }
        public Worker (int a,DateTime bd, string n, int l, string i) : base(a, bd, n,l)
        {
            _industry = i;
        }
    }
}
