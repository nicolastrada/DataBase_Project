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
    public partial class Form_AggiungiFotografo : Form
    {
        private digitalphotoEntities DP_Entities = new digitalphotoEntities();

        public Form_AggiungiFotografo()
        {
            InitializeComponent();
            this.Load_Lst_Fotografi();
        }

        private void Btn_aggiungiFotografo(object sender, EventArgs e)
        {
            if (this.tbx_nome.Text != "" || this.tbx_cognome.Text != "" || this.tbx_email.Text != "" || this.tbx_telefono.Text != "")
            {
                fotografo f = new fotografo();
                f.idFotografo = this.DP_Entities.fotografoes.ToList().Last().idFotografo + 1;
                f.nome = this.tbx_nome.Text;
                f.cognome = this.tbx_cognome.Text;
                f.email = this.tbx_email.Text;
                f.telefono = this.tbx_telefono.Text;
                this.DP_Entities.fotografoes.Add(f);
                this.DP_Entities.SaveChanges();
                this.Load_Lst_Fotografi();
                this.tbx_nome.Text = "";
                this.tbx_cognome.Text = "";
                this.tbx_email.Text = "";
                this.tbx_telefono.Text = "";
            }
            else
            {
                MessageBox.Show("Compilare tutti i campi forniti per aggiungere correttamente un Fotografo");
            }
        }


        //Load Functions
        private void Load_Lst_Fotografi()
        {
            this.lst_fotografi.Items.Clear();
            foreach (fotografo f in this.DP_Entities.fotografoes.ToList())
            {
                this.lst_fotografi.Items.Add(f.ToString());
            }
        }
    }
}
