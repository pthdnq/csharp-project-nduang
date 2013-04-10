using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading;

namespace Dãy_chẵn_lẻ_Thread
{
    class Program
    {
        static int[] ds = new int[100] ;
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(daychan));
            t1.Start();
            dayle();
           // Console.ReadLine();
            //taomang(ds);
        }
        static void taomang(int[] niz)
        {
            niz[0] = 0;
            for (int i = 1; i < 100; i++)
            {
                niz[i] = niz[i-1] + 1;
                //Console.Write(ds[i]);
                //Console.ReadLine();
            }
        }
        static void daychan()
        {
            taomang(ds);
            int[] chan = new int[51];
            chan[0] = 0;
            for (int i = 0; i < ds.Length; i++)
            {
                if ((ds[i] % 2) == 0)
                {
                    chan[i] = ds[i];
                    Console.Write(chan[i]+" ");
                }
                    
                  

            }
        }
        static void dayle()
        {
            taomang(ds);
            int[] le = new int[51];
            le[0] = 1;
            for (int i = 0; i < ds.Length; i++)
            {
                if ((ds[i] % 2) != 0)
                {
                    le[i] = ds[i];
                    Console.Write(le[i]+" ");
                }
            }
        }
    }
}
