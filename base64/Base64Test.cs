using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base64
{
    class Base64Test
    {
        //Arrange
        private const string encodeTestString = "Kacper nie zda";
        private const string encodeTestValue = "S2FjcGVyIG5pZSB6ZGE=";
        private const string decodeTestString = "S2FjcGVyIG5pZSB6ZGE=";
        private const string decodeTestValue = "Kacper nie zda";
        
        private string resultString;
        public algBase64 base64 = new algBase64();
        
        private string testBase64Encode()
        {
            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(encodeTestString);
            resultString = new string(base64.encodeBase64Algoritm(data));
            return resultString;
        }

        private string testBase64Decode()
        {
            byte[] value = base64.decodeBase64Algoritm(decodeTestString.ToCharArray());
            resultString = System.Text.Encoding.ASCII.GetString(value);
            return resultString;
        }

        public bool testBase64Result()
        {
            //Act
            string encodeResult = testBase64Encode();
            string decodeResult = testBase64Decode();

            //Assert
            if (encodeResult == encodeTestValue && decodeResult == decodeTestValue)
                return true;
            else 
                return false;
        }
    }
}
