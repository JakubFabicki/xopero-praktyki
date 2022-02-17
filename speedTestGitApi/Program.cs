using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Threading;

namespace speedTestGitApi
{
    class Program
    {
        static List<JSON> jsons;
        static string id = "10825276";
        static HttpClient client;
        static string rezultat;

        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            getProject();
            getProject(2);
            getProject(3);
            getProject(4);
            getProject(5);
            watch.Stop();
            Console.WriteLine(rezultat);

            rezultat = null;

            Stopwatch watch2 = new Stopwatch();
            watch2.Start(); 
            Thread watki = new Thread(new ThreadStart(() => getProject()));
            watki.Start();
            Thread watki2 = new Thread(new ThreadStart(() => getProject(2)));
            watki2.Start();
            Thread watki3 = new Thread(new ThreadStart(() => getProject(3)));
            watki3.Start();
            Thread watki4 = new Thread(new ThreadStart(() => getProject(4)));
            watki4.Start();
            Thread watki5 = new Thread(new ThreadStart(() => getProject(5)));
            watki5.Start();

            watki.Join();
            watki2.Join();

            watch2.Stop();
            Console.WriteLine(rezultat);
            Console.WriteLine(watch.ElapsedMilliseconds);
            Console.WriteLine(watch2.ElapsedMilliseconds);
        }

        private static void getProjectTheard(int i)
        {
            
        }

        public static void getProject(int page = 1)
        {
            using (client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("PRIVATE-TOKEN", "glpat-AL2AsHbBxoL_KqC13p46");

                var response = client.GetAsync($"https://gitlab.com/api/v4/users/{id}/projects?per_page=100&page={page.ToString()}").Result;


                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;
                    deserializeJSONProject(responseString);

                }
            }
        }

        private static void deserializeJSONProject(string json)
        {
            JSON jsonObj;
            jsons = JsonSerializer.Deserialize<List<JSON>>(json);

            for (int i = 0; i < jsons.Count; i++)
            {
                jsonObj = jsons[i];
                rezultat += jsonObj.name + "\r\n";
            }

        }
    }
}
