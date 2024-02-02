using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Asus : Computer
    {
        public override void Show()
        {
            Console.WriteLine("Tampilan tipe Asus : seri ZenBook Duo14");
        }

        public override void Print()
        {
            Console.WriteLine("Tipe Asus seri ZenBook....");
        }
    }
}