namespace allatkertGUI
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
            this.dagiAdatok = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLeiras = new System.Windows.Forms.Label();
            this.megnevezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jegytipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reszletek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dagiAdatok)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keresés";
            // 
            // txKereses
            // 
            this.txKereses.Location = new System.Drawing.Point(70, 47);
            this.txKereses.Name = "txKereses";
            this.txKereses.Size = new System.Drawing.Size(206, 20);
            this.txKereses.TabIndex = 1;
            this.txKereses.TextChanged += new System.EventHandler(this.txKereses_TextChanged);
            // 
            // dagiAdatok
            // 
            this.dagiAdatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dagiAdatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.megnevezes,
            this.jegytipus,
            this.ar,
            this.reszletek});
            this.dagiAdatok.Location = new System.Drawing.Point(43, 76);
            this.dagiAdatok.Name = "dagiAdatok";
            this.dagiAdatok.Size = new System.Drawing.Size(642, 290);
            this.dagiAdatok.TabIndex = 2;
            this.dagiAdatok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dagiAdatok_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.lbLeiras);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(43, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 166);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Részletes leírás";
            // 
            // lbLeiras
            // 
            this.lbLeiras.AutoSize = true;
            this.lbLeiras.Location = new System.Drawing.Point(24, 41);
            this.lbLeiras.Name = "lbLeiras";
            this.lbLeiras.Size = new System.Drawing.Size(51, 13);
            this.lbLeiras.TabIndex = 5;
            this.lbLeiras.Text = "lbLeiras";
            // 
            // megnevezes
            // 
            this.megnevezes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.megnevezes.HeaderText = "Megnevezés";
            this.megnevezes.Name = "megnevezes";
            this.megnevezes.ReadOnly = true;
            // 
            // jegytipus
            // 
            this.jegytipus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jegytipus.HeaderText = "Típus";
            this.jegytipus.Name = "jegytipus";
            this.jegytipus.ReadOnly = true;
            // 
            // ar
            // 
            this.ar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ar.HeaderText = "Belépőjegy ára [Ft]";
            this.ar.Name = "ar";
            this.ar.ReadOnly = true;
            // 
            // reszletek
            // 
            this.reszletek.HeaderText = "reszletek";
            this.reszletek.Name = "reszletek";
            this.reszletek.ReadOnly = true;
            this.reszletek.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(723, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dagiAdatok);
            this.Controls.Add(this.txKereses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Állatkerti belépők";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dagiAdatok)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txKereses;
        private System.Windows.Forms.DataGridView dagiAdatok;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbLeiras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn megnevezes;
        private System.Windows.Forms.DataGridViewTextBoxColumn jegytipus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ar;
        private System.Windows.Forms.DataGridViewTextBoxColumn reszletek;
    }
}

