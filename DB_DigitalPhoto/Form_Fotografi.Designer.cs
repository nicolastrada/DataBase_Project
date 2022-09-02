
namespace DB_DigitalPhoto
{
    partial class Form_Fotografi
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
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_cognome = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbox_fotografi = new System.Windows.Forms.ComboBox();
            this.lbl_foto_fotografi = new System.Windows.Forms.Label();
            this.cmbx_intervista = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_intervista = new System.Windows.Forms.Label();
            this.lst_foto_progetti = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_progetto = new System.Windows.Forms.Label();
            this.lst_mostre = new System.Windows.Forms.ListBox();
            this.lst_gallerie = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Menu_General = new System.Windows.Forms.MenuStrip();
            this.Menu_Clienti = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiFotografiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_General.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(10, 251);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(90, 24);
            this.lbl_telefono.TabIndex = 14;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(10, 211);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(62, 24);
            this.lbl_email.TabIndex = 13;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_cognome
            // 
            this.lbl_cognome.AutoSize = true;
            this.lbl_cognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cognome.Location = new System.Drawing.Point(10, 171);
            this.lbl_cognome.Name = "lbl_cognome";
            this.lbl_cognome.Size = new System.Drawing.Size(99, 24);
            this.lbl_cognome.TabIndex = 11;
            this.lbl_cognome.Text = "Cognome:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(10, 131);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(67, 24);
            this.lbl_nome.TabIndex = 10;
            this.lbl_nome.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fotografi:";
            // 
            // cmbox_fotografi
            // 
            this.cmbox_fotografi.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbox_fotografi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_fotografi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbox_fotografi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_fotografi.FormattingEnabled = true;
            this.cmbox_fotografi.Location = new System.Drawing.Point(12, 85);
            this.cmbox_fotografi.Name = "cmbox_fotografi";
            this.cmbox_fotografi.Size = new System.Drawing.Size(290, 26);
            this.cmbox_fotografi.TabIndex = 8;
            this.cmbox_fotografi.TabStop = false;
            this.cmbox_fotografi.SelectedIndexChanged += new System.EventHandler(this.Cmbox_fotografi_SelectedIndexChanged);
            // 
            // lbl_foto_fotografi
            // 
            this.lbl_foto_fotografi.AutoEllipsis = true;
            this.lbl_foto_fotografi.AutoSize = true;
            this.lbl_foto_fotografi.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_foto_fotografi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_foto_fotografi.Location = new System.Drawing.Point(12, 337);
            this.lbl_foto_fotografi.MaximumSize = new System.Drawing.Size(290, 250);
            this.lbl_foto_fotografi.MinimumSize = new System.Drawing.Size(290, 250);
            this.lbl_foto_fotografi.Name = "lbl_foto_fotografi";
            this.lbl_foto_fotografi.Size = new System.Drawing.Size(290, 250);
            this.lbl_foto_fotografi.TabIndex = 15;
            // 
            // cmbx_intervista
            // 
            this.cmbx_intervista.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbx_intervista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_intervista.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbx_intervista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_intervista.FormattingEnabled = true;
            this.cmbx_intervista.Location = new System.Drawing.Point(402, 85);
            this.cmbx_intervista.Name = "cmbx_intervista";
            this.cmbx_intervista.Size = new System.Drawing.Size(290, 26);
            this.cmbx_intervista.TabIndex = 16;
            this.cmbx_intervista.TabStop = false;
            this.cmbx_intervista.SelectedIndexChanged += new System.EventHandler(this.Cmbx_intervista_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Interviste Svolte:";
            // 
            // lbl_intervista
            // 
            this.lbl_intervista.AutoEllipsis = true;
            this.lbl_intervista.AutoSize = true;
            this.lbl_intervista.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_intervista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_intervista.Location = new System.Drawing.Point(402, 131);
            this.lbl_intervista.MaximumSize = new System.Drawing.Size(290, 220);
            this.lbl_intervista.MinimumSize = new System.Drawing.Size(290, 220);
            this.lbl_intervista.Name = "lbl_intervista";
            this.lbl_intervista.Size = new System.Drawing.Size(290, 220);
            this.lbl_intervista.TabIndex = 18;
            // 
            // lst_foto_progetti
            // 
            this.lst_foto_progetti.BackColor = System.Drawing.Color.Gainsboro;
            this.lst_foto_progetti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_foto_progetti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_foto_progetti.FormattingEnabled = true;
            this.lst_foto_progetti.ItemHeight = 18;
            this.lst_foto_progetti.Location = new System.Drawing.Point(991, 89);
            this.lst_foto_progetti.Name = "lst_foto_progetti";
            this.lst_foto_progetti.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_foto_progetti.Size = new System.Drawing.Size(329, 272);
            this.lst_foto_progetti.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(398, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mostre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(710, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Progetto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(987, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Foto Presenti:";
            // 
            // lbl_progetto
            // 
            this.lbl_progetto.AutoEllipsis = true;
            this.lbl_progetto.AutoSize = true;
            this.lbl_progetto.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_progetto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_progetto.Location = new System.Drawing.Point(714, 131);
            this.lbl_progetto.MaximumSize = new System.Drawing.Size(250, 220);
            this.lbl_progetto.MinimumSize = new System.Drawing.Size(250, 220);
            this.lbl_progetto.Name = "lbl_progetto";
            this.lbl_progetto.Size = new System.Drawing.Size(250, 220);
            this.lbl_progetto.TabIndex = 25;
            // 
            // lst_mostre
            // 
            this.lst_mostre.BackColor = System.Drawing.Color.Gainsboro;
            this.lst_mostre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_mostre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_mostre.FormattingEnabled = true;
            this.lst_mostre.HorizontalScrollbar = true;
            this.lst_mostre.ItemHeight = 18;
            this.lst_mostre.Location = new System.Drawing.Point(402, 405);
            this.lst_mostre.Name = "lst_mostre";
            this.lst_mostre.Size = new System.Drawing.Size(464, 182);
            this.lst_mostre.TabIndex = 26;
            this.lst_mostre.SelectedIndexChanged += new System.EventHandler(this.Lst_mostre_SelectedIndexChanged);
            // 
            // lst_gallerie
            // 
            this.lst_gallerie.BackColor = System.Drawing.Color.Gainsboro;
            this.lst_gallerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_gallerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_gallerie.FormattingEnabled = true;
            this.lst_gallerie.HorizontalScrollbar = true;
            this.lst_gallerie.ItemHeight = 18;
            this.lst_gallerie.Location = new System.Drawing.Point(895, 405);
            this.lst_gallerie.Name = "lst_gallerie";
            this.lst_gallerie.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_gallerie.Size = new System.Drawing.Size(425, 182);
            this.lst_gallerie.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(891, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Gallerie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "Foto Eseguite:";
            // 
            // Menu_General
            // 
            this.Menu_General.BackColor = System.Drawing.Color.Gainsboro;
            this.Menu_General.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_General.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Clienti});
            this.Menu_General.Location = new System.Drawing.Point(0, 0);
            this.Menu_General.Name = "Menu_General";
            this.Menu_General.Size = new System.Drawing.Size(1332, 36);
            this.Menu_General.TabIndex = 30;
            this.Menu_General.Text = "Menu";
            // 
            // Menu_Clienti
            // 
            this.Menu_Clienti.BackColor = System.Drawing.Color.Silver;
            this.Menu_Clienti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiFotografiToolStripMenuItem});
            this.Menu_Clienti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Clienti.Name = "Menu_Clienti";
            this.Menu_Clienti.Size = new System.Drawing.Size(113, 32);
            this.Menu_Clienti.Text = "Fotografi";
            // 
            // aggiungiFotografiToolStripMenuItem
            // 
            this.aggiungiFotografiToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.aggiungiFotografiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggiungiFotografiToolStripMenuItem.Name = "aggiungiFotografiToolStripMenuItem";
            this.aggiungiFotografiToolStripMenuItem.Size = new System.Drawing.Size(238, 28);
            this.aggiungiFotografiToolStripMenuItem.Text = "Aggiungi Fotografi";
            this.aggiungiFotografiToolStripMenuItem.Click += new System.EventHandler(this.AggiungiFotografiToolStripMenuItem_Click);
            // 
            // Form_Fotografi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 603);
            this.Controls.Add(this.Menu_General);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lst_gallerie);
            this.Controls.Add(this.lst_mostre);
            this.Controls.Add(this.lbl_progetto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lst_foto_progetti);
            this.Controls.Add(this.lbl_intervista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx_intervista);
            this.Controls.Add(this.lbl_foto_fotografi);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_cognome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbox_fotografi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Fotografi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fotografi";
            this.Menu_General.ResumeLayout(false);
            this.Menu_General.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_cognome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbox_fotografi;
        private System.Windows.Forms.Label lbl_foto_fotografi;
        private System.Windows.Forms.ComboBox cmbx_intervista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_intervista;
        private System.Windows.Forms.ListBox lst_foto_progetti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_progetto;
        private System.Windows.Forms.ListBox lst_mostre;
        private System.Windows.Forms.ListBox lst_gallerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip Menu_General;
        private System.Windows.Forms.ToolStripMenuItem Menu_Clienti;
        private System.Windows.Forms.ToolStripMenuItem aggiungiFotografiToolStripMenuItem;
    }
}