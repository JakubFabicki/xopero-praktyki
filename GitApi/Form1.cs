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
                var response = client.GetAsync("https://gitlab.com/api/v4/projects/?simple=yes&private=true&per_page=1000&page=1").Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;

                    // by calling .Result you are synchronously reading the result
                    string responseString = responseContent.ReadAsStringAsync().Result;

                    Console.WriteLine(responseString);
                }
            }
        }
    }
}
