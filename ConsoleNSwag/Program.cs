using System.Collections.Generic;
using MyNamespace;
using static System.Console;

namespace ConsoleNSwag
{
    public class Program
    {
        public static void Main()
        {
            WriteLine("Welcome to Nswag Generated Client");

            ValuesClient testClient = new ValuesClient();
            //ValuesClient testClient = new ValuesClient("http://localhost:44355");

            // Call GetAsync Values API  
            string getresult = testClient.GetAsync(1).GetAwaiter().GetResult();

            // Call GetAllAsync Values API  
            ICollection<string> getAllresult = testClient.GetAllAsync().GetAwaiter().GetResult();
        }
    }
}
