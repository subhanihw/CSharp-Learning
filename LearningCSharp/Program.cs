using System;
using System.IO;

namespace HelloWorld
{
    public enum Days
    {
        Sunday = 1,
        Monday = 2,
        Tuesday = 3
    }
    
    class Program
    {
        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] arr = new int[length];
            for(int i = 0; i<length; i++)
            {
                arr[i] = num*(i+1);
            }
            return arr;
        }
        /*static void Main(string[] args)
        {
            *//*float s = 24f;
            Console.WriteLine("{0} {1}", 12, 24.5f);
            Person person = new Person();
            person.display();
            Console.Write("ENter x: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine(x);

            var arr = new int[] { 1, 2, 3, 4, 5 };
            var str = string.Join(",", arr);
            Console.WriteLine(str);

            var day = Days.Sunday;
            Console.WriteLine(day);

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < arr.Length; i++) { Console.WriteLine(arr[i]); }
            var name = " ";

            var result = String.IsNullOrEmpty(name);

            Console.WriteLine(result);*//*

            Console.WriteLine(string.Join(",",ArrayOfMultiples(12,10)));


        }*/
    }
}