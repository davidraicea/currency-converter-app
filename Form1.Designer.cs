namespace ProiectCasaDeSchimbValutar
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbValoare = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valoare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valuta initiala:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valuta finala:";
            // 
            // tbValoare
            // 
            this.tbValoare.Location = new System.Drawing.Point(207, 71);
            this.tbValoare.Name = "tbValoare";
            this.tbValoare.Size = new System.Drawing.Size(111, 20);
            this.tbValoare.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbValoare, "Introduceti valoarea pe care doriti sa o schimbati");
            this.tbValoare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValoare_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AED",
            "AUD",
            "BGN",
            "BRL",
            "CAD",
            "CHF",
            "CNY",
            "CZK",
            "DKK",
            "EGP",
            "EUR",
            "GBP",
            "HUF",
            "INR",
            "JPY",
            "KRW",
            "MDL",
            "MXN",
            "NOK",
            "NZD",
            "PLN",
            "RON",
            "RSD",
            "RUB",
            "SEK",
            "THB",
            "TRY",
            "UAH",
            "USD",
            "XAU",
            "XDR",
            "ZAR"});
            this.comboBox1.Location = new System.Drawing.Point(207, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "AED",
            "AUD",
            "BGN",
            "BRL",
            "CAD",
            "CHF",
            "CNY",
            "CZK",
            "DKK",
            "EGP",
            "EUR",
            "GBP",
            "HUF",
            "INR",
            "JPY",
            "KRW",
            "MDL",
            "MXN",
            "NOK",
            "NZD",
            "PLN",
            "RON",
            "RSD",
            "RUB",
            "SEK",
            "THB",
            "TRY",
            "UAH",
            "USD",
            "XAU",
            "XDR",
            "ZAR"});
            this.comboBox2.Location = new System.Drawing.Point(207, 195);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(111, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(18, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 75);
            this.button1.TabIndex = 6;
            this.button1.Text = "Efectueaza schimb!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.istoricToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareFisierTextToolStripMenuItem,
            this.restaurareFisierTextToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // salvareFisierTextToolStripMenuItem
            // 
            this.salvareFisierTextToolStripMenuItem.Name = "salvareFisierTextToolStripMenuItem";
            this.salvareFisierTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvareFisierTextToolStripMenuItem.Text = "Salvare fisier text";
            this.salvareFisierTextToolStripMenuItem.Click += new System.EventHandler(this.salvareFisierTextToolStripMenuItem_Click);
            // 
            // restaurareFisierTextToolStripMenuItem
            // 
            this.restaurareFisierTextToolStripMenuItem.Name = "restaurareFisierTextToolStripMenuItem";
            this.restaurareFisierTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaurareFisierTextToolStripMenuItem.Text = "Restaurare fisier text";
            this.restaurareFisierTextToolStripMenuItem.Click += new System.EventHandler(this.restaurareFisierTextToolStripMenuItem_Click);
            // 
            // istoricToolStripMenuItem
            // 
            this.istoricToolStripMenuItem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.istoricToolStripMenuItem.Name = "istoricToolStripMenuItem";
            this.istoricToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.istoricToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.istoricToolStripMenuItem.Text = "&Istoric Tranzactii";
            this.istoricToolStripMenuItem.Click += new System.EventHandler(this.istoricToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(18, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 75);
            this.button2.TabIndex = 8;
            this.button2.Text = "&Vezi cursuri valutare";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbValoare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Schimb valutar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbValoare;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istoricToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
    }
}

