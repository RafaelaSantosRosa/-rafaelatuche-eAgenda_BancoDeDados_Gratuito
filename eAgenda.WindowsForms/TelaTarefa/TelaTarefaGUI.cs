using eAgenda.Controladores.TarefaModule;
using eAgenda.Dominio.TarefaModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WindowsForms
{
    public partial class TelaTarefaGUI : Form
    {
        public ControladorTarefa controladorTarefa = new ControladorTarefa();

        PrioridadeEnum prioridade = new PrioridadeEnum();
        public TelaTarefaGUI()
        {
            InitializeComponent();

            PreencherTabelaTarefasPendentes();

            PreencherTabelaTarefasConcluidas();
        }

        private void PreencherTabelaTarefasConcluidas()
        {
            dataSetConcluidas.Clear();

            List<Tarefa> tarefas = controladorTarefa.SelecionarTodasTarefasConcluidas();

            foreach (Tarefa tarefasConcluidas in tarefas)
            {
                dtTarefasConcluidas.Rows.Add(tarefasConcluidas.Id, tarefasConcluidas.Titulo, tarefasConcluidas.Prioridade, tarefasConcluidas.Percentual,
                    tarefasConcluidas.DataCriacao.ToShortDateString(), tarefasConcluidas.DataConclusao);
            }
        }

        private void PreencherTabelaTarefasPendentes()
        {
            dataSetTarefasPendentes.Clear();

            List<Tarefa> tarefas = controladorTarefa.SelecionarTodasTarefasPendentes();

            foreach (Tarefa tarefasPendentes in tarefas)
            {
                dtPendentes.Rows.Add(tarefasPendentes.Id, tarefasPendentes.Titulo, tarefasPendentes.Prioridade, tarefasPendentes.Percentual,
                    tarefasPendentes.DataCriacao.ToShortDateString(), tarefasPendentes.DataConclusao);
            }
        }


        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = InsereTarefa();

            controladorTarefa.InserirNovo(tarefa);

            PreencherTabelaTarefasPendentes();
        }
       

        private void cbPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cbPrioridade.SelectedIndex)
            {
                case 0: prioridade = PrioridadeEnum.Baixa;
                    break;
                case 1: prioridade = PrioridadeEnum.Normal;
                    break;
                case 2: prioridade = PrioridadeEnum.Alta;
                    break;
            }
        }

        private int SelecionarId(DataGridView tabela)
        {
            DataGridViewRow linhaEscolhida = tabela.SelectedRows[0];

            object idTarefa = linhaEscolhida.Cells[0].Value;

            int idSelecionado = Convert.ToInt32(idTarefa);

            PreencherTabelaTarefasPendentes();

            return idSelecionado;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewPendentes.Rows.Count == 0)
            {
                MessageBox.Show("Nenhuma tarefa Selecionada!");
            }
            controladorTarefa.Excluir(SelecionarId(dataGridViewPendentes));

            PreencherTabelaTarefasPendentes();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = InsereTarefa();

            controladorTarefa.Editar(SelecionarId(dataGridViewPendentes), tarefa);

            PreencherTabelaTarefasPendentes();
        }

        private Tarefa InsereTarefa()
        {
            string titulo = tbTitulo.Text;
            //int porcentagem = Convert.ToInt32(tbPorcentagem.Text);
            //DateTime dataConclusao = dateTimePickerConclusao.Value;

            //Tarefa tarefa = new Tarefa(titulo, DateTime.Now, dataConclusao, prioridade, porcentagem);
            Tarefa tarefa = new Tarefa(titulo, DateTime.Now, prioridade);
            return tarefa;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
