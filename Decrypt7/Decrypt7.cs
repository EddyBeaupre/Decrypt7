using System;
using System.Windows.Forms;

namespace Decrypt7_CSharp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private String Decrypt(String Crypted)
        {
            try { 
            Int32 XIdx;
            Int32[] Xlat = new Int32[] { 0x64, 0x73, 0x66, 0x64, 0x3B, 0x6B, 0x66, 0x6F, 0x41, 0x2C, 0x2E, 0x69, 0x79, 0x65, 0x77, 0x72, 0x6B, 0x6C, 0x64, 0x4A, 0x4B, 0x44, 0x48, 0x53, 0x55, 0x42, 0x73, 0x67, 0x76, 0x63, 0x61, 0x36, 0x39, 0x38, 0x33, 0x34, 0x6E, 0x63, 0x78, 0x76, 0x39, 0x38, 0x37, 0x33, 0x32, 0x35, 0x34, 0x6B, 0x3B, 0x66, 0x67, 0x38, 0x37 };
            Int32 Pos = 0;

            String Encrypted = Crypted.Trim();
            String Decrypt = String.Empty;

            XIdx = Convert.ToInt32(Encrypted.Substring(Pos, 2));

            while ((Pos+=2) < Encrypted.Length)
            {
                Decrypt += (Char)(Int32.Parse(Encrypted.Substring(Pos, 2), System.Globalization.NumberStyles.HexNumber) ^ Xlat[XIdx++]);
            }
            return (Decrypt);
            }
            catch
            {
                return (String.Empty);
            }
        }

        private void Start1_Click(object sender, EventArgs e)
        {
            try
            {
                DecryptBox1.Text = Decrypt(CryptBox1.Text);
            }
            catch
            {
                DecryptBox1.Text = String.Empty;
            }
        }
    }
}
