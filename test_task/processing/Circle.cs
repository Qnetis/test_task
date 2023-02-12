using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task.processing
{
    internal class Circle : IGeometry
    {
        void IGeometry.calculate()
        {
            Console.WriteLine("-> Введите радиус круга: ");
            int radius;
            while (!int.TryParse(Console.ReadLine(), out radius))
                Console.WriteLine("-> Введите цифру");
            Console.WriteLine("-> Площадь круга = " + Math.PI * Math.Pow(radius, 2));

        }
    }
}
