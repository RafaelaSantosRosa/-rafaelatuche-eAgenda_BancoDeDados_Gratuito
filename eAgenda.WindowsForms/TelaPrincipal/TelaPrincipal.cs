using System;
using System.Windows.Forms;

namespace eAgenda.WindowsForms
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btTarefa_Click(object sender, EventArgs e)
        {
            TelaTarefaGUI telaTarefaGUI = new TelaTarefaGUI();
            telaTarefaGUI.Visible = true;
        }

        private void btContato_Click(object sender, EventArgs e)
        {
            TelaContato telaContato = new TelaContato();
            telaContato.Visible = true;
        }

        private void btCompromisso_Click(object sender, EventArgs e)
        {
            TelaCompromisso telaCompromisso = new TelaCompromisso();
            telaCompromisso.Visible = true;
        }

    }
}
