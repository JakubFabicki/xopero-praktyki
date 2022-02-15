using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Kurs_walut___email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sendMail();
        }
        
        private bool ValidateRemoteCertificate(object sender, X509Certificate cert, X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            //Use sslPolicyErrors to check what the error is for the certificate.

            //Validate your certificate.
            //Check Hash for MiTM attack.

            //Decide if it is good, then return true, else return false.
            return true;
        }
        void sendMail()
        { 
            string jsonString = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\config.json");
            json configJson = JsonConvert.DeserializeObject<json>(jsonString);
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(ValidateRemoteCertificate);
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com.")
                {
                    Port = 587,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(configJson.email, configJson.name),
                    EnableSsl = true
            };

                smtpClient.Send(configJson.email, configJson.email, "subject", "body");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
