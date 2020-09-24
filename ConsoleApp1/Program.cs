using System;
using System.Threading;

namespace CalcuApplication
{
    class NullShow
    { public static void XianCheng1()
        {
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine("线程1");
                Console.WriteLine(i.ToString());
            }
               
        }
        public static void XianCheng2()
        {
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine("线程2");
                Console.WriteLine(i.ToString());
            }
             }


        static void Main(string[] args)
        {
            ThreadStart Aa = new ThreadStart(XianCheng1);
            ThreadStart Bb = new ThreadStart(XianCheng2);
            Thread AA = new Thread(Aa);
            Thread BB = new Thread(Bb);
            AA.Start();
            BB.Start();




        }
    }




}
