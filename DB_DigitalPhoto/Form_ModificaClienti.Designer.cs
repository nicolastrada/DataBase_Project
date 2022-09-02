
namespace DB_DigitalPhoto
{
    partial class Form_ModificaClienti
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
            this.lst_clienti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_idCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_cognome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_cf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_telefono = new System.Windows.Forms.TextBox();
            this.cmbx_abbonamentoCliente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_aggiungiCliente = new System.Windows.Forms.Button();
            this.btn_rimuoviCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_clienti
            // 
            this.lst_clienti.BackColor = System.Drawing.Color.Gainsboro;
            this.lst_clienti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lst_clienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_clienti.FormattingEnabled = true;
            this.lst_clienti.ItemHeight = 22;
            this.lst_clienti.Location = new System.Drawing.Point(12, 59);
            this.lst_clienti.Name = "lst_clienti";
            this.lst_clienti.Size = new System.Drawing.Size(564, 508);
            this.lst_clienti.TabIndex = 0;
            this.lst_clienti.SelectedIndexChanged += new System.EventHandler(this.Lst_clienti_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clienti:";
            // 
            // tbx_idCliente
            // 
            this.tbx_idCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_idCliente.Location = new System.Drawing.Point(610, 84);
            this.tbx_idCliente.MaximumSize = new System.Drawing.Size(210, 40);
            this.tbx_idCliente.MinimumSize = new System.Drawing.Size(210, 35);
            this.tbx_idCliente.Name = "tbx_idCliente";
            this.tbx_idCliente.Size = new System.Drawing.Size(210, 27);
            this.tbx_idCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(606, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(606, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome:";
            // 
            // tbx_nome
            // 
            this.tbx_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nome.Location = new System.Drawing.Point(610, 159);
            this.tbx_nome.MaximumSize = new System.Drawing.Size(210, 40);
            this.tbx_nome.MinimumSize = new System.Drawing.Size(210, 35);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(210, 27);
            this.tbx_nome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cognome:";
            // 
            // tbx_cognome
            // 
            this.tbx_cognome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_cognome.Location = new System.Drawing.Point(610, 237);
            this.tbx_cognome.MaximumSize = new System.Drawing.Size(210, 40);
            this.tbx_cognome.MinimumSize = new System.Drawing.Size(210, 35);
            this.tbx_cognome.Name = "tbx_cognome";
            this.tbx_cognome.Size = new System.Drawing.Size(210, 27);
            this.tbx_cognome.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(606, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            // 
            // tbx_email
            // 
            this.tbx_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_email.Location = new System.Drawing.Point(610, 314);
            this.tbx_email.MaximumSize = new System.Drawing.Size(210, 40);
            this.tbx_email.MinimumSize = new System.Drawing.Size(210, 35);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(210, 27);
            this.tbx_email.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(606, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Codice Fiscale:";
            // 
            // tbx_cf
            // 
            this.tbx_cf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_cf.Location = new System.Drawing.Point(610, 389);
            this.tbx_cf.MaximumSize = new System.Drawing.Size(210, 40);
            this.tbx_cf.MinimumSize = new System.Drawing.Size(210, 35);
            this.tbx_cf.Name = "tbx_cf";
            this.tbx_cf.Size = new System.Drawing.Size(210, 27);
            this.tbx_cf.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(606, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefono:";
            // 
            // tbx_telefono
            // 
            this.tbx_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_telefono.Location = new System.Drawing.Point(610, 464);
            this.tbx_telefono.MaximumSize = new System.Drawing.Size(210, 40);
            this.tbx_telefono.MinimumSize = new System.Drawing.Size(210, 35);
            this.tbx_telefono.Name = "tbx_telefono";
            this.tbx_telefono.Size = new System.Drawing.Size(210, 27);
            this.tbx_telefono.TabIndex = 12;
            // 
            // cmbx_abbonamentoCliente
            // 
            this.cmbx_abbonamentoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_abbonamentoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_abbonamentoCliente.FormattingEnabled = true;
            this.cmbx_abbonamentoCliente.Items.AddRange(new object[] {
            "Base",
            "Premium"});
            this.cmbx_abbonamentoCliente.Location = new System.Drawing.Point(909, 84);
            this.cmbx_abbonamentoCliente.Name = "cmbx_abbonamentoCliente";
            this.cmbx_abbonamentoCliente.Size = new System.Drawing.Size(240, 28);
            this.cmbx_abbonamentoCliente.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(905, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tipologia Abbonamento";
            // 
            // btn_aggiungiCliente
            // 
            this.btn_aggiungiCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_aggiungiCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aggiungiCliente.Location = new System.Drawing.Point(962, 525);
            this.btn_aggiungiCliente.Name = "btn_aggiungiCliente";
            this.btn_aggiungiCliente.Size = new System.Drawing.Size(160, 56);
            this.btn_aggiungiCliente.TabIndex = 16;
            this.btn_aggiungiCliente.Text = "Aggiungi Cliente";
            this.btn_aggiungiCliente.UseVisualStyleBackColor = false;
            this.btn_aggiungiCliente.Click += new System.EventHandler(this.Btn_aggiungiCliente_Click);
            // 
            // btn_rimuoviCliente
            // 
            this.btn_rimuoviCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_rimuoviCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rimuoviCliente.Location = new System.Drawing.Point(1143, 525);
            this.btn_rimuoviCliente.Name = "btn_rimuoviCliente";
            this.btn_rimuoviCliente.Size = new System.Drawing.Size(160, 56);
            this.btn_rimuoviCliente.TabIndex = 17;
            this.btn_rimuoviCliente.Text = "Rimuovi Cliente";
            this.btn_rimuoviCliente.UseVisualStyleBackColor = false;
            this.btn_rimuoviCliente.Click += new System.EventHandler(this.Btn_rimuoviCliente_Click);
            // 
            // Form_ModificaClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 603);
            this.Controls.Add(this.btn_rimuoviCliente);
            this.Controls.Add(this.btn_aggiungiCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbx_abbonamentoCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_telefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_cf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_cognome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_idCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_clienti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ModificaClienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggiunta e Rimozione Clienti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_clienti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_idCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_cognome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_cf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_telefono;
        private System.Windows.Forms.ComboBox cmbx_abbonamentoCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_aggiungiCliente;
        private System.Windows.Forms.Button btn_rimuoviCliente;
    }
}