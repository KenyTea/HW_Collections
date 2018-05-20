using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stack
            /*Решить следующие задачи с использованием класса Stack:
            1.	Дан файл, в котором записан набор чисел. Переписать в другой файл все числа в обратном порядке.*/

            Stack<int> num = new Stack<int>();
            num.Push(1);
            num.Push(2);
            num.Push(3);
            foreach (int item in num)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            foreach (int item in num.Reverse())
            {
                Console.Write(item);
            }

            Console.WriteLine();
            Console.WriteLine();

            /*2.	Создать текстовый файл. Распечатать гласные буквы этого файла в обратном порядке.*/
            string f = "UedYaaspWqndLdjZ";
            char[] a = f.ToCharArray();
            Stack<char> stack = new Stack<char>();
            foreach (char item in a)
            {
                stack.Push(item);
            }

            foreach (char item in stack)
            {
                if (item.ToString() == item.ToString().ToUpper())
                    Console.Write(item);
            }
            #endregion

            #region Queue
            /*1.	Решить следующие задачи с использованием класса Queue:
             2.	Дан файл, содержащий числа. За один просмотр файла напечатать элементы файла в следующем порядке: 
             сначала все числа, из интервала [a,b], потом все числа, меньшие a, 
             потом все числа, большие b, сохраняя исходный порядок в каждой группе чисел.*/
            Console.WriteLine();
            Console.WriteLine();

            Queue<int> qe = new Queue<int>();
            qe.Enqueue(5);
            qe.Enqueue(8);
            qe.Enqueue(3);
            qe.Enqueue(1);
            qe.Enqueue(9);
            qe.Enqueue(11);
            qe.Enqueue(2);
            qe.Enqueue(33);

            foreach (int item in qe)
            {
                if (item > 7 && item < 12)

                    Console.Write(item + " ");
            }
            Console.WriteLine();


            foreach (int item in qe)
            {
                if (item < 7)
                    Console.Write(item + " ");
            }
            Console.WriteLine();

            foreach (int item in qe)
            {
                if (item < 12)
                    Console.Write(item + " ");
            }
            Console.WriteLine();


            /*5.	Дан текстовый файл. За один просмотр файла напечатать элементы файла в следующем порядке:
             сначала все слова, начинающиеся с прописной буквы, потом все слова, начинающиеся со строчной буквы, 
             сохраняя исходный порядок в каждой группе слов.*/
            Console.WriteLine();
            Queue<string> qq = new Queue<string>();
            qq.Enqueue("Masha");
            qq.Enqueue("plus");
            qq.Enqueue("Sasha");
            qq.Enqueue("equals");
            qq.Enqueue("Porridge");

            foreach (string item in qq)
            {
                if(item == item.ToUpper())
                    Console.WriteLine(item);
            }
            foreach (string item in qq)
            {
                if (item == item.ToLower())
                    Console.WriteLine(item);
            }

            #endregion

            #region 
            Console.ReadKey();
        }
    }
}
