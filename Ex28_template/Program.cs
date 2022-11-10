using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(19,DateTime.Now,"あごだし 律", 2001);
            Console.WriteLine($"名前：{student.name}、年齢：{student.age}、学籍番号：{student.number}だよ");
            Person person = new Person(18,DateTime.Now, "儚木 成駿", 180, 200, 50);
            Console.WriteLine($"名前：{person.name}、年齢：{person.age}");
            Worker worker = new Worker(28,DateTime.Now, "初心 忘太","スタントマン");
            Console.WriteLine($"名前：{worker.name}、年齢：{worker.age}、職業：{worker.industry}");
        }
    }
}
