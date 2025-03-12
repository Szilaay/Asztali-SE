namespace szemelyugyi_ab
{
    partial class frmStatisztika
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szulido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eletkor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fizetes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belepdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beosztas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilepdatum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thnev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txKereses = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMindenki = new System.Windows.Forms.RadioButton();
            this.rbKilepettek = new System.Windows.Forms.RadioButton();
            this.rbAktivak = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAtlag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nev,
            this.szulido,
            this.eletkor,
            this.fizetes,
            this.belepdatum,
            this.beosztas,
            this.kilepdatum,
            this.thnev});
            this.dataGridView1.Location = new System.Drawing.Point(13, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1063, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // nev
            // 
            this.nev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nev.HeaderText = "Dolgozó neve";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            // 
            // szulido
            // 
            this.szulido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.szulido.HeaderText = "Születési idő";
            this.szulido.Name = "szulido";
            this.szulido.ReadOnly = true;
            // 
            // eletkor
            // 
            this.eletkor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eletkor.HeaderText = "Életkor";
            this.eletkor.Name = "eletkor";
            this.eletkor.ReadOnly = true;
            // 
            // fizetes
            // 
            this.fizetes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fizetes.HeaderText = "Fizetése";
            this.fizetes.Name = "fizetes";
            this.fizetes.ReadOnly = true;
            // 
            // belepdatum
            // 
            this.belepdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.belepdatum.HeaderText = "Belépés dátuma";
            this.belepdatum.Name = "belepdatum";
            this.belepdatum.ReadOnly = true;
            // 
            // beosztas
            // 
            this.beosztas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.beosztas.HeaderText = "Beosztása";
            this.beosztas.Name = "beosztas";
            this.beosztas.ReadOnly = true;
            // 
            // kilepdatum
            // 
            this.kilepdatum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kilepdatum.HeaderText = "Kilépés dátuma";
            this.kilepdatum.Name = "kilepdatum";
            this.kilepdatum.ReadOnly = true;
            // 
            // thnev
            // 
            this.thnev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thnev.HeaderText = "Telephely neve";
            this.thnev.Name = "thnev";
            this.thnev.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keresés";
            // 
            // txKereses
            // 
            this.txKereses.Location = new System.Drawing.Point(84, 93);
            this.txKereses.Name = "txKereses";
            this.txKereses.Size = new System.Drawing.Size(197, 22);
            this.txKereses.TabIndex = 2;
            this.txKereses.TextChanged += new System.EventHandler(this.txKereses_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMindenki);
            this.groupBox1.Controls.Add(this.rbKilepettek);
            this.groupBox1.Controls.Add(this.rbAktivak);
            this.groupBox1.Location = new System.Drawing.Point(287, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Státusz";
            // 
            // rbMindenki
            // 
            this.rbMindenki.AutoSize = true;
            this.rbMindenki.Location = new System.Drawing.Point(6, 71);
            this.rbMindenki.Name = "rbMindenki";
            this.rbMindenki.Size = new System.Drawing.Size(87, 20);
            this.rbMindenki.TabIndex = 2;
            this.rbMindenki.TabStop = true;
            this.rbMindenki.Text = "Mindenki";
            this.rbMindenki.UseVisualStyleBackColor = true;
            this.rbMindenki.CheckedChanged += new System.EventHandler(this.rbMindenki_CheckedChanged);
            // 
            // rbKilepettek
            // 
            this.rbKilepettek.AutoSize = true;
            this.rbKilepettek.Location = new System.Drawing.Point(6, 47);
            this.rbKilepettek.Name = "rbKilepettek";
            this.rbKilepettek.Size = new System.Drawing.Size(94, 20);
            this.rbKilepettek.TabIndex = 1;
            this.rbKilepettek.TabStop = true;
            this.rbKilepettek.Text = "Kilépettek";
            this.rbKilepettek.UseVisualStyleBackColor = true;
            this.rbKilepettek.CheckedChanged += new System.EventHandler(this.rbKilepettek_CheckedChanged);
            // 
            // rbAktivak
            // 
            this.rbAktivak.AutoSize = true;
            this.rbAktivak.Location = new System.Drawing.Point(6, 21);
            this.rbAktivak.Name = "rbAktivak";
            this.rbAktivak.Size = new System.Drawing.Size(76, 20);
            this.rbAktivak.TabIndex = 0;
            this.rbAktivak.TabStop = true;
            this.rbAktivak.Text = "Aktívak";
            this.rbAktivak.UseVisualStyleBackColor = true;
            this.rbAktivak.CheckedChanged += new System.EventHandler(this.rbAktivak_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.lbAtlag);
            this.panel1.Location = new System.Drawing.Point(13, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 100);
            this.panel1.TabIndex = 4;
            // 
            // lbAtlag
            // 
            this.lbAtlag.AutoSize = true;
            this.lbAtlag.ForeColor = System.Drawing.Color.Red;
            this.lbAtlag.Location = new System.Drawing.Point(14, 39);
            this.lbAtlag.Name = "lbAtlag";
            this.lbAtlag.Size = new System.Drawing.Size(60, 16);
            this.lbAtlag.TabIndex = 0;
            this.lbAtlag.Text = "lbAtlag ";
            // 
            // frmStatisztika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txKereses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStatisztika";
            this.Text = "Statisztika Form";
            this.Load += new System.EventHandler(this.frmStatisztika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn szulido;
        private System.Windows.Forms.DataGridViewTextBoxColumn eletkor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fizetes;
        private System.Windows.Forms.DataGridViewTextBoxColumn belepdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn beosztas;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilepdatum;
        private System.Windows.Forms.DataGridViewTextBoxColumn thnev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txKereses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMindenki;
        private System.Windows.Forms.RadioButton rbKilepettek;
        private System.Windows.Forms.RadioButton rbAktivak;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAtlag;
    }
}