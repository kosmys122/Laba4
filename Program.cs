using System.Security.Cryptography;

namespace Laba4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = [1, 2, 3, 4, 5];
            Console.WriteLine(num[3]);
            var n = num[1];
            Console.WriteLine(n);
            num[1] = 505;
            Console.WriteLine(num[1]);
            Console.WriteLine(num.Length);
            Console.WriteLine(num[num.Length - 1]);
            Console.WriteLine(num[num.Length - 2]);
            Console.WriteLine(num[num.Length - 3]);
            Console.WriteLine(num[^1]);
            Console.WriteLine(num[^2]);
            Console.WriteLine(num[^3]);

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
                num[i] = num[i] * 2;
                Console.WriteLine(num[i]);
            }
            int i = 0;
            while (i < num.Length)
            {
                Console.WriteLine(num[i]);
                i++;
            }
            int[,] num = { { 0, 1, 2 }, { 3, 4, 5 } };
            object[] s1 = ["Иван", "Игорь", 4, 4.6, "с"];
            s1[4] = 4;
            dynamic[] s2 = ["Иван", "Игорь", 4, 4.6, "с"];
            s2[4] = 4;
            Console.WriteLine(s1[4].GetType());
            Console.WriteLine(s2[4].GetType());
            int[] num = [1, 35, 6, 67, -4, 36, -1, 4 - 7, 4, 0, 63, -5, -4, -36, 56];
            int res = 0;
            foreach (int number in num)
            {
                if (number > 0)
                    res++;
            }
            Console.WriteLine($"Больше нуля {res}");
            int n = num.Length;
            int k = n / 2;
            int temp;
            for (int i = 0; i < k; i++)
            {
                temp = num[i];
                num[i] = num[n - i - 1];
                num[n - i - 1] = temp;
            }
            foreach (int i in num)
            {
                Console.Write($"{i} \t");
            }
            int temp;
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] < num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            List<string> p = new List<string>;
            List<string> p = [];
            List<string> p = new List<string>();
            { "Иван","Игорь","Александр"}
            ;
            List<string> s = ["Иван", "Игорь", "Александр"];
            var ys = new List<string>(s);
            List<string> s = new List<string>(10);
            List<string> s = new(10);

            List<string> s = ["Билли", "Игорь", "Степан"];
            string s1 = s[0];
            Console.WriteLine(s1);
            s[0] = "Богдан";
            Console.WriteLine(s[0]);
            List<string> s = ["Билли", "Игорь", "Степан"];
            Console.WriteLine(s.Count);
            List<string> s = ["Билли", "Игорь", "Степан"];
            foreach (var p in s)
            {
                Console.WriteLine(p);
            }
            List<string> s = ["Билли", "Игорь", "Степан"];
            s.Add("Van");
            s.AddRange(["Антон", "Денис"]);
            s.Insert(1, "Кирилл");
            s.InsertRange(1, ["Mike", "Kate"]);
            s.Insert(7, "Михаил");
            foreach (var p in s)
            {
                Console.WriteLine(p);
            }
            var p = new List<string>() { "Eugene", "Mike", "Kate", "Tom", "Bob", "Sam", "Tom", "Alice" };
            p.RemoveAt(1);
            p.Remove("Tom");
            p.RemoveRange(1, 2);
            p.Clear

             //Задание 1
             List<string> item = ["sword", "shield", "potion", "sword", "potion", "potion"];
            //Задание 2
            int b = 0;
            int[] a = [10, 20, 30, 40, 50, 60];
            for (int i = 0; i < a.Length; i++)
            {
                b += a[i];
            }
            Console.WriteLine(b);





        }
    }
}
