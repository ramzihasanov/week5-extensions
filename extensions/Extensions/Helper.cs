using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace extensions.Extensions
{
    public static class Helper
    {
        public static int Repeated(this string sentence, string word)
        {
            int count = 0;
            sentence = sentence.Trim();
            string[] str = sentence.Split(' ',',');
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == word)
                    count++;
            }
            return count;
        }




        public static bool IsPolendrom(this int num)
        {

            int a = 0;
            int oldnum=num;
          while(num > 0)
            {
               int r=num%10;
                a = a * 10 + r;
                num /=10;
            }
            return (a == oldnum);
        }





        public static bool HasAnyDigit(this string str)
        {
            foreach (char s in str)
            {
                if (char.IsDigit(s))
                {
                    return true;
                }
            }

            return false;
        }     
    }
}
