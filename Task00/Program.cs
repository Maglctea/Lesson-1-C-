// Задание 1
// Console.WriteLine("Введите 1 число:");
// int a = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("Введите 2 число:");
// int b = Convert.ToInt32(Console.ReadLine());
//
// if (b * b == a)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// Задание 2.1
// Console.WriteLine("Введите число:");
// int a = Convert.ToInt32(Console.ReadLine());
//
// if (a < 1 || a > 7) 
// {
//     Console.WriteLine("Такого дня нет:");
// }
//
// if (a == 1)
//     Console.WriteLine("Понедельник");
// if (a == 2)
//     Console.WriteLine("Вторник");
// if (a == 3)
//     Console.WriteLine("Среда");
// if (a == 4)
//     Console.WriteLine("Четверг");
// if (a == 5)
//     Console.WriteLine("Пятница");
// if (a == 6)
//     Console.WriteLine("Суббота");
// if (a == 7)
//     Console.WriteLine("Воскресенье:");

// Задание 2.2
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1:
        Console.WriteLine("Понедельник");
    break;

    case 2:
        Console.WriteLine("Вторник");
    break;

    case 3:
        Console.WriteLine("Среда");
    break;

    case 4:
        Console.WriteLine("Четверг");
    break;

    case 5:
        Console.WriteLine("Пятница");
    break;

    case 6:
        Console.WriteLine("Суббота");
    break;

    case 7:
        Console.WriteLine("Воскресенье");
    break;

    default:
        Console.WriteLine("Такого дня нет");
    break;
}