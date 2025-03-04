// See https://aka.ms/new-console-template for more information
using System;

namespace assignment1
{
    class Program
    {
        int GetPrime(int n, int[]arr)
        {
            int cnt = 0;
            for(int i = 2; i * i < n; i++)
            {
                while (n % i == 0)
                {
                    if (cnt == 0 || arr[cnt] != i)
                    {
                        arr[cnt] = i;
                        cnt++;
                        n /= i;
                    }
                }
            }
            if (n != 1) arr[cnt] = n;
            return cnt;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string str = "";
            str = Console.ReadLine();
            int num = 0;
            num = Int32.Parse(str);
            int[] arr = new int[500];
            int k = p.GetPrime(num, arr);
            for(int i = 0; i < k+1; i++)
            {
                Console.Write(arr[i]);
                Console.Write(' ');
            }
        }
    }
}
