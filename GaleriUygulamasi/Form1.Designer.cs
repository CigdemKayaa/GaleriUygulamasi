namespace GaleriUygulamasi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAc = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDosya});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuDosya
            // 
            this.MenuDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAc,
            this.MenuKaydet,
            this.toolStripMenuItem1,
            this.MenuEkle,
            this.toolStripMenuItem2,
            this.MenuCikis});
            this.MenuDosya.Name = "MenuDosya";
            this.MenuDosya.Size = new System.Drawing.Size(51, 20);
            this.MenuDosya.Text = "Dosya";
            // 
            // MenuAc
            // 
            this.MenuAc.Name = "MenuAc";
            this.MenuAc.Size = new System.Drawing.Size(180, 22);
            this.MenuAc.Text = "Aç";
            this.MenuAc.Click += new System.EventHandler(this.MenuAc_Click);
            // 
            // MenuKaydet
            // 
            this.MenuKaydet.Name = "MenuKaydet";
            this.MenuKaydet.Size = new System.Drawing.Size(180, 22);
            this.MenuKaydet.Text = "Kaydet";
            this.MenuKaydet.Click += new System.EventHandler(this.MenuKaydet_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuEkle
            // 
            this.MenuEkle.Name = "MenuEkle";
            this.MenuEkle.Size = new System.Drawing.Size(180, 22);
            this.MenuEkle.Text = "Ekle";
            this.MenuEkle.Click += new System.EventHandler(this.MenuEkle_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuCikis
            // 
            this.MenuCikis.Name = "MenuCikis";
            this.MenuCikis.Size = new System.Drawing.Size(180, 22);
            this.MenuCikis.Text = "Çıkış";
            this.MenuCikis.Click += new System.EventHandler(this.MenuCikis_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 426);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuDosya;
        private System.Windows.Forms.ToolStripMenuItem MenuAc;
        private System.Windows.Forms.ToolStripMenuItem MenuKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuEkle;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuCikis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

