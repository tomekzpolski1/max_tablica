using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program znajdujący największą liczbę");
            Console.WriteLine("Ile chcesz podać liczb");
            int rozmiar = int.Parse(Console.ReadLine());
            int[] liczby = new int [rozmiar];
            for (int i = 0; i < liczby.Length; i++) //wczytywanie liczb
            {
                Console.WriteLine("Podaj liczbę {0}", i+1);
                liczby[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Podane liczby to:"); //wypisywanie liczb
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.Write("Liczba {0}. - {1} ", i+1, liczby[i]);
            }
            int max = liczby[0]; // algorytm znajdujacy najwieksza wartość
            int licznik = 0;
            for (int i = 0; i < liczby.Length; i++)
            {
                if (liczby[i]>max)
                {
                    max = liczby[i];
                    licznik = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Największa liczba to: {0}, jest to liczba numer - {1}", max, licznik+1); //wypisywanie wyniku
        }
    }
}
