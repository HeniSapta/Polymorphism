using Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer Computer;

            Console.WriteLine("Pilih merk Computer: ");
            Console.WriteLine("1. Acer");
            Console.WriteLine("2. Asus");
            Console.WriteLine("3. Hp\n");

            Console.Write("Nomor merk Computer [1..3]: ");
            int nomorMerkComputer = Convert.ToInt32(Console.ReadLine());

            if (nomorMerkComputer == 1)
                Computer = new Acer();
            else if (nomorMerkComputer == 2)
                Computer = new Asus();
            else
                Computer = new Hp();

            Computer.Show();
            Computer.Print();

            Console.ReadKey();
        }
    }
}