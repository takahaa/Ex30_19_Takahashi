using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Plant : Life
    {
        /// <summary>
        /// 植物
        /// </summary>

        //植物の種類
        public string _typeplant;
        public string typeplant
        {
            get { return _typeplant; }
        }
        public Plant(DateTime bd, string n,int l, string tp) : base(bd, n, l)
        {
            _typeplant = tp;
        }
    }
}
