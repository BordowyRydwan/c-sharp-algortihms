using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class MyQueueNode<T>
    {
        public T Data { get; set; } = default(T);
        public MyQueueNode<T> NextNode { get; set; } = null;

        public MyQueueNode(T value)
        {
            Data = value;
        }
    }

    class MyQueue<T>
    {
        public MyQueueNode<T> Head { get; set; }

        public MyQueue()
        {
            Head = null;
        }

        public MyQueue(T value)
        {
            Head = new MyQueueNode<T>(value);
        }

        public MyQueue(T[] elements)
        {
            if (elements.Length == 0)
            {
                Head = null;
            }

            else
            {
                for (int i = 0; i < elements.Length; ++i)
                {
                    Enqueue(elements[i]);
                }
            }
        }

        public void Enqueue(T element)
        {
            MyQueueNode<T> newNode = new MyQueueNode<T>(element);
            MyQueueNode<T> tmp = Head;

            while (tmp.NextNode != null)
            {
                tmp = tmp.NextNode;
            }

            tmp.NextNode = newNode;
        }

        public T Dequeue()
        {
            T data = Head.Data;
            Head = Head.NextNode;

            return data;
        }

        public T Peek()
        {
            return Head.Data;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }
    }
}
