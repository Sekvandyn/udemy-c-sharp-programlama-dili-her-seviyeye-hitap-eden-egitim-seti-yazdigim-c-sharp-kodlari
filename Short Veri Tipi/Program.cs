using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Short_Veri_Tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // shorrt -32768 ile +32768 arasındaki tam sayı değerlerini alır
            short degisken1 = -50;
            short degisken2 = 50;
            short degisken3 = 12448;
            // short degisken4 = -622024; //min 32768 olabileceği için hata verir
            short degisken5 = short.MaxValue; //alabileceği en yüksek değeri değisken5 e atar
            short degisken6 = short.MinValue; //alabieceği eb düsük değeri degisken5 ya atar

            Console.WriteLine(degisken1);
            Console.WriteLine(degisken2);
            Console.WriteLine(degisken3);
            Console.WriteLine(degisken5);
            Console.WriteLine(degisken6);
            Console.ReadLine();
        }
    }
}
