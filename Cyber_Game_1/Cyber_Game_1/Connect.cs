using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Cyber_Game_1
{
    public class Connect
    {
        public static void connect(string CONNECTIP)
        {
            int IP1, IP2, IP3, IP4;
            int IP;
            string machine1 = "C:\\Users\\hayden parsons\\source\\repos\\Cyber_Game_1\\Machines\\Machine1.txt";
            string[] tokens = CONNECTIP.Split('.');
            IP1 = Int32.Parse(tokens[0]);   // 192
            IP2 = Int32.Parse(tokens[1]);   // 168
            IP3 = Int32.Parse(tokens[2]);   // 0
            IP4 = Int32.Parse(tokens[3]);   // 1
            string line = "";
            using (StreamReader sr = new StreamReader(machine1))
                for (int i = 0; i < 15; i++)
                {

                    if (line == "TrueFirewall,")
                    {
                    }
                    else if (line == "FIREPASS,")
                    {
                        i++;
                    }
                    else if (line == "OPEN,")
                    {                      
                    }
                    else if (line == "SSHCLOSE")
                    {                        
                    }
                    else if(line != "TrueFirewall")
                    {
                        
                       line = sr.ReadLine();
 
                    }

                    if (line == null) break; // there are less than 15 lines in the file
                }
            if (CONNECTIP == line)
            {
                string firepass;
                int g = 1;
                Console.WriteLine("Connected to " + CONNECTIP);
                string LineRead = Console.ReadLine();
                while (g == 1)
                {
                    LineRead = Console.ReadLine();
                    if (LineRead == "Probe")
                    {
                        using (StreamReader sr = new StreamReader(machine1))
                            for (int i = 0; i < 15; i++)
                            {

                                if (line == "TrueFirewall,")
                                {
                                    Console.WriteLine("ACTIVE FIREWALL");
                                }
                                else if (line == "FIREPASS,")
                                {
                                    i++;
                                    firepass = sr.ReadLine();

                                }
                                else if (line == "OPEN,")
                                {
                                    Console.WriteLine("ADMIN PRIVALLAGES GRANTED");
                                }
                                else if (line == "SSHCLOSE")
                                {
                                    Console.WriteLine("SSH CLOSED 22");
                                }

                            }
                    }
                }
            }
        }
    }
}
