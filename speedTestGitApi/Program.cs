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

        static int time;
        static void Main(string[] args)
        {
            //for(int i = 0; i < 20; i++)
            //{
            //    Stopwatch watch = new Stopwatch();
            //    watch.Start();
            //    getProject();
            //    getProject(2);
            //    getProject(3);
            //    getProject(4);
            //    getProject(5);
            //    watch.Stop();
            //    time += (int)watch.ElapsedMilliseconds;
            //    Console.WriteLine(watch.ElapsedMilliseconds);
            //}

            //Console.WriteLine("Średnia main wątku to: " + (time / 5));

            rezultat = null;
            time = 0;


            for (int i = 0; i < 20; i++)
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
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
                watki3.Join();
                watki4.Join();
                watki5.Join();
                watch.Stop();
                time += (int)watch.ElapsedMilliseconds;
                Console.WriteLine(watch.ElapsedMilliseconds);
            }

            Console.WriteLine("Średnia main wątku to: " + (time / 20));
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
