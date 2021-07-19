using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WindowsForms
{
    public partial class TelaCompromisso : Form
    {
        public ControladorContato controladorContato = new ControladorContato();
        public ControladorCompromisso controladorCompromisso = new ControladorCompromisso();
        public TelaCompromisso()
        {
            InitializeComponent();

            PreencherTodasTabelasCompromisso();

            PreencherTabelaContatos();
        }

        private void PreencherTabelaCompromissosPassados()
        {
            dataSetPassados.Clear();

            List<Compromisso> compromissos = controladorCompromisso.SelecionarCompromissosPassados(DateTime.Now.Date);

            foreach (var compromisso in compromissos)
            {
                dtPassados.Rows.Add(compromisso.Id, compromisso.Assunto, compromisso.Data.ToShortDateString(), compromisso.HoraInicio,
                    compromisso.HoraTermino, compromisso.Contato, compromisso.Local);
            }
        }

        private void PreencherTabelaCompromissosFuturos()
        {
            dataSetFuturos.Clear();

            DateTime dataInicial = dateTimeInicial.Value;
            DateTime dataFinal = dateTimeFinal.Value;

            List<Compromisso> compromissos = controladorCompromisso.SelecionarCompromissosFuturos(dataInicial, dataFinal);

            foreach (var compromisso in compromissos)
            {
                dtFuturos.Rows.Add(compromisso.Id, compromisso.Assunto, compromisso.Data.ToShortDateString(), compromisso.HoraInicio,
                    compromisso.HoraTermino, compromisso.Contato, compromisso.Local);
            }
        }

        private void PreencherTabelaTodosCompromissos()
        {
            dataSetTodosCompromissos.Clear();

            List<Compromisso> compromissos = controladorCompromisso.SelecionarTodos();

            foreach (var compromisso in compromissos)
            {
                dtTodosCompromissos.Rows.Add(compromisso.Id, compromisso.Assunto, compromisso.Data.ToShortDateString(), compromisso.HoraInicio,
                    compromisso.HoraTermino, compromisso.Contato, compromisso.Local);
            }
        }

        private void PreencherTabelaContatos()
        {
            dataSetContatos.Clear();

            List<Contato> contatos = controladorContato.SelecionarTodos();

            foreach (var contato in contatos)
            {
                dtTabelaContatos.Rows.Add(contato.Id, contato.Nome);
            }
        }


        private int SelecionarIdCompromisso(DataGridView tabela)
        {
            if (dataGridFuturos.SelectedRows.Count == 0 || dataGridPassados.SelectedRows.Count == 0 || dataGridTodos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum compromisso selecionado!");

                return 0;
            }
            DataGridViewRow linhaEscolhida = tabela.SelectedRows[0];

            object idCompromisso = linhaEscolhida.Cells[0].Value;

            int idSelecionado = Convert.ToInt32(idCompromisso);

            return idSelecionado;
        }

        private int SelecionarIdContato(DataGridView tabela)
        {
            if (dataGridContatos.SelectedRows.Count == 0 )
            {
                MessageBox.Show("Nenhum contato selecionado!");

                return 0;
            }
            DataGridViewRow linhaEscolhida = tabela.SelectedRows[0];

            object idContato = linhaEscolhida.Cells[0].Value;

            int idSelecionado = Convert.ToInt32(idContato);

            return idSelecionado;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            controladorCompromisso.Excluir(SelecionarIdCompromisso(dataGridTodos));

            controladorCompromisso.Excluir(SelecionarIdCompromisso(dataGridPassados));

            controladorCompromisso.Excluir(SelecionarIdCompromisso(dataGridFuturos));
            
            PreencherTodasTabelasCompromisso();
        }

        private void PreencherTodasTabelasCompromisso()
        {
            PreencherTabelaTodosCompromissos();

            PreencherTabelaCompromissosPassados();

            PreencherTabelaCompromissosFuturos();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = InsereCompromisso();

            if(tbNome.Text == "" || tbLocal.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
            }

            controladorCompromisso.InserirNovo(compromisso);

            PreencherTodasTabelasCompromisso();

            LimparCampos();
        }

        private Compromisso InsereCompromisso()
        {
            string assunto = tbNome.Text;
            DateTime data = dateTimeDataCompromisso.Value;
            TimeSpan horaInicio = ObterHoraInicio();
            TimeSpan horaFim = ObterHoraFim();
            
            string local, link;
            
            ObterLocal(out local, out link);

            Contato contato = null;
            if (cbMarcarContato.Checked)
                contato = controladorContato.SelecionarPorId(SelecionarIdContato(dataGridContatos));

            Compromisso compromisso = new Compromisso(assunto, local, link, data,
                horaInicio, horaFim, contato);
            return compromisso;
        }

        private void ObterLocal(out string local, out string link)
        {
            local = "";
            link = "";
            if (rbPresencial.Checked)
            {
                local = tbLocal.Text;
                link = "Presencial";
            }
            else if (rbRemoto.Checked)
            {
                link = tbLocal.Text;
                local = "Remoto";
            }
        }

        private TimeSpan ObterHoraFim()
        {
            string horaFimTxt = mtbHoraFinal.Text;
            string[] horaFimArray = horaFimTxt.Split(':');
            TimeSpan horaFim = new TimeSpan(int.Parse(horaFimArray[0]), int.Parse(horaFimArray[1]), 0);
            return horaFim;
        }

        private TimeSpan ObterHoraInicio()
        {
            string horaInicioTxt = mtbHoraInicio.Text;
            string[] horaInicioArray = horaInicioTxt.Split(':');
            TimeSpan horaInicio = new TimeSpan(int.Parse(horaInicioArray[0]), int.Parse(horaInicioArray[1]), 0);

            return horaInicio;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = InsereCompromisso();

            controladorCompromisso.Editar(SelecionarIdCompromisso(dataGridTodos), compromisso);
            controladorCompromisso.Editar(SelecionarIdCompromisso(dataGridFuturos), compromisso);
            controladorCompromisso.Editar(SelecionarIdCompromisso(dataGridPassados), compromisso);

            PreencherTodasTabelasCompromisso();

            LimparCampos();
        }

        private void LimparCampos()
        {
            tbNome.Text = "";
            mtbHoraInicio.Text = "";
            mtbHoraFinal.Text = "";
            tbLocal.Text = "";
        }
    }
}
