
namespace eAgenda.WindowsForms
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.btTarefa = new System.Windows.Forms.Button();
            this.btContato = new System.Windows.Forms.Button();
            this.btCompromisso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(60, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-vindo(a)";
            // 
            // btTarefa
            // 
            this.btTarefa.BackColor = System.Drawing.Color.Indigo;
            this.btTarefa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTarefa.ForeColor = System.Drawing.Color.White;
            this.btTarefa.Location = new System.Drawing.Point(22, 118);
            this.btTarefa.Name = "btTarefa";
            this.btTarefa.Size = new System.Drawing.Size(87, 32);
            this.btTarefa.TabIndex = 1;
            this.btTarefa.Text = "Tarefa";
            this.btTarefa.UseVisualStyleBackColor = false;
            this.btTarefa.Click += new System.EventHandler(this.btTarefa_Click);
            // 
            // btContato
            // 
            this.btContato.BackColor = System.Drawing.Color.Indigo;
            this.btContato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContato.ForeColor = System.Drawing.Color.White;
            this.btContato.Location = new System.Drawing.Point(138, 118);
            this.btContato.Name = "btContato";
            this.btContato.Size = new System.Drawing.Size(90, 32);
            this.btContato.TabIndex = 2;
            this.btContato.Text = "Contato";
            this.btContato.UseVisualStyleBackColor = false;
            this.btContato.Click += new System.EventHandler(this.btContato_Click);
            // 
            // btCompromisso
            // 
            this.btCompromisso.BackColor = System.Drawing.Color.Indigo;
            this.btCompromisso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCompromisso.ForeColor = System.Drawing.Color.White;
            this.btCompromisso.Location = new System.Drawing.Point(22, 169);
            this.btCompromisso.Name = "btCompromisso";
            this.btCompromisso.Size = new System.Drawing.Size(206, 32);
            this.btCompromisso.TabIndex = 3;
            this.btCompromisso.Text = "Compromisso";
            this.btCompromisso.UseVisualStyleBackColor = false;
            this.btCompromisso.Click += new System.EventHandler(this.btCompromisso_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(252, 240);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCompromisso);
            this.Controls.Add(this.btContato);
            this.Controls.Add(this.btTarefa);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e-Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTarefa;
        private System.Windows.Forms.Button btContato;
        private System.Windows.Forms.Button btCompromisso;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

