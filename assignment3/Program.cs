using System.ComponentModel.DataAnnotations;

namespace _3_6_1
{
    public abstract class Graphics
    {
        public abstract double GetArea();
        public abstract bool ifLegal();
    }
    public class Triangle : Graphics
    {
        public int l1, l2, l3;
        public Triangle(int l1,int l2,int l3)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }
        public override bool ifLegal()
        {
            if (l1 < l2)
            {
                if (l2 < l3) return (l1 + l2 > l3);
                else return (l1 + l3 > l2);
            }
            else
            {
                if (l1 < l3) return (l1 + l2 > l3);
                else return (l2 + l3 > l1);
            }
        }
        public override double GetArea()
        {
            int p = (l1 + l2 + l3) / 2;
            return Math.Sqrt(p * (p - l1) * (p - l2) * (p - l3));
        }
    }
    public class Rectangle : Graphics
    {
        public int a, b;
        public Rectangle(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public override bool ifLegal()
        {
            return true;
        }
        public override double GetArea()
        {
            return (double)a * b;
        }
    }
    public class Square : Graphics
    {
        public int a, b;
        public Square(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override bool ifLegal()
        {
            return (a == b);
        }
        public override double GetArea()
        {
            return (double)a * b;
        }
    }
    public class Factory
    {
        public int RandomShape()
        {
            Random r = new Random();
            return r.Next(1, 4);
        }
        public double TotalArea()
        {
            double sum = 0;
            for(int i = 0; i < 10; i++)
            {
                int choice = RandomShape();
                Random r = new Random();
                switch (choice)
                {
                    case 1:
                        Graphics g1 = new Triangle(r.Next(100), r.Next(100), r.Next(100));
                        if (!g1.ifLegal())
                        {
                            Console.WriteLine("三角形创建失败");
                        }
                        else
                        {
                            Console.Write("三角形的面积为：");
                            Console.WriteLine(g1.GetArea());
                            sum += g1.GetArea();
                        }
                        break;
                    case 2: 
                        Graphics g2 = new Rectangle(r.Next(100), r.Next(100));
                        if (!g2.ifLegal())
                        {
                            Console.WriteLine("矩形创建失败");
                        }
                        else
                        {
                            Console.Write("矩形的面积为：");
                            Console.WriteLine(g2.GetArea());
                            sum += g2.GetArea();
                        }
                        break;
                    case 3:
                        Graphics g3 = new Rectangle(r.Next(100), r.Next(100));
                        if (!g3.ifLegal())
                        {
                            Console.WriteLine("正方形创建失败");
                        }
                        else
                        {
                            Console.Write("正方形的面积为：");
                            Console.WriteLine(g3.GetArea());
                            sum += g3.GetArea();
                        }
                        break;
                } 
            }
            Console.Write("面积和为：");
            Console.WriteLine(sum);
            return sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory f = new Factory();
            f.TotalArea();
        }
    }
}
