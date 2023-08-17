
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp
{
    public abstract class Shape
    {
        public int height { get; set; }
        public int width { get; set; }
        public abstract void draw();
    }

    public class Circle:Shape 
    {
        public int radius { get; set; }

        public override void draw()
        {
            Console.WriteLine("Inside Circle");
        }
    }

    public class Rectangle:Shape
    {
        public override void draw()
        {
            Console.WriteLine("Inside Rectangle");
        }
    }

    public class Pro
    {
       public delegate int deleteFilter(int a, int b);
        public readonly List<int> list = new List<int>();

        public void inti()
        {
            list.Add(0);
        }

        public static deleteFilter dele = null;
        static void Main(string[] args)
        {
            /*dele = new deleteFilter(sum);
            dele += sub;

            Console.WriteLine(dele.Invoke(40, 20));

            foreach (deleteFilter method in dele.GetInvocationList())
            {
                Console.WriteLine(method.Method.Name + ", Result: {0}", method.Invoke(40,20));
            }*/

            Func<int, int> square = num => num * num;
            Console.WriteLine(square(10));

            Action s = () => Console.WriteLine("Lamda");

            int[] a = new int[] {1,2,3,4,5};
            modifyA(a);

            Console.WriteLine(string.Join(",", a));

            Pro p = new Pro(); 
            p.inti();
            p.list.ForEach(x => Console.WriteLine(x));

        }

        static void modifyA(int[] a)
        {
            a[0] = 10;
        }
        static int sum(int a, int b)
        {
            return a + b;
        }

        static int sub(int a, int b) { return a - b; }
    }
}
