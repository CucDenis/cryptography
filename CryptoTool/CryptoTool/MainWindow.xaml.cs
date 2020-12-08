using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.IO;

namespace CryptoTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       static string sFilleNames = "";
       static string plainText = "";
       byte[] cipherText;
       byte[] cipherKey;
       byte[] cipherIV;
       static string algorithmName = "";
       static string selectedRb = "";
       static List<string> encryptedText = new List<string>();
       static List<string> decryptedText = new List<string>();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Filter = "Log Files|*.log|Textfiles|*.txt|All Files|*.*";
            fileDialog.DefaultExt = ".txt";
            Nullable<bool> dialogOk = fileDialog.ShowDialog();

            sFilleNames = "";

            if (dialogOk == true)
            {
                foreach (string sFileName in fileDialog.FileNames)
                {
                    sFilleNames += ";" + sFileName;
                }
                sFilleNames = sFilleNames.Substring(1);

                txbFileName.Text = sFilleNames;
            }
        }

        private void RunEncrypDecryp(object sender, RoutedEventArgs e)
        {
            switch (algorithmName)
            {
                case "Rijndael":
                    RijndaelEncDec();
                    break;
                case "AES":
                    AESEncDec();
                    break;
                case "RC2":
                    RC2EncDec();
                    break;
                case "TripleDES":
                    TripleDESEncDec();
                    break;
                case "DES":
                    RijndaelEncDec();
                    break;
                default:
                    RijndaelEncDec();
                    break;
            }
        }

        void PrintText(object sender, SelectionChangedEventArgs args)
        {
            ListBoxItem lbi = ((sender as ListBox).SelectedItem as ListBoxItem);
            algorithmName = lbi.Content.ToString();
        }

        private void RijndaelEncDec()
        {
            try
            {

                using (Rijndael myRijndael = Rijndael.Create())
                {
                    if (selectedRb == "Encryption")
                    {
                        encryptedText.Clear();
                        PlainTextRead();
                        // Encrypt the string to an array of bytes.
                        byte[] encrypted = RijndaelCrypto.EncryptStringToBytes(plainText, cipherKey = myRijndael.Key, cipherIV = myRijndael.IV);
                        cipherText = encrypted;
                        encryptedText.Add(Convert.ToBase64String(encrypted));
                        txbEncryDecryp.Text = encryptedText[0];
                    }
                    else if (selectedRb == "Decryption")
                    {
                        string roundtrip = RijndaelCrypto.DecryptStringFromBytes(cipherText, cipherKey, cipherIV);
                        txbEncryDecryp.Text = roundtrip;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }

        private void AESEncDec()
        {
            try
            {

                using (Aes myAes = Aes.Create())
                {
                    if (selectedRb == "Encryption")
                    {
                        encryptedText.Clear();
                        PlainTextRead();
                        // Encrypt the string to an array of bytes.
                        byte[] encrypted = AES.EncryptStringToBytes_Aes(plainText, cipherKey = myAes.Key, cipherIV = myAes.IV);
                        cipherText = encrypted;
                        encryptedText.Add(Convert.ToBase64String(encrypted));
                        txbEncryDecryp.Text = encryptedText[0];
                    }
                    else if (selectedRb == "Decryption")
                    {
                        string roundtrip = AES.DecryptStringFromBytes_Aes(cipherText, cipherKey, cipherIV);
                        txbEncryDecryp.Text = roundtrip;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }

        private void TripleDESEncDec()
        {
            try
            {
                encryptedText.Clear();
                PlainTextRead();
                // Create a new TripleDESCryptoServiceProvider object
                // to generate a key and initialization vector (IV).
                TripleDESCryptoServiceProvider tDESalg = new TripleDESCryptoServiceProvider();
                if (selectedRb == "Encryption")
                {
                    // Encrypt the string to an in-memory buffer.
                    byte[] Data = TripleDES.EncryptTextToMemory(plainText, cipherKey = tDESalg.Key, cipherIV = tDESalg.IV);
                    cipherText = Data;
                    encryptedText.Add(Convert.ToBase64String(Data));
                    txbEncryDecryp.Text = encryptedText[0];
                }
                else if (selectedRb == "Decryption")
                {

                    // Decrypt the buffer back to a string.
                    string roundTrip = TripleDES.DecryptTextFromMemory(cipherText, cipherKey, cipherIV);
                    txbEncryDecryp.Text = roundTrip;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void RC2EncDec()
        {
            try
            {

                using (RC2CryptoServiceProvider rc2CSP = new RC2CryptoServiceProvider())
                {
                    if (selectedRb == "Encryption")
                    {
                        encryptedText.Clear();
                        PlainTextRead();
                        // Encrypt the string to an array of bytes.
                        byte[] encrypted = RC2.EncryptStringToBytes(plainText, cipherKey = rc2CSP.Key, cipherIV = rc2CSP.IV);
                        cipherText = encrypted;
                        encryptedText.Add(Convert.ToBase64String(encrypted));
                        txbEncryDecryp.Text = encryptedText[0];
                    }
                    else if (selectedRb == "Decryption")
                    {
                        string roundtrip = RC2.DecryptStringFromBytes(cipherText, cipherKey, cipherIV);
                        txbEncryDecryp.Text = roundtrip;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }

        private void DESEncDec()
        {
            try
            {
                encryptedText.Clear();
                PlainTextRead();
                // Create a new TripleDESCryptoServiceProvider object
                // to generate a key and initialization vector (IV).
                DESCryptoServiceProvider DESalg = new DESCryptoServiceProvider();
                if (selectedRb == "Encryption")
                {
                    // Encrypt the string to an in-memory buffer.
                    byte[] Data = TripleDES.EncryptTextToMemory(plainText, cipherKey = DESalg.Key, cipherIV = DESalg.IV);
                    cipherText = Data;
                    encryptedText.Add(Convert.ToBase64String(Data));
                    txbEncryDecryp.Text = encryptedText[0];
                }
                else if (selectedRb == "Decryption")
                {

                    // Decrypt the buffer back to a string.
                    string roundTrip = TripleDES.DecryptTextFromMemory(cipherText, cipherKey, cipherIV);
                    txbEncryDecryp.Text = roundTrip;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void PlainTextRead()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(sFilleNames))
                {
                    plainText = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        private void decryption_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if ((bool)rb.IsChecked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                selectedRb = "Decryption";
            }
        }

        private void encryption_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if ((bool)rb.IsChecked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                selectedRb = "Encryption";
            }

        }
    }
}
