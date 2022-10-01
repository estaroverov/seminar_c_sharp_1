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
        Console.WriteLine("Четверг");
        break;
    default:
        Console.WriteLine("Нет такой задачи");
        break;
}