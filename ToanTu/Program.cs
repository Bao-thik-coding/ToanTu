using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToanTu
{
    class Program
    {
        static void Main(string[] args)
        {
            int cao;
            int dai;

            Console.Write("Nhap do dai: ");
            dai = int.Parse(Console.ReadLine());
            Console.Write("Nhap do cao: ");
            cao = int.Parse(Console.ReadLine());

            int dien_tich = cao * dai;
            Console.WriteLine("Dien Tich la " + dien_tich);
            Console.ReadKey();
        }
    }
}
