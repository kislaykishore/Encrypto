using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encrypto.Common;
using System.IO;
using Crypto;

namespace Encrypto
{
    public partial class EncryptionForm : Form
    {
        public EncryptionForm()
        {
            InitializeComponent();
            openFileDialog1.Multiselect = false;
        }

        private void EncryptionForm_Load(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = false;
            foreach (var algo in Enum.GetNames(typeof(Algos)))
            {
                cmb_algos.Items.Add(algo);
            }
        }

        private void cmb_algos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetState();
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (!e.Cancel)
            {
                txt_open_file.Text = openFileDialog1.FileName;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (!e.Cancel)
            {
                txt_save_file.Text = saveFileDialog1.FileName;
            }
        }

        private void btn_open_file_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            IList<string> messages;
            if (Validate(out messages))
            {
                Encrypt();
                txt_key.Text = "";
            }
            else {
                MessageBox.Show(string.Join(", ", messages));
            }

        }

        private void Encrypt()
        {
            
            string cipher = null;
            var mode = GetMode();
            switch (mode)
            {
                case Algos.AES:
                    string text = File.ReadAllText(txt_open_file.Text);
                    cipher = StringCipher.Encrypt(text, txt_key.Text);
                    File.WriteAllText(txt_save_file.Text, cipher);
                    break;
                case Algos.RSA:
                    byte[] bytes = File.ReadAllBytes(txt_open_file.Text);
                    string key = File.ReadAllText(txt_key_location.Text);
                    byte[] cipherBytes = RSACipher.Encrypt(bytes, key);
                    File.WriteAllBytes(txt_save_file.Text, cipherBytes);
                    break;

            }
            MessageBox.Show("Encryption done");
        }

        private void Decrypt()
        {
            var mode = GetMode();
            switch (mode)
            {
                case Algos.AES:
                    string cipher = File.ReadAllText(txt_open_file.Text);
                    string plain_text = StringCipher.Decrypt(cipher, txt_key.Text);
                    File.WriteAllText(txt_save_file.Text, plain_text);
                    break;
                case Algos.RSA:
                    byte[] cipherBytes = File.ReadAllBytes(txt_open_file.Text);
                    string key = File.ReadAllText(txt_key_location.Text);
                    byte[] plainBytes = RSACipher.Decrypt(cipherBytes, key);
                    File.WriteAllBytes(txt_save_file.Text, plainBytes);
                    break;

            }
            MessageBox.Show("Decryption done");
        }

        private Algos GetMode()
        {
            var selectedText = this.cmb_algos.Text;
            var algo = (Algos)Enum.Parse(typeof(Algos), selectedText);
            return algo;
        }

        private bool Validate(out IList<string> messages)
        {
            messages = new List<string>();
            var algo = GetMode();
            switch (algo)
            {
                case Algos.RSA:
                    if (!File.Exists(txt_key_location.Text))
                    {
                        messages.Add("Key file location is not correct");
                    }
                    break;
                case Algos.AES:
                    if (string.IsNullOrEmpty(txt_key.Text))
                    {
                        messages.Add("Key shouldn't be empty");
                    }
                    break;
            }

            
            if (!File.Exists(txt_open_file.Text))
            {
                messages.Add("Invalid input file");
            }
            if (string.IsNullOrWhiteSpace(txt_save_file.Text))
            {
                messages.Add("Output file has not been specified");
            }
            if (messages.Count != 0)
            {
                return false;
            }
            return true;
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            IList<string> messages;
            if (Validate(out messages))
            {
                Decrypt();
                txt_key.Text = "";
            }
            else
            {
                MessageBox.Show(string.Join(", ", messages));
            }

        }

        private void btn_save_file_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void radio_encrypt_CheckedChanged(object sender, EventArgs e)
        {
            ResetState();
        }

        private void ResetState()
        {
            // Hide all
            txt_key_location.Hide();
            txt_key.Hide();

            lb_key_path.Hide();
            lb_secret_key.Hide();

            btn_encrypt.Hide();
            btn_decrypt.Hide();
            btn_key_file.Hide();

            var selectedText = this.cmb_algos.Text;
            if (!string.IsNullOrWhiteSpace(selectedText))
            {
                var algo = GetMode();
                switch (algo)
                {
                    case Algos.AES:
                        // Hide all
                        // Show only the needed controls
                        lb_secret_key.Show();
                        txt_key.Show();
                        break;
                    case Algos.RSA:
                        // Hide all
                        // Show only needed control
                        if(radio_decrypt.Checked || radio_encrypt.Checked)
                        {
                            txt_key_location.Show();
                            btn_key_file.Show();
                        }
                        if (radio_encrypt.Checked)
                        {
                            lb_key_path.Text = "Public Key Path";
                            txt_key_location.Show();
                            lb_key_path.Show();
                            btn_encrypt.Show();
                        }
                        if (radio_decrypt.Checked)
                        {
                            lb_key_path.Text = "Private Key Path";
                            txt_key_location.Show();
                            lb_key_path.Show();
                        }
                        break;
                }
                if (radio_encrypt.Checked)
                {
                    btn_encrypt.Show();
                }
                if (radio_decrypt.Checked)
                {
                    btn_decrypt.Show();
                }
            }
        }

        private void radio_decrypt_CheckedChanged(object sender, EventArgs e)
        {
            ResetState();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            txt_key_location.Text = openFileDialog2.FileName;
        }

        private void btn_key_file_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void txt_key_location_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
