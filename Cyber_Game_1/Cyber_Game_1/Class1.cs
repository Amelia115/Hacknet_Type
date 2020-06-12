using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace Cyber_Game_1
{

    public class machine_definition
    {
        public static (bool, bool, string, bool, string, string) MachineDef(bool elevation, bool FIREW, string FIREWPASS, bool SSHOPC, string IPTE, string connections)
        {
            var machine = "";
            var machinefiles = "C:\\Users\\hayden parsons\\source\\repos\\Cyber_Game_1\\machinefiles.txt";
            var random = new Random();
            string life;
            string line;
            using (StreamReader st = new StreamReader(machinefiles))
                for(int t = 0; t < 1; t++)
                {
                    machine = st.ReadLine();
                    life = st.ReadLine();
                    if(life == null) { break; }
                    
                                        
                    using (StreamReader sr = new StreamReader(machine))
                        for (int i = 0; i < 15; i++)
                        {
                            line = sr.ReadLine();
                            //Console.WriteLine(line);
                            if (line == "TrueFirewall,")
                            {
                                FIREW = true;
                                //Console.WriteLine(FIREW);
                            }
                            else if (line == "FIREPASS,")
                            {
                                i++;
                                line = sr.ReadLine();
                                FIREWPASS = line;
                                //Console.WriteLine(FIREWPASS);
                            }
                            else if (line == "OPEN,")
                            {
                                elevation = true;
                                //Console.WriteLine(elevation);
                            }
                            else if (line == "SSHCLOSE")
                            {
                                SSHOPC = false;
                                //Console.Write(SSHOPC);
                            }
                            else if(line != "0")
                            {
                                connections = line;
                                Console.WriteLine(connections);
                            }
                          
                            if (line == null) break; // there are less than 15 lines in the file                          
                        }
                    IPTE = random.Next(1, 255) + "." + random.Next(0, 255) + "." + random.Next(0, 255) + "." + random.Next(0, 255);
                    File.WriteAllText(machine, IPTE);
                }
            
                       
            //adds machine1 directory into the file
            //File.WriteAllText(machinefiles, machine);
            //writes the directory to the console for testing
            //Console.WriteLine(File.ReadAllText(machinefiles));
            //creates the machine1 file
            //var machine = File.Create(machine1);
            //closes the file 
            //machine.Close();
            /*
            File.WriteAllText (machine, "TrueFirewall," + Environment.NewLine + "FIREPASS," + Environment.NewLine + "hi" + Environment.NewLine + "OPEN," + Environment.NewLine + "SSHCLOSE");
            File.WriteAllText(machine, Environment.NewLine + random.Next(1, 255) + "." + random.Next(0, 255) + "." + random.Next(0, 255) + "." + random.Next(0, 255));
            string line;
            using (StreamReader sr = new StreamReader(machine))
                for (int i = 0; i < 15; i++)
                {
                    line = sr.ReadLine();
                    //Console.WriteLine(line);
                    if(line == "TrueFirewall,")
                    {
                        FIREW = true;
                        //Console.WriteLine(FIREW);
                    }else if (line == "FIREPASS,")
                    {
                        i++;
                        line = sr.ReadLine();
                        FIREWPASS = line;
                        //Console.WriteLine(FIREWPASS);
                    }else if (line == "OPEN,")
                    {
                        elevation = true;
                        //Console.WriteLine(elevation);
                    }else if (line == "SSHCLOSE")
                    {
                        SSHOPC = false;
                        //Console.Write(SSHOPC);
                    }
                    else
                    {
                        IPTE = sr.ReadLine();
                        Console.WriteLine(IPTE);
                        Thread.Sleep(1);
                    }


                    if (line == null) break; // there are less than 15 lines in the file
                }
            */
            return (elevation, FIREW, FIREWPASS, SSHOPC, IPTE, connections);
           
        }
    }
}
