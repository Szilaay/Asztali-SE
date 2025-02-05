namespace adatbazisos
{
    partial class frmFo
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
            this.btnBetoltes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txKereses = new System.Windows.Forms.TextBox();
            this.dgAdatok = new System.Windows.Forms.DataGridView();
            this.lbAtlag = new System.Windows.Forms.Label();
            this.btnUjAdat = new System.Windows.Forms.Button();
            this.autoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tulajszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdatok)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBetoltes
            // 
            this.btnBetoltes.Location = new System.Drawing.Point(12, 12);
            this.btnBetoltes.Name = "btnBetoltes";
            this.btnBetoltes.Size = new System.Drawing.Size(627, 79);
            this.btnBetoltes.TabIndex = 0;
            this.btnBetoltes.Text = "Adatok betöltése";
            this.btnBetoltes.UseVisualStyleBackColor = true;
            this.btnBetoltes.Click += new System.EventHandler(this.btnBetoltes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keresés";
            // 
            // txKereses
            // 
            this.txKereses.Location = new System.Drawing.Point(303, 109);
            this.txKereses.Name = "txKereses";
            this.txKereses.Size = new System.Drawing.Size(223, 26);
            this.txKereses.TabIndex = 2;
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
            this.dgAdatok.Location = new System.Drawing.Point(12, 148);
            this.dgAdatok.Name = "dgAdatok";
            this.dgAdatok.Size = new System.Drawing.Size(737, 263);
            this.dgAdatok.TabIndex = 3;
            // 
            // lbAtlag
            // 
            this.lbAtlag.AutoSize = true;
            this.lbAtlag.Location = new System.Drawing.Point(12, 415);
            this.lbAtlag.Name = "lbAtlag";
            this.lbAtlag.Size = new System.Drawing.Size(51, 20);
            this.lbAtlag.TabIndex = 4;
            this.lbAtlag.Text = "label2";
            // 
            // btnUjAdat
            // 
            this.btnUjAdat.Location = new System.Drawing.Point(645, 12);
            this.btnUjAdat.Name = "btnUjAdat";
            this.btnUjAdat.Size = new System.Drawing.Size(104, 79);
            this.btnUjAdat.TabIndex = 5;
            this.btnUjAdat.Text = "Új adat felvitel";
            this.btnUjAdat.UseVisualStyleBackColor = true;
            // 
            // autoid
            // 
            this.autoid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.autoid.HeaderText = "Azonosító";
            this.autoid.Name = "autoid";
            this.autoid.ReadOnly = true;
            // 
            // rendszam
            // 
            this.rendszam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rendszam.HeaderText = "Rendszám";
            this.rendszam.Name = "rendszam";
            this.rendszam.ReadOnly = true;
            // 
            // tipus
            // 
            this.tipus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipus.HeaderText = "Típus";
            this.tipus.Name = "tipus";
            this.tipus.ReadOnly = true;
            // 
            // szin
            // 
            this.szin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.szin.HeaderText = "Szín";
            this.szin.Name = "szin";
            this.szin.ReadOnly = true;
            // 
            // tulajszam
            // 
            this.tulajszam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tulajszam.HeaderText = "Tulajdonosok száma";
            this.tulajszam.Name = "tulajszam";
            this.tulajszam.ReadOnly = true;
            // 
            // ar
            // 
            this.ar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ar.HeaderText = "Ára";
            this.ar.Name = "ar";
            this.ar.ReadOnly = true;
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 444);
            this.Controls.Add(this.btnUjAdat);
            this.Controls.Add(this.lbAtlag);
            this.Controls.Add(this.dgAdatok);
            this.Controls.Add(this.txKereses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBetoltes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gépjármű nyílvántartás";
            ((System.ComponentModel.ISupportInitialize)(this.dgAdatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBetoltes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txKereses;
        private System.Windows.Forms.DataGridView dgAdatok;
        private System.Windows.Forms.Label lbAtlag;
        private System.Windows.Forms.Button btnUjAdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn szin;
        private System.Windows.Forms.DataGridViewTextBoxColumn tulajszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn ar;
    }
}

