using System.Runtime.InteropServices;
using test_task.processing;

namespace test_task
{
    internal class Controller
    {
        private readonly string? _name;
        private IGeometry? _geometry;

        public Controller(string name)
        {
            if (string.IsNullOrEmpty(name))
                _name = "пользователь";
            else
                _name = name;

        }

        public void SetFigure(IGeometry weapon)
        {
            _geometry = weapon;
        }

        public void Run()
        {

            if (_geometry is null)
            {
                Console.WriteLine($"-> Извините{_name}, такое ещё не умеем (но легко добавить)");
                return;
            }

            _geometry.calculate();

            Console.WriteLine($"-> {_name} результат получен");
        }
    }
}
