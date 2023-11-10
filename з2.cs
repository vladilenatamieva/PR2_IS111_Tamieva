using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;

namespace з2
{
    public class Laptop
    {
        private string name; private int price;
        private string processor; private int ram;
        private int hardDisk;
        public Laptop(string name, int price, string processor, int ram, int hardDisk)
        {
            this.name = name; this.price = price;
            this.processor = processor; this.ram = ram;
            this.hardDisk = hardDisk;
        }
        public void Display()
        {
            Console.WriteLine("Ноутбук:");
            Console.WriteLine($"Название: {name}"); Console.WriteLine($"Цена: {price} рублей");
            Console.WriteLine($"Процессор: {processor}"); Console.WriteLine($"Оперативная память: {ram} ГБ");
            Console.WriteLine($"Жесткий диск: {hardDisk} ГБ"); Console.WriteLine();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop("dexp", 60000, "i3", 2, 500);
            Laptop laptop2 = new Laptop("asus", 80000, "i5", 4, 1024);
            Laptop laptop3 = new Laptop("huawei", 100000, "i9", 8, 1024);
            laptop1.Display();
            laptop2.Display(); laptop3.Display();
        }
    }
}
