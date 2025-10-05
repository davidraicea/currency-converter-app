namespace ProiectCasaDeSchimbValutar
{
    partial class FormPrincipal
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
            this.casaDeSchimbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aranjareFerestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.casaDeSchimbToolStripMenuItem,
            this.aranjareFerestreToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // casaDeSchimbToolStripMenuItem
            // 
            this.casaDeSchimbToolStripMenuItem.Name = "casaDeSchimbToolStripMenuItem";
            this.casaDeSchimbToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.casaDeSchimbToolStripMenuItem.Text = "&Casa de schimb";
            this.casaDeSchimbToolStripMenuItem.Click += new System.EventHandler(this.casaDeSchimbToolStripMenuItem_Click);
            // 
            // aranjareFerestreToolStripMenuItem
            // 
            this.aranjareFerestreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.orizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.aranjareFerestreToolStripMenuItem.Name = "aranjareFerestreToolStripMenuItem";
            this.aranjareFerestreToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.aranjareFerestreToolStripMenuItem.Text = "&Aranjare ferestre";
            this.aranjareFerestreToolStripMenuItem.Click += new System.EventHandler(this.aranjareFerestreToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cascadeToolStripMenuItem.Text = "Cascada";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // orizontalToolStripMenuItem
            // 
            this.orizontalToolStripMenuItem.Name = "orizontalToolStripMenuItem";
            this.orizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.orizontalToolStripMenuItem.Text = "Orizontal";
            this.orizontalToolStripMenuItem.Click += new System.EventHandler(this.orizontalToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Meniu Principal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrincipal_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem casaDeSchimbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aranjareFerestreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}