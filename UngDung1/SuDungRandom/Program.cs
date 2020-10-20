using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            // Lay 1 so ngau nhien 0 - 9
            //Console.WriteLine(a.Next(0, 9));
            Console.WriteLine("Nhap mot so bat ky: ");
            int kq = a.Next(0, 9);
            // Console.WriteLine(kq);
            // Nhap du doan
            int dudoan = int.Parse(Console.ReadLine());
            // So sanh
            if (dudoan==kq)
            {
                Console.WriteLine("Ban da doan dung!");
            }
            else
            {
                Console.WriteLine("Ban da doan sai!");
            }
        }
    }
}
