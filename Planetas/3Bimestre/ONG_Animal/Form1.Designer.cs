namespace _3Bimestre.ONG_Animal
{
    partial class Form1
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
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_nameAnimal = new System.Windows.Forms.Label();
            this.lbl_typeAnimal = new System.Windows.Forms.Label();
            this.lbl_genreAnimal = new System.Windows.Forms.Label();
            this.lbl_vaccineAnimal = new System.Windows.Forms.Label();
            this.lbl_situationAnimal = new System.Windows.Forms.Label();
            this.lbl_availabletoAdoptAnimal = new System.Windows.Forms.Label();
            this.lbl_birthDateAnimal = new System.Windows.Forms.Label();
            this.txt_nameAnimal = new System.Windows.Forms.TextBox();
            this.txt_typeAnimal = new System.Windows.Forms.TextBox();
            this.txt_genreAnimal = new System.Windows.Forms.TextBox();
            this.txt_vaccineAnimal = new System.Windows.Forms.TextBox();
            this.txt_situationAnimal = new System.Windows.Forms.TextBox();
            this.txt_availabletoAdoptAnimal = new System.Windows.Forms.TextBox();
            this.dtp_birthDateAnimal = new System.Windows.Forms.DateTimePicker();
            this.btn_newAnimal = new System.Windows.Forms.Button();
            this.btn_editAnimal = new System.Windows.Forms.Button();
            this.btn_deleteAnimal = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(276, 208);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Buscar";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbl_nameAnimal
            // 
            this.lbl_nameAnimal.AutoSize = true;
            this.lbl_nameAnimal.Location = new System.Drawing.Point(34, 25);
            this.lbl_nameAnimal.Name = "lbl_nameAnimal";
            this.lbl_nameAnimal.Size = new System.Drawing.Size(83, 13);
            this.lbl_nameAnimal.TabIndex = 2;
            this.lbl_nameAnimal.Text = "Nome do animal";
            // 
            // lbl_typeAnimal
            // 
            this.lbl_typeAnimal.AutoSize = true;
            this.lbl_typeAnimal.Location = new System.Drawing.Point(210, 25);
            this.lbl_typeAnimal.Name = "lbl_typeAnimal";
            this.lbl_typeAnimal.Size = new System.Drawing.Size(76, 13);
            this.lbl_typeAnimal.TabIndex = 3;
            this.lbl_typeAnimal.Text = "Tipo de animal";
            // 
            // lbl_genreAnimal
            // 
            this.lbl_genreAnimal.AutoSize = true;
            this.lbl_genreAnimal.Location = new System.Drawing.Point(34, 75);
            this.lbl_genreAnimal.Name = "lbl_genreAnimal";
            this.lbl_genreAnimal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_genreAnimal.Size = new System.Drawing.Size(42, 13);
            this.lbl_genreAnimal.TabIndex = 4;
            this.lbl_genreAnimal.Text = "Gênero";
            // 
            // lbl_vaccineAnimal
            // 
            this.lbl_vaccineAnimal.AutoSize = true;
            this.lbl_vaccineAnimal.Location = new System.Drawing.Point(210, 75);
            this.lbl_vaccineAnimal.Name = "lbl_vaccineAnimal";
            this.lbl_vaccineAnimal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_vaccineAnimal.Size = new System.Drawing.Size(58, 13);
            this.lbl_vaccineAnimal.TabIndex = 5;
            this.lbl_vaccineAnimal.Text = "Vacinação";
            this.lbl_vaccineAnimal.Click += new System.EventHandler(this.lbl_vaccineAnimal_Click);
            // 
            // lbl_situationAnimal
            // 
            this.lbl_situationAnimal.AutoSize = true;
            this.lbl_situationAnimal.Location = new System.Drawing.Point(401, 75);
            this.lbl_situationAnimal.Name = "lbl_situationAnimal";
            this.lbl_situationAnimal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_situationAnimal.Size = new System.Drawing.Size(97, 13);
            this.lbl_situationAnimal.TabIndex = 6;
            this.lbl_situationAnimal.Text = "Situação do animal";
            this.lbl_situationAnimal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_availabletoAdoptAnimal
            // 
            this.lbl_availabletoAdoptAnimal.AutoSize = true;
            this.lbl_availabletoAdoptAnimal.Location = new System.Drawing.Point(589, 75);
            this.lbl_availabletoAdoptAnimal.Name = "lbl_availabletoAdoptAnimal";
            this.lbl_availabletoAdoptAnimal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_availabletoAdoptAnimal.Size = new System.Drawing.Size(121, 13);
            this.lbl_availabletoAdoptAnimal.TabIndex = 7;
            this.lbl_availabletoAdoptAnimal.Text = "Disponível para adoção";
            this.lbl_availabletoAdoptAnimal.Click += new System.EventHandler(this.lbl_availabletoAdoptAnimal_Click);
            // 
            // lbl_birthDateAnimal
            // 
            this.lbl_birthDateAnimal.AutoSize = true;
            this.lbl_birthDateAnimal.Location = new System.Drawing.Point(401, 25);
            this.lbl_birthDateAnimal.Name = "lbl_birthDateAnimal";
            this.lbl_birthDateAnimal.Size = new System.Drawing.Size(102, 13);
            this.lbl_birthDateAnimal.TabIndex = 8;
            this.lbl_birthDateAnimal.Text = "Data de nascimento";
            // 
            // txt_nameAnimal
            // 
            this.txt_nameAnimal.Location = new System.Drawing.Point(37, 42);
            this.txt_nameAnimal.Name = "txt_nameAnimal";
            this.txt_nameAnimal.Size = new System.Drawing.Size(129, 20);
            this.txt_nameAnimal.TabIndex = 9;
            // 
            // txt_typeAnimal
            // 
            this.txt_typeAnimal.Location = new System.Drawing.Point(213, 42);
            this.txt_typeAnimal.Name = "txt_typeAnimal";
            this.txt_typeAnimal.Size = new System.Drawing.Size(129, 20);
            this.txt_typeAnimal.TabIndex = 10;
            // 
            // txt_genreAnimal
            // 
            this.txt_genreAnimal.Location = new System.Drawing.Point(37, 91);
            this.txt_genreAnimal.Name = "txt_genreAnimal";
            this.txt_genreAnimal.Size = new System.Drawing.Size(129, 20);
            this.txt_genreAnimal.TabIndex = 11;
            // 
            // txt_vaccineAnimal
            // 
            this.txt_vaccineAnimal.Location = new System.Drawing.Point(213, 91);
            this.txt_vaccineAnimal.Name = "txt_vaccineAnimal";
            this.txt_vaccineAnimal.Size = new System.Drawing.Size(129, 20);
            this.txt_vaccineAnimal.TabIndex = 12;
            // 
            // txt_situationAnimal
            // 
            this.txt_situationAnimal.Location = new System.Drawing.Point(404, 91);
            this.txt_situationAnimal.Name = "txt_situationAnimal";
            this.txt_situationAnimal.Size = new System.Drawing.Size(129, 20);
            this.txt_situationAnimal.TabIndex = 13;
            // 
            // txt_availabletoAdoptAnimal
            // 
            this.txt_availabletoAdoptAnimal.Location = new System.Drawing.Point(592, 91);
            this.txt_availabletoAdoptAnimal.Name = "txt_availabletoAdoptAnimal";
            this.txt_availabletoAdoptAnimal.Size = new System.Drawing.Size(129, 20);
            this.txt_availabletoAdoptAnimal.TabIndex = 14;
            // 
            // dtp_birthDateAnimal
            // 
            this.dtp_birthDateAnimal.Location = new System.Drawing.Point(404, 42);
            this.dtp_birthDateAnimal.Name = "dtp_birthDateAnimal";
            this.dtp_birthDateAnimal.Size = new System.Drawing.Size(216, 20);
            this.dtp_birthDateAnimal.TabIndex = 15;
            // 
            // btn_newAnimal
            // 
            this.btn_newAnimal.BackColor = System.Drawing.Color.Lime;
            this.btn_newAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_newAnimal.Location = new System.Drawing.Point(34, 142);
            this.btn_newAnimal.Name = "btn_newAnimal";
            this.btn_newAnimal.Size = new System.Drawing.Size(132, 34);
            this.btn_newAnimal.TabIndex = 16;
            this.btn_newAnimal.Text = "Adicionar";
            this.btn_newAnimal.UseVisualStyleBackColor = false;
            // 
            // btn_editAnimal
            // 
            this.btn_editAnimal.BackColor = System.Drawing.Color.Yellow;
            this.btn_editAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_editAnimal.Location = new System.Drawing.Point(213, 142);
            this.btn_editAnimal.Name = "btn_editAnimal";
            this.btn_editAnimal.Size = new System.Drawing.Size(92, 34);
            this.btn_editAnimal.TabIndex = 17;
            this.btn_editAnimal.Text = "Editar";
            this.btn_editAnimal.UseVisualStyleBackColor = false;
            // 
            // btn_deleteAnimal
            // 
            this.btn_deleteAnimal.BackColor = System.Drawing.Color.Red;
            this.btn_deleteAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_deleteAnimal.Location = new System.Drawing.Point(352, 142);
            this.btn_deleteAnimal.Name = "btn_deleteAnimal";
            this.btn_deleteAnimal.Size = new System.Drawing.Size(92, 34);
            this.btn_deleteAnimal.TabIndex = 18;
            this.btn_deleteAnimal.Text = "Remover";
            this.btn_deleteAnimal.UseVisualStyleBackColor = false;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.Control;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_clear.Location = new System.Drawing.Point(491, 142);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(92, 34);
            this.btn_clear.TabIndex = 19;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_deleteAnimal);
            this.Controls.Add(this.btn_editAnimal);
            this.Controls.Add(this.btn_newAnimal);
            this.Controls.Add(this.dtp_birthDateAnimal);
            this.Controls.Add(this.txt_availabletoAdoptAnimal);
            this.Controls.Add(this.txt_situationAnimal);
            this.Controls.Add(this.txt_vaccineAnimal);
            this.Controls.Add(this.txt_genreAnimal);
            this.Controls.Add(this.txt_typeAnimal);
            this.Controls.Add(this.txt_nameAnimal);
            this.Controls.Add(this.lbl_birthDateAnimal);
            this.Controls.Add(this.lbl_availabletoAdoptAnimal);
            this.Controls.Add(this.lbl_situationAnimal);
            this.Controls.Add(this.lbl_vaccineAnimal);
            this.Controls.Add(this.lbl_genreAnimal);
            this.Controls.Add(this.lbl_typeAnimal);
            this.Controls.Add(this.lbl_nameAnimal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_nameAnimal;
        private System.Windows.Forms.Label lbl_typeAnimal;
        private System.Windows.Forms.Label lbl_genreAnimal;
        private System.Windows.Forms.Label lbl_vaccineAnimal;
        private System.Windows.Forms.Label lbl_situationAnimal;
        private System.Windows.Forms.Label lbl_availabletoAdoptAnimal;
        private System.Windows.Forms.Label lbl_birthDateAnimal;
        private System.Windows.Forms.TextBox txt_nameAnimal;
        private System.Windows.Forms.TextBox txt_typeAnimal;
        private System.Windows.Forms.TextBox txt_genreAnimal;
        private System.Windows.Forms.TextBox txt_vaccineAnimal;
        private System.Windows.Forms.TextBox txt_situationAnimal;
        private System.Windows.Forms.TextBox txt_availabletoAdoptAnimal;
        private System.Windows.Forms.DateTimePicker dtp_birthDateAnimal;
        private System.Windows.Forms.Button btn_newAnimal;
        private System.Windows.Forms.Button btn_editAnimal;
        private System.Windows.Forms.Button btn_deleteAnimal;
        private System.Windows.Forms.Button btn_clear;
    }
}