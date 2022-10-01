Console.WriteLine("1. Задача №2");
Console.WriteLine("2. Задача №4");
Console.WriteLine("3. Задача №6");
Console.WriteLine("4. Задача №8");
Console.WriteLine("5. Задача повышенной сложности");
Console.Write("Выберите номер задачи:");
int taskNumber = int.Parse(Console.ReadLine());

switch (taskNumber)
{
    case 1:
        Console.WriteLine("Вы выбрали задачу №2");
        Console.Write("Введите первое число:");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число:");
        int number2 = int.Parse(Console.ReadLine());
        if(number1>number2)
        {
            Console.WriteLine($"Число {number1} больше числа {number2}");
        }
        else if(number2>number1)
        {
            Console.WriteLine($"Число {number2} больше числа {number1}");
        }
        else
        {
            Console.WriteLine($"Число {number1} равно числу {number2}");
        }
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
        Console.WriteLine("Четверг");
        break;
    default:
        Console.WriteLine("Нет такой задачи");
        break;
}