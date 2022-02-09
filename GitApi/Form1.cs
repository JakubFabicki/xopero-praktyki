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
        //glpat-X539X-MgHnwgM_FDiyes
        List<JSON> jsons;
        List<UserID> jsonsID;
        string token, id;
        HttpClient client;

        public Form1()
        {
            InitializeComponent();
            getUserID();
        }
        
        private void getProject(string token, int page = 1)
        {
            using (client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("PRIVATE-TOKEN", token);   
                this.token = token;
                var response = client.GetAsync($"https://gitlab.com/api/v4/users/{id}/projects?per_page=20&page={page.ToString()}").Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;
                    deserializeJSONProject(responseString);
                }
                else
                    MessageBox.Show("Wprowadź poprawne dane");
            }
        }

        private void getUserID()
        {
            using (client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("PRIVATE-TOKEN", "glpat-X539X-MgHnwgM_FDiyes");
                var response = client.GetAsync($"https://gitlab.com/api/v4/user").Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;
                    deserializeJSONID(responseString);
                    Console.WriteLine(responseString);
                }
                else
                    MessageBox.Show("Wprowadź poprawne dane");
            }
        }

        private void delete(string id)
        {
            using (client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("PRIVATE-TOKEN", token);
                var response = client.DeleteAsync($"https://gitlab.com/api/v4/projects/{id}").Result;

                if (response.IsSuccessStatusCode)
                    Console.WriteLine("Pomyślnie usunięto projekt");
                else
                    Console.WriteLine("Projekt nie został usunięty");
            }
        }

        private void deserializeJSONProject(string json)
        {
            JSON jsonObj;
            jsons = JsonSerializer.Deserialize<List<JSON>>(json);

            if (listBox.Items.Count > 0)
                listBox.Items.Clear();

            for(int i = 0; i < jsons.Count; i++)
            {
                jsonObj = jsons[i];
                listBox.Items.Add(jsonObj.name, false);
            }
        }

        private void deserializeJSONID(string json)
        {
            UserID jsonObj = JsonSerializer.Deserialize<UserID>(json);

            nameLabel.Text = (jsonObj.name);
            id = jsonObj.id.ToString();
        }

        private void projectBtn_Click(object sender, EventArgs e)
        {
            getProject(tokenBox.Text, (int)numPage.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gitlab.com/-/profile/personal_access_tokens");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            for(int i = listBox.Items.Count - 1; i >= 0;  i--)
            {
                if (listBox.GetItemChecked(i))
                {
                    listBox.Items.Remove(listBox.Items[i]);
                    MessageBox.Show(jsons[i].id.ToString());
                    delete(jsons[i].id.ToString());
                }
            }
        }

        private void numPage_ValueChanged(object sender, EventArgs e)
        {
            getProject(tokenBox.Text, (int)numPage.Value);
        }

        private void createRepo()
        {
            for(int i = 0; i < 20; i++)
                {
                    var values = new List<KeyValuePair<string, string>>();
                    values.Add(new KeyValuePair<string, string>("name", "redsadas" + i.ToString()));
                    var content = new FormUrlEncodedContent(values);
                    var responsePost = client.PostAsync($"https://gitlab.com/api/v4/projects/", content).Result;
                    if (responsePost.IsSuccessStatusCode)
                        Console.WriteLine("działa "+responsePost.StatusCode);
                    else
                        Console.WriteLine("działa nie " + responsePost.StatusCode);
            }
        }
    }
}
