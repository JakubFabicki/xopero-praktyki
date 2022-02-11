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
        List<JSON> jsons;
        string token, id;
        HttpClient client;

        public Form1()
        {
            InitializeComponent();
            //createRepo();
        }
        
        private void getUserID()
        {
            using (client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("PRIVATE-TOKEN", tokenBox.Text);
                var response = client.GetAsync($"https://gitlab.com/api/v4/user").Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;
                    deserializeJSONID(responseString);
                }
                else
                    MessageBox.Show("Wprowadź poprawne dane");
            }
        }

        private void getProject(string token, int page = 1)
        {
            getUserID();
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

        private void delete(string id)
        {
            getUserID();
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

        private void deleteAll()
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz skasować wszystko?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (jsons == null)
                    getProject(token);

                while (jsons.Count > 0)
                {
                    for (int i = jsons.Count - 1; i == 0; i--)
                    {
                        delete(jsons[i].id.ToString());
                        listBox.Items.Remove(listBox.Items[i]);
                    }
                    getProject(token);
                }
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

            nameLabel.Text = ("Witaj " + jsonObj.name);
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
                    delete(jsons[i].id.ToString());
                }
            }
        }

        private void numPage_ValueChanged(object sender, EventArgs e)
        {
            getProject(tokenBox.Text, (int)numPage.Value);
            checkBox1.Checked = false;
        }

        private void deleteAllBtn_Click(object sender, EventArgs e)
        {
            deleteAll();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                for (int i = 0; i < listBox.Items.Count; i++)
                    listBox.SetItemChecked(i, true);
            else
                for (int i = 0; i < listBox.Items.Count; i++)
                    listBox.SetItemChecked(i, false);
        }

        private void addRepoBtn_Click(object sender, EventArgs e)
        {
            createRepo(genRepoName.Text, (int) genRepoNum.Value);
            getProject(tokenBox.Text, (int)numPage.Value);
        }

        private void createRepo(string name, int length)
        {
            using (client = new HttpClient())
            {
                token = tokenBox.Text;
                client.DefaultRequestHeaders.Add("PRIVATE-TOKEN", token);
                barLabel.Visible = true;
                bar.Visible = true;
                barLabel.Text = $"0 / {length}";
                bar.Minimum = 0;
                bar.Maximum = length;
                for (int i = 0; i < length; i++)
                {
                    var values = new List<KeyValuePair<string, string>>();
                    values.Add(new KeyValuePair<string, string>("name", name + i.ToString()));
                    var content = new FormUrlEncodedContent(values);
                    var responsePost = client.PostAsync($"https://gitlab.com/api/v4/projects/", content).Result;
                    if (responsePost.IsSuccessStatusCode)
                    {
                        Console.WriteLine("działa "+ i +" "+responsePost.StatusCode);
                        bar.Value = i+1;
                        barLabel.Text = $"{bar.Value - 1} / {bar.Maximum}";
                    }
                    else
                    {
                        Console.WriteLine("działa nie " + responsePost.StatusCode);
                        bar.Maximum--;
                    }
                }
                barLabel.Visible = false;
                bar.Visible = false;
                bar.Value = 0;
            }
        }
    }
}
