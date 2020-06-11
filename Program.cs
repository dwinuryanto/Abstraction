using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abstraction.AbstractClass;
using Abstrastion.AbstractClass;
//using Abstraction.Interface;
namespace AbstratClass
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunRuang bangunruang;
           // IBangunRuang bangunruang;
            Console.WriteLine("1. Kubus ");
            bangunruang = new Kubus();
            bangunruang.Volume();
            bangunruang.LuasPermukaan();

            Console.WriteLine("2. Balok ");
            bangunruang = new Balok();
            bangunruang.Volume();
            bangunruang.LuasPermukaan();
            Console.ReadKey(true);

        }
    }
}
