using System;

class Program
{
    static void Main(string[] args)
    {
       while (true)
        {
            Console.WriteLine("напишите номер задания от 1 до 3");
            int i =Convert.ToInt32(Console.ReadLine());
            try
            {


                if (i == 1)
                {
                    ZedOne();
                }
                if (i == 2)
                {
                    ZedTwo();
                }
                if (i == 3)
                {
                    ZedThri();
                }
                else
                {
                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Пока");
            }
        }
    }
    static void ZedOne()
    {
        while (true)
        {
            Console.Write("Введите целое число или 'q' для выхода: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                Console.WriteLine("[STOP]");
                break;
            }

            int number;
            if (int.TryParse(input, out number))
            {
                int sum = SumOfDigits(number);
                if (sum % 2 == 0)
                {
                    Console.WriteLine("[STOP]");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для выхода.");
            }
        }
    }
    static void ZedTwo()
    {
        // Создаем объект Random для генерации случайных чисел
        Random random = new Random();

        // Создаем массив случайных трехзначных чисел
        int[] array = new int[10]; // Массив из 10 элементов
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000); // Генерируем случайное трехзначное число
        }

        // Подсчитываем количество четных чисел в массиве
        int countEven = CountEvenNumbers(array);
        for(int i = 0; i <array.Length; i++)
        {
            Console.Write(" "+ array[i]+" ");
        }
        // Выводим результат на экран
        Console.WriteLine($"Количество четных чисел в массиве: {countEven}");
    }
    public static void ZedThri()
    {
        int[] array = { 1, 3, 5, 6, 7, 8 }; // Заданный массив

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Переворачиваем массив
        ReverseArray(array);

        // Выводим перевернутый массив
        Console.WriteLine("\nПеревернутый массив:");
        PrintArray(array);
    }
    public static void ReverseArray(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left < right)
        {
            // Обмениваем значения на позициях left и right
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;

            // Переходим к следующим элементам
            left++;
            right--;
        }
    }

    // Функция для вывода массива на консоль
    public static void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine("]");
    }
    public static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        foreach (var num in array)
        {
            if (num % 2 == 0) // Если число делится на 2 без остатка, оно четное
            {
                count++; // Увеличиваем счетчик четных чисел
            }
        }
        return count;
    }
    // Функция для вычисления суммы цифр числа
    static int SumOfDigits(int num)
    {
        int sum = 0;
        num = Math.Abs(num); // Убедимся, что число неотрицательное

        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }

}
