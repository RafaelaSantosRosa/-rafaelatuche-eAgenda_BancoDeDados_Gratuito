using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WindowsForms
{
    public partial class TelaContato : Form
    {
        public ControladorContato controladorContato = new ControladorContato();

        public TelaContato()
        {
            InitializeComponent();

            PreencherTabelaContatos();
        }

        private void PreencherTabelaContatos()
        {
            dataSetContatos.Clear();

            List<Contato> contatos = controladorContato.SelecionarTodos();

            foreach (var contato in contatos)
            {
                dtContatos.Rows.Add(contato.Id, contato.Nome, contato.Email, contato.Telefone,
                    contato.Cargo, contato.Empresa);
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Contato contato = InsereContato();

            ValidarCampos();

            controladorContato.InserirNovo(contato);
            
            PreencherTabelaContatos();

            LimparCampos();
        }

        private int SelecionarId(DataGridView tabela)
        {
            if (dataGridContatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum compromisso selecionado!");

                return 0;
            }
            DataGridViewRow linhaEscolhida = tabela.SelectedRows[0];

            object idContato = linhaEscolhida.Cells[0].Value;

            int idSelecionado = Convert.ToInt32(idContato);

            PreencherTabelaContatos();

            return idSelecionado;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            controladorContato.Excluir(SelecionarId(dataGridContatos));

            PreencherTabelaContatos();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Contato contato = InsereContato();
            
            ValidarCampos();

            controladorContato.Editar(SelecionarId(dataGridContatos), contato);

            PreencherTabelaContatos();

            LimparCampos();
        }

        private void ValidarCampos()
        {
            if (tbNome.Text == "" || tbEmail.Text == "" || tbTelefone.Text == "" || tbCargo.Text == "" || tbEmpresa.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
            }
        }

        private Contato InsereContato()
        {
            string nome = tbNome.Text;
            string email = tbEmail.Text;
            string telefone = tbTelefone.Text;
            string cargo = tbCargo.Text;
            string empresa = tbEmpresa.Text;

            Contato contato = new Contato(nome, email, telefone, empresa, cargo);
            return contato;
        }

        private void LimparCampos()
        {
            tbNome.Text = "";
            tbEmail.Text = "";
            tbTelefone.Text = "";
            tbCargo.Text = "";
            tbEmpresa.Text = "";
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
