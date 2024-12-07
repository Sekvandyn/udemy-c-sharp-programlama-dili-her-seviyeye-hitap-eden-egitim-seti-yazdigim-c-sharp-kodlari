using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Veri_Tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // byte değişkeni 0 ile 255 arasındaki tam sayı değerlerini alır
            byte degisken = 7;
            byte degisken2 = 8;
            byte degisken3 = byte.MaxValue; //max değeri degisken3 e atar
            byte degisken4 = byte.MinValue; // min değeri degisken4 e  atar
            // byte degisken3 = 521; // 0 ile 255 arasında değer alır o yüzden hata verir

            Console.WriteLine(degisken);
            Console.WriteLine(degisken2);
            Console.WriteLine(degisken3);
            Console.WriteLine(degisken4);
            Console.ReadLine();
        }
    }
}
