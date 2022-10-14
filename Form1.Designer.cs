
namespace BilgiYarismasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnbasla = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.labelBİR = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldogrucvp = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.lblsayac = new System.Windows.Forms.Label();
            this.lbldogru = new System.Windows.Forms.Label();
            this.lblyanlis = new System.Windows.Forms.Label();
            this.lblsoru = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.lblbos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbasla
            // 
            this.btnbasla.BackColor = System.Drawing.Color.White;
            this.btnbasla.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbasla.Location = new System.Drawing.Point(673, 434);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(177, 64);
            this.btnbasla.TabIndex = 0;
            this.btnbasla.Text = "BAŞLA";
            this.btnbasla.UseVisualStyleBackColor = false;
            this.btnbasla.Click += new System.EventHandler(this.btnbasla_Click);
            // 
            // textBox1
            // 
            this.textBox1.CausesValidation = false;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(204, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(446, 209);
            this.textBox1.TabIndex = 1;
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.White;
            this.btnA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnA.Location = new System.Drawing.Point(204, 239);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(130, 50);
            this.btnA.TabIndex = 2;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.White;
            this.btnC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnC.Location = new System.Drawing.Point(204, 326);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(130, 50);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.White;
            this.btnB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnB.Location = new System.Drawing.Point(520, 239);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(130, 50);
            this.btnB.TabIndex = 4;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.White;
            this.btnD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnD.Location = new System.Drawing.Point(520, 326);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(130, 50);
            this.btnD.TabIndex = 5;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // labelBİR
            // 
            this.labelBİR.AutoSize = true;
            this.labelBİR.BackColor = System.Drawing.Color.Transparent;
            this.labelBİR.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBİR.ForeColor = System.Drawing.Color.White;
            this.labelBİR.Location = new System.Drawing.Point(668, 9);
            this.labelBİR.Name = "labelBİR";
            this.labelBİR.Size = new System.Drawing.Size(56, 23);
            this.labelBİR.TabIndex = 6;
            this.labelBİR.Text = "SÜRE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(668, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "PUAN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "SORU:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "DOĞRU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "YANLIŞ:";
            // 
            // lbldogrucvp
            // 
            this.lbldogrucvp.AutoSize = true;
            this.lbldogrucvp.BackColor = System.Drawing.Color.Transparent;
            this.lbldogrucvp.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldogrucvp.ForeColor = System.Drawing.Color.White;
            this.lbldogrucvp.Location = new System.Drawing.Point(25, 457);
            this.lbldogrucvp.Name = "lbldogrucvp";
            this.lbldogrucvp.Size = new System.Drawing.Size(125, 23);
            this.lbldogrucvp.TabIndex = 11;
            this.lbldogrucvp.Text = "DOĞRU CEVAP";
            this.lbldogrucvp.Visible = false;
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.BackColor = System.Drawing.Color.Transparent;
            this.lblpuan.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpuan.ForeColor = System.Drawing.Color.White;
            this.lblpuan.Location = new System.Drawing.Point(735, 53);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(20, 23);
            this.lblpuan.TabIndex = 12;
            this.lblpuan.Text = "0";
            // 
            // lblsayac
            // 
            this.lblsayac.AutoSize = true;
            this.lblsayac.BackColor = System.Drawing.Color.Transparent;
            this.lblsayac.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsayac.ForeColor = System.Drawing.Color.White;
            this.lblsayac.Location = new System.Drawing.Point(735, 9);
            this.lblsayac.Name = "lblsayac";
            this.lblsayac.Size = new System.Drawing.Size(20, 23);
            this.lblsayac.TabIndex = 13;
            this.lblsayac.Text = "0";
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.BackColor = System.Drawing.Color.Transparent;
            this.lbldogru.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldogru.ForeColor = System.Drawing.Color.White;
            this.lbldogru.Location = new System.Drawing.Point(92, 83);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(20, 23);
            this.lbldogru.TabIndex = 14;
            this.lbldogru.Text = "0";
            // 
            // lblyanlis
            // 
            this.lblyanlis.AutoSize = true;
            this.lblyanlis.BackColor = System.Drawing.Color.Transparent;
            this.lblyanlis.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblyanlis.ForeColor = System.Drawing.Color.White;
            this.lblyanlis.Location = new System.Drawing.Point(92, 127);
            this.lblyanlis.Name = "lblyanlis";
            this.lblyanlis.Size = new System.Drawing.Size(20, 23);
            this.lblyanlis.TabIndex = 15;
            this.lblyanlis.Text = "0";
            // 
            // lblsoru
            // 
            this.lblsoru.AutoSize = true;
            this.lblsoru.BackColor = System.Drawing.Color.Transparent;
            this.lblsoru.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoru.ForeColor = System.Drawing.Color.White;
            this.lblsoru.Location = new System.Drawing.Point(78, 9);
            this.lblsoru.Name = "lblsoru";
            this.lblsoru.Size = new System.Drawing.Size(20, 23);
            this.lblsoru.TabIndex = 16;
            this.lblsoru.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "BOŞ:";
            // 
            // lblbos
            // 
            this.lblbos.AutoSize = true;
            this.lblbos.BackColor = System.Drawing.Color.Transparent;
            this.lblbos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbos.ForeColor = System.Drawing.Color.White;
            this.lblbos.Location = new System.Drawing.Point(92, 172);
            this.lblbos.Name = "lblbos";
            this.lblbos.Size = new System.Drawing.Size(20, 23);
            this.lblbos.TabIndex = 18;
            this.lblbos.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(862, 510);
            this.Controls.Add(this.lblbos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblsoru);
            this.Controls.Add(this.lblyanlis);
            this.Controls.Add(this.lbldogru);
            this.Controls.Add(this.lblsayac);
            this.Controls.Add(this.lblpuan);
            this.Controls.Add(this.lbldogrucvp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBİR);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnbasla);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "KİM KRUŞONER OLMAK İSTER ?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Label labelBİR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldogrucvp;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label lblsayac;
        private System.Windows.Forms.Label lbldogru;
        private System.Windows.Forms.Label lblyanlis;
        private System.Windows.Forms.Label lblsoru;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblbos;
    }
}

