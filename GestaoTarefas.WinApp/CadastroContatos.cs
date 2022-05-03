using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoContatos.Dominio;


namespace GestaoTarefas.WinApp
{
    public partial class CadastroContatos : Form
    {
        private Contato contato;
        public CadastroContatos()
        {
            InitializeComponent();
        }
        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
                txtContatoNome.Text = contato.Nome;
                txtContatnoEmail.Text = contato.Email;
                txtContatoTel.Text = contato.Telefone;
                txtContatoEmpresa.Text = contato.Empresa;
                TxtContatoCargo.Text = contato.Cargo;
            }
        }
        private void btnGravarContato_Click(object sender, EventArgs e)
        {
            contato.Nome = txtContatoNome.Text;
            contato.Email = txtContatnoEmail.Text;
            contato.Telefone = txtContatoTel.Text;
            contato.Empresa = txtContatoEmpresa.Text;
            contato.Cargo = TxtContatoCargo.Text;
        }
    }
}
