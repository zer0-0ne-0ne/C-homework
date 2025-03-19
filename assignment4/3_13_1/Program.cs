using System.Collections.Generic;

namespace _3_13_1
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> current = head;
            while (current != null)
            {
                action(current.Data);
                current = current.Next;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            for(int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            //打印元素
            intlist.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            //求最大值最小值
            int max = int.MinValue;
            intlist.ForEach(x => max = Math.Max(max, x));
            Console.WriteLine("最大值: " + max);
            int min = int.MaxValue;
            intlist.ForEach(x => min = Math.Min(min, x));
            Console.WriteLine("最小值: " + min);
            // 求和
            int sum = 0;
            intlist.ForEach(x => sum += x);
            Console.WriteLine("求和: " + sum);
        }
    }
}
