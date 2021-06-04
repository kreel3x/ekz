using System;
using System.Threading;

namespace ekz
{
    class Program
    {
        static void Main(string[] args)
        {
            Seans_Kino[] a = new Seans_Kino[5];
            a[0] = new Seans_Kino("Синий Зал",100);
            a[1] = new Seans_Kino("Желтый Зал", 100);
            a[2] = new Seans_Kino("Зеленый Зал", 15);
            a[3] = new Seans_Kino("Фиолетовый Зал", 15);
            a[4] = new Seans_Kino("Красный Зал", 15);



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
        private int nomerSeansa;
        private string name;

        public Seans_Kino(string name, int sitsAmount)
        {
            this.name = name;
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

            Console.WriteLine("Начало сеанса: " + name + " со " + viewers + " зрителем/ями.");
            Thread.Sleep(5000);
            Console.WriteLine("Конец сеанса " + name + ". Все на выход!");
            viewers = 0;
        }
        


    }


}
