using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_walut___email
{
    class HTTP
    {
        public bool aplicationRun = true;
        
        public void listening()
        {
            bool listenerBool = true;
            var listener = new HttpListener();
            var url = "http://localhost:9000/";
            listener.Prefixes.Add(url);
            listener.Start();

            while (listenerBool)
            {
                var context = listener.GetContext();
                var request = context.Request;
                listenerBool = false;

                aplicationRun = false;
            }
            listener.Stop();
        }
    }
}
