using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class HashMapSet
    {
        public Hashtable elements = new Hashtable();

        public void Add(Object value)
        {
            elements.Add(value.GetHashCode(), value);
        }

        public void Remove(Object key)
        {
            if (elements.ContainsKey(key))
            {
                elements.Remove(key);
            }
        }

        public bool Contains(Object klucz)
        {
            return elements.ContainsKey(klucz.GetHashCode());
        }

        public static HashMapSet Intersection(HashMapSet set1, HashMapSet set2)
        {
            HashMapSet result = new HashMapSet();

            foreach (DictionaryEntry item in set1.elements)
            {
                if (set2.Contains(item.Key))
                {
                    result.Add(item.Value);
                }
            }

            return result;
        }

        public static HashMapSet Sum(HashMapSet set1, HashMapSet set2)
        {
            HashMapSet result = new HashMapSet();

            foreach (DictionaryEntry item in set1.elements)
            {
                result.Add(item.Value);
            }

            foreach (DictionaryEntry item in set2.elements)
            {
                if (!result.Contains(item.Key))
                {
                    result.Add(item.Value);
                }
            }

            return result;
        }

        public static HashMapSet Difference(HashMapSet set1, HashMapSet set2)
        {
            foreach(DictionaryEntry item in set2.elements)
            {
                if (set1.Contains(item))
                {
                    set1.Remove(item);
                }
            }

            return set1;
        }
    }

    class ListSet<T>
    {
        public MyList<T> List { get; set; } = new MyList<T>();

        public void Add(T element)
        {
            if (List.Search(element) == -1)
            {
                List.Inject(element);
            }
        }

        public void Remove(T element)
        {
            int index = List.Search(element);
            MyListNode<T> tmp = List.Head;

            if(index == 0)
            {
                List.Pop();
            }

            else if (index == List.Count - 1)
            {
                List.Eject();
            }

            else
            {
                MyList<T> leftSlice = List.Slice(0, index - 1);
                MyList<T> rightSlice = List.Slice(index + 1, List.Count - 1);

                List = MyList<T>.Concat(leftSlice, rightSlice);
            }

        }

        public bool Contains(T element)
        {
            return List.Search(element) != -1;
        }

        public static ListSet<T> Sum(ListSet<T> set1, ListSet<T> set2)
        {
            for (int i = 0; i < set2.List.Count; ++i)
            {
                if (!set1.Contains(set2.List[i]))
                {
                    set1.Add(set2.List[i]);
                }
            }

            return set1;
        }

        public static ListSet<T> Intersection(ListSet<T> set1, ListSet<T> set2)
        {
            ListSet<T> result = new ListSet<T>();

            for (int i = 0; i < set2.List.Count; ++i)
            {
                if (set1.Contains(set2.List[i]))
                {
                    result.Add(set2.List[i]);
                }
            }

            return result;
        }

        public static ListSet<T> Difference(ListSet<T> set1, ListSet<T> set2)
        {
            for (int i = 0; i < set2.List.Count; ++i)
            {
                if (set1.Contains(set2.List[i]))
                {
                    set1.Remove(set2.List[i]);
                }
            }

            return set1;
        }
    }
}
