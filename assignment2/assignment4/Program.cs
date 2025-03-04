namespace assignment4
{
    internal class Program
    {
        bool ifToeplitz(int [,]arr)
        {
            int m = arr.GetLength(0);
            int n = arr.GetLength(1);
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[i + 1, j + 1] != arr[i, j]) return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string str = "";
            int m = 0, n = 0;
            Console.WriteLine("请输入矩阵的长：");
            str = Console.ReadLine();
            n = int.Parse(str);
            Console.WriteLine("请输入矩阵的宽：");
            str = Console.ReadLine();
            m = int.Parse(str);
            Console.WriteLine("请依次输入矩阵的元素：");
            int[,] matrix = new int[m, n];
            char s = ' ';
            for(int i = 0; i < m; i++)
            {
                string[] arr = Console.ReadLine().Split(s);
                for(int j = 0; j < arr.Length; j++)
                {
                    matrix[i, j] = int.Parse(arr[j]);
                }
            }
            bool toeplitz = p.ifToeplitz(matrix);
            Console.Write(toeplitz);
        }
    }
}
