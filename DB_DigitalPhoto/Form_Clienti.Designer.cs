
namespace DB_DigitalPhoto
{
    partial class Form_Clienti
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
            this.Menu_General = new System.Windows.Forms.MenuStrip();
            this.Menu_Clienti = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiRimuoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_fotografi = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbox_Clienti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_cognome = new System.Windows.Forms.Label();
            this.lbl_cf = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_abbonamento = new System.Windows.Forms.Label();
            this.cmbox_foto_album = new System.Windows.Forms.ComboBox();
            this.lbl_descrizione = new System.Windows.Forms.Label();
            this.pctbox_Foto = new System.Windows.Forms.PictureBox();
            this.lst_foto_album = new System.Windows.Forms.ListBox();
            this.chkbox_raccoltaTemporanena = new System.Windows.Forms.CheckBox();
            this.btn_acquistaFoto = new System.Windows.Forms.Button();
            this.lst_venditeCliente = new System.Windows.Forms.ListBox();
            this.Menu_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_General
            // 
            this.Menu_General.BackColor = System.Drawing.Color.Gainsboro;
            this.Menu_General.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_General.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Clienti,
            this.menu_fotografi});
            this.Menu_General.Location = new System.Drawing.Point(0, 0);
            this.Menu_General.Name = "Menu_General";
            this.Menu_General.Size = new System.Drawing.Size(1332, 36);
            this.Menu_General.TabIndex = 0;
            this.Menu_General.Text = "Menu";
            // 
            // Menu_Clienti
            // 
            this.Menu_Clienti.BackColor = System.Drawing.Color.Silver;
            this.Menu_Clienti.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiRimuoviToolStripMenuItem});
            this.Menu_Clienti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Clienti.Name = "Menu_Clienti";
            this.Menu_Clienti.Size = new System.Drawing.Size(87, 32);
            this.Menu_Clienti.Text = "Clienti";
            // 
            // aggiungiRimuoviToolStripMenuItem
            // 
            this.aggiungiRimuoviToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.aggiungiRimuoviToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggiungiRimuoviToolStripMenuItem.Name = "aggiungiRimuoviToolStripMenuItem";
            this.aggiungiRimuoviToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.aggiungiRimuoviToolStripMenuItem.Text = "Aggiungi/Rimuovi";
            this.aggiungiRimuoviToolStripMenuItem.Click += new System.EventHandler(this.AggiungiRimuoviToolStripMenuItem_Click);
            // 
            // menu_fotografi
            // 
            this.menu_fotografi.BackColor = System.Drawing.Color.Silver;
            this.menu_fotografi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_fotografi.Name = "menu_fotografi";
            this.menu_fotografi.Size = new System.Drawing.Size(113, 32);
            this.menu_fotografi.Text = "Fotografi";
            this.menu_fotografi.Click += new System.EventHandler(this.Menu_fotografi_Click);
            // 
            // cmbox_Clienti
            // 
            this.cmbox_Clienti.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbox_Clienti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_Clienti.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbox_Clienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_Clienti.FormattingEnabled = true;
            this.cmbox_Clienti.Location = new System.Drawing.Point(16, 74);
            this.cmbox_Clienti.Name = "cmbox_Clienti";
            this.cmbox_Clienti.Size = new System.Drawing.Size(261, 26);
            this.cmbox_Clienti.TabIndex = 1;
            this.cmbox_Clienti.TabStop = false;
            this.cmbox_Clienti.SelectedIndexChanged += new System.EventHandler(this.Cmbox_Clienti_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clienti:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(14, 120);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(67, 24);
            this.lbl_nome.TabIndex = 3;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_cognome
            // 
            this.lbl_cognome.AutoSize = true;
            this.lbl_cognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cognome.Location = new System.Drawing.Point(14, 160);
            this.lbl_cognome.Name = "lbl_cognome";
            this.lbl_cognome.Size = new System.Drawing.Size(99, 24);
            this.lbl_cognome.TabIndex = 4;
            this.lbl_cognome.Text = "Cognome:";
            // 
            // lbl_cf
            // 
            this.lbl_cf.AutoSize = true;
            this.lbl_cf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cf.Location = new System.Drawing.Point(14, 280);
            this.lbl_cf.Name = "lbl_cf";
            this.lbl_cf.Size = new System.Drawing.Size(140, 24);
            this.lbl_cf.TabIndex = 5;
            this.lbl_cf.Text = "Codice Fiscale:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(14, 240);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(90, 24);
            this.lbl_telefono.TabIndex = 7;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(14, 200);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(62, 24);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Acquisti Effettuati:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Abbonamento:";
            // 
            // lbl_abbonamento
            // 
            this.lbl_abbonamento.AutoEllipsis = true;
            this.lbl_abbonamento.AutoSize = true;
            this.lbl_abbonamento.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_abbonamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_abbonamento.Location = new System.Drawing.Point(315, 79);
            this.lbl_abbonamento.MaximumSize = new System.Drawing.Size(200, 150);
            this.lbl_abbonamento.MinimumSize = new System.Drawing.Size(200, 150);
            this.lbl_abbonamento.Name = "lbl_abbonamento";
            this.lbl_abbonamento.Size = new System.Drawing.Size(200, 150);
            this.lbl_abbonamento.TabIndex = 11;
            // 
            // cmbox_foto_album
            // 
            this.cmbox_foto_album.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbox_foto_album.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_foto_album.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbox_foto_album.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_foto_album.FormattingEnabled = true;
            this.cmbox_foto_album.Items.AddRange(new object[] {
            "FOTO",
            "ALBUM"});
            this.cmbox_foto_album.Location = new System.Drawing.Point(561, 47);
            this.cmbox_foto_album.Name = "cmbox_foto_album";
            this.cmbox_foto_album.Size = new System.Drawing.Size(212, 26);
            this.cmbox_foto_album.TabIndex = 13;
            this.cmbox_foto_album.TabStop = false;
            this.cmbox_foto_album.SelectedIndexChanged += new System.EventHandler(this.Cmbox_foto_album_SelectedIndexChanged);
            // 
            // lbl_descrizione
            // 
            this.lbl_descrizione.AutoEllipsis = true;
            this.lbl_descrizione.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_descrizione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_descrizione.Location = new System.Drawing.Point(1029, 367);
            this.lbl_descrizione.MinimumSize = new System.Drawing.Size(255, 180);
            this.lbl_descrizione.Name = "lbl_descrizione";
            this.lbl_descrizione.Size = new System.Drawing.Size(255, 226);
            this.lbl_descrizione.TabIndex = 14;
            // 
            // pctbox_Foto
            // 
            this.pctbox_Foto.Location = new System.Drawing.Point(1027, 47);
            this.pctbox_Foto.Name = "pctbox_Foto";
            this.pctbox_Foto.Size = new System.Drawing.Size(257, 244);
            this.pctbox_Foto.TabIndex = 15;
            this.pctbox_Foto.TabStop = false;
            // 
            // lst_foto_album
            // 
            this.lst_foto_album.BackColor = System.Drawing.Color.Gainsboro;
            this.lst_foto_album.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_foto_album.FormattingEnabled = true;
            this.lst_foto_album.ItemHeight = 16;
            this.lst_foto_album.Location = new System.Drawing.Point(561, 79);
            this.lst_foto_album.Name = "lst_foto_album";
            this.lst_foto_album.Size = new System.Drawing.Size(413, 514);
            this.lst_foto_album.TabIndex = 16;
            this.lst_foto_album.SelectedIndexChanged += new System.EventHandler(this.Lst_foto_album_SelectedIndexChanged);
            // 
            // chkbox_raccoltaTemporanena
            // 
            this.chkbox_raccoltaTemporanena.AutoSize = true;
            this.chkbox_raccoltaTemporanena.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chkbox_raccoltaTemporanena.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbox_raccoltaTemporanena.Location = new System.Drawing.Point(792, 55);
            this.chkbox_raccoltaTemporanena.Name = "chkbox_raccoltaTemporanena";
            this.chkbox_raccoltaTemporanena.Size = new System.Drawing.Size(170, 21);
            this.chkbox_raccoltaTemporanena.TabIndex = 17;
            this.chkbox_raccoltaTemporanena.Text = "Raccolte Temporanee";
            this.chkbox_raccoltaTemporanena.UseVisualStyleBackColor = false;
            this.chkbox_raccoltaTemporanena.CheckedChanged += new System.EventHandler(this.Chkbox_raccoltaTemporanena_CheckedChanged);
            // 
            // btn_acquistaFoto
            // 
            this.btn_acquistaFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acquistaFoto.Location = new System.Drawing.Point(1027, 311);
            this.btn_acquistaFoto.Name = "btn_acquistaFoto";
            this.btn_acquistaFoto.Size = new System.Drawing.Size(136, 40);
            this.btn_acquistaFoto.TabIndex = 18;
            this.btn_acquistaFoto.Text = "Acquista Foto";
            this.btn_acquistaFoto.UseVisualStyleBackColor = true;
            this.btn_acquistaFoto.Click += new System.EventHandler(this.Btn_acquistaFoto);
            // 
            // lst_venditeCliente
            // 
            this.lst_venditeCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.lst_venditeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_venditeCliente.FormattingEnabled = true;
            this.lst_venditeCliente.ItemHeight = 18;
            this.lst_venditeCliente.Location = new System.Drawing.Point(18, 402);
            this.lst_venditeCliente.MaximumSize = new System.Drawing.Size(515, 191);
            this.lst_venditeCliente.MinimumSize = new System.Drawing.Size(515, 191);
            this.lst_venditeCliente.Name = "lst_venditeCliente";
            this.lst_venditeCliente.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_venditeCliente.Size = new System.Drawing.Size(515, 184);
            this.lst_venditeCliente.TabIndex = 19;
            // 
            // Form_Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1332, 603);
            this.Controls.Add(this.lst_venditeCliente);
            this.Controls.Add(this.btn_acquistaFoto);
            this.Controls.Add(this.chkbox_raccoltaTemporanena);
            this.Controls.Add(this.lst_foto_album);
            this.Controls.Add(this.pctbox_Foto);
            this.Controls.Add(this.lbl_descrizione);
            this.Controls.Add(this.cmbox_foto_album);
            this.Controls.Add(this.lbl_abbonamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_telefono);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_cf);
            this.Controls.Add(this.lbl_cognome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbox_Clienti);
            this.Controls.Add(this.Menu_General);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Clienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clienti";
            this.Menu_General.ResumeLayout(false);
            this.Menu_General.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_General;
        private System.Windows.Forms.ToolStripMenuItem menu_fotografi;
        private System.Windows.Forms.ToolStripMenuItem Menu_Clienti;
        private System.Windows.Forms.ToolStripMenuItem aggiungiRimuoviToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbox_Clienti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_cognome;
        private System.Windows.Forms.Label lbl_cf;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_abbonamento;
        private System.Windows.Forms.ComboBox cmbox_foto_album;
        private System.Windows.Forms.Label lbl_descrizione;
        private System.Windows.Forms.PictureBox pctbox_Foto;
        private System.Windows.Forms.ListBox lst_foto_album;
        private System.Windows.Forms.CheckBox chkbox_raccoltaTemporanena;
        private System.Windows.Forms.Button btn_acquistaFoto;
        private System.Windows.Forms.ListBox lst_venditeCliente;
    }
}