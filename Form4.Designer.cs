namespace ProiectCasaDeSchimbValutar
{
    partial class Form4
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
            this.incarcaDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incarcaDateToolStripMenuItem,
            this.imprimareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incarcaDateToolStripMenuItem
            // 
            this.incarcaDateToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.incarcaDateToolStripMenuItem.Name = "incarcaDateToolStripMenuItem";
            this.incarcaDateToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.incarcaDateToolStripMenuItem.Text = "&Incarca Date";
            this.incarcaDateToolStripMenuItem.Click += new System.EventHandler(this.incarcaDateToolStripMenuItem_Click);
            // 
            // imprimareToolStripMenuItem
            // 
            this.imprimareToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.imprimareToolStripMenuItem.Name = "imprimareToolStripMenuItem";
            this.imprimareToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.imprimareToolStripMenuItem.Text = "&Previzualizare";
            this.imprimareToolStripMenuItem.Click += new System.EventHandler(this.imprimareToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 423);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Referinta: 1 RON";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form4";
            this.Text = "Cursuri sub forma grafica";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form4_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incarcaDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimareToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}