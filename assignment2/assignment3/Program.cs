namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Prime = new int[101];
            for (int i = 0; i < 100; i++) 
            {
                Prime[i] = 0;
            }
            Prime[0] = Prime[1] = 1;
            for(int i = 2; i * i < 100; i++)
            {
                if (Prime[i] == 0)
                {
                    for (int j = i * i; j < 100; j += i) 
                    {
                        Prime[j] = 1;
                    }
                }
            }
            for(int i = 2; i < 100; i++)
            {
                if (Prime[i] == 0)
                {
                    Console.Write(i);
                    Console.Write(' ');
                }
            }
        }
    }
}
