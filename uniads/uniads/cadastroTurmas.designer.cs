namespace uniads
{
    partial class cadastroTurmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroTurmas));
            this.btnnovoturma = new System.Windows.Forms.Button();
            this.txtidturma = new System.Windows.Forms.TextBox();
            this.btninserirturma = new System.Windows.Forms.Button();
            this.btnalterarturma = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnfecharturma = new System.Windows.Forms.Button();
            this.cbxcursoturma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxprofessorturma = new System.Windows.Forms.ComboBox();
            this.cbxpoloturma = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridalunosmatriculados = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstatusturma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnliberar = new System.Windows.Forms.Button();
            this.lblstatusturmas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridalunosmatriculados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnnovoturma
            // 
            this.btnnovoturma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovoturma.Location = new System.Drawing.Point(880, 117);
            this.btnnovoturma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnovoturma.Name = "btnnovoturma";
            this.btnnovoturma.Size = new System.Drawing.Size(97, 37);
            this.btnnovoturma.TabIndex = 41;
            this.btnnovoturma.Text = "Limpar";
            this.btnnovoturma.UseVisualStyleBackColor = true;
            this.btnnovoturma.Click += new System.EventHandler(this.btnnovoturma_Click);
            // 
            // txtidturma
            // 
            this.txtidturma.Enabled = false;
            this.txtidturma.Location = new System.Drawing.Point(15, 28);
            this.txtidturma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtidturma.Name = "txtidturma";
            this.txtidturma.ReadOnly = true;
            this.txtidturma.Size = new System.Drawing.Size(172, 22);
            this.txtidturma.TabIndex = 38;
            // 
            // btninserirturma
            // 
            this.btninserirturma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserirturma.Location = new System.Drawing.Point(880, 117);
            this.btninserirturma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btninserirturma.Name = "btninserirturma";
            this.btninserirturma.Size = new System.Drawing.Size(97, 37);
            this.btninserirturma.TabIndex = 37;
            this.btninserirturma.Text = "Inserir";
            this.btninserirturma.UseVisualStyleBackColor = true;
            this.btninserirturma.Click += new System.EventHandler(this.btninserirturma_Click);
            // 
            // btnalterarturma
            // 
            this.btnalterarturma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterarturma.Location = new System.Drawing.Point(777, 117);
            this.btnalterarturma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnalterarturma.Name = "btnalterarturma";
            this.btnalterarturma.Size = new System.Drawing.Size(97, 37);
            this.btnalterarturma.TabIndex = 36;
            this.btnalterarturma.Text = "Alterar";
            this.btnalterarturma.UseVisualStyleBackColor = true;
            this.btnalterarturma.Click += new System.EventHandler(this.btnalterarturma_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Id";
            // 
            // btnfecharturma
            // 
            this.btnfecharturma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecharturma.Location = new System.Drawing.Point(983, 117);
            this.btnfecharturma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfecharturma.Name = "btnfecharturma";
            this.btnfecharturma.Size = new System.Drawing.Size(97, 37);
            this.btnfecharturma.TabIndex = 34;
            this.btnfecharturma.Text = "Fechar";
            this.btnfecharturma.UseVisualStyleBackColor = true;
            this.btnfecharturma.Click += new System.EventHandler(this.btnfecharturma_Click);
            // 
            // cbxcursoturma
            // 
            this.cbxcursoturma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcursoturma.FormattingEnabled = true;
            this.cbxcursoturma.Items.AddRange(new object[] {
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxcursoturma.Location = new System.Drawing.Point(193, 28);
            this.cbxcursoturma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxcursoturma.Name = "cbxcursoturma";
            this.cbxcursoturma.Size = new System.Drawing.Size(340, 24);
            this.cbxcursoturma.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Curso";
            // 
            // cbxprofessorturma
            // 
            this.cbxprofessorturma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxprofessorturma.FormattingEnabled = true;
            this.cbxprofessorturma.Location = new System.Drawing.Point(15, 82);
            this.cbxprofessorturma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxprofessorturma.Name = "cbxprofessorturma";
            this.cbxprofessorturma.Size = new System.Drawing.Size(717, 24);
            this.cbxprofessorturma.TabIndex = 30;
            // 
            // cbxpoloturma
            // 
            this.cbxpoloturma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxpoloturma.FormattingEnabled = true;
            this.cbxpoloturma.Location = new System.Drawing.Point(540, 28);
            this.cbxpoloturma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxpoloturma.Name = "cbxpoloturma";
            this.cbxpoloturma.Size = new System.Drawing.Size(539, 24);
            this.cbxpoloturma.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(536, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Polo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Professor";
            // 
            // gridalunosmatriculados
            // 
            this.gridalunosmatriculados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridalunosmatriculados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridalunosmatriculados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.curso,
            this.professor,
            this.polo,
            this.status,
            this.idstatusturma});
            this.gridalunosmatriculados.Location = new System.Drawing.Point(15, 159);
            this.gridalunosmatriculados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridalunosmatriculados.MaximumSize = new System.Drawing.Size(1065, 622);
            this.gridalunosmatriculados.Name = "gridalunosmatriculados";
            this.gridalunosmatriculados.ReadOnly = true;
            this.gridalunosmatriculados.RowTemplate.Height = 24;
            this.gridalunosmatriculados.Size = new System.Drawing.Size(1065, 622);
            this.gridalunosmatriculados.TabIndex = 42;
            this.gridalunosmatriculados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridalunosmatriculados_CellContentDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // curso
            // 
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            // 
            // professor
            // 
            this.professor.HeaderText = "Professor";
            this.professor.Name = "professor";
            this.professor.ReadOnly = true;
            // 
            // polo
            // 
            this.polo.HeaderText = "Pólo";
            this.polo.Name = "polo";
            this.polo.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // idstatusturma
            // 
            this.idstatusturma.HeaderText = "idstatusturma";
            this.idstatusturma.Name = "idstatusturma";
            this.idstatusturma.ReadOnly = true;
            this.idstatusturma.Visible = false;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(657, 117);
            this.btnexcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(115, 37);
            this.btnexcluir.TabIndex = 43;
            this.btnexcluir.Text = "Cancelar";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnliberar
            // 
            this.btnliberar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnliberar.Location = new System.Drawing.Point(675, 117);
            this.btnliberar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnliberar.Name = "btnliberar";
            this.btnliberar.Size = new System.Drawing.Size(97, 37);
            this.btnliberar.TabIndex = 44;
            this.btnliberar.Text = "Ativar";
            this.btnliberar.UseVisualStyleBackColor = true;
            this.btnliberar.Click += new System.EventHandler(this.btnliberar_Click);
            // 
            // lblstatusturmas
            // 
            this.lblstatusturmas.AutoSize = true;
            this.lblstatusturmas.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatusturmas.Location = new System.Drawing.Point(15, 134);
            this.lblstatusturmas.Name = "lblstatusturmas";
            this.lblstatusturmas.Size = new System.Drawing.Size(0, 22);
            this.lblstatusturmas.TabIndex = 45;
            this.lblstatusturmas.Visible = false;
            // 
            // cadastroTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1092, 779);
            this.Controls.Add(this.lblstatusturmas);
            this.Controls.Add(this.btnliberar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.gridalunosmatriculados);
            this.Controls.Add(this.btnnovoturma);
            this.Controls.Add(this.txtidturma);
            this.Controls.Add(this.btninserirturma);
            this.Controls.Add(this.btnalterarturma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnfecharturma);
            this.Controls.Add(this.cbxcursoturma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxprofessorturma);
            this.Controls.Add(this.cbxpoloturma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1110, 826);
            this.Name = "cadastroTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de turmas";
            this.Load += new System.EventHandler(this.cadastroTurmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridalunosmatriculados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnnovoturma;
        private System.Windows.Forms.TextBox txtidturma;
        private System.Windows.Forms.Button btninserirturma;
        private System.Windows.Forms.Button btnalterarturma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnfecharturma;
        private System.Windows.Forms.ComboBox cbxcursoturma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxprofessorturma;
        private System.Windows.Forms.ComboBox cbxpoloturma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridalunosmatriculados;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnliberar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn polo;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstatusturma;
        private System.Windows.Forms.Label lblstatusturmas;
    }
}