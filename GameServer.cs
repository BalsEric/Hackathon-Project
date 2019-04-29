using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTCP;
namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SimpleTcpServer server;
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            System.Net.IPAddress ip = System.Net.IPAddress.Parse("79.119.22.192");
            server.Start(ip, Convert.ToInt32("8910"));
            while(true)
            {
                server.DataReceived += Server_DataReceived;
            }
        }
        public static void Server_DataReceived(object sender,SimpleTCP.Message e)
        {
            Console.WriteLine(e.MessageString);
            e.ReplyLine(string.Format("Haha {0}", e.MessageString));
        }
    }
}
