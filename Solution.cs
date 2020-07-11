using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polindrom
{
    public class Solution
    {

        //Определяет, палиндром ли число 
        public static bool IsPalindrom(int x)
        {
            string str = Convert.ToString(x);
            int len = str.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        //Определяет, палиндром ли строка
        public static bool IsPalindrom(string x)
        {
            x = x.ToLower();
            int j = x.Length - 1;
            for (int i = 0; i < j; i++)
            {
                if (x[i] < 'a' || x[i] > 'z') continue;
                if (x[j] < 'a' || x[j] > 'z') { j--; i--; continue; }
                if (x[i] != x[j])
                {
                    Console.WriteLine(x);
                    Console.WriteLine("no");
                    return false;
                }
                else j--;
            }
            Console.WriteLine(x.Replace(" ", "").ToLower());
            Console.WriteLine("yes");
            return true;
        }

        //Возвращает "обратно" число
        public static int Reverse(int x)
        {
            int k = (int)Math.Log10(Math.Abs(x)) + 1;
            int n = 0, n_1 = 0;
            for (int i = 2; i < k + 1; i++)
            {
                n += (x % (int)(Math.Pow(10, i)) /
                    (int)(Math.Pow(10, i - 1))) * (int)Math.Pow(10, k - i);
            }
            n_1 = n;
            n += (x % 10) * (int)Math.Pow(10, k - 1);
            if (n % (Math.Pow(10, k - 1)) != n_1)
                n = -1;
            return n;
        }
    }
}
