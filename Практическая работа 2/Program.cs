using System;

namespace Практическая_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            string a = Console.ReadLine();
            int s = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 'f')
                {
                    s++;
                }
                if (s == 2)
                {
                    Console.WriteLine($"Индекс второго вхождения: {i}");
                    break;
                }
            }
            if (s == 1)
            {
                Console.WriteLine("-1");
            }
            if (s == 0)
            {
                Console.WriteLine("-2");
            }


            Console.WriteLine("Задание 2");
            string l = Console.ReadLine();
            //string k = "";
            l = l.ToLower();
            string[] rus = { "а", "б", "в", "г", "д", "е", "ё", "ж ", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ы", "э", "ю", "я"};
            string[] rus2 = { "a", "b", "v", "g", "d", "e", "ye", "zh", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh","shch", "y", "e", "yu", "ya" };
            for(int i = 0; i < l.Length; i++)
            {
                for (int j = 0; j < rus.Length; j++)
                {
                    if (l[i].ToString() == rus[j])
                    {
                        l = l.Replace(l[i].ToString(), rus2[j]);
                    }
                }
            }
            Console.WriteLine(l);


            Console.WriteLine("Задание 3");
            string b = Console.ReadLine();
            string c = "h";
            int k1 = b.IndexOf(c);
            int k2 = b.LastIndexOf(c);
            int d = k1 + 1;
            int g = k2 + 1;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == 'h')
                {
                    b = b.Replace('h', 'H');
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (b[k1] == 'H')
                {
                    b = b.Insert(k1, c);
                    b = b.Remove(d, 1);
                }
                else if (b[k2] == 'H')
                {
                    b = b.Insert(k2, c);
                    b = b.Remove(g, 1);
                }
            }
            Console.WriteLine($"Результат замены: {b}");
        }
    }
}
