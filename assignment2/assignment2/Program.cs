namespace assignment2
{
    internal class Program
    {
        int GetMax(List<int> arr)
        {
            int max = 0;
            foreach(int i in arr)
            {
                if (i > max) max = i;
            }
            return max;
        }
        int GetMin(List<int> arr)
        {
            int min = arr[0];
            foreach (int i in arr)
            {
                if (i < min) min = i;
            }
            return min;
        }
        int GetSum(List<int> arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }
        int GetAverage(List<int> arr)
        {
            int sum = 0, cnt = 0, ave = 0;
            foreach(int i in arr)
            {
                sum += i;
                cnt += 1;
            }
            if (cnt != 0) ave = sum / cnt;
            return ave;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("请输入整数数组的元素：");
            char s = ' ';
            string[] arr = Console.ReadLine().Split(s);
            List<int> integers = new List<int>();
            foreach(string str in arr)
            {
                integers.Add(int.Parse(str));
            }
            Console.Write("数组最大值为：");
            Console.WriteLine(p.GetMax(integers));
            Console.Write("数组最小值为：");
            Console.WriteLine(p.GetMin(integers));
            Console.Write("数组平均值为：");
            Console.WriteLine(p.GetAverage(integers));
            Console.Write("数组元素的和为：");
            Console.WriteLine(p.GetSum(integers));
        }
    }
}
