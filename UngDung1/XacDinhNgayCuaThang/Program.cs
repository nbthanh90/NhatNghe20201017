using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XacDinhNgayCuaThang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap Thang: ");
            int thang = int.Parse(Console.ReadLine());
            if (thang == 2)
            {
                // La thang 2
                Console.WriteLine("Nhap Nam: ");
                int nam = int.Parse(Console.ReadLine());
                if (nam % 4 == 0 && nam % 100 > 0)
                {
                    Console.WriteLine("Thang " + thang + "co 29 Ngay");
                }
                else
                {
                    Console.WriteLine("Thang " + thang + "co 28 Ngay");
                }
            }
            else
            {
                // Cac THANG con lai
                switch (thang)
                {
                    case 1: Console.WriteLine("Thang " + thang + " co 31 ngay"); break;
                    case 3: Console.WriteLine("Thang " + thang + " co 31 ngay"); break;
                    case 4: Console.WriteLine("Thang " + thang + " co 30 ngay"); break;
                    case 5: Console.WriteLine("Thang " + thang + " co 31 ngay"); break;
                    case 6: Console.WriteLine("Thang " + thang + " co 30 ngay"); break;
                    case 7: Console.WriteLine("Thang " + thang + " co 31 ngay"); break;
                    case 8: Console.WriteLine("Thang " + thang + " co 31 ngay"); break;
                    case 9: Console.WriteLine("Thang " + thang + " co 30 ngay"); break;
                    case 10: Console.WriteLine("Thang " + thang + " co 31 ngay"); break;
                    case 11: Console.WriteLine("Thang " + thang + " co 30 ngay"); break;
                    case 12: Console.WriteLine("Thang " + thang + " co 31 ngay"); break;
                    default: Console.WriteLine("Khong phai THANG trong NAM!"); break;
                }
            }
            // Xac dinh MUA cua THANG
            switch (thang)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Xuan");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Ha");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Thu");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Dong");
                    break;
                default:
                    break;
            }
        }
    }
}
