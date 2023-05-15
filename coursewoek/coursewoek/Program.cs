using System;
using System.Threading.Tasks;
namespace QuickSortAlgoritm
{
    class program
    {
        static void Main()

        {
            int[] MyArray = new int[10];

            Console.WriteLine("Выберите способ заполнения массива:");
            Console.WriteLine("1 - Автоматически");
            Console.WriteLine("2 - Самому");

            int vibor = int.Parse(Console.ReadLine());
            if (vibor == 1)
            {                // Заполнение массива автоматически
                Random random = new Random();
                for (int i = 0; i < MyArray.Length; i++)
                {
                    MyArray[i] = random.Next(1, 100);
                }
            }
            else if (vibor == 2)
            {                // Заполнение массива вручную
                for (int i = 0; i < MyArray.Length; i++)
                {
                    Console.Write($"Введите элемент массива {i}: ");
                    MyArray[i] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"Исходный массив: {string.Join(", ", MyArray)}");

            int[] sortedArray = QuickSort(MyArray, 0, MyArray.Length - 1);
            Console.WriteLine($"Отсортированный массив: {string.Join(", ", sortedArray)}");
            Console.ReadLine();

        }
        private static int[] QuickSort(int[] array, int min, int max)
        {
            if (min >= max)
            {
                return array;
            }
            int pivot = GetPivot(array, min, max);
            QuickSort(array, min, pivot - 1);
            QuickSort(array, pivot + 1, max); return array;
        }
        private static int GetPivot(int[] array, int min, int max)
        {
            int pivot = min - 1; for (int i = min; i <= max; i++)
            {
                if (array[i] < array[max])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++; 
            Swap(ref array[pivot], ref array[max]);
            return pivot;
        }
        private static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right; 
            right = temp;
        }
    }
}using System;
using System.Threading.Tasks;
namespace QuickSortAlgoritm
{
    class program
    {
        static void Main()

        {
            int[] MyArray = new int[10];

            Console.WriteLine("Выберите способ заполнения массива:");
            Console.WriteLine("1 - Автоматически");
            Console.WriteLine("2 - Самому");

            int vibor = int.Parse(Console.ReadLine());
            if (vibor == 1)
            {                // Заполнение массива автоматически
                Random random = new Random();
                for (int i = 0; i < MyArray.Length; i++)
                {
                    MyArray[i] = random.Next(1, 100);
                }
            }
            else if (vibor == 2)
            {                // Заполнение массива вручную
                for (int i = 0; i < MyArray.Length; i++)
                {
                    Console.Write($"Введите элемент массива {i}: ");
                    MyArray[i] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine($"Исходный массив: {string.Join(", ", MyArray)}");

            int[] sortedArray = QuickSort(MyArray, 0, MyArray.Length - 1);
            Console.WriteLine($"Отсортированный массив: {string.Join(", ", sortedArray)}");
            Console.ReadLine();

        }
        private static int[] QuickSort(int[] array, int min, int max)
        {
            if (min >= max)
            {
                return array;
            }
            int pivot = GetPivot(array, min, max);
            QuickSort(array, min, pivot - 1);
            QuickSort(array, pivot + 1, max); return array;
        }
        private static int GetPivot(int[] array, int min, int max)
        {
            int pivot = min - 1; for (int i = min; i <= max; i++)
            {
                if (array[i] < array[max])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++; 
            Swap(ref array[pivot], ref array[max]);
            return pivot;
        }
        private static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right; 
            right = temp;
        }
    }
}

