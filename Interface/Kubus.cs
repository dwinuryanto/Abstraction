using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Kubus : IBangunRuang
    {
        public int S;
        public void volume()
        {
            Console.WriteLine("masukan nilai sisi : ");
            S = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volume Kubus   =  " + (S * S * S));
        }
       public void LuasPermukaan()
        {
            Console.WriteLine("Luas Permukaan Kubus   =  " + (6 * (S * S)));
        }
    }
}
