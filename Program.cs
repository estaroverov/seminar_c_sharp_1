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
        Console.WriteLine("Вы выбрали задачу №4");
        Console.Write("Введите первое число:");
        int number2_1 = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число:");
        int number2_2 = int.Parse(Console.ReadLine());
        Console.Write("Введите третье число:");
        int number2_3 = int.Parse(Console.ReadLine());
        int max = number2_1;
        if(max<number2_2)
        {
            max = number2_2;
        }
        if(max < number2_3)
        {
            max = number2_3;
        }
        Console.WriteLine($"max={max}");
        break;
    case 3:
        Console.WriteLine("Вы выбрали задачу №6");
        Console.Write("Введите число:");
        int number3 = int.Parse(Console.ReadLine());
        if(number3%2!=0)
        {
            Console.WriteLine($"Число {number3} нечетное!");
        }
        else
        {
             Console.WriteLine($"Число {number3} четное!");
        }
        break;
    case 4:
        Console.WriteLine("Вы выбрали задачу №8");
        Console.Write("Введите число:");
        int number4 = int.Parse(Console.ReadLine());
        int counter = 0;
        while(counter<=number4)
        {
            if(counter%2==0 && counter !=0)
            {
                Console.WriteLine(counter);
            }
            counter++;
        }
        
        break;
    case 5:
        Console.WriteLine("Четверг");
        break;
    default:
        Console.WriteLine("Нет такой задачи");
        break;
}