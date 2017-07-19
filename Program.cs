using GlobalSightLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Xml;
using Newtonsoft.Json;

namespace GlobalSightAPITesting
{
    class Program
    {

        static void Main(string[] args)
        {
            Test();

            //string tmPath = @"C:\Users\m.alabdalkarim\workspace\globalsightworkspace\TMs\MultiUn.tmx";

            //var resultPath = @"C:\Users\m.alabdalkarim\workspace\globalsightworkspace\TMs\MultiUnTMs";

            //var buffer = new byte[419829954];

            //long index = 1;


            //using (FileStream file = new FileStream(tmPath, FileMode.Open, FileAccess.Read))
            //{
            //    long count = file.Length;

            //    while (file.Read(buffer, 0, buffer.Length) > 0)
            //    {
            //        Console.WriteLine($"Write {index} of {count}");

            //        string stringData = Encoding.UTF8.GetString(buffer);

            //        File.WriteAllText($"{resultPath}\\{index}.tmx", stringData);

            //        index += buffer.Length;

            //    }
            //}

        }

        private static void Test()
        {
            GlobalSightAPI gsAPI = new GlobalSightAPI();

            // Get an authentication token from GlobalSight - required to be passed with subsequent API calls

            // Enter your GlobalSight username and password here
            string authCode = gsAPI.Login("user", "password");
            //wLCRi//KQFs=<separator>yNh7P9aS21g=+_+Welocalize
            // Output GlobalSight server version

            //Console.WriteLine("GlobalSight Server Version: " + gsAPI.GetServerVersion(authCode));
            //Console.WriteLine("Search Result: ", gsAPI.tmFullTextSearch(authCode, "Terrorist", "project_save", "en_US", "ar_SA", "", "", "", "Welocalize"));
            //Console.WriteLine("Search Result: ", gsAPI.tmFullTextSearch(authCode, "But Iran", "project_save", "en_US", "ar_SA", "", "", "", "Welocalize"));
            ////Console.WriteLine("Search Result: ", gsAPI.tmFullTextSearch(authCode, "الرياض", "project_save", "ar_SA", "en_US", "", "", "", "Welocalize"));

            //var tmprofiles = gsAPI.getAllTMProfiles(authCode);
            ////gsAPI.searchEntriesAsync(authCode, "mytestingtmprofile", "Video", "en_GB");
            string searchResult =  gsAPI.searchEntries(authCode, "mytestingtmprofile", "Videos", "en_GB");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(searchResult);
            string jsonResult = JsonConvert.SerializeXmlNode(doc);


            //var tmFiles = Directory.GetFiles(@"C:\Users\m.alabdalkarim\workspace\globalsightworkspace\TMs\MultiUnTMs");
            //int filesCounter = 2;
            //foreach (var tmFile in tmFiles)
            //{
            //    string tmPath = $"{tmFile}";
            //    string tmName = $"MultiUn{filesCounter}";
            //    byte[] tmxAsBytes = File.ReadAllBytes(tmPath);
            //    var tmpName = tmFile.Remove(0, 70);
            //    string uploadResult = gsAPI.uploadTmxFile(authCode, tmpName, tmName, tmxAsBytes);
            //    gsAPI.importTmxFile(authCode, tmName, "merge");
            //    filesCounter++;
            //}

            //byte[] tmxAsBytes = System.IO.File.ReadAllBytes(tmPath); //not working for files >2GB

            //Console.WriteLine("Search Result: ", gsAPI.tmFullTextSearch(authCode, "THE", "project_save", "ar_SA", "en_US", "", "", "", "Welocalize"));
            //Console.WriteLine("Search Result: ", gsAPI.tmFullTextSearch(authCode, "الرياض", "project_save", "en_US", "ar_SA", "", "", "", "Welocalize"));
        }
    }
}