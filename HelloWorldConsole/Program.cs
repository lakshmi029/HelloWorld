using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    class Program
    {
        static WebClient client = new WebClient();
        static void Main(string[] args)
        {
            string baseAddress = ConfigurationManager.AppSettings["BaseAddress"];
            var response = client.DownloadString(baseAddress + "/api/Home/Index");
            HelloWorldClass detail = new HelloWorldClass();
            detail.ReturnValue = response.ToString();
            Console.WriteLine(detail.ReturnValue);
            Console.ReadLine();
        }
    }
}
