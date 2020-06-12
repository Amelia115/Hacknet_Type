using System;
using System.IO;
using System.Threading.Tasks;

namespace Cyber_Game_1
{

    public class Program
    {

        public struct Machine
        {

            public bool FIRE;
            public string FIREPASS;
            public bool SSHOC;
            public bool elevation;
            public string IP;
            public string connections;

        }
        public static void Main(string[] args)
        {

            Console.WriteLine("EVERYTHING SIMULATED IN THIS GAME IS ILLEGAL TO DO IN REAL LIFE, DO NOT IMMITATE THIS GAME");
            Console.ReadLine();
            bool elevation = false;
            bool FIREW = false;
            string FIREWPASS = "";
            bool SSHOPC = false;
            string username = "";
            string password = "";
            string IPTE = "";
            string connections = "";
            
            (username, password) = Login_screen.login(username, password);
            //machine_definition.MachineDef(elevation, FIREW, FIREWPASS, SSHOPC);

            Machine machine1 = new Machine();
            (elevation, FIREW, FIREWPASS, SSHOPC, IPTE, connections) = machine_definition.MachineDef(elevation, FIREW, FIREWPASS, SSHOPC, IPTE, connections);
            machine1.FIRE = FIREW;
            machine1.FIREPASS = FIREWPASS;
            machine1.SSHOC = SSHOPC;
            machine1.IP = IPTE;
            machine1.elevation = elevation;
            machine1.connections = connections;
            Machine machine2 = new Machine();
            (elevation, FIREW, FIREWPASS, SSHOPC, IPTE, connections) = machine_definition.MachineDef(elevation, FIREW, FIREWPASS, SSHOPC, IPTE, connections);
            machine2.FIRE = FIREW;
            machine2.FIREPASS = FIREWPASS;
            machine2.SSHOC = SSHOPC;
            machine2.IP = IPTE;
            machine2.elevation = elevation;
            machine2.connections = connections;
            //Console.WriteLine(machine1.FIRE);
            //Console.WriteLine(machine1.FIREPASS);
            //Console.WriteLine(machine1.SSHOC);
            boot();
            Tutorial.StartMessage();
            
        }
        
        static void boot()
        {
            string file = "C:\\Users\\hayden parsons\\source\\repos\\Cyber_Game_1\\boot.txt";
            string line;
            using (StreamReader sr = new StreamReader(file))
            for (int i = 0; i < 100; i++)
            {
                line = sr.ReadLine();
                Console.WriteLine(line);
                
                if (line == null) break; // there are less than 15 lines in the file
            }
            Console.Clear();
        }


    }
}
