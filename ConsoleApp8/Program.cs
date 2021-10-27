using System;
using ClassLibrary2;
using ClassLibrary;




namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
           // task 1 - Вариант 1 : если есть готовый массив в классе ArrayWorker и его инвертировать

            ArrayWorker arrayWorker = new ArrayWorker();

            arrayWorker.Inversiya();


           // task 1   Вариант 2 : если введем  массив в класс ArrayWorker с КОНСОЛИ и его инвертируем

             arrayWorker.Inversiya2();

            Console.WriteLine();

          //  task 2


            Console.WriteLine("Task 2  Added index ");
            
            int[] mas = { 1, 2, 4,8,5,0};
              arrayWorker.Insert(ref mas, 888, 3);

            Console.WriteLine();


            // task 3  CONE

            Console.WriteLine();

             Console.Write($"Введите значение высоты h  -\t\t\t\t");
            double h = double.Parse(Console.ReadLine());
            Console.Write("Введите значение радиуса r -\t\t\t\t");
            double r = double.Parse(Console.ReadLine());
            double l = Math.Sqrt(h + r);
            Console.WriteLine($"Найдем значение образующей  l зная значения h и r - \t{l}");


            Cone cone = new Cone(h, r, l);
            Console.WriteLine();


            Console.WriteLine($" Полная площадь конуса равна \t{cone.SFull()} единиц");
            Console.WriteLine($" Полная площадь конуса равна \t{cone.SGround()} единиц");





        }
        

    }
}
