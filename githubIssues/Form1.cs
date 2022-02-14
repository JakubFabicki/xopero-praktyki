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

//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

namespace githubIssues
{
    public partial class Form1 : Form
    {
        //List<JSON> jsons;
        string token, id;

        public Form1()
        {
            InitializeComponent();
            getRepo();
        }
        
        private void getRepo()
        {
            var client = new GitHubClient(new ProductHeaderValue("JakubFabicki"));
            var tokenAuth = new Credentials("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"); // NOTE: not real token
            client.Credentials = tokenAuth;

            var recently = new IssueRequest
            {
                Filter = IssueFilter.All,
                State = ItemStateFilter.All,
                Since = DateTimeOffset.Now.Subtract(TimeSpan.FromDays(14))
            };
            var issues = client.Issue.GetAllForCurrent(recently).Result;
            Console.WriteLine(issues.Count);

        }
    }
}
