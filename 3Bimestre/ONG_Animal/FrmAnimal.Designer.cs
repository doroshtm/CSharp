namespace ONG_Animal
{
    partial class FrmAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnimal));
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovaAdocao = new System.Windows.Forms.Button();
            this.LblVacinacao = new System.Windows.Forms.Label();
            this.LblStatusAnimal = new System.Windows.Forms.Label();
            this.LblNomeAnimal = new System.Windows.Forms.Label();
            this.LblTipoAnimal = new System.Windows.Forms.Label();
            this.TxtVacinacao = new System.Windows.Forms.TextBox();
            this.TxtSituacao = new System.Windows.Forms.TextBox();
            this.TxtAnimalTipo = new System.Windows.Forms.TextBox();
            this.TxtAnimalNome = new System.Windows.Forms.TextBox();
            this.LblBusca = new System.Windows.Forms.Label();
            this.BtnBusca = new System.Windows.Forms.Button();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.DtgAnimal = new System.Windows.Forms.DataGridView();
            this.StripRodape = new System.Windows.Forms.StatusStrip();
            this.LblDispo = new System.Windows.Forms.Label();
            this.TxtDisponivel = new System.Windows.Forms.TextBox();
            this.LblGenero = new System.Windows.Forms.Label();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.DtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.LblDataNascimento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.MistyRose;
            this.BtnCancelar.Location = new System.Drawing.Point(320, 127);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(84, 24);
            this.BtnCancelar.TabIndex = 34;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Visible = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Location = new System.Drawing.Point(224, 127);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(84, 24);
            this.BtnDelete.TabIndex = 33;
            this.BtnDelete.Text = "Excluir";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Visible = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Yellow;
            this.BtnEditar.Location = new System.Drawing.Point(118, 127);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(84, 24);
            this.BtnEditar.TabIndex = 32;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Visible = false;
            // 
            // BtnNovaAdocao
            // 
            this.BtnNovaAdocao.BackColor = System.Drawing.Color.Lime;
            this.BtnNovaAdocao.Location = new System.Drawing.Point(12, 127);
            this.BtnNovaAdocao.Name = "BtnNovaAdocao";
            this.BtnNovaAdocao.Size = new System.Drawing.Size(84, 24);
            this.BtnNovaAdocao.TabIndex = 31;
            this.BtnNovaAdocao.Text = "Nova adoção";
            this.BtnNovaAdocao.UseVisualStyleBackColor = false;
            // 
            // LblVacinacao
            // 
            this.LblVacinacao.AutoSize = true;
            this.LblVacinacao.Location = new System.Drawing.Point(191, 63);
            this.LblVacinacao.Name = "LblVacinacao";
            this.LblVacinacao.Size = new System.Drawing.Size(61, 13);
            this.LblVacinacao.TabIndex = 30;
            this.LblVacinacao.Text = "Vacinação:";
            this.LblVacinacao.Click += new System.EventHandler(this.LblVacinacao_Click);
            // 
            // LblStatusAnimal
            // 
            this.LblStatusAnimal.AutoSize = true;
            this.LblStatusAnimal.Location = new System.Drawing.Point(341, 63);
            this.LblStatusAnimal.Name = "LblStatusAnimal";
            this.LblStatusAnimal.Size = new System.Drawing.Size(100, 13);
            this.LblStatusAnimal.TabIndex = 29;
            this.LblStatusAnimal.Text = "Situação da animal:";
            this.LblStatusAnimal.Click += new System.EventHandler(this.LblStatusAnimal_Click);
            // 
            // LblNomeAnimal
            // 
            this.LblNomeAnimal.AutoSize = true;
            this.LblNomeAnimal.Location = new System.Drawing.Point(9, 24);
            this.LblNomeAnimal.Name = "LblNomeAnimal";
            this.LblNomeAnimal.Size = new System.Drawing.Size(86, 13);
            this.LblNomeAnimal.TabIndex = 28;
            this.LblNomeAnimal.Text = "Nome do animal:";
            // 
            // LblTipoAnimal
            // 
            this.LblTipoAnimal.AutoSize = true;
            this.LblTipoAnimal.Location = new System.Drawing.Point(115, 21);
            this.LblTipoAnimal.Name = "LblTipoAnimal";
            this.LblTipoAnimal.Size = new System.Drawing.Size(76, 13);
            this.LblTipoAnimal.TabIndex = 27;
            this.LblTipoAnimal.Text = "Tipo do animal";
            // 
            // TxtVacinacao
            // 
            this.TxtVacinacao.Location = new System.Drawing.Point(194, 82);
            this.TxtVacinacao.Name = "TxtVacinacao";
            this.TxtVacinacao.Size = new System.Drawing.Size(143, 20);
            this.TxtVacinacao.TabIndex = 26;
            this.TxtVacinacao.TextChanged += new System.EventHandler(this.TxtVacinacao_TextChanged);
            // 
            // TxtSituacao
            // 
            this.TxtSituacao.Location = new System.Drawing.Point(342, 82);
            this.TxtSituacao.Name = "TxtSituacao";
            this.TxtSituacao.Size = new System.Drawing.Size(105, 20);
            this.TxtSituacao.TabIndex = 25;
            this.TxtSituacao.TextChanged += new System.EventHandler(this.TxtSituacao_TextChanged);
            // 
            // TxtAnimalTipo
            // 
            this.TxtAnimalTipo.Location = new System.Drawing.Point(118, 40);
            this.TxtAnimalTipo.Name = "TxtAnimalTipo";
            this.TxtAnimalTipo.Size = new System.Drawing.Size(100, 20);
            this.TxtAnimalTipo.TabIndex = 24;
            // 
            // TxtAnimalNome
            // 
            this.TxtAnimalNome.Location = new System.Drawing.Point(12, 40);
            this.TxtAnimalNome.Name = "TxtAnimalNome";
            this.TxtAnimalNome.Size = new System.Drawing.Size(100, 20);
            this.TxtAnimalNome.TabIndex = 23;
            // 
            // LblBusca
            // 
            this.LblBusca.AutoSize = true;
            this.LblBusca.Location = new System.Drawing.Point(12, 160);
            this.LblBusca.Name = "LblBusca";
            this.LblBusca.Size = new System.Drawing.Size(58, 13);
            this.LblBusca.TabIndex = 22;
            this.LblBusca.Text = "Busca por:";
            // 
            // BtnBusca
            // 
            this.BtnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBusca.Location = new System.Drawing.Point(353, 158);
            this.BtnBusca.Name = "BtnBusca";
            this.BtnBusca.Size = new System.Drawing.Size(29, 23);
            this.BtnBusca.TabIndex = 21;
            this.BtnBusca.UseVisualStyleBackColor = true;
            // 
            // TxtBusca
            // 
            this.TxtBusca.Location = new System.Drawing.Point(74, 158);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(273, 20);
            this.TxtBusca.TabIndex = 20;
            // 
            // DtgAnimal
            // 
            this.DtgAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgAnimal.Location = new System.Drawing.Point(12, 184);
            this.DtgAnimal.Name = "DtgAnimal";
            this.DtgAnimal.Size = new System.Drawing.Size(501, 130);
            this.DtgAnimal.TabIndex = 19;
            // 
            // StripRodape
            // 
            this.StripRodape.Location = new System.Drawing.Point(0, 428);
            this.StripRodape.Name = "StripRodape";
            this.StripRodape.Size = new System.Drawing.Size(800, 22);
            this.StripRodape.TabIndex = 18;
            this.StripRodape.Text = "statusStrip1";
            // 
            // LblDispo
            // 
            this.LblDispo.AutoSize = true;
            this.LblDispo.Location = new System.Drawing.Point(458, 63);
            this.LblDispo.Name = "LblDispo";
            this.LblDispo.Size = new System.Drawing.Size(122, 13);
            this.LblDispo.TabIndex = 36;
            this.LblDispo.Text = "Disponivel para adoção:";
            this.LblDispo.Click += new System.EventHandler(this.LblDispo_Click);
            // 
            // TxtDisponivel
            // 
            this.TxtDisponivel.Location = new System.Drawing.Point(461, 82);
            this.TxtDisponivel.Name = "TxtDisponivel";
            this.TxtDisponivel.Size = new System.Drawing.Size(174, 20);
            this.TxtDisponivel.TabIndex = 35;
            this.TxtDisponivel.TextChanged += new System.EventHandler(this.TxtDisponivel_TextChanged);
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Location = new System.Drawing.Point(9, 66);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(45, 13);
            this.LblGenero.TabIndex = 38;
            this.LblGenero.Text = "Genero:";
            // 
            // TxtGenero
            // 
            this.TxtGenero.Location = new System.Drawing.Point(12, 82);
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(174, 20);
            this.TxtGenero.TabIndex = 37;
            // 
            // DtpDataNascimento
            // 
            this.DtpDataNascimento.Location = new System.Drawing.Point(224, 40);
            this.DtpDataNascimento.Name = "DtpDataNascimento";
            this.DtpDataNascimento.Size = new System.Drawing.Size(200, 20);
            this.DtpDataNascimento.TabIndex = 39;
            // 
            // LblDataNascimento
            // 
            this.LblDataNascimento.AutoSize = true;
            this.LblDataNascimento.Location = new System.Drawing.Point(221, 21);
            this.LblDataNascimento.Name = "LblDataNascimento";
            this.LblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.LblDataNascimento.TabIndex = 40;
            this.LblDataNascimento.Text = "Data de Nascimento:";
            // 
            // FrmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblDataNascimento);
            this.Controls.Add(this.DtpDataNascimento);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.TxtGenero);
            this.Controls.Add(this.LblDispo);
            this.Controls.Add(this.TxtDisponivel);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovaAdocao);
            this.Controls.Add(this.LblVacinacao);
            this.Controls.Add(this.LblStatusAnimal);
            this.Controls.Add(this.LblNomeAnimal);
            this.Controls.Add(this.LblTipoAnimal);
            this.Controls.Add(this.TxtVacinacao);
            this.Controls.Add(this.TxtSituacao);
            this.Controls.Add(this.TxtAnimalTipo);
            this.Controls.Add(this.TxtAnimalNome);
            this.Controls.Add(this.LblBusca);
            this.Controls.Add(this.BtnBusca);
            this.Controls.Add(this.TxtBusca);
            this.Controls.Add(this.DtgAnimal);
            this.Controls.Add(this.StripRodape);
            this.Name = "FrmAnimal";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgAnimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovaAdocao;
        private System.Windows.Forms.Label LblVacinacao;
        private System.Windows.Forms.Label LblStatusAnimal;
        private System.Windows.Forms.Label LblNomeAnimal;
        private System.Windows.Forms.Label LblTipoAnimal;
        private System.Windows.Forms.TextBox TxtVacinacao;
        private System.Windows.Forms.TextBox TxtSituacao;
        private System.Windows.Forms.TextBox TxtAnimalTipo;
        private System.Windows.Forms.TextBox TxtAnimalNome;
        private System.Windows.Forms.Label LblBusca;
        private System.Windows.Forms.Button BtnBusca;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.DataGridView DtgAnimal;
        private System.Windows.Forms.StatusStrip StripRodape;
        private System.Windows.Forms.Label LblDispo;
        private System.Windows.Forms.TextBox TxtDisponivel;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.DateTimePicker DtpDataNascimento;
        private System.Windows.Forms.Label LblDataNascimento;
    }
}