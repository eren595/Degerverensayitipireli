using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Degerverensayıtipireli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 =sayi1;
            sayi2 = 50;
            Console.WriteLine("sayi1 = {0}",sayi1);
            Console.WriteLine("sayi2 ={0}", sayi2);
            Console.WriteLine("=====================");
            SayiTutucu st1 = new SayiTutucu();
            st1.A = 10;
            SayiTutucu st2 = st1;
            st2.A = 50;
            Console.WriteLine("st1.A degeri: {0}", st1.A);
            Console.WriteLine("st2.A degeri: {0}", st2.A);
        }
    }
    class SayiTutucu
    {
        public int A { get; set; }
    }
}
