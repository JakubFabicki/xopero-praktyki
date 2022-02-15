using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;
using System.Text.Json;
using System.Text.Json.Serialization;
using MySql.Data.MySqlClient;

//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

namespace githubIssues
{
    public partial class Form1 : Form
    {
        //List<JSON> jsons;
        string token, id;


        int issues = 0;
        int openPullReq = 0;
        int closePullReq = 0;

        public Form1()
        {
            InitializeComponent();

            foreach (DataGridViewColumn item in dataGridView1.Columns)
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void repoBtn_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void tokenBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/settings/tokens");
        }

        private void viewRepoBtn_Click(object sender, EventArgs e)
        {
            getRepo();
        }

        private void getRaportBtn_Click(object sender, EventArgs e)
        {
            getRaport();
        }
        
        private void raportBtn_Click(object sender, EventArgs e)
        {
            generateRaport();
        }

        private void getRepo()
        {
            var client = new GitHubClient(new ProductHeaderValue(ownerBox.Text));
            var tokenAuth = new Credentials(tokenBox.Text); // NOTE: not real token
            client.Credentials = tokenAuth;
            viewRepoBox.Text = null;
            try
            {
                var repositoryList = client.Repository.GetAllForCurrent().Result;

                for (int i = 0; i < repositoryList.Count; i++)
                    viewRepoBox.Text += repositoryList[i].Name + "\r\n";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Wprowadź poprawne dane!");
            }
        }

        private void getData()
        {
            var client = new GitHubClient(new ProductHeaderValue(ownerBox.Text));
            var tokenAuth = new Credentials(tokenBox.Text); // NOTE: not real token
            client.Credentials = tokenAuth;

            pullClosedView.Text = null;
            pullView.Text = null;
            issuesView.Text = null;
            try
            {
                var issues = client.Issue.GetAllForCurrent(new IssueRequest
                {
                    Filter = IssueFilter.All,
                    State = ItemStateFilter.All,
                    Since = DateTimeOffset.Now.Subtract(TimeSpan.FromDays(14))
                }).Result;
            
                var pullRequestsOpen = client.PullRequest.GetAllForRepository(ownerBox.Text, repoBox.Text, new PullRequestRequest
                {
                    State = ItemStateFilter.Open
                }).Result;

                var pullRequestsClosed = client.PullRequest.GetAllForRepository(ownerBox.Text, repoBox.Text, new PullRequestRequest
                {
                    State = ItemStateFilter.Closed
                }).Result;

                for (int i = 0; i < pullRequestsClosed.Count; i++)
                    pullClosedView.Text += pullRequestsClosed[i].Title + "\r\n";
                openPullReq = pullRequestsClosed.Count;


                for (int i = 0; i < issues.Count; i++)
                {
                    if (issues[i].PullRequest == null)
                    {
                        issuesView.Text += issues[i].Title + "\r\n";
                        this.issues++;
                    }

                }

                for (int i = 0; i < pullRequestsOpen.Count; i++)
                    pullView.Text += pullRequestsOpen[i].Title + "\r\n";
                closePullReq = pullRequestsClosed.Count;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Wprowadź prawidłowe dane!");
            }
        }
        
        private void generateRaport()
        {
            DateTime dateTime = DateTime.Now;
            string owner = ownerBox.Text;
            string repo = repoBox.Text;

            string connStr = "server=localhost;user=root;database=raportsrepo;port=3306;password=Admin_12345";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string query = "INSERT INTO raportsdata(issues, openPullReq, closePullReq, createData, owner, repo) " +
                                $"Values ('{issues}', '{openPullReq}', '{closePullReq}', '{dateTime}', '{owner}', '{repo}')";
                
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
        }

        private void getRaport()
        {
            string connStr = "server=localhost;user=root;database=raportsrepo;port=3306;password=Admin_12345";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = $"SELECT issues, openPullReq, closePullReq, createData FROM raportsdata WHERE owner='{ownerBox.Text}' AND repo='{repoBox.Text}'";
                //string sql = "SELECT * FROM raportsrepo.raportsdata";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);
                    
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
        }

        public void createRaport()
        {
            string connStr = "server=localhost;user=root;database=raportsrepo;port=3306;password=Admin_12345";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                //string sql = "SELECT Name, HeadOfState FROM Country WHERE Continent='Oceania'";
                //MySqlCommand cmd = new MySqlCommand(sql, conn);
                //MySqlDataReader rdr = cmd.ExecuteReader();

                //while (rdr.Read())
                //{
                //    Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                //}ALTER USER root IDENTIFIED BY Admin_1234;

                //rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
        }
    }
}
