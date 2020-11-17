using System;
using System.Collections;
using System.Collections.Generic;

public static partial class Algorithms{
    public static void QueueSort(Queue<int> queue)
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();

            stack1.Push(queue.Dequeue());

            while (queue.Count > 0)
            {
                int num = queue.Dequeue();
                int max = stack1.Peek();

                if (num >= max)
                {
                    stack1.Push(num);
                    max = num;
                }
                else
                {
                    while (stack1.Count > 0)
                    {
                        int tmp = stack1.Peek();

                        if (tmp > num)
                        {
                            stack2.Push(stack1.Pop());
                        }
                        else
                        {
                            break;
                        }
                    }

                    stack1.Push(num);

                    while (stack2.Count > 0)
                    {
                        stack1.Push(stack2.Pop());
                    }
                }
            }


            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }

            while (stack2.Count > 0)
            {
                queue.Enqueue(stack2.Pop());
            }
        }
}