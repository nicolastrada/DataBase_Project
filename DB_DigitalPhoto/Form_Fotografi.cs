using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_DigitalPhoto
{
    public partial class Form_Fotografi : Form
    {

        private digitalphotoEntities DP_Entities = new digitalphotoEntities();

        public Form_Fotografi()
        {
            InitializeComponent();
            Load_Cmbox_Fotografi();
        }

        private void Cmbox_fotografi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item_selected = this.cmbox_fotografi.SelectedItem.ToString();
            int id_fotografo = Int32.Parse(item_selected.Substring(item_selected.IndexOf("(") + 1, item_selected.IndexOf(")") - item_selected.IndexOf(")") + 1));
            fotografo fotografo_selected = this.Find_FotografoByID(id_fotografo);
            if (fotografo_selected != null)
            {
                this.lbl_nome.Text = fotografo_selected.nome;
                this.lbl_cognome.Text = fotografo_selected.cognome;
                this.lbl_email.Text = fotografo_selected.email;
                this.lbl_telefono.Text = fotografo_selected.telefono;
                this.Load_Cmbox_Interviste(fotografo_selected);
                this.lbl_foto_fotografi.Text = "";
                foreach (foto fo in fotografo_selected.fotoes.ToList())
                {
                    this.lbl_foto_fotografi.Text += fo.ToString() + "\n";
                }
            }
            else
            {
                MessageBox.Show("Errore nella selezione del Fotografo");
            }
        }

        private void Cmbx_intervista_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item_selected = this.cmbx_intervista.SelectedItem.ToString();
            int id_intervista = Int32.Parse(item_selected.Substring(item_selected.IndexOf("(") + 1, item_selected.IndexOf(")") - item_selected.IndexOf(")") + 1));
            intervista intervista_selected = this.Find_IntervistaByID(id_intervista);
            if (intervista_selected != null)
            {
                this.lbl_intervista.Text = intervista_selected.intervista1;
                this.lbl_progetto.Text = intervista_selected.progetto.ToString();
                this.Load_List_FotoProgetto(intervista_selected.progetto);
                this.Load_List_Mostra(intervista_selected.progetto);
            }
            else
            {
                MessageBox.Show("Errore nella selezione dell'intervista");
            }
        }

        private void Lst_mostre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lst_mostre.SelectedItem != null)
            {
                string item_selected = this.lst_mostre.SelectedItem.ToString();
                int id_mostra = Int32.Parse(item_selected.Substring(item_selected.IndexOf("(") + 1, item_selected.IndexOf(")") - item_selected.IndexOf(")") + 1));
                mostra mostra_selected = this.Find_MostraByID(id_mostra);
                Load_List_Galleria(mostra_selected);
            }
        }

        private void AggiungiFotografiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AggiungiFotografo w_AggiuntaFotografi = new Form_AggiungiFotografo();
            w_AggiuntaFotografi.ShowDialog();
            this.Load_Cmbox_Fotografi();
        }


        //Load Functions
        private void Load_Cmbox_Fotografi()
        {
            this.cmbox_fotografi.Items.Clear();
            foreach (fotografo f in this.DP_Entities.fotografoes.ToList())
            {
                this.cmbox_fotografi.Items.Add(f.ToString());
            }
        }

        private void Load_Cmbox_Interviste(fotografo f)
        {
            this.lst_foto_progetti.Items.Clear();
            this.cmbx_intervista.Items.Clear();
            this.lst_mostre.Items.Clear();
            this.lst_gallerie.Items.Clear();
            this.lbl_intervista.Text = "";
            this.lbl_progetto.Text = "";
            foreach (intervista interv in f.intervistas.ToList())
            {
                this.cmbx_intervista.Items.Add(interv);
            }
        }

        private void Load_List_FotoProgetto(progetto p)
        {
            this.lst_foto_progetti.Items.Clear();
            foreach (foto f in p.fotoes.ToList())
            {
                this.lst_foto_progetti.Items.Add(f.ToString());
            }
        }

        private void Load_List_Mostra(progetto p)
        {
            this.lst_mostre.Items.Clear();
            foreach (mostra m in p.mostras.ToList())
            {
                this.lst_mostre.Items.Add(m.ToString());
            }
        }

        private void Load_List_Galleria(mostra m)
        {
            this.lst_gallerie.Items.Clear();
            foreach (galleria g in m.gallerias.ToList())
            {
                this.lst_gallerie.Items.Add(g.ToString());
            }
        }


        //Find Functions
        private fotografo Find_FotografoByID(int id_Fotografo)
        {
            foreach (fotografo f in this.DP_Entities.fotografoes.ToList())
            {
                if (f.idFotografo == id_Fotografo)
                {
                    return f;
                }
            }
            return null;
        }

        private mostra Find_MostraByID(int id_mostra)
        {
            foreach (mostra m in this.DP_Entities.mostras.ToList())
            {
                if (m.idMostra == id_mostra)
                {
                    return m;
                }
            }
            return null;
        }

        private intervista Find_IntervistaByID(int id_Intervista)
        {
            foreach (intervista interv in this.DP_Entities.intervistas.ToList())
            {
                if (interv.idIntervista == id_Intervista)
                {
                    return interv;
                }
            }
            return null;
        }

    }
}
