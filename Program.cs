Console.WriteLine("1. Задача №2"); // max и min 2ух чисел
Console.WriteLine("2. Задача №4"); // max 3ех чисел
Console.WriteLine("3. Задача №6"); // Является ли число четным
Console.WriteLine("4. Задача №8"); // Показывает все четные числа от 1 до N
Console.WriteLine("5. Задача повышенной сложности"); // Сравнение сумм элементов 2ух частей массива
Console.Write("Выберите номер задачи:");
int taskNumber = int.Parse(Console.ReadLine());

switch (taskNumber)
{
    case 1: // Первая задача (под номером 2 в ДЗ)
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
    case 2: // Вторая задача (под номером 4 в ДЗ)
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
    case 3: // Третья задача (под номером 6 в ДЗ)
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
    case 4: // Четвертая задача (под номером 8 в ДЗ)
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
    case 5: // Задача повышенной сложности 
        Console.WriteLine("Вы выбрали задачу повышенной сложности!");
        Console.Write("Введите размер массива:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int [n];
        Console.WriteLine("Введите массив:");
        for(int i=0; i<n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Введите индекс массива:");
        int k = int.Parse(Console.ReadLine());
        int sum1 = 0;
        int sum2 = 0;
        Console.Write("Массив:");
        for(int j = 0; j<n; j++)
        {
            Console.Write(arr[j]+",");
            if(j<=k)
            {
                sum1 = sum1 + arr[j];
            }
            else
            {
                sum2 = sum2 + arr[j];
            }
        }
        Console.WriteLine($"сумма элементов из первой части:{sum1}");
        Console.WriteLine($"Сумма элементов из второй части:{sum2}");
        if(sum1>sum2)
        {
            Console.WriteLine($"Первая часть!");
        }
        else if(sum2>sum1)
        {
             Console.WriteLine("Вторая часть!");
        }
        else
        {
             Console.WriteLine("Обе части равны!");
        }
        break;
    default:
        Console.WriteLine("Нет такой задачи");
        break;
}