using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace Cyber_Game_1
{
    public class Login_screen
   {
        public static (string, string) login(string username, string password)
        {
            Console.Write("USERNAME: ");
            username = Console.ReadLine();
            //Console.WriteLine("");
            //Console.Write(username);
            Console.Write("PASSWORD: ");
            password = Console.ReadLine();
            Console.WriteLine(password);
            return (username, password);
        }
    }
}
