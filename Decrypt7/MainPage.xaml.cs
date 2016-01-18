using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Resources;
using Windows.ApplicationModel.Resources.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Decrypt7
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private String Decrypt(String Crypted)
        {
            try
            {
                if(Crypted.Length > 2) { 
                Int32 XIdx;
                Int32[] Xlat = new Int32[] { 0x64, 0x73, 0x66, 0x64, 0x3B, 0x6B, 0x66, 0x6F, 0x41, 0x2C, 0x2E, 0x69, 0x79, 0x65, 0x77, 0x72, 0x6B, 0x6C, 0x64, 0x4A, 0x4B, 0x44, 0x48, 0x53, 0x55, 0x42, 0x73, 0x67, 0x76, 0x63, 0x61, 0x36, 0x39, 0x38, 0x33, 0x34, 0x6E, 0x63, 0x78, 0x76, 0x39, 0x38, 0x37, 0x33, 0x32, 0x35, 0x34, 0x6B, 0x3B, 0x66, 0x67, 0x38, 0x37 };
                Int32 Pos = 0;

                String Encrypted = Crypted.Trim();
                String Decrypt = String.Empty;

                XIdx = Convert.ToInt32(Encrypted.Substring(Pos, 2));

                while ((Pos += 2) < Encrypted.Length)
                {
                    Decrypt += (Char)(Int32.Parse(Encrypted.Substring(Pos, 2), System.Globalization.NumberStyles.HexNumber) ^ Xlat[XIdx++]);
                }
                return (Decrypt);
                } else
                {
                    return (String.Empty);
                }
            }
            catch
            {
                ResourceLoader rl = new ResourceLoader();

                return (rl.GetString("decryptError"));
            }
        }

        private void inputButton_Click(object sender, RoutedEventArgs e)
        {
            String Result = Decrypt(cryptedInput.Text);
            if(Result == String.Empty)
            {
                decryptedOutput.Text = "...";
            } else
            {
                decryptedOutput.Text = Result;
            }
        }
    }
}
