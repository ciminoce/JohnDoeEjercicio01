using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnDoeEjercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la medida del cateto a:");
            var catetoA = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la medida del cateto B:");
            var catetoB = int.Parse(Console.ReadLine());
            var superficie = catetoA * catetoB / 2;
            var hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));
            var perimetro = catetoA + catetoB + hipotenusa;
            Console.WriteLine($"la superficie es {superficie}");
            Console.WriteLine($"el perímetro es {perimetro}");
            Console.ReadLine();
        }
	}
}
