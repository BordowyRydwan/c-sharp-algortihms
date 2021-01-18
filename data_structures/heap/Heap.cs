using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Heap<T> where T : IComparable<T>
    {
        public T[] elements = new T[0];

        public Heap() { }

        public Heap(T element)
        {
            elements = new T[] {element};
        }

        public Heap(T[] elements)
        {
            foreach(T item in elements)
            {
                Insert(item);
            }
        }

        public int Height
        {
            get
            {
                int h = 0;
                for (int i = 1; i < elements.Length; i = 2 * i + 1)
                {
                    h++;
                }
                return h;
            }
        }

        public void Insert(T node)
        {
            Array.Resize(ref elements, elements.Length + 1);

            elements[elements.Length - 1] = node;

            for(int i = elements.Length - 1; i > 0;)
            {
                int parent = (int)Math.Floor(Convert.ToDecimal((i - 1) / 2));
                T tmp = elements[parent];

                if(tmp.CompareTo(elements[i]) == -1)
                {
                    elements[parent] = elements[i];
                    elements[i] = tmp;
                    i = parent;
                }
                else
                {
                    break;
                }
            }
        }

        public void Heapify(int node)
        {
            int length = elements.Length;
            int highest = node;

            int left = 2 * node + 1;
            int right = 2 * node + 2;

            if (left < length && elements[left].CompareTo(elements[highest]) == 1)
            {
                highest = left;
            }

            if (right < length && elements[right].CompareTo(elements[highest]) == 1)
            {
                highest = right;
            }

            if (highest != node)
            {
                T tmp = elements[node];

                elements[node] = elements[highest];
                elements[highest] = tmp;
                Heapify(highest);
            }
        }

        public void DeleteHighest()
        {
            elements[0] = elements[elements.Length - 1];

            Array.Resize(ref elements, elements.Length - 1);
            Heapify(0);
        }

        public void Build()
        {
            for(int i = (elements.Length - 1) / 2; i >= 0; --i)
            {
                Heapify(i);
            }
        }

        public int HowManyLeaves()
        {
            int counter = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (2 * i + 1 >= elements.Length)
                {
                    counter++;
                }
            }
            return counter;
        }

        public bool IsHeap()
        {
            for (int i = 0; i < elements.Length / 2; i++)
            {
                if (elements[2 * i + 1].CompareTo(elements[i]) == 1) {
                    return false;
                }

                if (2 * i + 2 < elements.Length && elements[2 * i + 2].CompareTo(elements[i]) == 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
