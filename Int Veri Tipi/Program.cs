using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int_Veri_Tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int veri tipi -2.147.483.648 ile +2.147.483.648 arasındaki tam sayı değerlerini alabilir
            //int 8 bit yani 1 byte yer kaplar
            int degisken1 = -8452;
            int degisken2 = 85515;
            // int degisken3 = -555451445545; // int min -2.147.483.648 değerini aldığı için tanımlanmaz
            int degisken4 = int.MaxValue; // Alabileceği maks değeri degisken4 ün içine atar
            int degisken5 = int.MinValue; // Alabieleceği Min Değeri degisken5 in içine atar

            Console.WriteLine(degisken1);
            Console.WriteLine(degisken2);
            Console.WriteLine(degisken4);
            Console.WriteLine(degisken5);
            Console.ReadLine();


        }
    }
}
