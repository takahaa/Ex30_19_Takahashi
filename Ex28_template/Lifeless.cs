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
        readonly private string _name;
        readonly private DateTime _birthDay = new DateTime();
        public DateTime birthday
        {
            get { return _birthDay; }
        }
        public string name
        {
            get { return _name; }
        }
        public Lifeless(DateTime bd, string n, float w = 0, float h = 0, float d = 0) : base(n, w, h, d)
        {
            this._birthDay = bd;
        }
    }
}
