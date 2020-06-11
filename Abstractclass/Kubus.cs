
using Abstrastion.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction.AbstractClass
{
    public class Kubus : BangunRuang
    {
        public int S;
        public override void Volume()
        {
            Console.WriteLine("masukan nilai sisi : ");
            S = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volume Kubus   =  " + (S * S * S));
        }
        public override void LuasPermukaan()
        {
            Console.WriteLine("Luas Permuaan Kubus   =  " + (6*(S * S)));
        }
    }
}
