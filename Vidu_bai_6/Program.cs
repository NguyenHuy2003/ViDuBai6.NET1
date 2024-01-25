using System;
using System.Text;

namespace Vidu_bai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Ví dụ dùng break: In ra các số từ 1 đến 10
            Console.WriteLine("Ví dụ dùng break: In ra các số từ 1 đến 10:");
            int n = 0;
            while (true)
            {
                Console.WriteLine(++n);
                if (n == 10)
                {
                    break;
                }
            }
            Console.WriteLine("------------------------------");

            // Ví dụ dùng continue: In ra các số chia hết cho 4 trong khoảng từ 1 đến 20
            Console.WriteLine("Ví dụ dùng continue: In ra các số chia hết cho 4 trong khoảng từ 1 đến 20:");

            for (int i = 1; i <= 20; i++)
            {
                if (i % 4 != 0)
                    continue;
                Console.WriteLine(i);
            }

            Console.WriteLine("------------------------------");

            // Ví dụ vòng lặp do while: Tính giai thừa của 9
            int giaiThua1 = 1;
            int k = 1;
            do
            {
                giaiThua1 = giaiThua1 * k;
                k++;
            }
            while (k < 10);

            Console.WriteLine("Ví dụ vòng lặp do while: Tính giai thừa của 9 bằng " + giaiThua1);
            Console.WriteLine("------------------------------");

            // Ví dụ vòng lặp while: Tính giai thừa của 9
            int giaiThua = 1;
            int j = 1;
            while (j < 10)
            {
                giaiThua = giaiThua * j;
                j++;
            }
            Console.WriteLine("Ví dụ vòng lặp while: Tính giai thừa của 9 bằng " + giaiThua);
            Console.WriteLine("------------------------------");

            // Ví dụ 1 vòng lặp for: Tính tổng từ 1 đến 9
            int tong = 0;
            for (int i = 1; i < 10; i++)
            {
                tong = tong + i;
            }
            Console.WriteLine("Ví dụ 1: Tổng từ 1 đến 9 bằng " + tong);
            Console.WriteLine("------------------------------");

            // Ví dụ 2 vòng lặp for: In ra các số chắn từ 10 đến 20
            int c = 10;
            Console.WriteLine("Ví dụ 2: In ra các số chắn từ 10 đến 20:");
            for (; c <= 20;)
            {
                Console.WriteLine(c);
                c += 2;
            }

        }
    }
}
