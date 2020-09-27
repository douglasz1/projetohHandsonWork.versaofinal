namespace uniads
{
    partial class relatorioCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(relatorioCurso));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordenador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargahoraria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnfecharrelatoriocursos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matricula,
            this.nome,
            this.grau,
            this.coordenador,
            this.cargahoraria,
            this.polo});
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1330, 650);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1330, 650);
            this.dataGridView1.TabIndex = 19;
            // 
            // matricula
            // 
            this.matricula.HeaderText = "Id";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Curso";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // grau
            // 
            this.grau.HeaderText = "Grau";
            this.grau.Name = "grau";
            this.grau.ReadOnly = true;
            // 
            // coordenador
            // 
            this.coordenador.HeaderText = "Coordenador";
            this.coordenador.Name = "coordenador";
            this.coordenador.ReadOnly = true;
            // 
            // cargahoraria
            // 
            this.cargahoraria.HeaderText = "Carga horária";
            this.cargahoraria.Name = "cargahoraria";
            this.cargahoraria.ReadOnly = true;
            // 
            // polo
            // 
            this.polo.HeaderText = "Pólo";
            this.polo.Name = "polo";
            this.polo.ReadOnly = true;
            // 
            // btnfecharrelatoriocursos
            // 
            this.btnfecharrelatoriocursos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecharrelatoriocursos.Location = new System.Drawing.Point(1266, 673);
            this.btnfecharrelatoriocursos.Margin = new System.Windows.Forms.Padding(2);
            this.btnfecharrelatoriocursos.Name = "btnfecharrelatoriocursos";
            this.btnfecharrelatoriocursos.Size = new System.Drawing.Size(73, 30);
            this.btnfecharrelatoriocursos.TabIndex = 21;
            this.btnfecharrelatoriocursos.Text = "Fechar";
            this.btnfecharrelatoriocursos.UseVisualStyleBackColor = true;
            this.btnfecharrelatoriocursos.Click += new System.EventHandler(this.btnfecharrelatoriocursos_Click);
            // 
            // relatorioCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1350, 711);
            this.Controls.Add(this.btnfecharrelatoriocursos);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1366, 750);
            this.Name = "relatorioCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de cursos ativos";
            this.Load += new System.EventHandler(this.relatorioCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnfecharrelatoriocursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn grau;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordenador;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargahoraria;
        private System.Windows.Forms.DataGridViewTextBoxColumn polo;
    }
}