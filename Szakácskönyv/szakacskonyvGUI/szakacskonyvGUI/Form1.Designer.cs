namespace szakacskonyvGUI
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
            this.txKereses = new System.Windows.Forms.TextBox();
            this.dagi = new System.Windows.Forms.DataGridView();
            this.etelnev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elkeszitesiido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alapanyagnev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyegyseg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leiras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dagi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keresés";
            // 
            // txKereses
            // 
            this.txKereses.Location = new System.Drawing.Point(70, 17);
            this.txKereses.Name = "txKereses";
            this.txKereses.Size = new System.Drawing.Size(304, 20);
            this.txKereses.TabIndex = 1;
            this.txKereses.TextChanged += new System.EventHandler(this.txKereses_TextChanged);
            // 
            // dagi
            // 
            this.dagi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dagi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.etelnev,
            this.elkeszitesiido,
            this.kategoria,
            this.alapanyagnev,
            this.mennyiseg,
            this.mennyegyseg,
            this.leiras});
            this.dagi.Location = new System.Drawing.Point(15, 43);
            this.dagi.Name = "dagi";
            this.dagi.Size = new System.Drawing.Size(906, 313);
            this.dagi.TabIndex = 2;
            this.dagi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dagi_CellClick);
            // 
            // etelnev
            // 
            this.etelnev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.etelnev.HeaderText = "Étel megnevezése";
            this.etelnev.Name = "etelnev";
            this.etelnev.ReadOnly = true;
            // 
            // elkeszitesiido
            // 
            this.elkeszitesiido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.elkeszitesiido.HeaderText = "Elkészítési idő";
            this.elkeszitesiido.Name = "elkeszitesiido";
            this.elkeszitesiido.ReadOnly = true;
            // 
            // kategoria
            // 
            this.kategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kategoria.HeaderText = "Kategória";
            this.kategoria.Name = "kategoria";
            this.kategoria.ReadOnly = true;
            // 
            // alapanyagnev
            // 
            this.alapanyagnev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alapanyagnev.HeaderText = "Alapanyag megnevezése";
            this.alapanyagnev.Name = "alapanyagnev";
            this.alapanyagnev.ReadOnly = true;
            // 
            // mennyiseg
            // 
            this.mennyiseg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mennyiseg.HeaderText = "Mennyiség";
            this.mennyiseg.Name = "mennyiseg";
            this.mennyiseg.ReadOnly = true;
            // 
            // mennyegyseg
            // 
            this.mennyegyseg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mennyegyseg.HeaderText = "Mennyiségi egység";
            this.mennyegyseg.Name = "mennyegyseg";
            this.mennyegyseg.ReadOnly = true;
            // 
            // leiras
            // 
            this.leiras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.leiras.HeaderText = "leiras";
            this.leiras.Name = "leiras";
            this.leiras.ReadOnly = true;
            this.leiras.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 138);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Elkészítés: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.DeepPink;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(16, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(870, 82);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(933, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dagi);
            this.Controls.Add(this.txKereses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Szakácskönyv";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dagi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txKereses;
        private System.Windows.Forms.DataGridView dagi;
        private System.Windows.Forms.DataGridViewTextBoxColumn etelnev;
        private System.Windows.Forms.DataGridViewTextBoxColumn elkeszitesiido;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn alapanyagnev;
        private System.Windows.Forms.DataGridViewTextBoxColumn mennyiseg;
        private System.Windows.Forms.DataGridViewTextBoxColumn mennyegyseg;
        private System.Windows.Forms.DataGridViewTextBoxColumn leiras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
    }
}

