using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            MinHeap<int> heap1 = new MinHeap<int>();

            heap1.Add(4);
            heap1.Add(3);
            heap1.Add(2);
            heap1.Add(1);
            heap1.Add(0);



            Console.WriteLine(heap1.Contains(2));
            Console.WriteLine(heap1.ExtractMax());
            Console.WriteLine(heap1.Count);

            Console.WriteLine(heap1.ExtractMax());
           
        }
    }
}

