using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Cyber_Game_1
{
    class Tutorial
    {
        public static void StartMessage()
        {
            Console.WriteLine("10 day timer expired");
            string file = "C:\\Users\\hayden parsons\\source\\repos\\Cyber_Game_1\\StartMessage.txt";
            for (int i = 0; i < 50; i++)
            {
                Console.Write("_");
                Thread.Sleep(100);
            }
            string line;
            using(StreamReader sr = new StreamReader(file))
            {
                for(int f = 0; f < 100; f++)
                {
                    line = sr.ReadLine();
                    Console.WriteLine(line);
                    Thread.Sleep(100);
                    if(line == null) { break; }
                }
                firstConnect();
            }

            
        }

        public static void firstConnect()
        {
            string CONNECTIP;
            while (true)
            {
                if (Console.ReadLine() == "connect")
                {
                    CONNECTIP = Console.ReadLine();
                    Console.WriteLine(CONNECTIP);
                    Connect.connect(CONNECTIP);
                }
                if(Console.ReadLine() == "Quit")
                {
                    Environment.Exit(0);
                }
            }

        }

    }
}
