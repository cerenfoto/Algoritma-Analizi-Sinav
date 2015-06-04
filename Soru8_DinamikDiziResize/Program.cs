using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru8_DinamikDiziResize
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> m = new MyStack<int>();
            int sayi = 0;
            Console.Write("Kac Sayi Gireceksin? :");
            sayi =Int32.Parse(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
            {
                Console.Write("Sayi Gir :");
                m.push(Int32.Parse(Console.ReadLine()));
                Console.WriteLine("");
            }

            elemanlariTerstenYazdir(m,sayi);
            Console.ReadKey();
        }

        private static void elemanlariTerstenYazdir(MyStack<int> m, int sayi)
        {
            Console.Write("Girilen Sayilar : ");
            for (int i = 0; i <sayi; i++)
            {
                Console.Write(m.pop() +" ");
            }
        }
    }

    class MyStack<T>
    {
        private T[] veri { get; set; }
        private int boyut;
        private int kapasite;

        public MyStack()
        {
            boyut = 0;
            kapasite = 3;
            veri = new T[kapasite];
            Console.WriteLine("Boyut : "+boyut+" Kapasite : "+kapasite);
        }
        internal void push(T i)
        {
            if (boyut >= kapasite) resize();
            veri[boyut++] = i;
            Console.WriteLine("PUSH Boyut : " + boyut + " Kapasite : " + kapasite);
		}


        private void resize()
        {
            kapasite *= 2;
            T[] yeniveri = new T[kapasite];
            for (int i = 0; i < veri.Length; i++)
            {
                yeniveri[i] = veri[i];
            }
            veri = yeniveri;
            Console.WriteLine("Kapasite Arttirildi.");
            Console.WriteLine("RESIZE Boyut : " + boyut + " Kapasite : " + kapasite);
        }

        public T pop()
        {           
            return veri[--boyut];
        }
    }
}