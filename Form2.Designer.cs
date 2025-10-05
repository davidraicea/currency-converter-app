namespace ProiectCasaDeSchimbValutar
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veziInListViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendar1 = new calendar.calendar();
            this.stergeDateDinZiuaSelectataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(800, 450);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem,
            this.veziInListViewToolStripMenuItem,
            this.stergeDateDinZiuaSelectataToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // veziInListViewToolStripMenuItem
            // 
            this.veziInListViewToolStripMenuItem.Name = "veziInListViewToolStripMenuItem";
            this.veziInListViewToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.veziInListViewToolStripMenuItem.Text = "Istoric (BD)";
            this.veziInListViewToolStripMenuItem.Click += new System.EventHandler(this.veziInListViewToolStripMenuItem_Click);
            // 
            // calendar1
            // 
            this.calendar1.Location = new System.Drawing.Point(566, 0);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(234, 223);
            this.calendar1.TabIndex = 1;
            // 
            // stergeDateDinZiuaSelectataToolStripMenuItem
            // 
            this.stergeDateDinZiuaSelectataToolStripMenuItem.Name = "stergeDateDinZiuaSelectataToolStripMenuItem";
            this.stergeDateDinZiuaSelectataToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.stergeDateDinZiuaSelectataToolStripMenuItem.Text = "Sterge date din ziua selectata";
            this.stergeDateDinZiuaSelectataToolStripMenuItem.Click += new System.EventHandler(this.stergeDateDinZiuaSelectataToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calendar1);
            this.Controls.Add(this.textBox1);
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Istoric";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veziInListViewToolStripMenuItem;
        private calendar.calendar calendar1;
        private System.Windows.Forms.ToolStripMenuItem stergeDateDinZiuaSelectataToolStripMenuItem;
    }
}