using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromicCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean c = false;
            int sda = 3/2;
            while (!c)
            {
                Console.WriteLine("Digite o palindrome inicial(fim para terminar): ");
                String s = Console.ReadLine();
                if (s.Length < 100)
                {
                    if (s.Equals("fim"))
                        c = true;
                    else
                        Console.WriteLine("Maior palíndrome é: " + a(s));
                }
                else
                    Console.WriteLine("A cadeia de caracteres precisa ter no máximo 100 elementos");

            }
        }

        public static string a(string s)
        {
            string d = "";
            int e = s.Length - 1;
            for (int i = 0; i < e; i++)
            {
                for (int z = i + 1; z <= e; z++)//estava "i + 2" mas isso pulava um teste de só 2 chars
                {
                    if (z - i > d.Length)
                    {
                        string p = s.Substring(i, z - i);
                        if (b(p))
                        {
                            if (p.Length > d.Length)
                                d = p;
                        }
                    }
                }
            }
            return d;
        }

        public static Boolean b(string word)
        {
            char[] k = word.ToCharArray();
            int l = k.Length / 2;
            int z = k.Length-1;//em vez de começar da meta e subir, erra necessário começar do final e descer
            for (int i = 0; i < l; i++)
            {
                if (k[i] != k[z])
                    return false;//troquei o retorno para false
                z--;//para descrecer em vez de subir
            }
            return true;//troquei o retorno para false
        }
    }
}
