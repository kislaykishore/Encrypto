using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            new EncryptionForm().Show();
        }

        private void btn_key_pair_gen_Click(object sender, EventArgs e)
        {
            new KeyGenForm().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
