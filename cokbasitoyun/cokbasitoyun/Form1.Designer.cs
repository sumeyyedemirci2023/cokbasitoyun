namespace cokbasitoyun
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblYanlis = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.btnCevap = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(103, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(273, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "=";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(228, 83);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(47, 13);
            this.lblDogru.TabIndex = 4;
            this.lblDogru.Text = "DOĞRU";
            // 
            // lblYanlis
            // 
            this.lblYanlis.AutoSize = true;
            this.lblYanlis.Location = new System.Drawing.Point(314, 83);
            this.lblYanlis.Name = "lblYanlis";
            this.lblYanlis.Size = new System.Drawing.Size(45, 13);
            this.lblYanlis.TabIndex = 5;
            this.lblYanlis.Text = "YANLIŞ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(534, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 108);
            this.listBox1.TabIndex = 6;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(152, 18);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 7;
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(12, 18);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 8;
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(317, 18);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(100, 20);
            this.txtCevap.TabIndex = 9;
            // 
            // btnCevap
            // 
            this.btnCevap.Location = new System.Drawing.Point(437, 15);
            this.btnCevap.Name = "btnCevap";
            this.btnCevap.Size = new System.Drawing.Size(75, 23);
            this.btnCevap.TabIndex = 10;
            this.btnCevap.Text = "Cevap ver";
            this.btnCevap.UseVisualStyleBackColor = true;
            this.btnCevap.Click += new System.EventHandler(this.btnCevapVer_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(37, 73);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 11;
            this.btnYeni.Text = "Yeni Sor";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(158, 83);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(35, 13);
            this.lblMesaj.TabIndex = 12;
            this.lblMesaj.Text = "Mesaj";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 142);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnCevap);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblYanlis);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblYanlis;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Button btnCevap;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label lblMesaj;
    }
}

