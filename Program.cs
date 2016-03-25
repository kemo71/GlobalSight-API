using GlobalSightLib;
using System;

namespace GlobalSightAPITesting
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalSightAPI gsAPI = new GlobalSightAPI();

            // Get an authentication token from GlobalSight - required to be passed with subsequent API calls
            
            // Enter your GlobalSight username and password here
            string authCode = gsAPI.Login("GLOBALSIGHT USERNAME", "GLOBALSIGHT PASSWORD");

            // Output GlobalSight server version
            Console.WriteLine("GlobalSight Server Version: " + gsAPI.GetServerVersion(authCode));

            Console.Read();
        }
    }
}