using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(DateTime.Now,"デジタルじろう", 1,2,3);

            Person[] person = new Person[] {student};

            Console.WriteLine(student);
            //Person person = new Person(DateTime.Now, "デジタル太郎", 0.5f, 160f, 50f);
        }
    }
}
