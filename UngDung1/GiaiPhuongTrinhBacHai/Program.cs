using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPhuongTrinhBacHai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phuong trinh bac hai aX^2 + bX + c = 0");
            Console.Write("Xin hay nhap a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Xin hay nhap b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Xin hay nhap c: ");
            double c = double.Parse(Console.ReadLine());

            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem!");
            }
            else
            {
                double X1 = (-b + Math.Sqrt(d) )/ (2 * a);
                double X2 = (-b - Math.Sqrt(d) )/ (2 * a);
                Console.WriteLine("Nghiem cua phuong trinh la: X1 = {0} | X2 = {1} ", X1, X2);
            }
        }
    }
}
