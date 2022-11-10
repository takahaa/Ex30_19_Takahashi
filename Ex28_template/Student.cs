using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 学生
    /// </summary>

    class Student : Person
    {
        public int _number; //学籍番号
        public int number
        {
            get { return _number; }
        }


        public Student(int a,DateTime bd, string n, int num) : base(a,bd, n,num)
        {
            _number = num;
        }
    }
}
