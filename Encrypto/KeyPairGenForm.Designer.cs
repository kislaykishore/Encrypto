namespace Encrypto
{
    partial class KeyPairGenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_private_key = new System.Windows.Forms.TextBox();
            this.txt_public_key = new System.Windows.Forms.TextBox();
            this.btn_public_key_loc = new System.Windows.Forms.Button();
            this.btn_private_key_loc = new System.Windows.Forms.Button();
            this.lb_pvt_key = new System.Windows.Forms.Label();
            this.lb_pub_key = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.btn_generate_key = new System.Windows.Forms.Button();
            this.cmb_algos = new System.Windows.Forms.ComboBox();
            this.lb_algorithm = new System.Windows.Forms.Label();
            this.lb_secret_key = new System.Windows.Forms.Label();
            this.txt_secret_key = new System.Windows.Forms.TextBox();
            this.btn_secret_key_loc = new System.Windows.Forms.Button();
            this.saveFileDialog3 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txt_private_key
            // 
            this.txt_private_key.Enabled = false;
            this.txt_private_key.Location = new System.Drawing.Point(99, 50);
            this.txt_private_key.Name = "txt_private_key";
            this.txt_private_key.Size = new System.Drawing.Size(100, 20);
            this.txt_private_key.TabIndex = 0;
            this.txt_private_key.Visible = false;
            // 
            // txt_public_key
            // 
            this.txt_public_key.Enabled = false;
            this.txt_public_key.Location = new System.Drawing.Point(99, 104);
            this.txt_public_key.Name = "txt_public_key";
            this.txt_public_key.Size = new System.Drawing.Size(100, 20);
            this.txt_public_key.TabIndex = 1;
            this.txt_public_key.Visible = false;
            // 
            // btn_public_key_loc
            // 
            this.btn_public_key_loc.Location = new System.Drawing.Point(222, 101);
            this.btn_public_key_loc.Name = "btn_public_key_loc";
            this.btn_public_key_loc.Size = new System.Drawing.Size(75, 23);
            this.btn_public_key_loc.TabIndex = 2;
            this.btn_public_key_loc.Text = "Browse";
            this.btn_public_key_loc.UseVisualStyleBackColor = true;
            this.btn_public_key_loc.Visible = false;
            this.btn_public_key_loc.Click += new System.EventHandler(this.btn_public_key_loc_Click);
            // 
            // btn_private_key_loc
            // 
            this.btn_private_key_loc.Location = new System.Drawing.Point(222, 47);
            this.btn_private_key_loc.Name = "btn_private_key_loc";
            this.btn_private_key_loc.Size = new System.Drawing.Size(75, 23);
            this.btn_private_key_loc.TabIndex = 3;
            this.btn_private_key_loc.Text = "Browse";
            this.btn_private_key_loc.UseVisualStyleBackColor = true;
            this.btn_private_key_loc.Visible = false;
            this.btn_private_key_loc.Click += new System.EventHandler(this.btn_private_key_loc_Click);
            // 
            // lb_pvt_key
            // 
            this.lb_pvt_key.AutoSize = true;
            this.lb_pvt_key.Location = new System.Drawing.Point(4, 58);
            this.lb_pvt_key.Name = "lb_pvt_key";
            this.lb_pvt_key.Size = new System.Drawing.Size(86, 13);
            this.lb_pvt_key.TabIndex = 4;
            this.lb_pvt_key.Text = "Private Key Path";
            this.lb_pvt_key.Visible = false;
            // 
            // lb_pub_key
            // 
            this.lb_pub_key.AutoSize = true;
            this.lb_pub_key.Location = new System.Drawing.Point(4, 111);
            this.lb_pub_key.Name = "lb_pub_key";
            this.lb_pub_key.Size = new System.Drawing.Size(82, 13);
            this.lb_pub_key.TabIndex = 5;
            this.lb_pub_key.Text = "Public Key Path";
            this.lb_pub_key.Visible = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // btn_generate_key
            // 
            this.btn_generate_key.Location = new System.Drawing.Point(82, 152);
            this.btn_generate_key.Name = "btn_generate_key";
            this.btn_generate_key.Size = new System.Drawing.Size(117, 23);
            this.btn_generate_key.TabIndex = 6;
            this.btn_generate_key.Text = "Generate Key";
            this.btn_generate_key.UseVisualStyleBackColor = true;
            this.btn_generate_key.Visible = false;
            this.btn_generate_key.Click += new System.EventHandler(this.GenerateKeyPair_Click);
            // 
            // cmb_algos
            // 
            this.cmb_algos.FormattingEnabled = true;
            this.cmb_algos.Location = new System.Drawing.Point(94, 10);
            this.cmb_algos.Name = "cmb_algos";
            this.cmb_algos.Size = new System.Drawing.Size(100, 21);
            this.cmb_algos.TabIndex = 7;
            this.cmb_algos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lb_algorithm
            // 
            this.lb_algorithm.AutoSize = true;
            this.lb_algorithm.Location = new System.Drawing.Point(7, 13);
            this.lb_algorithm.Name = "lb_algorithm";
            this.lb_algorithm.Size = new System.Drawing.Size(50, 13);
            this.lb_algorithm.TabIndex = 8;
            this.lb_algorithm.Text = "Algorithm";
            // 
            // lb_secret_key
            // 
            this.lb_secret_key.AutoSize = true;
            this.lb_secret_key.Location = new System.Drawing.Point(4, 57);
            this.lb_secret_key.Name = "lb_secret_key";
            this.lb_secret_key.Size = new System.Drawing.Size(84, 13);
            this.lb_secret_key.TabIndex = 9;
            this.lb_secret_key.Text = "Secret Key Path";
            this.lb_secret_key.Click += new System.EventHandler(this.lb_secret_key_Click);
            // 
            // txt_secret_key
            // 
            this.txt_secret_key.Enabled = false;
            this.txt_secret_key.Location = new System.Drawing.Point(99, 50);
            this.txt_secret_key.Name = "txt_secret_key";
            this.txt_secret_key.Size = new System.Drawing.Size(100, 20);
            this.txt_secret_key.TabIndex = 10;
            this.txt_secret_key.Visible = false;
            // 
            // btn_secret_key_loc
            // 
            this.btn_secret_key_loc.Location = new System.Drawing.Point(222, 47);
            this.btn_secret_key_loc.Name = "btn_secret_key_loc";
            this.btn_secret_key_loc.Size = new System.Drawing.Size(75, 23);
            this.btn_secret_key_loc.TabIndex = 11;
            this.btn_secret_key_loc.Text = "Browse";
            this.btn_secret_key_loc.UseVisualStyleBackColor = true;
            this.btn_secret_key_loc.Visible = false;
            this.btn_secret_key_loc.Click += new System.EventHandler(this.btn_secret_key_loc_Click);
            // 
            // saveFileDialog3
            // 
            this.saveFileDialog3.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog3_FileOk);
            // 
            // KeyPairGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 262);
            this.Controls.Add(this.btn_secret_key_loc);
            this.Controls.Add(this.txt_secret_key);
            this.Controls.Add(this.lb_secret_key);
            this.Controls.Add(this.lb_algorithm);
            this.Controls.Add(this.cmb_algos);
            this.Controls.Add(this.btn_generate_key);
            this.Controls.Add(this.lb_pub_key);
            this.Controls.Add(this.lb_pvt_key);
            this.Controls.Add(this.btn_private_key_loc);
            this.Controls.Add(this.btn_public_key_loc);
            this.Controls.Add(this.txt_public_key);
            this.Controls.Add(this.txt_private_key);
            this.Name = "KeyPairGenForm";
            this.Text = "KeyPairGenForm";
            this.Load += new System.EventHandler(this.KeyPairGenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_private_key;
        private System.Windows.Forms.TextBox txt_public_key;
        private System.Windows.Forms.Button btn_public_key_loc;
        private System.Windows.Forms.Button btn_private_key_loc;
        private System.Windows.Forms.Label lb_pvt_key;
        private System.Windows.Forms.Label lb_pub_key;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Button btn_generate_key;
        private System.Windows.Forms.ComboBox cmb_algos;
        private System.Windows.Forms.Label lb_algorithm;
        private System.Windows.Forms.Label lb_secret_key;
        private System.Windows.Forms.TextBox txt_secret_key;
        private System.Windows.Forms.Button btn_secret_key_loc;
        private System.Windows.Forms.SaveFileDialog saveFileDialog3;
    }
}