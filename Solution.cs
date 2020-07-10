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
            string str = "";
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] >= 'a' && x[i] <= 'z')
                    str += x[i];
            }
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

        //Возвращает "обратно" число
        public static int Reverse(int x)
        {
            string str = Convert.ToString(x);
            int len = str.Length;
            string str_1 = "";
            for (int i = len - 1; i >= 0; i--)
                if (str[i] != '-' && str[i] != '0')
                    str_1 += str[i];
            try
            {
                if (str[0] == '-')
                    return -Convert.ToInt32(str_1);
                else return Convert.ToInt32(str_1);
            }
            catch (System.OverflowException) { return -1; }
        }
    }
}
