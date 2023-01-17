using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Parfonov_RE_21mp_LR7
{
    public partial class Form1 : Form
    {
        private byte[] aesKey;
        private byte[] aesIV;

        private byte[] tripleDesKey;
        private byte[] tripleDesIV;

        private Aes myAes = Aes.Create();
        private TripleDES my3Des = TripleDES.Create();
        public Form1()
        {
            InitializeComponent();
            comboBox_KeySize.Text = "128";
        }
        float shannon(byte[] data)
        {
            float[] dataCounter = new float[256];
            Array.Clear(dataCounter, 0, dataCounter.Length);
            float entropy = 0.0f;
            float dataLength = data.Length;

            foreach (byte b in data)
            {
                dataCounter[b]++;
            }

            foreach (float count in dataCounter)
            {
                float px = count / dataLength;

                if (px > 0)
                {
                    entropy -= px * (float)Math.Log(px, 2);
                }
            }

            return entropy / 8.0f;
        }

        private void b_In_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileInpath = openFileDialog.FileName;
                    text_In.Text = fileInpath;
                    if (File.Exists(fileInpath))
                    {
                        byte[] bytes = File.ReadAllBytes(fileInpath);
                        int fileInSize = bytes.Length;
                        label_InSize.Text = fileInSize + " б";

                        label_InEnthropy.Text = shannon(bytes).ToString();
                    }
                }
            }
        }

        private void b_Out_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileOutpath = openFileDialog.FileName;
                    text_Out.Text = fileOutpath;
                    label_OutSize.Text = "???";
                    label_OutEnthropy.Text = "???";
                }
            }
        }

        private void b_GenKey_Click(object sender, EventArgs e)
        {
            myAes.KeySize = Int16.Parse(comboBox_KeySize.Text);
            aesKey = myAes.Key;


            StringBuilder sb = new StringBuilder();
            foreach (byte b in aesKey)
            {
                sb.Append(b.ToString("0000"));
                sb.Append("-");
            }
            sb.Length--;
            textBox_Key.Text = sb.ToString();
        }

        private void b_GenBI_Click(object sender, EventArgs e)
        {
            myAes.GenerateIV();
            aesIV = myAes.IV;

            my3Des.GenerateIV();
            tripleDesIV = my3Des.IV;
            StringBuilder sb = new StringBuilder();

            if (radioButton_AES.Checked)
            {
                foreach (byte b in aesIV)
                {
                    sb.Append(b.ToString("0000"));
                    sb.Append("-");
                }
            }

            
            textBox_IV.Text = sb.ToString();
        }

        private void checkBox_IV0_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_IV0.Checked)
            {
                StringBuilder sb = new StringBuilder();
                if (radioButton_AES.Checked)
                {
                    b_GenBI.Enabled = false;
                    aesIV = new byte[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    foreach (byte b in aesIV)
                    {
                        sb.Append(b.ToString("0000"));
                        sb.Append("-");
                    }
                }

                textBox_IV.Text = sb.ToString();
            }
            else
            {
                b_GenBI.Enabled = true;
            }
        }

        private void radioButton_AES_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Key.Text = "";
            textBox_IV.Text = "";
            checkBox_IV0.Checked = false;
            comboBox_KeySize.Enabled = true;
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string fileSavePath = "";
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileSavePath = openFileDialog.FileName;
                }
                if (File.Exists(fileSavePath))
                {
                    File.WriteAllText(fileSavePath, textBox_Key + "\n" + textBox_IV.Text);
                    MessageBox.Show("Ключ збережено");
                }
            }
        }

        private void b_Load_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string fileLoadPath = "";
                openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileLoadPath = openFileDialog.FileName;
                }
                if (File.Exists(fileLoadPath))
                {
                    string loadText = File.ReadAllText(fileLoadPath);
                    string[] strings = loadText.Split('\n');
                    string[] key_s = strings[0].Split('-');
                    string[] IV_s = strings[1].Split('-');

                    byte[] newKey = new byte[key_s.Length];
                    int i = 0;
                    foreach (string s in key_s)
                    {
                        newKey[i++] = byte.Parse(s);
                    }
                    aesKey = newKey;

                    byte[] newIV = new byte[IV_s.Length];
                    i = 0;
                    foreach (string s in IV_s)
                    {
                        newIV[i++] = byte.Parse(s);
                    }
                    aesIV = newIV;

                    textBox_Key.Text = strings[0];
                    textBox_IV.Text = strings[1];
                    MessageBox.Show("Key: " + strings[0] + "\n" + "IV: " + strings[1]);
                }
            }
        }

        private void button_Encrypt_Click(object sender, EventArgs e)
        {
            string fileInPath = text_In.Text;
            string fileOutPath = text_Out.Text;
            if (File.Exists(fileInPath) && File.Exists(fileOutPath))
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                string inText = File.ReadAllText(fileInPath);

                byte[] encrypted = { 0 };
                if (radioButton_AES.Checked)
                {
                    encrypted = EncryptStringToBytes_Aes(inText, aesKey, aesIV);
                }

                int fileOutSize = encrypted.Length;
                label_OutSize.Text = fileOutSize + " б";
                label_OutEnthropy.Text = shannon(encrypted).ToString();
                File.WriteAllBytes(fileOutPath, encrypted);

                stopwatch.Stop();
                label_time.Text = stopwatch.Elapsed.ToString(@"mm\:ss\.fff");
            }
        }

        private void button_Dechipher_Click(object sender, EventArgs e)
        {
            string fileInPath = text_In.Text;
            string fileOutPath = text_Out.Text;
            if (File.Exists(fileInPath) && File.Exists(fileOutPath))
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                byte[] inBytes = File.ReadAllBytes(fileInPath);
                string plainText = "";
                try
                {
                    if (radioButton_AES.Checked)
                    {
                        plainText = DecryptStringFromBytes_Aes(inBytes, aesKey, aesIV);
                    }

                    File.WriteAllText(fileOutPath, plainText);
                }
                catch
                {
                    MessageBox.Show("Не вдалося розшифрувати файл");
                }

                stopwatch.Stop();
                label_time.Text = stopwatch.Elapsed.ToString(@"mm\:ss\.fff");
            }
        }
        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }
        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
    }

        
}
