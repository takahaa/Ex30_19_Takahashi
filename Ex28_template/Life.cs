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
        public int _life_span;

        public DateTime birthday
        {
            get { return _birthDay; }
        }
        public string name
        {
            get { return _name; }
        }

        public int life_span
        {
            get { return _life_span; }
        }

        public bool GetBirthdayToday()
        {
            if(birthday.Date == DateTime.Today.Date)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Life( DateTime bd,string n, int l) : base(n)
        {
            _birthDay = bd;
            _life_span = l;
        }
        
    }
}
