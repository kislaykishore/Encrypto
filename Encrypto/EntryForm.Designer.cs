namespace Encrypto
{
    partial class EntryForm
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
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_key_pair_gen = new System.Windows.Forms.Button();
            this.btn_digital_sig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(72, 23);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(111, 23);
            this.btn_encrypt.TabIndex = 0;
            this.btn_encrypt.Text = "Encrypt/Decrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_key_pair_gen
            // 
            this.btn_key_pair_gen.Location = new System.Drawing.Point(72, 64);
            this.btn_key_pair_gen.Name = "btn_key_pair_gen";
            this.btn_key_pair_gen.Size = new System.Drawing.Size(111, 23);
            this.btn_key_pair_gen.TabIndex = 1;
            this.btn_key_pair_gen.Text = "Generate Keys";
            this.btn_key_pair_gen.UseVisualStyleBackColor = true;
            this.btn_key_pair_gen.Click += new System.EventHandler(this.btn_key_pair_gen_Click);
            // 
            // btn_digital_sig
            // 
            this.btn_digital_sig.Location = new System.Drawing.Point(72, 107);
            this.btn_digital_sig.Name = "btn_digital_sig";
            this.btn_digital_sig.Size = new System.Drawing.Size(111, 23);
            this.btn_digital_sig.TabIndex = 2;
            this.btn_digital_sig.Text = "Digital Signature";
            this.btn_digital_sig.UseVisualStyleBackColor = true;
            this.btn_digital_sig.Visible = false;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_digital_sig);
            this.Controls.Add(this.btn_key_pair_gen);
            this.Controls.Add(this.btn_encrypt);
            this.Name = "EntryForm";
            this.Text = "Choose an action";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_key_pair_gen;
        private System.Windows.Forms.Button btn_digital_sig;
    }
}

