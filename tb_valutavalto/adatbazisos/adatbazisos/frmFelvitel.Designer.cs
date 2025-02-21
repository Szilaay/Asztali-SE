namespace adatbazisos
{
    partial class frmFelvitel
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
            this.txRendszam = new System.Windows.Forms.TextBox();
            this.txTipus = new System.Windows.Forms.TextBox();
            this.txSzin = new System.Windows.Forms.TextBox();
            this.txTulaj = new System.Windows.Forms.TextBox();
            this.txAr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnElvet = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txRendszam
            // 
            this.txRendszam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txRendszam.Location = new System.Drawing.Point(111, 15);
            this.txRendszam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txRendszam.MaxLength = 6;
            this.txRendszam.Name = "txRendszam";
            this.txRendszam.Size = new System.Drawing.Size(148, 26);
            this.txRendszam.TabIndex = 0;
            // 
            // txTipus
            // 
            this.txTipus.Location = new System.Drawing.Point(111, 54);
            this.txTipus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txTipus.MaxLength = 50;
            this.txTipus.Name = "txTipus";
            this.txTipus.Size = new System.Drawing.Size(148, 26);
            this.txTipus.TabIndex = 1;
            // 
            // txSzin
            // 
            this.txSzin.Location = new System.Drawing.Point(111, 95);
            this.txSzin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txSzin.MaxLength = 10;
            this.txSzin.Name = "txSzin";
            this.txSzin.Size = new System.Drawing.Size(148, 26);
            this.txSzin.TabIndex = 2;
            // 
            // txTulaj
            // 
            this.txTulaj.Location = new System.Drawing.Point(111, 138);
            this.txTulaj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txTulaj.MaxLength = 3;
            this.txTulaj.Name = "txTulaj";
            this.txTulaj.Size = new System.Drawing.Size(148, 26);
            this.txTulaj.TabIndex = 3;
            this.txTulaj.TextChanged += new System.EventHandler(this.txTulaj_TextChanged);
            // 
            // txAr
            // 
            this.txAr.Location = new System.Drawing.Point(111, 178);
            this.txAr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txAr.MaxLength = 12;
            this.txAr.Name = "txAr";
            this.txAr.Size = new System.Drawing.Size(148, 26);
            this.txAr.TabIndex = 4;
            this.txAr.TextChanged += new System.EventHandler(this.txAr_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rendszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Típus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Szín:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tulajszám:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ár:";
            // 
            // btnElvet
            // 
            this.btnElvet.BackgroundImage = global::adatbazisos.Properties.Resources.elvet;
            this.btnElvet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnElvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnElvet.ForeColor = System.Drawing.Color.DarkRed;
            this.btnElvet.Location = new System.Drawing.Point(17, 214);
            this.btnElvet.Name = "btnElvet";
            this.btnElvet.Size = new System.Drawing.Size(116, 55);
            this.btnElvet.TabIndex = 11;
            this.btnElvet.UseVisualStyleBackColor = true;
            this.btnElvet.Click += new System.EventHandler(this.btnElvet_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.BackgroundImage = global::adatbazisos.Properties.Resources.oke;
            this.btnMentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMentes.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMentes.Location = new System.Drawing.Point(139, 214);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(120, 55);
            this.btnMentes.TabIndex = 10;
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // frmFelvitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(276, 281);
            this.Controls.Add(this.btnElvet);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txAr);
            this.Controls.Add(this.txTulaj);
            this.Controls.Add(this.txSzin);
            this.Controls.Add(this.txTipus);
            this.Controls.Add(this.txRendszam);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFelvitel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Új gépjárműfelvitele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txRendszam;
        private System.Windows.Forms.TextBox txTipus;
        private System.Windows.Forms.TextBox txSzin;
        private System.Windows.Forms.TextBox txTulaj;
        private System.Windows.Forms.TextBox txAr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnElvet;
    }
}