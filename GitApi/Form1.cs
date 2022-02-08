using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace GitApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            connect();
        }
        
        private void connect()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("PRIVATE-TOKEN", "glpat-i_zjWsubaxnfdLWzxdGH");
                //var response = client.GetAsync("https://gitlab.com/api/v4/users/10825276/projects").Result;
                var response = client.GetAsync("https://gitlab.com/api/v4/users/10825276/projects").Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    // by calling .Result you are synchronously reading the result
                    string responseString = responseContent.ReadAsStringAsync().Result;

                    deserializeJSON(responseString);
                    //Console.WriteLine(responseString);
                }
            }
        }

        private void deserializeJSON(string json)
        {
            JSON elevadoresModel;
            var elevadoresModels = JsonSerializer.Deserialize<List<JSON>>(json);
            elevadoresModel = elevadoresModels.First();
            Console.WriteLine(elevadoresModel.@namespace.name);

        } 
    }
}
