using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WindowsForms
{
    public partial class TelaVisualizarContatos : Form
    {
        public ControladorContato controladorContato = new ControladorContato();

        public TelaVisualizarContatos()
        {
            InitializeComponent();

            PreencherTabelaContatos();
        }

        private void PreencherTabelaContatos()
        {
            dataSetTabelaContatos.Clear();

            List<Contato> contatos = controladorContato.SelecionarTodos();

            foreach (var contato in contatos)
            {
                dtTabelaContatos.Rows.Add(contato.Id, contato.Nome, contato.Email, contato.Telefone,
                    contato.Cargo, contato.Empresa);
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void btOk_Click(object sender, EventArgs e)
        {
            Contato contato = null;
            contato = controladorContato.SelecionarPorId(SelecionarId(dataGridContatos));
        }

        private int SelecionarId(DataGridView tabela)
        {
            DataGridViewRow linhaEscolhida = tabela.SelectedRows[0];

            object idCompromisso = linhaEscolhida.Cells[0].Value;

            int idSelecionado = Convert.ToInt32(idCompromisso);

            return idSelecionado;
        }
    }
}
