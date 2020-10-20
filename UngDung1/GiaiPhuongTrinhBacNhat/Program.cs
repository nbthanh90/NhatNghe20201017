using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPhuongTrinhBacNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phuong trinh bac nhat aX + b = 0");
            Console.Write("Xin hay nhap gia tri a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Xin hay nhap gia tri b: ");
            double b = double.Parse(Console.ReadLine());
            // Voi a = 0
            if (a == 0)
            {
                // Kiem tra b = 0?
                if (b == 0)
                {
                    // Voi b = 0
                    Console.WriteLine("Vo so nghiem");
                }
                else
                {
                    // Voi b != 0
                    Console.WriteLine("Vo nghiem");
                }
            }
            else
            {
                // Voi a != 0
                Console.WriteLine("X = {0}", -b / a);
            }

        }
    }
}
