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
            var threeMonthsAgoIsh = DateTime.Now.Subtract(TimeSpan.FromDays(90));

            // search for a specific term
            var request = new SearchIssuesRequest("*")
            {
                // only search pull requests
                Type = IssueTypeQualifier.PullRequest,
                State = ItemState.Open,
                Language = Language.CSharp,
                Updated = new DateRange(threeMonthsAgoIsh, SearchQualifierOperator.GreaterThan)
            };
            var issues = client.Issue.GetAllForCurrent(request).Result; 
            Console.WriteLine(issues.Count);

        }
    }
}
