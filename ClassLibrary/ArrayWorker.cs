using System;
using System.Text;

namespace ClassLibrary
{
    public  class ArrayWorker

    {
        int[] massiv = new[] { 2, 4, 6, 7, 8, 11, -34, 6 };

           
        public void Inversiya()
        {
            Console.WriteLine("Task 1 option 1: WE HAVE GOT READY ARRAY ");
            Console.WriteLine();
            Console.Write("Вывод ИНВЕРТИРУЕМОГО массива :\t\t");
           
            for (int i = massiv.Length - 1; i >= 0; i--)
            {

                Console.Write($"{massiv[i]}\t");

            }
            Console.WriteLine();
        }

        int[] massiv2;
        public void Inversiya2(params int[] mass)
        {
            Console.WriteLine("Task 1 option 2 : WE INPUT OUR ARRAY ");
            Console.WriteLine();

            Console.Write("\nВведите  количество элементтов массива \t ");

            int elements = int.Parse(Console.ReadLine());
             massiv2 = new int[elements];

            for (int i = 0; i < massiv2.Length; i++)
            {
                Console.Write($"Элемент {i} = ");
                massiv2[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Вывод ИНВЕРТИРУЕМОГО массива :\t\t");

            for (int i = massiv2.Length - 1; i >= 0; i--)
            {
                Console.Write($"{massiv2[i]}\t");
            }
            Console.WriteLine();
        }

        public void   Insert(ref int[] mas, int value, int index)
        {
           

            int[] newArray = new int[mas.Length + 1];
            newArray[index] = value;
            for (int i = 0; i < index; i++)
                newArray[i] = mas[i];
            for (int i = index; i < mas.Length; i++)

                newArray[i + 1] = mas[i];

            mas = newArray;
            Console.Write("Обновленный  массив с дополонительным индексом ");
            for (int i = 0; i < mas.Length; i++)
            {
              Console.Write($"\t{mas[i]}");
            }    
               
            
        }


    }
   

}

