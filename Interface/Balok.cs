using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Balok : IBangunRuang
    {
        public int P, L, T;
        public void volume()
        {
            Console.WriteLine("masukan nilai Panjang : ");
            P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("masukan nilai Lebar : ");
            L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("masukan nilai Tinggi : ");
            T = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volume Balok   =  " + (P * L * T));
        }

        public void LuasPermukaan()
        {
            Console.WriteLine("Luas Permukaan Balok   =  " + (2 * (P * L + P * T + L * T)));
        }

      
    }
}
