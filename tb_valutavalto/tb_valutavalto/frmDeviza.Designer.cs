namespace tb_valutavalto
{
    partial class frmDeviza
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
            this.label2 = new System.Windows.Forms.Label();
            this.txDevNev = new System.Windows.Forms.TextBox();
            this.txDevKod = new System.Windows.Forms.TextBox();
            this.btnElvet = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deviza rövid kódja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deviza neve:";
            // 
            // txDevNev
            // 
            this.txDevNev.Location = new System.Drawing.Point(129, 69);
            this.txDevNev.Name = "txDevNev";
            this.txDevNev.Size = new System.Drawing.Size(218, 22);
            this.txDevNev.TabIndex = 2;
            // 
            // txDevKod
            // 
            this.txDevKod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txDevKod.Location = new System.Drawing.Point(169, 38);
            this.txDevKod.MaxLength = 3;
            this.txDevKod.Name = "txDevKod";
            this.txDevKod.Size = new System.Drawing.Size(67, 22);
            this.txDevKod.TabIndex = 3;
            this.txDevKod.TextChanged += new System.EventHandler(this.txDevKod_TextChanged);
            // 
            // btnElvet
            // 
            this.btnElvet.Image = global::tb_valutavalto.Properties.Resources.elvet;
            this.btnElvet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnElvet.Location = new System.Drawing.Point(203, 118);
            this.btnElvet.Name = "btnElvet";
            this.btnElvet.Size = new System.Drawing.Size(144, 59);
            this.btnElvet.TabIndex = 5;
            this.btnElvet.Text = "Elvet";
            this.btnElvet.UseVisualStyleBackColor = true;
            this.btnElvet.Click += new System.EventHandler(this.btnElvet_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Image = global::tb_valutavalto.Properties.Resources.oke;
            this.btnMentes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMentes.Location = new System.Drawing.Point(29, 118);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(144, 59);
            this.btnMentes.TabIndex = 4;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // frmDeviza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 197);
            this.Controls.Add(this.btnElvet);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.txDevKod);
            this.Controls.Add(this.txDevNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDeviza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Deviza rögzítése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txDevNev;
        private System.Windows.Forms.TextBox txDevKod;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnElvet;
    }
}