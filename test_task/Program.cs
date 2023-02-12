using test_task;
using test_task.processing;

main();

void main()
{

    Console.WriteLine("----Добро пожаловать на тестовое задание----\nКак могу к вам обращаться?");
    string nameUser = Console.ReadLine();
    Controller hero = new(nameUser);
    while (true)
    {
        Console.WriteLine("-> Введите действие которое хотите совершить: ");
        Console.WriteLine("-> 1 - Вычислять площадь круга ");
        Console.WriteLine("-> 2 - Вычислять площадь треугольника");
        int actionNumber;
        while (!int.TryParse(Console.ReadLine(), out actionNumber))
            Console.WriteLine("-> Пожалуйста введите цифру");
        GetFactory(hero, actionNumber);
        hero.Run();
    }

}

void GetFactory(Controller hero, int actionNumber)
{

    switch (actionNumber)
    {
        case 1:
            hero.SetFigure(new Circle());
            break;
        case 2:
            hero.SetFigure(new Triangle());
            break;

        default:
            break;
    }
}