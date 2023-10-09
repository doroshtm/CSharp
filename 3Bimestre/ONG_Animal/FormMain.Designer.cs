namespace ONG_Pet_2a
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.TsmCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAnimais = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAdopter = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.TsRodape = new System.Windows.Forms.StatusStrip();
            this.DtgAdoption = new System.Windows.Forms.DataGridView();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.LblBusca = new System.Windows.Forms.Label();
            this.BtnBusca = new System.Windows.Forms.Button();
            this.TxtStatus = new System.Windows.Forms.TextBox();
            this.TxtInformacoes = new System.Windows.Forms.TextBox();
            this.DtAdoption = new System.Windows.Forms.DateTimePicker();
            this.LblAnimal = new System.Windows.Forms.Label();
            this.LblDataAdoption = new System.Windows.Forms.Label();
            this.LblInformacoes = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblAdopter = new System.Windows.Forms.Label();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.CblAdopter = new System.Windows.Forms.ComboBox();
            this.CblAnimal = new System.Windows.Forms.ComboBox();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAdoption)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmCadastros,
            this.TsmAjuda});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(827, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // TsmCadastros
            // 
            this.TsmCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiAnimais,
            this.TsmiAdopter});
            this.TsmCadastros.Name = "TsmCadastros";
            this.TsmCadastros.Size = new System.Drawing.Size(71, 20);
            this.TsmCadastros.Text = "Cadastros";
            // 
            // TsmiAnimais
            // 
            this.TsmiAnimais.Name = "TsmiAnimais";
            this.TsmiAnimais.Size = new System.Drawing.Size(122, 22);
            this.TsmiAnimais.Text = "Animais";
            this.TsmiAnimais.Click += new System.EventHandler(this.TsmiAnimais_Click);
            // 
            // TsmiAdopter
            // 
            this.TsmiAdopter.Name = "TsmiAdopter";
            this.TsmiAdopter.Size = new System.Drawing.Size(122, 22);
            this.TsmiAdopter.Text = "Adopters";
            this.TsmiAdopter.Click += new System.EventHandler(this.TsmiAdopter_Click);
            // 
            // TsmAjuda
            // 
            this.TsmAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiAjuda});
            this.TsmAjuda.Name = "TsmAjuda";
            this.TsmAjuda.Size = new System.Drawing.Size(50, 20);
            this.TsmAjuda.Text = "Ajuda";
            // 
            // TsmiAjuda
            // 
            this.TsmiAjuda.Name = "TsmiAjuda";
            this.TsmiAjuda.Size = new System.Drawing.Size(105, 22);
            this.TsmiAjuda.Text = "Ajuda";
            this.TsmiAjuda.Click += new System.EventHandler(this.TsmiAjuda_Click);
            // 
            // TsRodape
            // 
            this.TsRodape.Location = new System.Drawing.Point(0, 437);
            this.TsRodape.Name = "TsRodape";
            this.TsRodape.Size = new System.Drawing.Size(827, 22);
            this.TsRodape.TabIndex = 1;
            this.TsRodape.Text = "statusStrip1";
            // 
            // DtgAdoption
            // 
            this.DtgAdoption.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgAdoption.Location = new System.Drawing.Point(25, 268);
            this.DtgAdoption.Name = "DtgAdoption";
            this.DtgAdoption.Size = new System.Drawing.Size(768, 150);
            this.DtgAdoption.TabIndex = 2;
            this.DtgAdoption.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgAdoption_RowHeaderMouseClick);
            // 
            // TxtBusca
            // 
            this.TxtBusca.Location = new System.Drawing.Point(105, 234);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(244, 20);
            this.TxtBusca.TabIndex = 3;
            // 
            // LblBusca
            // 
            this.LblBusca.AutoSize = true;
            this.LblBusca.Location = new System.Drawing.Point(25, 237);
            this.LblBusca.Name = "LblBusca";
            this.LblBusca.Size = new System.Drawing.Size(74, 13);
            this.LblBusca.TabIndex = 4;
            this.LblBusca.Text = "Pesquisar por:";
            // 
            // BtnBusca
            // 
            this.BtnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBusca.Location = new System.Drawing.Point(355, 232);
            this.BtnBusca.Name = "BtnBusca";
            this.BtnBusca.Size = new System.Drawing.Size(31, 23);
            this.BtnBusca.TabIndex = 5;
            this.BtnBusca.UseVisualStyleBackColor = true;
            this.BtnBusca.Click += new System.EventHandler(this.BtnBusca_Click);
            // 
            // TxtStatus
            // 
            this.TxtStatus.Location = new System.Drawing.Point(500, 64);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(213, 20);
            this.TxtStatus.TabIndex = 7;
            // 
            // TxtInformacoes
            // 
            this.TxtInformacoes.Location = new System.Drawing.Point(251, 119);
            this.TxtInformacoes.Name = "TxtInformacoes";
            this.TxtInformacoes.Size = new System.Drawing.Size(462, 20);
            this.TxtInformacoes.TabIndex = 8;
            // 
            // DtAdoption
            // 
            this.DtAdoption.Location = new System.Drawing.Point(25, 119);
            this.DtAdoption.Name = "DtAdoption";
            this.DtAdoption.Size = new System.Drawing.Size(200, 20);
            this.DtAdoption.TabIndex = 10;
            // 
            // LblAnimal
            // 
            this.LblAnimal.AutoSize = true;
            this.LblAnimal.Location = new System.Drawing.Point(22, 48);
            this.LblAnimal.Name = "LblAnimal";
            this.LblAnimal.Size = new System.Drawing.Size(87, 13);
            this.LblAnimal.TabIndex = 11;
            this.LblAnimal.Text = "Nome do Animal:";
            // 
            // LblDataAdoption
            // 
            this.LblDataAdoption.AutoSize = true;
            this.LblDataAdoption.Location = new System.Drawing.Point(22, 103);
            this.LblDataAdoption.Name = "LblDataAdoption";
            this.LblDataAdoption.Size = new System.Drawing.Size(88, 13);
            this.LblDataAdoption.TabIndex = 12;
            this.LblDataAdoption.Text = "Data da Adoção:";
            // 
            // LblInformacoes
            // 
            this.LblInformacoes.AutoSize = true;
            this.LblInformacoes.Location = new System.Drawing.Point(248, 103);
            this.LblInformacoes.Name = "LblInformacoes";
            this.LblInformacoes.Size = new System.Drawing.Size(65, 13);
            this.LblInformacoes.TabIndex = 13;
            this.LblInformacoes.Text = "Informações";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(497, 48);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(49, 13);
            this.LblStatus.TabIndex = 14;
            this.LblStatus.Text = "Situação";
            // 
            // LblAdopter
            // 
            this.LblAdopter.AutoSize = true;
            this.LblAdopter.Location = new System.Drawing.Point(224, 48);
            this.LblAdopter.Name = "LblAdopter";
            this.LblAdopter.Size = new System.Drawing.Size(90, 13);
            this.LblAdopter.TabIndex = 15;
            this.LblAdopter.Text = "Pessoa adotante:";
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnNovo.Location = new System.Drawing.Point(25, 167);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(105, 40);
            this.BtnNovo.TabIndex = 16;
            this.BtnNovo.Text = "Nova Adoção";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnCancelar.Location = new System.Drawing.Point(410, 167);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(105, 40);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Visible = false;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.Tomato;
            this.BtnExcluir.Location = new System.Drawing.Point(284, 167);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(105, 40);
            this.BtnExcluir.TabIndex = 18;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Visible = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Khaki;
            this.BtnEditar.Location = new System.Drawing.Point(154, 167);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(105, 40);
            this.BtnEditar.TabIndex = 19;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Visible = false;
            // 
            // CblAdopter
            // 
            this.CblAdopter.FormattingEnabled = true;
            this.CblAdopter.Location = new System.Drawing.Point(227, 63);
            this.CblAdopter.Name = "CblAdopter";
            this.CblAdopter.Size = new System.Drawing.Size(238, 21);
            this.CblAdopter.TabIndex = 20;
            this.CblAdopter.SelectedIndexChanged += new System.EventHandler(this.CblAdopter_SelectedIndexChanged);
            // 
            // CblAnimal
            // 
            this.CblAnimal.FormattingEnabled = true;
            this.CblAnimal.Location = new System.Drawing.Point(25, 63);
            this.CblAnimal.Name = "CblAnimal";
            this.CblAnimal.Size = new System.Drawing.Size(165, 21);
            this.CblAnimal.TabIndex = 21;
            this.CblAnimal.SelectedIndexChanged += new System.EventHandler(this.CblAnimal_SelectedIndexChanged);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 459);
            this.Controls.Add(this.CblAnimal);
            this.Controls.Add(this.CblAdopter);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.LblAdopter);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblInformacoes);
            this.Controls.Add(this.LblDataAdoption);
            this.Controls.Add(this.LblAnimal);
            this.Controls.Add(this.DtAdoption);
            this.Controls.Add(this.TxtInformacoes);
            this.Controls.Add(this.TxtStatus);
            this.Controls.Add(this.BtnBusca);
            this.Controls.Add(this.LblBusca);
            this.Controls.Add(this.TxtBusca);
            this.Controls.Add(this.DtgAdoption);
            this.Controls.Add(this.TsRodape);
            this.Controls.Add(this.MenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "ONG Pet do CTI - INI2B";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAdoption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem TsmCadastros;
        private System.Windows.Forms.ToolStripMenuItem TsmiAnimais;
        private System.Windows.Forms.ToolStripMenuItem TsmiAdopter;
        private System.Windows.Forms.ToolStripMenuItem TsmAjuda;
        private System.Windows.Forms.ToolStripMenuItem TsmiAjuda;
        private System.Windows.Forms.StatusStrip TsRodape;
        private System.Windows.Forms.DataGridView DtgAdoption;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.Label LblBusca;
        private System.Windows.Forms.Button BtnBusca;
        private System.Windows.Forms.TextBox TxtStatus;
        private System.Windows.Forms.TextBox TxtInformacoes;
        private System.Windows.Forms.DateTimePicker DtAdoption;
        private System.Windows.Forms.Label LblAnimal;
        private System.Windows.Forms.Label LblDataAdoption;
        private System.Windows.Forms.Label LblInformacoes;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblAdopter;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.ComboBox CblAdopter;
        private System.Windows.Forms.ComboBox CblAnimal;
    }
}

