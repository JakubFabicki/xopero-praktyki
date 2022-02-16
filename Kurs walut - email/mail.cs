using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_walut___email
{
    class mail
    {
        string jsonString;
        json configJson;
        private HttpClient client;
        HTTP http;
        Form1 form;

        public mail(Form1 form)
        {
            this.form = form;
            http = new HTTP();
            jsonString = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\config.json");
            configJson = JsonConvert.DeserializeObject<json>(jsonString);
        }

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        public void getCurrency()
        {
            using (client = new HttpClient())
            {
                var response = client.GetAsync($"https://api.nbp.pl/api/exchangerates/tables/a").Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;

                    List<currencyTableJson> json = JsonConvert.DeserializeObject<List<currencyTableJson>>(responseString);
                    currencyTableJson jsonObj = json[0];

                    for (int i = 0; i < jsonObj.rates.Count; i++)
                    {
                        form.currencyListBox.Items.Add(jsonObj.rates[i].code);
                    }
                }
            }
        }

        public void sendMailStart()
        {
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = configJson.senderConfig.interval * 60000;
            sendMail();
            myTimer.Start();

            Thread thread1 = new Thread(http.listening);
            thread1.Start();
        }

        private void sendMail()
        {
            if (http.aplicationRun)
            {

                DateTime dateTime = DateTime.Now;
                string title = "Kurs walut - raport z " + DateTime.Now.ToString("HH:mm MM/dd/yyyy");
                string body = "Przesyłamy aktualny kurs wybranych walut poniżej: \r\n";

                for (int i = 0; i < form.currencyListBox.Items.Count; i++)
                {
                    if (form.currencyListBox.GetItemChecked(i))
                    {
                        string code = form.currencyListBox.Items[i].ToString();
                        using (client = new HttpClient())
                        {
                            var response = client.GetAsync($"http://api.nbp.pl/api/exchangerates/rates/a/{code}/").Result;

                            if (response.IsSuccessStatusCode)
                            {
                                var responseContent = response.Content;
                                string responseString = responseContent.ReadAsStringAsync().Result;
                                currencyJson json = JsonConvert.DeserializeObject<currencyJson>(responseString);
                                body += $"{json.currency}({json.code}): {json.rates[0].mid.ToString()}\r\n";
                            }
                        }
                    }
                }

                ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(ValidateRemoteCertificate);

                try
                {
                    var smtpClient = new SmtpClient(configJson.senderConfig.smtpServer)
                    {
                        Port = configJson.senderConfig.port,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(configJson.senderConfig.email, configJson.senderConfig.key),
                        EnableSsl = true
                    };

                    smtpClient.Send(configJson.senderConfig.email, configJson.email, title, body);
                    Console.WriteLine("Send");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                myTimer.Stop();
                MessageBox.Show("Wyłączam aplikacje");
                myTimer.Tick -= new EventHandler(TimerEventProcessor);
                Application.Exit();
            }
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();
            sendMail();
            myTimer.Enabled = true;
        }

        //usuwanie zabezpieczeń ssl
        private bool ValidateRemoteCertificate(object sender, X509Certificate cert, X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            //Use sslPolicyErrors to check what the error is for the certificate.

            //Validate your certificate.
            //Check Hash for MiTM attack.

            //Decide if it is good, then return true, else return false.
            return true;
        }
    }
}
