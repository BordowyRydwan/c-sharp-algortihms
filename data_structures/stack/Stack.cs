using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class MyStackNode<T>
    {
        public T Data { get; set; } = default(T);
        public MyStackNode<T> NextNode { get; set; } = null;

        public MyStackNode(T value)
        {
            Data = value;
        }
    }

    class MyStack<T>
    {
        public MyStackNode<T> Head { get; set; }

        public MyStack()
        {
            Head = null;
        }

        public MyStack(T value)
        {
            Head = new MyStackNode<T>(value);
        }

        public MyStack(T[] elements)
        {
            if (elements.Length == 0)
            {
                Head = null;
            }

            else
            {
                for (int i = 0; i < elements.Length; ++i)
                {
                    Push(elements[i]);
                }
            }
        }

        public void Push(T element)
        {
            MyStackNode<T> newNode = new MyStackNode<T>(element);

            newNode.NextNode = Head;
            Head = newNode;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public T Pop()
        {
            if(IsEmpty())
            {
                throw new Exception("Empty stack");
            }

            T data = Head.Data;
            Head = Head.NextNode;

            return data;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Empty stack");
            }

            return Head.Data;
        }

        public override string ToString()
        {
            string res = "[";
            MyStackNode<T> tmp = Head;

            while (tmp != null)
            {
                res += tmp.Data + ", ";
                tmp = tmp.NextNode;
            }

            res += "]";

            return res;
        }
    }
}
