namespace Encrypto
{
    partial class EncryptionForm
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
            this.cmb_algos = new System.Windows.Forms.ComboBox();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txt_open_file = new System.Windows.Forms.TextBox();
            this.btn_open_file = new System.Windows.Forms.Button();
            this.txt_save_file = new System.Windows.Forms.TextBox();
            this.btn_save_file = new System.Windows.Forms.Button();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_secret_key = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radio_encrypt = new System.Windows.Forms.RadioButton();
            this.radio_decrypt = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_key_path = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.txt_key_location = new System.Windows.Forms.TextBox();
            this.btn_key_file = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_algos
            // 
            this.cmb_algos.FormattingEnabled = true;
            this.cmb_algos.Location = new System.Drawing.Point(108, 12);
            this.cmb_algos.Name = "cmb_algos";
            this.cmb_algos.Size = new System.Drawing.Size(100, 21);
            this.cmb_algos.TabIndex = 0;
            this.cmb_algos.SelectedIndexChanged += new System.EventHandler(this.cmb_algos_SelectedIndexChanged);
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(108, 76);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(100, 20);
            this.txt_key.TabIndex = 1;
            this.txt_key.UseSystemPasswordChar = true;
            this.txt_key.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // txt_open_file
            // 
            this.txt_open_file.Enabled = false;
            this.txt_open_file.Location = new System.Drawing.Point(108, 125);
            this.txt_open_file.Name = "txt_open_file";
            this.txt_open_file.Size = new System.Drawing.Size(100, 20);
            this.txt_open_file.TabIndex = 2;
            // 
            // btn_open_file
            // 
            this.btn_open_file.Location = new System.Drawing.Point(251, 122);
            this.btn_open_file.Name = "btn_open_file";
            this.btn_open_file.Size = new System.Drawing.Size(75, 23);
            this.btn_open_file.TabIndex = 3;
            this.btn_open_file.Text = "Browse";
            this.btn_open_file.UseVisualStyleBackColor = true;
            this.btn_open_file.Click += new System.EventHandler(this.btn_open_file_Click);
            // 
            // txt_save_file
            // 
            this.txt_save_file.Enabled = false;
            this.txt_save_file.Location = new System.Drawing.Point(108, 172);
            this.txt_save_file.Name = "txt_save_file";
            this.txt_save_file.Size = new System.Drawing.Size(100, 20);
            this.txt_save_file.TabIndex = 4;
            // 
            // btn_save_file
            // 
            this.btn_save_file.Location = new System.Drawing.Point(251, 169);
            this.btn_save_file.Name = "btn_save_file";
            this.btn_save_file.Size = new System.Drawing.Size(75, 23);
            this.btn_save_file.TabIndex = 5;
            this.btn_save_file.Text = "Browse";
            this.btn_save_file.UseVisualStyleBackColor = true;
            this.btn_save_file.Click += new System.EventHandler(this.btn_save_file_Click);
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(154, 227);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_encrypt.TabIndex = 6;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Visible = false;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(154, 227);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_decrypt.TabIndex = 7;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Visible = false;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Algorithm";
            // 
            // lb_secret_key
            // 
            this.lb_secret_key.AutoSize = true;
            this.lb_secret_key.Location = new System.Drawing.Point(12, 83);
            this.lb_secret_key.Name = "lb_secret_key";
            this.lb_secret_key.Size = new System.Drawing.Size(59, 13);
            this.lb_secret_key.TabIndex = 9;
            this.lb_secret_key.Text = "Secret Key";
            this.lb_secret_key.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Input File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Output File";
            // 
            // radio_encrypt
            // 
            this.radio_encrypt.AutoSize = true;
            this.radio_encrypt.Location = new System.Drawing.Point(21, 14);
            this.radio_encrypt.Name = "radio_encrypt";
            this.radio_encrypt.Size = new System.Drawing.Size(61, 17);
            this.radio_encrypt.TabIndex = 12;
            this.radio_encrypt.TabStop = true;
            this.radio_encrypt.Text = "Encrypt";
            this.radio_encrypt.UseVisualStyleBackColor = true;
            this.radio_encrypt.CheckedChanged += new System.EventHandler(this.radio_encrypt_CheckedChanged);
            // 
            // radio_decrypt
            // 
            this.radio_decrypt.AutoSize = true;
            this.radio_decrypt.Location = new System.Drawing.Point(88, 14);
            this.radio_decrypt.Name = "radio_decrypt";
            this.radio_decrypt.Size = new System.Drawing.Size(62, 17);
            this.radio_decrypt.TabIndex = 13;
            this.radio_decrypt.TabStop = true;
            this.radio_decrypt.Text = "Decrypt";
            this.radio_decrypt.UseVisualStyleBackColor = true;
            this.radio_decrypt.CheckedChanged += new System.EventHandler(this.radio_decrypt_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_encrypt);
            this.groupBox1.Controls.Add(this.radio_decrypt);
            this.groupBox1.Location = new System.Drawing.Point(16, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 31);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lb_key_path
            // 
            this.lb_key_path.AutoSize = true;
            this.lb_key_path.Location = new System.Drawing.Point(13, 82);
            this.lb_key_path.Name = "lb_key_path";
            this.lb_key_path.Size = new System.Drawing.Size(50, 13);
            this.lb_key_path.TabIndex = 15;
            this.lb_key_path.Text = "Key Path";
            this.lb_key_path.Visible = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // txt_key_location
            // 
            this.txt_key_location.Location = new System.Drawing.Point(108, 76);
            this.txt_key_location.Name = "txt_key_location";
            this.txt_key_location.Size = new System.Drawing.Size(100, 20);
            this.txt_key_location.TabIndex = 16;
            this.txt_key_location.Visible = false;
            this.txt_key_location.TextChanged += new System.EventHandler(this.txt_key_location_TextChanged);
            // 
            // btn_key_file
            // 
            this.btn_key_file.Location = new System.Drawing.Point(251, 72);
            this.btn_key_file.Name = "btn_key_file";
            this.btn_key_file.Size = new System.Drawing.Size(75, 23);
            this.btn_key_file.TabIndex = 17;
            this.btn_key_file.Text = "Browse";
            this.btn_key_file.UseVisualStyleBackColor = true;
            this.btn_key_file.Visible = false;
            this.btn_key_file.Click += new System.EventHandler(this.btn_key_file_Click);
            // 
            // EncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 262);
            this.Controls.Add(this.btn_key_file);
            this.Controls.Add(this.txt_key_location);
            this.Controls.Add(this.lb_key_path);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_secret_key);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.btn_save_file);
            this.Controls.Add(this.txt_save_file);
            this.Controls.Add(this.btn_open_file);
            this.Controls.Add(this.txt_open_file);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.cmb_algos);
            this.Name = "EncryptionForm";
            this.Text = "EncryptionForm";
            this.Load += new System.EventHandler(this.EncryptionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_algos;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txt_open_file;
        private System.Windows.Forms.Button btn_open_file;
        private System.Windows.Forms.TextBox txt_save_file;
        private System.Windows.Forms.Button btn_save_file;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_secret_key;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radio_encrypt;
        private System.Windows.Forms.RadioButton radio_decrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_key_path;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox txt_key_location;
        private System.Windows.Forms.Button btn_key_file;
    }
}