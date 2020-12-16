using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class ArrayBinaryTree<T>
    {
        public T[] Elements;

        public ArrayBinaryTree()
        {
            Elements = new T[0];
        }

        public ArrayBinaryTree(T value)
        {
            Elements = new T[] { value };
        }

        public ArrayBinaryTree(T[] values)
        {
            Elements = values;
        }

        public ArrayBinaryTree(List<T> values)
        {
            Elements = values.ToArray();
        }

        public T Root
        {
            get
            {
                return Elements[0];
            }
            set
            {
                Elements[0] = value;
            }
        }

        public int Height
        {
            get
            {
                return Convert.ToInt32(Math.Floor(Math.Log(Elements.Length, 2.0)));
            }
        }

        public bool Exists(T value)
        {
            for(int i = 0; i < Elements.Length; ++i)
            {
                if(Equals(value, Elements[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public T GetParentOf(int index)
        {
            int targetIndex = GetParentIndexOf(index);

            if (targetIndex < Elements.Length)
            {
                return Elements[targetIndex];
            }

            throw new ArgumentOutOfRangeException();
        }

        public int GetParentIndexOf(int index)
        {
            return Convert.ToInt32(Math.Floor((double)index / 2));
        }

        public void SetParentOf(int index, T value)
        {
            if(index > 0)
            {
                int targetIndex = (int)Math.Floor((double)index / 2) - 1;

                if (Elements.Length < targetIndex + 1)
                {
                    Array.Resize(ref Elements, targetIndex + 1);
                }

                Elements[targetIndex] = value;
            }
        }

        public T GetLeftOf(int index)
        {
            int targetIndex = GetLeftIndexOf(index);

            if (targetIndex < Elements.Length)
            {
                return Elements[targetIndex];
            }

            throw new ArgumentOutOfRangeException();
        }

        public int GetLeftIndexOf(int index)
        {
            return index * 2 + 1;
        }

        public void SetLeftOf(int index, T value)
        {
            int targetIndex = GetLeftIndexOf(index);

            if (Elements.Length < targetIndex + 1 && index >= 0)
            {
                Array.Resize(ref Elements, targetIndex + 1);
            }

            Elements[targetIndex] = value;
        }

        public T GetRightOf(int index)
        {
            int targetIndex = GetRightIndexOf(index);

            if (targetIndex < Elements.Length)
            {
                return Elements[targetIndex];
            }

            throw new ArgumentOutOfRangeException();
        }

        public int GetRightIndexOf(int index)
        {
            return index * 2 + 2;
        }

        public void SetRightOf(int index, T value)
        {
            int targetIndex = GetRightIndexOf(index);

            if(Elements.Length < targetIndex + 1 && index >= 0)
            {
                Array.Resize(ref Elements, targetIndex + 1);
            }

            Elements[targetIndex] = value;
            
        }

        public T GetElementFromPath(bool[] path)
        {
            int index = GetIndexElementFromPath(path);

            if(index < Elements.Length)
            {
                return Elements[index];
            }

            return default(T);
        }

        public int GetIndexElementFromPath(bool[] path)
        {
            int index = 0;

            for (int i = 0; i < path.Length; ++i)
            {
                index = path[i] ? GetRightIndexOf(index) : GetLeftIndexOf(index);
            }

            if(path.Length > 0 && index == 0)
            {
                return -1;
            }

            return index;
            
        }


    }
}
