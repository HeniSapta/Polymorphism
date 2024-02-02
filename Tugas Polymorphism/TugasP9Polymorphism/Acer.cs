using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Acer : Computer
    {
        public override void Show()
        {
            Console.WriteLine("Tampilan tipe Acer  : SFX14-41G ");
        }

        public override void Print()
        {
            Console.WriteLine("Inilah salah satu tipe Acer....");
        }
    }
}
