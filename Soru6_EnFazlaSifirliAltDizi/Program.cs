using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnFazlaSifirliAltdizi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[] { 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0,1,1};
            enFazlaSifirliAltDiziBul(dizi);
        }

        private static void enFazlaSifirliAltDiziBul(int[] dizi)
        {
            int[] sifirliAltDiziler =new int[dizi.Length];
            int sayici = 0, sayi = 0;
            Console.Write("Dizi elemanlari :");
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == 0)
                {
                    sayici++;
                }
                else if(dizi[i]==1 && sayici>0)
                {
                    sifirliAltDiziler[sayi] = sayici;
                    sayici = 0;
                    sayi++;
                }
                Console.Write(" "+dizi[i]+" ");
            }

            sifirSayisi(sifirliAltDiziler);
        }

        private static void sifirSayisi(int[] sifirliAltDiziler)
        {
            int enb = 0;
            for (int i = 0; i < sifirliAltDiziler.Length; i++)
            {
                if (sifirliAltDiziler[i] > enb)
                    enb = sifirliAltDiziler[i];
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("En cok sifira sahip alt dizinin sifir sayisi : " + enb);
            Console.ReadKey();
        }
    }
}
