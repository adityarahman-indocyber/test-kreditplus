using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdityaRahman
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 3;
            a = a + b;
            b = a - b;
            a = a - b;
           
            Console.WriteLine("Soal no 1 : ");
            Console.WriteLine("Hasilnya A : {0} ", a);
            Console.WriteLine("Hasilnya B : {0} ", b);

            Console.WriteLine("\nSoal ke 2 : ");
            int[] x = { 20, 10, 50, 46, 26, 87, 25, 5, 97, 24 };
            int tampung;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i; j < x.Length; j++)
                {
                    if (x[i] > x[j])
                    {
                        tampung = x[i];
                        x[i] = x[j];
                        x[j] = tampung;
                    }
                }
            }
            Console.WriteLine("Perubahan nilai dari terkecil ke terbesar ");
            Console.Write("Nilai : ");
            for (int k = 0; k < x.Length; k++)
            {
                Console.Write("{0} ", x[k]);
            }

        }
    }
}
