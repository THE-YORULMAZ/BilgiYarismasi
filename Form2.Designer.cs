
namespace BilgiYarismasi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bnbasla = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnbasla
            // 
            this.bnbasla.BackColor = System.Drawing.Color.Transparent;
            this.bnbasla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnbasla.BackgroundImage")));
            this.bnbasla.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bnbasla.ForeColor = System.Drawing.Color.Black;
            this.bnbasla.Location = new System.Drawing.Point(105, 115);
            this.bnbasla.Name = "bnbasla";
            this.bnbasla.Size = new System.Drawing.Size(166, 30);
            this.bnbasla.TabIndex = 0;
            this.bnbasla.Text = "OYNA";
            this.bnbasla.UseVisualStyleBackColor = false;
            this.bnbasla.Click += new System.EventHandler(this.bnbasla_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncikis.BackgroundImage")));
            this.btncikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncikis.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.Location = new System.Drawing.Point(105, 217);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(166, 30);
            this.btncikis.TabIndex = 1;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = true;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 575);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.bnbasla);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnbasla;
        private System.Windows.Forms.Button btncikis;
    }
}