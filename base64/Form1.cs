using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string encodeBase64(string inputText)
        {
            string base64Decoded = inputText;
            string base64Encoded;

            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(base64Decoded);
            base64Encoded = System.Convert.ToBase64String(data);
            return base64Encoded;
        }

        private string decodeBase64(string inputText)
        {
            string base64Encoded = inputText;
            string base64Decoded;

            byte[] data = System.Convert.FromBase64String(base64Encoded);
            base64Decoded = System.Text.ASCIIEncoding.ASCII.GetString(data);

            return base64Decoded;
        }

        private char[] encodeBase64Algoritm(byte[] data)
        {
            int dataLength;
            int dataLengthPadd;
            int paddingCount;
            int blockCount;

            dataLength = data.Length;

            if(dataLength%3 == 0)
            {
                paddingCount = 0;
                blockCount = dataLength / 3;
            }
            else
            {
                paddingCount = 3 - (dataLength%3);
                blockCount = (dataLength + paddingCount) / 3;
            }

            dataLengthPadd = dataLength + paddingCount;

            byte[] source2 = new byte[dataLengthPadd];

            for(int i = 0; i < dataLengthPadd; i++)
            {
                if (i < dataLength)
                    source2[i] = data[i];
                else
                    source2[i] = 0;
            }

            byte[] byteTab = new byte[3];
            byte[] tempTab = new byte[5];
            byte[] buffor = new byte[blockCount * 4];
            char[] result = new char[blockCount * 4];

            for(int i = 0; i < blockCount; i++)
            {
                byteTab[0] = source2[i * 3];
                byteTab[1] = source2[i * 3 + 1];
                byteTab[2] = source2[i * 3 + 2];

                tempTab[1] = (byte)((byteTab[0] & 252) >> 2);

                tempTab[0] = (byte)((byteTab[0] & 3) << 4);
                tempTab[2] = (byte)((byteTab[1] & 240) >> 4);
                tempTab[2] += tempTab[0];

                tempTab[0] = (byte)((byteTab[1] & 15) << 2);
                tempTab[3] = (byte)((byteTab[2] & 192) >> 6);
                tempTab[3] += tempTab[0];

                tempTab[4] = (byte)(byteTab[2] & 63);

                buffor[i * 4] = tempTab[1];
                buffor[i * 4 + 1] = tempTab[2];
                buffor[i * 4 + 2] = tempTab[3];
                buffor[i * 4 + 3] = tempTab[4];
            }

            for(int i = 0; i < blockCount * 4; i++)
            {
                result[i] = SixBitToChar(buffor[i]);
            }

            switch (paddingCount)
            {
                case 1:
                    result[blockCount * 4 - 1] = '=';
                    break;
                case 2:
                    result[blockCount * 4 - 1] = '=';
                    result[blockCount * 4 - 2] = '=';
                    break;
                default:
                    break;
            }
            
            return result;
        }

        private byte[] decodeBase64Algoritm(char[] data)
        {
            int dataLength, resultLength;
            int length = 0;
            int blockCount;
            int paddingCount = 0;

            dataLength = data.Length;
            blockCount = dataLength / 4;
            length = blockCount * 3;

            for(int i = 0; i < 2; i++)
               if (data[dataLength - i - 1] == '=')
                    paddingCount++;

            byte[] buffor = new byte[dataLength];
            byte[] buffor2 = new byte[length];
            
            for (int i = 0; i < dataLength; i++)
            {
                buffor[i] = CharToSixBit(data[i]);
            }

            byte[] byteTab = new byte[4];
            byte[] tempTab = new byte[4];

            for(int i = 0; i < blockCount; i++)
            {
                tempTab[0] = buffor[i * 4]; 
                tempTab[1] = buffor[i * 4 + 1];
                tempTab[2] = buffor[i * 4 + 2];
                tempTab[3] = buffor[i * 4 + 3];

                byteTab[0] = (byte)(tempTab[0] << 2);
                byteTab[1] = (byte)((tempTab[1] & 48) >> 4);
                byteTab[1] += byteTab[0];

                byteTab[0] = (byte)((tempTab[1] & 15) << 4);
                byteTab[2] = (byte)((tempTab[2] & 60) >> 2);
                byteTab[2] += byteTab[0];

                byteTab[0] = (byte)((tempTab[2] & 3) << 6);
                byteTab[3] = tempTab[3];
                byteTab[3] += byteTab[0];

                buffor2[i * 3] = byteTab[1];
                buffor2[i * 3 + 1] = byteTab[2];
                buffor2[i * 3 + 2] = byteTab[3];
            }
            
            resultLength = length - paddingCount;
            byte[] result = new byte[resultLength];

            for (int i = 0; i < resultLength; i++)
            {
                result[i] = buffor2[i];
            }

            return result;
        }

        static char SixBitToChar(byte buffor)
        {
            char[] lookupTable = new char[64] {
                'A','B','C','D','E','F','G','H','I','J','K','L','M',
                'N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                'a','b','c','d','e','f','g','h','i','j','k','l','m',
                'n','o','p','q','r','s','t','u','v','w','x','y','z',
                '0','1','2','3','4','5','6','7','8','9','+','/'
            };

            if ((buffor >= 0) && (buffor <= 63))
            {
                return lookupTable[(int)buffor];
            }
            else
            {
                return ' ';
            }
        }

        private byte CharToSixBit(char c)
        {
            char[] lookupTable = new char[64] {
                'A','B','C','D','E','F','G','H','I','J','K','L','M','N',
                'O','P','Q','R','S','T','U','V','W','X','Y', 'Z',
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n',
                'o','p','q','r','s','t','u','v','w','x','y','z',
                '0','1','2','3','4','5','6','7','8','9','+','/'
            };

            if (c == '=')
            {
                return 0;
            }
            else
            {
                for (int x = 0; x < 64; x++)
                    if (lookupTable[x] == c)
                        return (byte)x;

                return 0;
            }
        }


        private void normalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(normalTextBox.Text);
                char[] value = encodeBase64Algoritm(data);
                string result;
                base64TextBox.Text = result = new string(value);
            }
        }

        private void base64TextBox_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string data = base64TextBox.Text;
                byte[] value = decodeBase64Algoritm(data.ToCharArray());
                string result = System.Text.Encoding.ASCII.GetString(value);
                normalTextBox.Text = result;
            }
        }
    }
}
