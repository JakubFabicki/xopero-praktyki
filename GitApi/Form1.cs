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
        }
        
        private void connect(string id, string token)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("PRIVATE-TOKEN", token);
                var response = client.GetAsync($"https://gitlab.com/api/v4/users/{id}/projects").Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    // by calling .Result you are synchronously reading the result
                    string responseString = responseContent.ReadAsStringAsync().Result;

                    deserializeJSON(responseString);
                }
                else
                    MessageBox.Show("Wprowadź poprawne dane");
            }
        }

        private void deserializeJSON(string json)
        {
            JSON jsonObj;
            var jsons = JsonSerializer.Deserialize<List<JSON>>(json);
            listBox.Text = null;
            for(int i = 0; i < jsons.Count; i++)
            {
                jsonObj = jsons[i];
                listBox.Text += jsonObj.name + "\r\n";
                Console.WriteLine(jsonObj.name);
            }
        }

        private void projectBtn_Click(object sender, EventArgs e)
        {
            connect(idBox.Text, tokenBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gitlab.com/-/profile/personal_access_tokens");
        }
    }
}
