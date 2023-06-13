using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            numbers.CariNilaiMin(33, 22);
            numbers.CariNilaiMin(1000, 20, 9);
            numbers.CariNilaiMax(55, 22);
            numbers.CariNilaiMax(1000, 20, 9);
        }
    }
}
