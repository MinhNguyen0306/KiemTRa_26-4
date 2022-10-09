using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_Kiemtra_26_4
{
    public abstract class Animal_235
    {
        public virtual void Eat() {
            Console.WriteLine("Ăn");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Âm thanh");
        }
    }

    class Cat_235 : Animal_235
    {
        public void Run()
        {
            Console.WriteLine("Mèo chạy");
        }
    }

    class Bird_235 : Animal_235
    {
        public void fly()
        {
            Console.WriteLine("bay");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat_235 bcat_235 = new Cat_235();
            Bird_235 bbird_235 = new Bird_235();
            bcat_235.Run();
            bbird_235.fly();
        }
    }
}
