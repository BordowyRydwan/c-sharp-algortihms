using System;

namespace Structures
{
    class MyListNode<T>
    {
        public T Data { get; set; } = default(T);
        public MyListNode<T> PreviousNode { get; set; } = null;
        public MyListNode<T> NextNode { get; set; } = null;

        public MyListNode(T value)
        {
            Data = value;
        }
    }

    class MyList<T>
    {
        public MyListNode<T> Head { get; set; }

        public MyList()
        {
            Head = null;
        }

        public MyList(T value)
        {
            Head = new MyListNode<T>(value);
        }

        public MyList(T[] elements)
        {
            if (elements.Length == 0)
            {
                Head = null;
            }

            else
            {
                Head = new MyListNode<T>(elements[0]);

                for (int i = 1; i < elements.Length; ++i)
                {
                    Inject(elements[i]);
                }
            }
        }

        public T this[int i]
        {
            get
            {
                MyListNode<T> tmp = Head;
                int counter = 0;

                if (i >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                while (counter < i)
                {
                    tmp = tmp.NextNode;
                    counter++;
                }

                return tmp.Data;
            }

            set
            {
                MyListNode<T> tmp = Head;
                int counter = 0;

                while (counter < i)
                {
                    tmp = tmp.NextNode;
                    counter++;
                }

                tmp.Data = value;
            }
        }

        public int Count
        {
            get
            {
                MyListNode<T> tmp = Head;
                int counter = 0;

                while (tmp != null)
                {
                    counter++;
                    tmp = tmp.NextNode;
                }

                return counter;
            }
        }

        public void Inject(T element)
        {
            MyListNode<T> newNode = new MyListNode<T>(element);
            MyListNode<T> tmp = Head;

            if (tmp == null)
            {
                Head = newNode;
                return;
            }

            while (tmp.NextNode != null)
            {
                tmp = tmp.NextNode;
            }

            tmp.NextNode = newNode;
            newNode.PreviousNode = tmp;
        }

        public void Push(T element)
        {
            MyListNode<T> newNode = new MyListNode<T>(element);

            newNode.NextNode = Head;
            Head.PreviousNode = newNode;

            Head = newNode;
        }

        public T Rear
        {
            get
            {
                MyListNode<T> tmp = Head;

                while (tmp.NextNode != null)
                {
                    tmp = tmp.NextNode;
                }

                return tmp.Data;
            }
        }

        public T Front { get => Head.Data; }

        public void Insert(T element, int index)
        {
            MyListNode<T> newNode = new MyListNode<T>(element);
            MyListNode<T> tmp = Head;

            if (index == Count)
            {
                Inject(element);
                return;
            }

            if (index > Count)
            {
                throw new IndexOutOfRangeException();
            }

            int counter = 0;

            while (counter < index)
            {
                tmp = tmp.NextNode;
                counter++;
            }

            tmp = tmp.PreviousNode;

            newNode.NextNode = tmp.NextNode;
            newNode.PreviousNode = tmp;
            tmp.NextNode = newNode; 
        }

        public void Eject()
        {
            MyListNode<T> tmp = Head;

            while (tmp.NextNode != null)
            {
                tmp = tmp.NextNode;
            }

            tmp.PreviousNode.NextNode = null;
        }

        public void Pop()
        {
            Head = Head.NextNode;
            Head.PreviousNode = null;
        }

        public int Search(T entry)
        {
            MyListNode<T> tmp = Head;
            int counter = 0;

            while (tmp != null)
            {
                if (Equals(tmp.Data, entry))
                {
                    return counter;
                }

                counter++;
                tmp = tmp.NextNode;
            }

            return -1;
        }

        public static MyList<T> Concat(MyList<T> list1, MyList<T> list2)
        {
            MyList<T> newList = new MyList<T>();

            newList.Head = list1.Head;

            MyListNode<T> tmp = newList.Head;

            while (tmp.NextNode != null)
            {
                tmp = tmp.NextNode;
            }

            tmp.NextNode = list2.Head;
            list2.Head.PreviousNode = tmp;

            return newList;
        }

        public MyList<T> Slice(int startIndex, int endIndex)
        {
            int counter = 0;

            if(startIndex >= Count || endIndex >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            MyListNode<T> tmp = new MyListNode<T>(Head.Data);
            tmp.NextNode = Head.NextNode;

            while (counter < startIndex)
            {
                tmp = tmp.NextNode;
                counter++;
            }

            MyList<T> newList = new MyList<T>(tmp.Data);

            while (counter < endIndex)
            {
                tmp = tmp.NextNode;
                newList.Inject(tmp.Data);
                counter++;
            }

            return newList;
        }

        public override string ToString()
        {
            string res = "[";
            MyListNode<T> tmp = Head;

            while(tmp != null)
            {
                res += tmp.Data + ", ";
                tmp = tmp.NextNode;
            }

            res += "]";

            return res;
        }
    }
}
