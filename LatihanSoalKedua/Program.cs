using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LatihanSoalKedua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Soal 1
            Console.Write("Input Angka: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.Write("Tekan enter untuk Lanjut: ");
            Console.ReadLine();

            // Soal 2
            int prima_count = 0;
            Console.Write("Input Num 1: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Num 2: ");
            int m = Convert.ToInt32(Console.ReadLine());

            for (int i = n + 1; i <= m; i++)
            {
                int modulo_count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        modulo_count++;
                    }
                }
                if (modulo_count == 2)
                {
                    prima_count++;
                }
            }
            Console.WriteLine(prima_count);
            Console.Write("Tekan Enter untuk lanjut: ");
            Console.ReadLine();

            // Soal 3
            Console.Write("Masukkan Kata: ");
            string kata3 = Console.ReadLine();
            int kata_error = 0;

            foreach (char huruf in kata3)
            {
                if (huruf == 'e' || huruf == 'd')
                {
                    kata_error++;
                }
            }
            Console.WriteLine(kata_error);
            Console.Write("Tekan Enter untuk Lanjut: ");
            Console.ReadLine();

            // Soal 4
            string kataRusak = "YRnzuijf%mX%tFfoqf";
            List<char> listRusak = new List<char>();

            foreach (char charKata in kataRusak)
            {
                if (char.IsLetter(charKata))
                {
                    char kata4 = (char)(charKata - 5);
                    listRusak.Add(kata4);
                }
                else
                {
                    listRusak.Add(charKata);
                }
            }

            List<char> hasil1 = new List<char>();
            List<char> hasil2 = new List<char>();

            int idx = 0;
            foreach (char c in listRusak)
            {
                if (c == '%')
                {
                    idx = 1;
                    continue;
                }
                if (idx == 0)
                {
                    hasil1.Add(c);
                }
                else
                {
                    hasil2.Add(c);
                }
            }

            string hasilAkhir1 = string.Join("", hasil1).Replace("%", " ");
            string hasilAkhir2 = string.Join("", hasil2).Trim();
            Console.WriteLine(hasilAkhir1);
            Console.WriteLine(hasilAkhir2); 

            Console.Write("Tekan Enter Untuk Keluar: ");
            Console.ReadLine();
        }
    }
}
