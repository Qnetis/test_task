using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task.processing
{
    internal class Triangle : IGeometry
    {
        void IGeometry.calculate()
        {
            Console.WriteLine("-> Введите первую сторону треугольника: ");
            float a = CheckingValue();


            Console.WriteLine("-> Введите вторую сторону треугольника: ");
            float b= CheckingValue();

            Console.WriteLine("-> Введите третью  сторону треугольника: ");
            float c = CheckingValue();


            float p = (a + b + c) / 2.0f;
            float s = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("-> Площадь треугольника по трем сторонам = " + s);
            bool specialTriangle = Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
            if (specialTriangle)
                Console.WriteLine("-> Треугольник является прямоугольным");
        }

        float CheckingValue()
        {
            float number;
            while (!float.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("-> Введите цифру");
            return number;
        }
    }
}
