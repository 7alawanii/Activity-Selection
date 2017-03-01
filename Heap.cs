using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Selection
{
    public class Heap
    { 
       public int Current_Size;
        private void Swap(Node[] array, int i, int j)
        {
            Node temp = new Node(array[i].Start, array[i].End,array[i].Order);
            array[i] = array[j];
            array[j] = temp;
        }
        public void Max_Heapify(Node[] array, int heapindex)
        {
            int largest = 0;
            int length = Current_Size;
            int Right_Child = (heapindex * 2) + 2;
            int Left_Child = (heapindex * 2) + 1;
            if (Left_Child < length && array[Left_Child].End > array[heapindex].End)
                largest = Left_Child;
            else
                largest = heapindex;
            if (Right_Child < length && array[Right_Child].End > array[largest].End)
                largest = Right_Child;
            if (largest != heapindex)
            {
                Swap(array, heapindex, largest);
                Max_Heapify(array, largest);
            }
        }
        public void Build_Max_Heap(Node[] array, int size)
        {
            int newsize = size - 1;
            for (int i = (newsize / 2); i >= 0; i--)
            {
                Max_Heapify(array, i);
            }
        }
        public Node dequeue(Node[] array)
        {
            Node root = array[0];
            Current_Size--;
            array[0] = array[Current_Size];
            Max_Heapify(array, 0);
            return root;
        }
        public Node[] Heap_Sort(Node[] array)
        {
            Node[] heap = new Node[Current_Size];
            for (int i = Current_Size - 1; i >= 0; i--)
            {
                heap[i] = dequeue(array);
            }
            return heap;
        }
    }
}
