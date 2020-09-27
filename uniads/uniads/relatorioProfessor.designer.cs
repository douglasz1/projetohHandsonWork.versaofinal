namespace uniads
{
    partial class relatorioProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(relatorioProfessor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnfecharrelatorioprofessores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.formacao,
            this.municipio,
            this.UF,
            this.logradouro,
            this.numero,
            this.curso});
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1330, 650);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1330, 650);
            this.dataGridView1.TabIndex = 19;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // formacao
            // 
            this.formacao.HeaderText = "Formação";
            this.formacao.Name = "formacao";
            this.formacao.ReadOnly = true;
            // 
            // municipio
            // 
            this.municipio.HeaderText = "Município";
            this.municipio.Name = "municipio";
            this.municipio.ReadOnly = true;
            // 
            // UF
            // 
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            // 
            // logradouro
            // 
            this.logradouro.HeaderText = "Logradouro";
            this.logradouro.Name = "logradouro";
            this.logradouro.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // curso
            // 
            this.curso.HeaderText = "Curso que leciona";
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            // 
            // btnfecharrelatorioprofessores
            // 
            this.btnfecharrelatorioprofessores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecharrelatorioprofessores.Location = new System.Drawing.Point(1266, 670);
            this.btnfecharrelatorioprofessores.Margin = new System.Windows.Forms.Padding(2);
            this.btnfecharrelatorioprofessores.Name = "btnfecharrelatorioprofessores";
            this.btnfecharrelatorioprofessores.Size = new System.Drawing.Size(73, 30);
            this.btnfecharrelatorioprofessores.TabIndex = 21;
            this.btnfecharrelatorioprofessores.Text = "Fechar";
            this.btnfecharrelatorioprofessores.UseVisualStyleBackColor = true;
            this.btnfecharrelatorioprofessores.Click += new System.EventHandler(this.btnfecharrelatorioprofessores_Click);
            // 
            // relatorioProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1350, 711);
            this.Controls.Add(this.btnfecharrelatorioprofessores);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1366, 750);
            this.Name = "relatorioProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de professores por curso";
            this.Load += new System.EventHandler(this.relatorioProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnfecharrelatorioprofessores;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn formacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
    }
}