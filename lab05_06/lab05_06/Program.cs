using System;

namespace lab05_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray;
            Console.Write("Введите длину массива: ");
            int n = int.Parse(Console.ReadLine());
            myArray = new int[n];
            for (int i = 0; i < myArray.Length; ++i)
            {
                Console.Write("a[{0}] = ", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Сумма элементов массива: {0}", Amount(myArray));
            Console.WriteLine("Среднее значение элементов массива: {0}", AverageScore(myArray));
            Console.WriteLine("Сумма положительных элементов массива: {0}", PositiveAmount(myArray));
            Console.WriteLine("Сумма элементов массива с нечетными номерами: {0}", OddAmount(myArray));
            Console.WriteLine("Индекс максимального элемента: {0}", Maximum(myArray));
            Console.WriteLine("Индекс минимального элемента: {0}", Minimum(myArray));
            Console.WriteLine("Сумма элементов массива минимальным и максимальным: {0}", FromMinToMaxAmount(myArray));
        }
        public static int Amount(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        public static double AverageScore(int[] a)
        {
            int sum = Amount(a);
            double score = sum/a.Length;
            return score;
        }
        public static int PositiveAmount(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0) sum += a[i];
            }
            return sum;
        }
        public static int OddAmount(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 != 0) sum += a[i];
            }
            return sum;
        }
        public static int Maximum(int[] a)
        {
            int max = a[0];
            int imax = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    imax = i;
                }
            }
            return imax;
        }
        public static int Minimum(int[] a)
        {
            int min = a[0];
            int imin = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    imin = i;
                }
            }
            return imin;
        }
        public static int FromMinToMaxAmount(int[] a)
        {
            int sum = 0;
            if (Minimum(a) > Maximum(a)) Console.WriteLine("Не удалось выполнить операцию");
            else
                for (int i = Minimum(a) + 1; i < Maximum(a); i++)
                {
                    sum += a[i];
                }
            return sum;
        }
    }
}

