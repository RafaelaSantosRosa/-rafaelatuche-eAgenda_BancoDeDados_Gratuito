
namespace eAgenda.WindowsForms
{
    partial class TelaTarefaGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTarefaGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPrioridade = new System.Windows.Forms.ComboBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPendentes = new System.Windows.Forms.TabPage();
            this.dataGridViewPendentes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetTarefasPendentes = new System.Data.DataSet();
            this.dtPendentes = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.tbConcluidas = new System.Windows.Forms.TabPage();
            this.dataGridViewTarefasConcluidas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioridadeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentagemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeInicioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeConclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetConcluidas = new System.Data.DataSet();
            this.dtTarefasConcluidas = new System.Data.DataTable();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.tbPorcentagem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerConclusao = new System.Windows.Forms.DateTimePicker();
            this.btVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpPendentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTarefasPendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPendentes)).BeginInit();
            this.tbConcluidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefasConcluidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConcluidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefasConcluidas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(244, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controle de Tarefas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(39, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(40, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prioridade";
            // 
            // cbPrioridade
            // 
            this.cbPrioridade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrioridade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbPrioridade.FormattingEnabled = true;
            this.cbPrioridade.Items.AddRange(new object[] {
            "Baixa",
            "Normal",
            "Alta"});
            this.cbPrioridade.Location = new System.Drawing.Point(146, 138);
            this.cbPrioridade.Name = "cbPrioridade";
            this.cbPrioridade.Size = new System.Drawing.Size(146, 26);
            this.cbPrioridade.TabIndex = 4;
            this.cbPrioridade.Text = "(Selecione)";
            this.cbPrioridade.SelectedIndexChanged += new System.EventHandler(this.cbPrioridade_SelectedIndexChanged);
            // 
            // tbTitulo
            // 
            this.tbTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTitulo.Location = new System.Drawing.Point(97, 98);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(242, 23);
            this.tbTitulo.TabIndex = 5;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Indigo;
            this.btCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.Color.White;
            this.btCadastrar.Location = new System.Drawing.Point(43, 376);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(605, 33);
            this.btCadastrar.TabIndex = 6;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(199, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPendentes);
            this.tabControl1.Controls.Add(this.tbConcluidas);
            this.tabControl1.Location = new System.Drawing.Point(43, 189);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 179);
            this.tabControl1.TabIndex = 10;
            // 
            // tpPendentes
            // 
            this.tpPendentes.BackColor = System.Drawing.Color.Silver;
            this.tpPendentes.Controls.Add(this.dataGridViewPendentes);
            this.tpPendentes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPendentes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpPendentes.Location = new System.Drawing.Point(4, 22);
            this.tpPendentes.Name = "tpPendentes";
            this.tpPendentes.Padding = new System.Windows.Forms.Padding(3);
            this.tpPendentes.Size = new System.Drawing.Size(597, 153);
            this.tpPendentes.TabIndex = 0;
            this.tpPendentes.Text = "Pendentes";
            // 
            // dataGridViewPendentes
            // 
            this.dataGridViewPendentes.AutoGenerateColumns = false;
            this.dataGridViewPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.prioridadeDataGridViewTextBoxColumn,
            this.porcentagemDataGridViewTextBoxColumn,
            this.dataDeInicioDataGridViewTextBoxColumn,
            this.dataFinalDataGridViewTextBoxColumn});
            this.dataGridViewPendentes.DataMember = "dtPendentes";
            this.dataGridViewPendentes.DataSource = this.dataSetTarefasPendentes;
            this.dataGridViewPendentes.Location = new System.Drawing.Point(0, -2);
            this.dataGridViewPendentes.MultiSelect = false;
            this.dataGridViewPendentes.Name = "dataGridViewPendentes";
            this.dataGridViewPendentes.ReadOnly = true;
            this.dataGridViewPendentes.RowHeadersVisible = false;
            this.dataGridViewPendentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPendentes.ShowCellToolTips = false;
            this.dataGridViewPendentes.Size = new System.Drawing.Size(599, 159);
            this.dataGridViewPendentes.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prioridadeDataGridViewTextBoxColumn
            // 
            this.prioridadeDataGridViewTextBoxColumn.DataPropertyName = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.HeaderText = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn.Name = "prioridadeDataGridViewTextBoxColumn";
            this.prioridadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porcentagemDataGridViewTextBoxColumn
            // 
            this.porcentagemDataGridViewTextBoxColumn.DataPropertyName = "Porcentagem";
            this.porcentagemDataGridViewTextBoxColumn.HeaderText = "Porcentagem";
            this.porcentagemDataGridViewTextBoxColumn.Name = "porcentagemDataGridViewTextBoxColumn";
            this.porcentagemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDeInicioDataGridViewTextBoxColumn
            // 
            this.dataDeInicioDataGridViewTextBoxColumn.DataPropertyName = "Data de Inicio";
            this.dataDeInicioDataGridViewTextBoxColumn.HeaderText = "Data de Inicio";
            this.dataDeInicioDataGridViewTextBoxColumn.Name = "dataDeInicioDataGridViewTextBoxColumn";
            this.dataDeInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFinalDataGridViewTextBoxColumn
            // 
            this.dataFinalDataGridViewTextBoxColumn.DataPropertyName = "Data Final";
            this.dataFinalDataGridViewTextBoxColumn.HeaderText = "Data Final";
            this.dataFinalDataGridViewTextBoxColumn.Name = "dataFinalDataGridViewTextBoxColumn";
            this.dataFinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSetTarefasPendentes
            // 
            this.dataSetTarefasPendentes.DataSetName = "NewDataSet";
            this.dataSetTarefasPendentes.Tables.AddRange(new System.Data.DataTable[] {
            this.dtPendentes});
            // 
            // dtPendentes
            // 
            this.dtPendentes.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6});
            this.dtPendentes.TableName = "dtPendentes";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Título";
            this.dataColumn2.ColumnName = "Titulo";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Prioridade";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Porcentagem";
            this.dataColumn4.ColumnName = "Porcentagem";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "Data de Início";
            this.dataColumn5.ColumnName = "Data de Inicio";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Data Final";
            // 
            // tbConcluidas
            // 
            this.tbConcluidas.BackColor = System.Drawing.Color.Silver;
            this.tbConcluidas.Controls.Add(this.dataGridViewTarefasConcluidas);
            this.tbConcluidas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConcluidas.Location = new System.Drawing.Point(4, 22);
            this.tbConcluidas.Name = "tbConcluidas";
            this.tbConcluidas.Padding = new System.Windows.Forms.Padding(3);
            this.tbConcluidas.Size = new System.Drawing.Size(597, 153);
            this.tbConcluidas.TabIndex = 1;
            this.tbConcluidas.Text = "Concluídas";
            // 
            // dataGridViewTarefasConcluidas
            // 
            this.dataGridViewTarefasConcluidas.AutoGenerateColumns = false;
            this.dataGridViewTarefasConcluidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTarefasConcluidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.tituloDataGridViewTextBoxColumn1,
            this.prioridadeDataGridViewTextBoxColumn1,
            this.porcentagemDataGridViewTextBoxColumn1,
            this.dataDeInicioDataGridViewTextBoxColumn1,
            this.dataDeConclusaoDataGridViewTextBoxColumn});
            this.dataGridViewTarefasConcluidas.DataMember = "dtTarefasConcluidas";
            this.dataGridViewTarefasConcluidas.DataSource = this.dataSetConcluidas;
            this.dataGridViewTarefasConcluidas.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTarefasConcluidas.Name = "dataGridViewTarefasConcluidas";
            this.dataGridViewTarefasConcluidas.RowHeadersVisible = false;
            this.dataGridViewTarefasConcluidas.Size = new System.Drawing.Size(608, 111);
            this.dataGridViewTarefasConcluidas.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // tituloDataGridViewTextBoxColumn1
            // 
            this.tituloDataGridViewTextBoxColumn1.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn1.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn1.Name = "tituloDataGridViewTextBoxColumn1";
            // 
            // prioridadeDataGridViewTextBoxColumn1
            // 
            this.prioridadeDataGridViewTextBoxColumn1.DataPropertyName = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn1.HeaderText = "Prioridade";
            this.prioridadeDataGridViewTextBoxColumn1.Name = "prioridadeDataGridViewTextBoxColumn1";
            // 
            // porcentagemDataGridViewTextBoxColumn1
            // 
            this.porcentagemDataGridViewTextBoxColumn1.DataPropertyName = "Porcentagem";
            this.porcentagemDataGridViewTextBoxColumn1.HeaderText = "Porcentagem";
            this.porcentagemDataGridViewTextBoxColumn1.Name = "porcentagemDataGridViewTextBoxColumn1";
            // 
            // dataDeInicioDataGridViewTextBoxColumn1
            // 
            this.dataDeInicioDataGridViewTextBoxColumn1.DataPropertyName = "Data de Inicio";
            this.dataDeInicioDataGridViewTextBoxColumn1.HeaderText = "Data de Inicio";
            this.dataDeInicioDataGridViewTextBoxColumn1.Name = "dataDeInicioDataGridViewTextBoxColumn1";
            // 
            // dataDeConclusaoDataGridViewTextBoxColumn
            // 
            this.dataDeConclusaoDataGridViewTextBoxColumn.DataPropertyName = "Data de Conclusao";
            this.dataDeConclusaoDataGridViewTextBoxColumn.HeaderText = "Data de Conclusao";
            this.dataDeConclusaoDataGridViewTextBoxColumn.Name = "dataDeConclusaoDataGridViewTextBoxColumn";
            // 
            // dataSetConcluidas
            // 
            this.dataSetConcluidas.DataSetName = "NewDataSet";
            this.dataSetConcluidas.Tables.AddRange(new System.Data.DataTable[] {
            this.dtTarefasConcluidas});
            // 
            // dtTarefasConcluidas
            // 
            this.dtTarefasConcluidas.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12});
            this.dtTarefasConcluidas.TableName = "dtTarefasConcluidas";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Id";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "Título";
            this.dataColumn8.ColumnName = "Titulo";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Prioridade";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Porcentagem";
            // 
            // dataColumn11
            // 
            this.dataColumn11.Caption = "Data de Início";
            this.dataColumn11.ColumnName = "Data de Inicio";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "Data de Conclusao";
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.Indigo;
            this.btEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.White;
            this.btEditar.Location = new System.Drawing.Point(249, 415);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(171, 33);
            this.btEditar.TabIndex = 6;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Indigo;
            this.btExcluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.White;
            this.btExcluir.Location = new System.Drawing.Point(488, 414);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(160, 32);
            this.btExcluir.TabIndex = 11;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // tbPorcentagem
            // 
            this.tbPorcentagem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPorcentagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPorcentagem.Location = new System.Drawing.Point(560, 144);
            this.tbPorcentagem.Name = "tbPorcentagem";
            this.tbPorcentagem.Size = new System.Drawing.Size(84, 23);
            this.tbPorcentagem.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(426, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Porcentagem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(393, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Data de Conclusão";
            // 
            // dateTimePickerConclusao
            // 
            this.dateTimePickerConclusao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerConclusao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerConclusao.Location = new System.Drawing.Point(563, 98);
            this.dateTimePickerConclusao.Name = "dateTimePickerConclusao";
            this.dateTimePickerConclusao.Size = new System.Drawing.Size(81, 20);
            this.dateTimePickerConclusao.TabIndex = 15;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.Indigo;
            this.btVoltar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Location = new System.Drawing.Point(43, 414);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(151, 33);
            this.btVoltar.TabIndex = 16;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // TelaTarefaGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 461);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.dateTimePickerConclusao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPorcentagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.cbPrioridade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaTarefaGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpPendentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTarefasPendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPendentes)).EndInit();
            this.tbConcluidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarefasConcluidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetConcluidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarefasConcluidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPrioridade;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPendentes;
        private System.Windows.Forms.TabPage tbConcluidas;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.DataGridView dataGridViewPendentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinalDataGridViewTextBoxColumn;
        private System.Data.DataSet dataSetTarefasPendentes;
        private System.Data.DataTable dtPendentes;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Windows.Forms.TextBox tbPorcentagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerConclusao;
        private System.Windows.Forms.DataGridView dataGridViewTarefasConcluidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioridadeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentagemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeInicioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeConclusaoDataGridViewTextBoxColumn;
        private System.Data.DataSet dataSetConcluidas;
        private System.Data.DataTable dtTarefasConcluidas;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Windows.Forms.Button btVoltar;
    }
}