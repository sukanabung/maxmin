using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak5
{
    internal class Numbers
    {
        public int CariNilaiMin(int a, int b)
        {
            int min;
            if (a < b)
            {
                Console.WriteLine("Nilai min dari ketiga nilai adalah : {0}", min = a);
                Console.ReadKey();
            }

            else if (b < a)
            {
                Console.WriteLine("Nilai max dari ketiga nilai adalah : {0}", min = b);
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Yang kamu masukkan bukan int !", min = a, min = b);
                Console.ReadKey();
            }
            return min;
        }
        public int CariNilaiMin(int a, int b, int c)
        {
            int min;
            if (a < b)
            {
                Console.WriteLine("Nilai min dari ketiga nilai adalah : {0}", min = a);
                Console.ReadKey();
            }
            else if (b < c)
            {
                Console.WriteLine("Nilai min dari ketiga nilai adalah : {0}", min = b);
                Console.ReadKey();
            }
            else if (c < a)
            {
                Console.WriteLine("Nilai min dari ketiga nilai adalah : {0}", min = c);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Yang kamu masukkan bukan int !}", min = a, min = b, min = c);
                Console.ReadKey();
            }
            return min;
        }

        public int CariNilaiMax(int a, int b)
        {
            int max;
            if (a > b)
            {
                Console.WriteLine("Nilai max dari ketiga nilai adalah : {0}", max = a);
                Console.ReadKey();
            }

            else if (b > a)
            {
                Console.WriteLine("Nilai max dari ketiga nilai adalah : {0}", max = b);
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Yang kamu masukkan bukan int !", max = a, max = b);
                Console.ReadKey();
            }
            return max;
        }
        public int CariNilaiMax(int a, int b, int c)
        {
            int max;
            if (a > b)
            {
                Console.WriteLine("Nilai max dari ketiga nilai adalah : {0}", max = a);
                Console.ReadKey();
            }
            else if (b > c)
            {
                Console.WriteLine("Nilai max dari ketiga nilai adalah : {0}", max = b);
                Console.ReadKey();
            }
            else if (c > a)
            {
                Console.WriteLine("Nilai m dari ketiga nilai adalah : {0}", max = c);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Yang kamu masukkan bukan int !}", max = a, max = b, max = c);
                Console.ReadKey();
            }
            return max;
        }
    }
}
