using System;
using System.Threading;

namespace ekz
{
    class Program
    {
        static void Main(string[] args)
        {
            Seans_Kino[] a = new Seans_Kino[5];
            a[0] = new Seans_Kino(100);
            a[1] = new Seans_Kino(100);
            a[2] = new Seans_Kino(15);
            a[3] = new Seans_Kino(15);
            a[4] = new Seans_Kino(15);



            while (true)
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread thread = new Thread(a[i].Na4aloFilma);
                    thread.Start();
                    Thread.Sleep(5000);
                }
            }
            



        }
    }
    
    class Seans_Kino
    {
        Random a = new Random();
        private int viewers;
        private int sits;
        static int nomerSeansa;

        public Seans_Kino(int sitsAmount)
        {
            sits = sitsAmount;
            if (sitsAmount <= 15)
            {
                viewers = a.Next(15);
            }
            else
            {
                viewers = a.Next(100);
            }

        }

        public void Na4aloFilma()
        {
            nomerSeansa += 1;
            Console.WriteLine("Начало сеанса №" + nomerSeansa + " со " + viewers + " зрителем/ями.");
            Thread.Sleep(5000);
            Console.WriteLine("Конец сеанса №" + nomerSeansa + ". Все на выход!");
            viewers = 0;
        }
        


    }


}
