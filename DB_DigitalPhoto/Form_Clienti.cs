using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DB_DigitalPhoto
{
    public partial class Form_Clienti : Form
    {
        private digitalphotoEntities DP_Entities = new digitalphotoEntities();

        public Form_Clienti()
        {
            InitializeComponent();
            this.Load_Cmbox_Clienti();
            this.cmbox_foto_album.SelectedIndex = 0;
            this.chkbox_raccoltaTemporanena.Enabled = false;
        }


        private void Menu_fotografi_Click(object sender, EventArgs e)
        {
            Form_Fotografi w_Fotografi = new Form_Fotografi();
            w_Fotografi.ShowDialog();
        }

        private void Cmbox_Clienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item_selected = this.cmbox_Clienti.SelectedItem.ToString();
            int id_cliente = Int32.Parse(item_selected.Substring(item_selected.IndexOf("(") + 1, item_selected.IndexOf(")") - item_selected.IndexOf(")") + 1));
            cliente cliente_selected = this.Find_ClienteByID(id_cliente);
            if (cliente_selected != null)
            {
                this.lbl_nome.Text = cliente_selected.nome;
                this.lbl_cognome.Text = cliente_selected.cognome;
                this.lbl_email.Text = cliente_selected.email;
                this.lbl_telefono.Text = cliente_selected.telefono;
                this.lbl_cf.Text = cliente_selected.CF;
                this.lbl_abbonamento.Text = cliente_selected.abbonamentoes.ToList().First().ToString();
                this.Load_Lst_VenditeC(cliente_selected);
                if(cliente_selected.abbonamentoes.ToList().Last().tipologia_abbonamento.tipologia == "Premium")
                {
                    this.chkbox_raccoltaTemporanena.Enabled = true;
                }
                else
                {
                    this.chkbox_raccoltaTemporanena.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Errore nella selezione del Cliente");
            }
        }

        private void Cmbox_foto_album_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbox_foto_album.SelectedItem.ToString() == "FOTO")
            {
                this.lbl_descrizione.Text = "";
                this.chkbox_raccoltaTemporanena.Enabled = true;
                this.chkbox_raccoltaTemporanena.Checked = false;
                this.lst_foto_album.Items.Clear();
                foreach (foto f in this.DP_Entities.fotoes.ToList())
                {
                    this.lst_foto_album.Items.Add(f.ToString());
                }
            }
            else if (this.cmbox_foto_album.SelectedItem.ToString() == "ALBUM")
            {
                this.lbl_descrizione.Text = "";
                this.chkbox_raccoltaTemporanena.Enabled = false;
                this.lst_foto_album.Items.Clear();
                foreach (album al in this.DP_Entities.albums)
                {
                    this.lst_foto_album.Items.Add(al.ToString());
                }
            }
            else
            {
                MessageBox.Show("Errore nella visualizzazione di Foto/Album");
            }
        }

        private void Lst_foto_album_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lst_foto_album.SelectedItem != null)
            {
                if (this.cmbox_foto_album.SelectedItem.ToString() == "FOTO")
                {
                    string item_selected = this.lst_foto_album.SelectedItem.ToString();
                    int id_foto = Int32.Parse(item_selected.Substring(item_selected.IndexOf("(") + 1, item_selected.IndexOf(")") - item_selected.IndexOf(")") + 1));
                    foto foto_selected = this.Find_FotoByID(id_foto);
                    if (foto_selected != null)
                    {
                        this.lbl_descrizione.Text = "Descrizione: " + foto_selected.descrizione.ToString() + "\nCategoria Foto: " + foto_selected.categoria.ToString() + " - Dimensione in MB : " + foto_selected.dimensione + "\nID Fotografo: " + foto_selected.fotografo_idFotografo;
                        //string s = Directory.GetCurrentDirectory() + "/Img_Foto/" + foto_selected.nome;
                        //this.pctbox_Foto.Load(s);
                        //if (File.Exists(s))
                        //{
                        //}
                    }
                }
            }
        }

        private void Btn_acquistaFoto(object sender, EventArgs e)
        {
            if (this.lst_foto_album.SelectedItem != null && this.cmbox_Clienti.SelectedItem != null)
            {
                string c_selected = this.cmbox_Clienti.SelectedItem.ToString();
                int id_cliente = Int32.Parse(c_selected.Substring(c_selected.IndexOf("(") + 1, c_selected.IndexOf(")") - c_selected.IndexOf(")") + 1));
                cliente cliente_selected = this.Find_ClienteByID(id_cliente);
                string item_selected = this.lst_foto_album.SelectedItem.ToString();
                int id_item = Int32.Parse(item_selected.Substring(item_selected.IndexOf("(") + 1, item_selected.IndexOf(")") - item_selected.IndexOf(")") + 1));
                if (cmbox_foto_album.SelectedItem.ToString() == "FOTO")
                {
                    foto f = this.Find_FotoByID(id_item);
                    vendita v = new vendita();
                    v.idVendita = this.DP_Entities.venditas.ToList().Last().idVendita + 1;
                    v.fotoes.Add(f);
                    v.cliente_idCliente = cliente_selected.idCliente;
                    v.cliente = cliente_selected;
                    v.data_vendita = System.DateTime.Now;
                    this.DP_Entities.venditas.Add(v);
                    this.DP_Entities.SaveChanges();
                    this.Load_Lst_VenditeC(cliente_selected);
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Selezionare prima una Foto o Album da acquistare");
            }
        }

        private void Chkbox_raccoltaTemporanena_CheckedChanged(object sender, EventArgs e)
        {
            this.lst_foto_album.Items.Clear();
            if (this.chkbox_raccoltaTemporanena.Checked == true)
            {
                this.lbl_descrizione.Text = "";
                foreach (foto f in this.DP_Entities.fotoes.ToList())
                {
                    if (f.raccolta_temporanea_idRaccoltaTemporanea != null)
                    {
                        this.lst_foto_album.Items.Add(f.ToString() + " " + f.raccolta_temporanea.ToString());
                    }
                }
            }
            else
            {
                this.lbl_descrizione.Text = "";
                foreach (foto f in this.DP_Entities.fotoes.ToList())
                {
                    this.lst_foto_album.Items.Add(f.ToString());
                }
            }
        }

        private void AggiungiRimuoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ModificaClienti w_ModificaClienti = new Form_ModificaClienti();
            w_ModificaClienti.ShowDialog();
            this.Load_Cmbox_Clienti();
            this.lbl_abbonamento.Text = "";
            this.lst_venditeCliente.Items.Clear();
            this.lbl_descrizione.Text = "";
            this.lbl_telefono.Text = "";
            this.lbl_email.Text = "";
            this.lbl_cf.Text = "";
            this.lbl_cognome.Text = "";
            this.lbl_nome.Text = "";
        }


        //Load Functions
        private void Load_Cmbox_Clienti()
        {
            this.cmbox_Clienti.Items.Clear();
            foreach (cliente c in this.DP_Entities.clientes.ToList())
            {
                this.cmbox_Clienti.Items.Add(c.ToString());
            }
        }

        private void Load_Lst_VenditeC(cliente c)
        {
            this.lst_venditeCliente.Items.Clear();
            foreach (vendita v in c.venditas.ToList())
            {
                this.lst_venditeCliente.Items.Add(v.ToString());
            }
        }


        //Find Functions
        private cliente Find_ClienteByID(int id_Cliente)
        {
            foreach (cliente c in this.DP_Entities.clientes.ToList())
            {
                if (c.idCliente == id_Cliente)
                {
                    return c;
                }
            }
            return null;
        }

        private foto Find_FotoByID(int id_Foto)
        {
            foreach (foto f in this.DP_Entities.fotoes.ToList())
            {
                if (f.idFoto == id_Foto)
                {
                    return f;
                }
            }
            return null;
        }

    }
}
