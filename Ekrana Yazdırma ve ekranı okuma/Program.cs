using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekrana_Yazdırma_ve_ekranı_okuma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //yorum satırı kodu etkilemez açıklamalar yapmanı sağşlar satır başına // ekleyerek yazılabilir
            /* veya bu şekilde birden fazla satırı yoruma dönüştürebilirsiniz */
            Console.WriteLine("C# Kodlarının ilki");//konsola yazdırır
            Console.WriteLine("Writeline alt satıra yazdırılır");// writeline ile iki farklı yazdırma olunca alt alta yazdırılır

            Console.Write("Write ise ");
            Console.Write("Yan yana yazdırır");// write ile iki farklı yazdırma olunca yanyana yazdırılır
            Console.ReadLine();//konsolun okunabilmesi için ekranda kalmasını sağlar
        }
    }
}
