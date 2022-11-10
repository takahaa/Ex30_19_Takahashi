using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 生き物
    /// </summary>
    class Life:Thing
    {
        
        readonly public DateTime _birthDay = new DateTime();


        public DateTime birthday
        {
            get { return _birthDay; }
        }
        public string name
        {
            get { return _name; }
        }
        public Life( DateTime bd,string n, float w = 0, float h = 0, float d = 0, float we = 0, float s = 0, float l = 0) : base(n,w,h,d,we,s,l)
        {
            _birthDay = birthday;
            //this._birthDay = bd;
        }
        
    }
}
