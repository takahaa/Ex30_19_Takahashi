using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(19,DateTime.Today,"木西 内代", 2001,80);
            Console.WriteLine($"名前：{student.name}、年齢：{student.age}、今日は誕生日か({student.GetBirthdayToday()})、学籍番号：{student.number}、寿命：{student.life_span}年");
            Worker worker = new Worker(28,DateTime.Today, "類家 毛馬子",80, "スタントマン");
            Console.WriteLine($"名前：{worker.name}、年齢：{worker.age}、今日は誕生日か({student.GetBirthdayToday()})、職業：{worker.industry}、寿命：{worker.life_span}年");
            Fish fish = new Fish(0, DateTime.Today, "イトウ", 20, "阿寒湖");
            Console.WriteLine($"魚の種類：{fish.name}、寿命：{fish.life_span}年、生息地：{fish.habitat}");
            Cat cat = new Cat(0, DateTime.Today, "マンチカン", 18, "穏やか");
            Console.WriteLine($"猫の種類：{cat.name}、寿命：{cat.life_span}年、性格：{cat.character}");
            Insect insect = new Insect(0, DateTime.Today, "バナナムシ", 9, "黄色");
            Console.WriteLine($"昆虫の種類：{insect.name}、寿命：{insect.life_span}カ月、色：{insect.color}");
            Lizard lizard = new Lizard(0, DateTime.Today, "ニホントカゲ", 6, "脂がのっていて旨い");
            Console.WriteLine($"トカゲの種類：{lizard.name}、寿命：{lizard.life_span}、味：{lizard.taste}");
            Car car = new Car("ラフェスタ", "白",0,0,0,1805,0);
            Console.WriteLine($"車の名前：{car.name}、車の色：{car.carcolor}、重さ{car.weight}");
            Refrigerator refrigerator = new Refrigerator("東芝",685,745,1833,1805,110,6);
            Console.WriteLine($"冷蔵庫のメーカー社：{refrigerator.name}、ドアの数：{refrigerator.doornum}、サイズ：{refrigerator.size}、重さ：{refrigerator.weight}");
        }
    }
}
