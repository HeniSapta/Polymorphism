using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Hp : Computer
    {
        public override void Show()
        {
            Console.WriteLine("Tampilan tipe Hp : Hp 14s-dq0508TU");
        }

        public override void Print()
        {
            Console.WriteLine("Salah satu tipe Laptop Hp....");
        }
    }
}