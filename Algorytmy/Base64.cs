using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy
{
    class Base64
    {
        public string encodeBase64(string inputText)
        {
            string base64Decoded = inputText;
            string base64Encoded;

            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(base64Decoded);
            base64Encoded = System.Convert.ToBase64String(data);
            return base64Encoded;
        }

        public string decodeBase64(string inputText)
        {
            string base64Encoded = inputText;
            string base64Decoded;

            byte[] data = System.Convert.FromBase64String(base64Encoded);
            base64Decoded = System.Text.ASCIIEncoding.ASCII.GetString(data);

            return base64Decoded;
        }
    }
}
