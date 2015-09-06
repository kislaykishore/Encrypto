using Crypto;
using Encrypto.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypto
{
    public partial class KeyGenForm : Form
    {
        public KeyGenForm()
        {
            InitializeComponent();
        }

        private void btn_private_key_loc_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

        }

        private void btn_public_key_loc_Click(object sender, EventArgs e)
        {
            saveFileDialog2.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            txt_private_key.Text = saveFileDialog1.FileName;
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            txt_public_key.Text = saveFileDialog2.FileName;
        }

        private void GenerateKeyPair_Click(object sender, EventArgs e)
        {
            switch (GetMode())
            {
                case Algos.RSA:
                    var keyPair = RSACipher.GenerateKeyPair();
                    File.WriteAllText(txt_private_key.Text, keyPair.ToXmlString(true));
                    File.WriteAllText(txt_public_key.Text, keyPair.ToXmlString(false));
                    break;
                case Algos.AES:
                    var key = StringCipher.GenerateKey();
                    File.WriteAllText(txt_secret_key.Text, key);
                    break;
            }
            MessageBox.Show("Key Pair Generated");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetState();
        }

        private void ResetState()
        {
            // Hide all
            lb_secret_key.Hide();
            lb_pvt_key.Hide();
            lb_pub_key.Hide();
            txt_private_key.Hide();
            txt_public_key.Hide();
            txt_secret_key.Hide();
            btn_private_key_loc.Hide();
            btn_public_key_loc.Hide();
            btn_secret_key_loc.Hide();
            btn_generate_key.Hide();

            switch (GetMode())
            {
                case Algos.AES:
                    lb_secret_key.Show();
                    txt_secret_key.Show();
                    btn_secret_key_loc.Show();
                    btn_generate_key.Show();
                    break;
                case Algos.RSA:
                    lb_pub_key.Show();
                    lb_pvt_key.Show();
                    txt_public_key.Show();
                    txt_private_key.Show();
                    btn_private_key_loc.Show();
                    btn_public_key_loc.Show();
                    btn_generate_key.Show();
                    break;
            }

        }

        private Algos GetMode()
        {
            var text = cmb_algos.Text;
            return (Algos)Enum.Parse(typeof(Algos), text);
        }

        private void KeyPairGenForm_Load(object sender, EventArgs e)
        {
            foreach (var algo in Enum.GetNames(typeof(Algos)))
            {
                cmb_algos.Items.Add(algo);
            }
        }

        private void lb_secret_key_Click(object sender, EventArgs e)
        {
        }

        private void btn_secret_key_loc_Click(object sender, EventArgs e)
        {
            saveFileDialog3.ShowDialog();
        }

        private void saveFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            txt_secret_key.Text = saveFileDialog3.FileName;
        }
    }
}
