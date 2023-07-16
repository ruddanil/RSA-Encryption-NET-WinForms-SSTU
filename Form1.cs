using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_Encryption_WinForms_SSTU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private string publicKeyServer;
        private string privateKeyServer;
        private string publicKeyClient;
        byte[] encryptedDataServer;
        private string filePathToSign;
        private string filePathToVerify;
        private string filePathDigitalSignature;

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Key Files (*.xml)|*.xml|Private Key Files (*.priv)|*.priv|Public Key Files (*.pub)|*.pub|All files (*.*)|*.*";
            saveFileDialog.Title = "Select a location to save the keys";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            publicKeyServer = rsa.ToXmlString(false);
            privateKeyServer = rsa.ToXmlString(true);

            File.WriteAllText(saveFileDialog.FileName + ".pub", publicKeyServer);
            textBoxPublicServer.Text = saveFileDialog.FileName + ".pub";

            File.WriteAllText(saveFileDialog.FileName + ".priv", privateKeyServer);
            textBoxPrivateServer.Text = saveFileDialog.FileName + ".priv";

            MessageBox.Show("Keys have been successfully created and saved");
        }

        private void buttonOpenPublicServer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Public Key Files (*.pub)|*.pub|XML Key Files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.Title = "Select the location of the public key";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            textBoxPublicServer.Text = openFileDialog.FileName;

            publicKeyServer = File.ReadAllText(openFileDialog.FileName);
        }

        private void buttonOpenPrivateServer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Private Key Files (*.priv)|*.priv|XML Key Files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.Title = "Select the location of the private key";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            textBoxPrivateServer.Text = openFileDialog.FileName;
            
            privateKeyServer = File.ReadAllText(openFileDialog.FileName);
        }

        private void buttonOpenFileForDecServer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Encrypted Text File (*.enc)|*.enc|All files (*.*)|*.*";
            openFileDialog.Title = "Select the file location to encrypt";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            richTextBoxTextForDecServer.Text = File.ReadAllText(openFileDialog.FileName);

            encryptedDataServer = File.ReadAllBytes(openFileDialog.FileName);
        }

        private void buttonStartDecServer_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(privateKeyServer);

            try
            {
                var decryptedBytes = rsa.Decrypt(encryptedDataServer, false);
                richTextBoxDecTextServer.Text = Encoding.Default.GetString(decryptedBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption error: \r\n" + ex);
            }
        }

        private void buttonOpenPublicClient_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Public Key Files (*.pub)|*.pub|XML Key Files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog.Title = "Select the location of the public key";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            textBoxPublicClient.Text = openFileDialog.FileName;

            publicKeyClient = File.ReadAllText(openFileDialog.FileName);
        }

        private void buttonOpenFileForEncClient_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Select the file location to decrypt";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            richTextBoxTextForEncClient.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void buttonStartEncServer_Click(object sender, EventArgs e)
        {
            if (publicKeyClient == null)
            {
                MessageBox.Show("No public key found");
                return;
            }

            byte[] dataToEncrypt = Encoding.Default.GetBytes(richTextBoxTextForEncClient.Text);

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(publicKeyClient);
            byte[] encryptedData = rsa.Encrypt(dataToEncrypt, false);

            richTextBoxEncTextClient.Text = Encoding.Default.GetString(encryptedData);

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Encrypted Text File (*.enc)|*.enc";
            saveFileDialog.Title = "Save Encrypted Text";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog.FileName, encryptedData);
                MessageBox.Show("Encrypted text saved successfully.");
            }
        }

        private void buttonOpenFileForSignServer_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Select the file location to sign";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            filePathToSign = openFileDialog.FileName;
        }

        private void buttonStartSignServer_Click(object sender, EventArgs e)
        {
            if (privateKeyServer == null)
            {
                MessageBox.Show("No private server key found");
                return;
            }

            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(privateKeyServer);

                var data = File.ReadAllBytes(filePathToSign);

                var signature = rsa.SignData(data, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

                var signatureFilePath = Path.ChangeExtension(filePathToSign, ".sig");

                File.WriteAllBytes(signatureFilePath, signature);
            }

            MessageBox.Show("File signed successfully.");
        }

        private void buttonOpenFileForSignClient_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Select the file location to verify digital signature";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            filePathToVerify = openFileDialog.FileName;
        }

        private void buttonOpenSignClient_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Signature files (*.sig)|*.sig|All files (*.*)|*.*";
            openFileDialog.Title = "Select the signature file location";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            filePathDigitalSignature = openFileDialog.FileName;
        }

        private void buttonStartVerifyClient_Click(object sender, EventArgs e)
        {
            if (publicKeyClient == null)
            {
                MessageBox.Show("No public server key found");
                return;
            }

            using (var rsa = new RSACryptoServiceProvider())
            {
                rsa.FromXmlString(publicKeyClient);

                var data = File.ReadAllBytes(filePathToVerify);

                var signature = File.ReadAllBytes(filePathDigitalSignature);

                var verified = rsa.VerifyData(data, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

                if (verified)
                {
                    MessageBox.Show("The digital signature is valid.");
                }
                else
                {
                    MessageBox.Show("The digital signature is invalid. The file may have been tampered with.");
                }
            }
        }
    }
}
