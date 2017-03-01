using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap heap = new Heap();
            int size;
            Console.Write("Please Enter The Number Of Activities : ");
            size = Convert.ToInt32(Console.ReadLine());
            Node[] Heap_Array = new Node[size];
            int counter = 0;
            heap.Current_Size = 0;
            Node temp;
            int s,e;
            for (int i = 0; i < size; i++)
            {
                Console.Write("Please Enter The Start Time Of Activity Number { "+(i + 1)+" } : ");
                s = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please Enter The End Time Of Activity Number { " + (i + 1) + " } : ");
                e = Convert.ToInt32(Console.ReadLine());
                temp = new Node(s, e,i);
                Heap_Array[i] = temp;
                heap.Current_Size++;
            }
            heap.Build_Max_Heap(Heap_Array, size);
            Node[] sorted = new Node[heap.Current_Size];
            sorted = heap.Heap_Sort(Heap_Array);
            Console.Write("The Maximal Set Of Non-Overlapping Activities Is { ");
            Node t = sorted[0];
            counter = t.End;
            Console.Write((t.Order + 1));
            for (int i = 1; i < size; i++)
            {
                t = sorted[i];
                if (sorted[i].Start >= counter)
                {
                    counter =t.End;
                    Console.Write(" , " + (t.Order+1));
                }

            }
            Console.Write(" } ");
            Console.ReadLine();
        }
    }
    }
