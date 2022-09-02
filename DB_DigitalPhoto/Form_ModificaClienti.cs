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
    public partial class Form_ModificaClienti : Form
    {
        private digitalphotoEntities DP_Entities = new digitalphotoEntities();

        public Form_ModificaClienti()
        {
            InitializeComponent();
            this.Load_List_Clienti();
        }

        private void Lst_clienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lst_clienti.SelectedItem.ToString() != null)
            {
                string item_selected = this.lst_clienti.SelectedItem.ToString();
                int id_cliente = Int32.Parse(item_selected.Substring(item_selected.IndexOf("(") + 1, item_selected.IndexOf(")") - item_selected.IndexOf(")") + 1));
                cliente cliente_selected = this.Find_ClienteByID(id_cliente);
                if (cliente_selected != null)
                {
                    this.tbx_idCliente.Text = cliente_selected.idCliente.ToString();
                    this.tbx_nome.Text = cliente_selected.nome;
                    this.tbx_cognome.Text = cliente_selected.cognome;
                    this.tbx_email.Text = cliente_selected.email;
                    this.tbx_telefono.Text = cliente_selected.telefono;
                    this.tbx_cf.Text = cliente_selected.CF;
                    if(cliente_selected.abbonamentoes.ToList().Last().tipologia_abbonamento.tipologia == "Base")
                    {
                        this.cmbx_abbonamentoCliente.SelectedItem = "Base";
                    }
                    else if (cliente_selected.abbonamentoes.ToList().Last().tipologia_abbonamento.tipologia == "Premium")
                    {
                        this.cmbx_abbonamentoCliente.SelectedItem = "Premium";
                    }
                }
            }
        }

        private void Btn_aggiungiCliente_Click(object sender, EventArgs e)
        {
            if(tbx_idCliente.Text == "")
            {
                if(cmbx_abbonamentoCliente.SelectedItem != null)
                {
                    abbonamento nAbbonamento = new abbonamento();
                    nAbbonamento.dataAcquisto = DateTime.Now;
                    if(cmbx_abbonamentoCliente.SelectedItem.ToString() == "Base")
                    {
                        nAbbonamento.tipologia_abbonamento_idTipologia_abbonamento = 1;
                        nAbbonamento.tipologia_abbonamento = this.DP_Entities.tipologia_abbonamento.ToList().First();
                    }
                    else
                    {
                        nAbbonamento.tipologia_abbonamento_idTipologia_abbonamento = 2;
                        nAbbonamento.tipologia_abbonamento = this.DP_Entities.tipologia_abbonamento.ToList().Last();
                    }
                    cliente nCliente = new cliente();
                    nCliente.idCliente = this.DP_Entities.clientes.ToList().Last().idCliente + 1;
                    nCliente.nome = this.tbx_nome.Text;
                    nCliente.cognome = this.tbx_cognome.Text;
                    nCliente.email = this.tbx_email.Text;
                    nCliente.CF = this.tbx_cf.Text;
                    nCliente.telefono = this.tbx_telefono.Text;
                    nAbbonamento.cliente_idCliente = nCliente.idCliente;
                    nAbbonamento.cliente = nCliente;
                    nCliente.abbonamentoes.Add(nAbbonamento);
                    this.DP_Entities.abbonamentoes.Add(nAbbonamento);
                    this.DP_Entities.clientes.Add(nCliente);
                    this.DP_Entities.SaveChanges();
                    this.tbx_nome.Text = "";
                    this.tbx_cognome.Text = "";
                    this.tbx_email.Text = "";
                    this.tbx_cf.Text = "";
                    this.tbx_telefono.Text = "";
                    this.cmbx_abbonamentoCliente.SelectedItem = null;
                    this.Load_List_Clienti();

                }
                else
                {
                    MessageBox.Show("Inserire la Tipologia di abbonamento preferita");
                }
            }
            else
            {
                MessageBox.Show("Lasciare il campo di ID Cliente vuoto per poter procedere all'aggiunta di un nuovo Cliente.");
            }
        }

        private void Btn_rimuoviCliente_Click(object sender, EventArgs e)
        {
            if (this.lst_clienti.SelectedItem != null)
            {
                string item_selected = this.lst_clienti.SelectedItem.ToString();
                int id_cliente = Int32.Parse(item_selected.Substring(item_selected.IndexOf("(") + 1, item_selected.IndexOf(")") - item_selected.IndexOf(")") + 1));
                cliente cliente_selected = this.Find_ClienteByID(id_cliente);
                if(cliente_selected.venditas.ToList().Count != 0)
                {
                    foreach (vendita v in cliente_selected.venditas.ToList())
                    {
                        this.DP_Entities.venditas.ToList().Remove(v);
                    }
                }
                this.DP_Entities.clientes.Remove(cliente_selected);
                this.DP_Entities.SaveChanges();
                this.tbx_idCliente.Text = "";
                this.tbx_nome.Text = "";
                this.tbx_cognome.Text = "";
                this.tbx_email.Text = "";
                this.tbx_cf.Text = "";
                this.tbx_telefono.Text = "";
                this.cmbx_abbonamentoCliente.SelectedItem = null;
                this.Load_List_Clienti();
            }
        }

        //Load Functions
        private void Load_List_Clienti()
        {
            this.lst_clienti.Items.Clear();
            foreach (cliente c in this.DP_Entities.clientes.ToList())
            {
                this.lst_clienti.Items.Add(c.ToString());
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
    }
}
