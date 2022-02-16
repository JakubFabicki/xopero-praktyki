using System;
using System.Net;
using System.Text;

namespace ListenerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and start a listener.
            var listener = new HttpListener();
            var url = (args.Length > 0) ? args[0] : "http://localhost:9000/api/cs/";
            listener.Prefixes.Add(url);
            listener.Start();

            // Announce that it's running.
            Console.WriteLine("Listening. Please submit requests to: {0}", url);

            while (true)
            {
                // Wait for a request.
                var context = listener.GetContext();
                var request = context.Request;

                // Display some information about the request.
                Console.WriteLine("Full URL: {0}", request.Url.OriginalString);
                Console.WriteLine("    Path: {0}", request.Url.PathAndQuery);

                // Break from the loop if it's the poison pill (a DELETE request).
                if (request.HttpMethod == "DELETE")
                {
                    Console.WriteLine("Asked to stop.");
                    break;
                }

                // Send a response.
                var response = context.Response;
                string responseString = "Hello from C#";
                byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                response.ContentType = "text/html";
                var output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                output.Close();
                response.Close();
            }
            // Stop listening.
            listener.Stop();
            System.Environment.Exit(1);
        }
    }
}