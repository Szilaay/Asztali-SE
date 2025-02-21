namespace adatbazisos
{
    partial class frmModositas
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
            this.dgAdatok = new System.Windows.Forms.DataGridView();
            this.autoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tulajszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txKereses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElvet = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txAr = new System.Windows.Forms.TextBox();
            this.txTulaj = new System.Windows.Forms.TextBox();
            this.txSzin = new System.Windows.Forms.TextBox();
            this.txTipus = new System.Windows.Forms.TextBox();
            this.txRendszam = new System.Windows.Forms.TextBox();
            this.lbAzon = new System.Windows.Forms.Label();
            this.txAzon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdatok)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAdatok
            // 
            this.dgAdatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAdatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autoid,
            this.rendszam,
            this.tipus,
            this.szin,
            this.tulajszam,
            this.ar});
            this.dgAdatok.Location = new System.Drawing.Point(18, 58);
            this.dgAdatok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgAdatok.Name = "dgAdatok";
            this.dgAdatok.Size = new System.Drawing.Size(794, 405);
            this.dgAdatok.TabIndex = 6;
            this.dgAdatok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAdatok_CellClick);
            // 
            // autoid
            // 
            this.autoid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.autoid.FillWeight = 101.7259F;
            this.autoid.HeaderText = "Azonosító";
            this.autoid.Name = "autoid";
            this.autoid.ReadOnly = true;
            // 
            // rendszam
            // 
            this.rendszam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rendszam.FillWeight = 101.7259F;
            this.rendszam.HeaderText = "Rendszám";
            this.rendszam.Name = "rendszam";
            this.rendszam.ReadOnly = true;
            // 
            // tipus
            // 
            this.tipus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipus.FillWeight = 101.7259F;
            this.tipus.HeaderText = "Típus";
            this.tipus.Name = "tipus";
            this.tipus.ReadOnly = true;
            // 
            // szin
            // 
            this.szin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.szin.FillWeight = 101.7259F;
            this.szin.HeaderText = "Szín";
            this.szin.Name = "szin";
            this.szin.ReadOnly = true;
            // 
            // tulajszam
            // 
            this.tulajszam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tulajszam.FillWeight = 91.37057F;
            this.tulajszam.HeaderText = "Tulajdonosok száma";
            this.tulajszam.Name = "tulajszam";
            this.tulajszam.ReadOnly = true;
            // 
            // ar
            // 
            this.ar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ar.FillWeight = 101.7259F;
            this.ar.HeaderText = "Ára";
            this.ar.Name = "ar";
            this.ar.ReadOnly = true;
            // 
            // txKereses
            // 
            this.txKereses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txKereses.Location = new System.Drawing.Point(268, 28);
            this.txKereses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txKereses.Name = "txKereses";
            this.txKereses.Size = new System.Drawing.Size(332, 26);
            this.txKereses.TabIndex = 5;
            this.txKereses.TextChanged += new System.EventHandler(this.txKereses_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(158, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Keresés";
            // 
            // btnElvet
            // 
            this.btnElvet.BackgroundImage = global::adatbazisos.Properties.Resources.elvet;
            this.btnElvet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnElvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnElvet.ForeColor = System.Drawing.Color.DarkRed;
            this.btnElvet.Location = new System.Drawing.Point(848, 378);
            this.btnElvet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnElvet.Name = "btnElvet";
            this.btnElvet.Size = new System.Drawing.Size(174, 85);
            this.btnElvet.TabIndex = 23;
            this.btnElvet.UseVisualStyleBackColor = true;
            this.btnElvet.Click += new System.EventHandler(this.btnElvet_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.BackgroundImage = global::adatbazisos.Properties.Resources.oke;
            this.btnMentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMentes.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMentes.Location = new System.Drawing.Point(1031, 378);
            this.btnMentes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(180, 85);
            this.btnMentes.TabIndex = 22;
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(923, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ár:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(851, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tulajszám:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(910, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Szín:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(900, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Típus:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(868, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rendszám:";
            // 
            // txAr
            // 
            this.txAr.Location = new System.Drawing.Point(989, 323);
            this.txAr.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txAr.MaxLength = 12;
            this.txAr.Name = "txAr";
            this.txAr.Size = new System.Drawing.Size(220, 26);
            this.txAr.TabIndex = 16;
            this.txAr.TextChanged += new System.EventHandler(this.txAr_TextChanged);
            // 
            // txTulaj
            // 
            this.txTulaj.Location = new System.Drawing.Point(989, 261);
            this.txTulaj.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txTulaj.MaxLength = 3;
            this.txTulaj.Name = "txTulaj";
            this.txTulaj.Size = new System.Drawing.Size(220, 26);
            this.txTulaj.TabIndex = 15;
            this.txTulaj.TextChanged += new System.EventHandler(this.txTulaj_TextChanged);
            // 
            // txSzin
            // 
            this.txSzin.Location = new System.Drawing.Point(989, 195);
            this.txSzin.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txSzin.MaxLength = 10;
            this.txSzin.Name = "txSzin";
            this.txSzin.Size = new System.Drawing.Size(220, 26);
            this.txSzin.TabIndex = 14;
            // 
            // txTipus
            // 
            this.txTipus.Location = new System.Drawing.Point(989, 132);
            this.txTipus.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txTipus.MaxLength = 50;
            this.txTipus.Name = "txTipus";
            this.txTipus.Size = new System.Drawing.Size(220, 26);
            this.txTipus.TabIndex = 13;
            // 
            // txRendszam
            // 
            this.txRendszam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txRendszam.Location = new System.Drawing.Point(989, 72);
            this.txRendszam.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txRendszam.MaxLength = 6;
            this.txRendszam.Name = "txRendszam";
            this.txRendszam.Size = new System.Drawing.Size(220, 26);
            this.txRendszam.TabIndex = 12;
            // 
            // lbAzon
            // 
            this.lbAzon.AutoSize = true;
            this.lbAzon.Location = new System.Drawing.Point(868, 34);
            this.lbAzon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAzon.Name = "lbAzon";
            this.lbAzon.Size = new System.Drawing.Size(92, 20);
            this.lbAzon.TabIndex = 24;
            this.lbAzon.Text = "Azonosítás:";
            // 
            // txAzon
            // 
            this.txAzon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txAzon.Enabled = false;
            this.txAzon.Location = new System.Drawing.Point(989, 28);
            this.txAzon.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txAzon.MaxLength = 6;
            this.txAzon.Name = "txAzon";
            this.txAzon.Size = new System.Drawing.Size(220, 26);
            this.txAzon.TabIndex = 25;
            // 
            // frmModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 501);
            this.Controls.Add(this.txAzon);
            this.Controls.Add(this.lbAzon);
            this.Controls.Add(this.btnElvet);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txAr);
            this.Controls.Add(this.txTulaj);
            this.Controls.Add(this.txSzin);
            this.Controls.Add(this.txTipus);
            this.Controls.Add(this.txRendszam);
            this.Controls.Add(this.dgAdatok);
            this.Controls.Add(this.txKereses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmModositas";
            this.Text = "frmModositas";
            this.Load += new System.EventHandler(this.frmModositas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAdatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn szin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tulajszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ar;
        private System.Windows.Forms.TextBox txKereses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnElvet;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txAr;
        private System.Windows.Forms.TextBox txTulaj;
        private System.Windows.Forms.TextBox txSzin;
        private System.Windows.Forms.TextBox txTipus;
        private System.Windows.Forms.TextBox txRendszam;
        private System.Windows.Forms.Label lbAzon;
        private System.Windows.Forms.TextBox txAzon;
    }
}