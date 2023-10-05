using System;
namespace Bai2_3
{
    class BaiTapVeNha
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Nhap vao so nam: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao so thang: ");
            y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0} {1}",x,y);
            if (y == 1 ||  y == 3|| y == 5 || y == 7 || y == 8 || y == 10 || y == 12)
            {
                Console.WriteLine("Thang {0} nam {1} co 31 ngay !", y,x);
            }
            if (y == 4 || y == 6 || y == 9 || y == 11 )
            {
                Console.WriteLine("Thang {0} nam {1} co 30 ngay !", y, x);
            }
            if (y == 2)
            {
                if ( x % 4 == 0)
                {
                    Console.WriteLine("Thang {0} nam {1} co 29 ngay !", y, x);
                }
                else 
                { 
                    Console.WriteLine("Thang {0} nam {1} co 28 ngay !", y, x);
                }
            }
        }
    }
}