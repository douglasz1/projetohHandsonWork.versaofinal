namespace uniads
{
    partial class cadastroCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroCurso));
            this.cbxcoordenadorcurso = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnomecurso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnfecharcurso = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxpolocurso = new System.Windows.Forms.ComboBox();
            this.txtcargahorariacurso = new System.Windows.Forms.TextBox();
            this.txtcodigocurso = new System.Windows.Forms.TextBox();
            this.btninserircurso = new System.Windows.Forms.Button();
            this.btnalterarcurso = new System.Windows.Forms.Button();
            this.cbxgraucurso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnexcluircurso = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordenador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargahoraria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstatuscurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnnovocurso = new System.Windows.Forms.Button();
            this.btnliberar = new System.Windows.Forms.Button();
            this.lblstatuscurso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxcoordenadorcurso
            // 
            this.cbxcoordenadorcurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcoordenadorcurso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxcoordenadorcurso.FormattingEnabled = true;
            this.cbxcoordenadorcurso.Items.AddRange(new object[] {
            " ",
            "Tânia Regina Sedrez",
            "Mariana Soares da Silva",
            "Ademar Arno Bussmann",
            "Alexandre de Sá Oliveira",
            "Anacleto Laurino Pinto",
            "Andre Graf de Almeida",
            "Andre Moraes dos Santos",
            "Andréa Márcia Ferreira da Silva",
            "Attela Jenichen Provesi",
            "Caio Cesar Ferrari Santangelo",
            "Camila da Silva Schmitt",
            "Carlos Marcelo Ardigo",
            "Claudia Silva Ribeiro Alves",
            "Cristiano Romais",
            "Cristina Melim",
            "Cristina Pereira Vecchio Balsini",
            "Edilene Naciara Pereira",
            "Eduardo José Costa",
            "Elton José Blageski Junior",
            "Fabiana de Bittencourt Rangel",
            "Fernando Cesar Lenzi",
            "Profª. Dra. Verônica Gesser"});
            this.cbxcoordenadorcurso.Location = new System.Drawing.Point(188, 81);
            this.cbxcoordenadorcurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxcoordenadorcurso.Name = "cbxcoordenadorcurso";
            this.cbxcoordenadorcurso.Size = new System.Drawing.Size(580, 24);
            this.cbxcoordenadorcurso.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Coordenador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Curso";
            // 
            // txtnomecurso
            // 
            this.txtnomecurso.Location = new System.Drawing.Point(188, 31);
            this.txtnomecurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnomecurso.Name = "txtnomecurso";
            this.txtnomecurso.Size = new System.Drawing.Size(580, 22);
            this.txtnomecurso.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Código";
            // 
            // btnfecharcurso
            // 
            this.btnfecharcurso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecharcurso.Location = new System.Drawing.Point(983, 112);
            this.btnfecharcurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfecharcurso.Name = "btnfecharcurso";
            this.btnfecharcurso.Size = new System.Drawing.Size(97, 37);
            this.btnfecharcurso.TabIndex = 19;
            this.btnfecharcurso.Text = "Fechar";
            this.btnfecharcurso.UseVisualStyleBackColor = true;
            this.btnfecharcurso.Click += new System.EventHandler(this.btnfecharcurso_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "Carga horária";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(775, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Polo";
            // 
            // cbxpolocurso
            // 
            this.cbxpolocurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxpolocurso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxpolocurso.FormattingEnabled = true;
            this.cbxpolocurso.Location = new System.Drawing.Point(775, 81);
            this.cbxpolocurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxpolocurso.Name = "cbxpolocurso";
            this.cbxpolocurso.Size = new System.Drawing.Size(304, 24);
            this.cbxpolocurso.TabIndex = 24;
            // 
            // txtcargahorariacurso
            // 
            this.txtcargahorariacurso.Location = new System.Drawing.Point(15, 82);
            this.txtcargahorariacurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcargahorariacurso.Name = "txtcargahorariacurso";
            this.txtcargahorariacurso.Size = new System.Drawing.Size(167, 22);
            this.txtcargahorariacurso.TabIndex = 25;
            // 
            // txtcodigocurso
            // 
            this.txtcodigocurso.Enabled = false;
            this.txtcodigocurso.Location = new System.Drawing.Point(16, 31);
            this.txtcodigocurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodigocurso.Name = "txtcodigocurso";
            this.txtcodigocurso.ReadOnly = true;
            this.txtcodigocurso.Size = new System.Drawing.Size(165, 22);
            this.txtcodigocurso.TabIndex = 26;
            // 
            // btninserircurso
            // 
            this.btninserircurso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserircurso.Location = new System.Drawing.Point(880, 112);
            this.btninserircurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btninserircurso.Name = "btninserircurso";
            this.btninserircurso.Size = new System.Drawing.Size(97, 37);
            this.btninserircurso.TabIndex = 29;
            this.btninserircurso.Text = "Inserir";
            this.btninserircurso.UseVisualStyleBackColor = true;
            this.btninserircurso.Click += new System.EventHandler(this.btninserircurso_Click);
            // 
            // btnalterarcurso
            // 
            this.btnalterarcurso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterarcurso.Location = new System.Drawing.Point(777, 112);
            this.btnalterarcurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnalterarcurso.Name = "btnalterarcurso";
            this.btnalterarcurso.Size = new System.Drawing.Size(97, 37);
            this.btnalterarcurso.TabIndex = 28;
            this.btnalterarcurso.Text = "Alterar";
            this.btnalterarcurso.UseVisualStyleBackColor = true;
            this.btnalterarcurso.Click += new System.EventHandler(this.btnalterarcurso_Click);
            // 
            // cbxgraucurso
            // 
            this.cbxgraucurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxgraucurso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxgraucurso.FormattingEnabled = true;
            this.cbxgraucurso.Items.AddRange(new object[] {
            " ",
            "Tecnólogo",
            "Bacharel",
            "Licenciatura",
            "Pós-Graduação",
            "Mestrado",
            "Doutorado"});
            this.cbxgraucurso.Location = new System.Drawing.Point(775, 31);
            this.cbxgraucurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxgraucurso.Name = "cbxgraucurso";
            this.cbxgraucurso.Size = new System.Drawing.Size(304, 24);
            this.cbxgraucurso.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(771, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "Grau";
            // 
            // btnexcluircurso
            // 
            this.btnexcluircurso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluircurso.Location = new System.Drawing.Point(653, 112);
            this.btnexcluircurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexcluircurso.Name = "btnexcluircurso";
            this.btnexcluircurso.Size = new System.Drawing.Size(119, 37);
            this.btnexcluircurso.TabIndex = 32;
            this.btnexcluircurso.Text = "Cancelar";
            this.btnexcluircurso.UseVisualStyleBackColor = true;
            this.btnexcluircurso.Click += new System.EventHandler(this.btnexcluircurso_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.grau,
            this.coordenador,
            this.cargahoraria,
            this.polo,
            this.status,
            this.idstatuscurso});
            this.dataGridView1.Location = new System.Drawing.Point(15, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 622);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // nome
            // 
            this.nome.HeaderText = "Curso";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 250;
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
            this.coordenador.Width = 200;
            // 
            // cargahoraria
            // 
            this.cargahoraria.HeaderText = "Carga horária";
            this.cargahoraria.Name = "cargahoraria";
            this.cargahoraria.ReadOnly = true;
            this.cargahoraria.Width = 200;
            // 
            // polo
            // 
            this.polo.HeaderText = "Pólo";
            this.polo.Name = "polo";
            this.polo.ReadOnly = true;
            this.polo.Width = 200;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // idstatuscurso
            // 
            this.idstatuscurso.HeaderText = "idstatuscurso";
            this.idstatuscurso.Name = "idstatuscurso";
            this.idstatuscurso.ReadOnly = true;
            this.idstatuscurso.Visible = false;
            // 
            // btnnovocurso
            // 
            this.btnnovocurso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnovocurso.Location = new System.Drawing.Point(880, 112);
            this.btnnovocurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnovocurso.Name = "btnnovocurso";
            this.btnnovocurso.Size = new System.Drawing.Size(97, 37);
            this.btnnovocurso.TabIndex = 34;
            this.btnnovocurso.Text = "Limpar";
            this.btnnovocurso.UseVisualStyleBackColor = true;
            this.btnnovocurso.Click += new System.EventHandler(this.btnnovocurso_Click);
            // 
            // btnliberar
            // 
            this.btnliberar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnliberar.Location = new System.Drawing.Point(675, 112);
            this.btnliberar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnliberar.Name = "btnliberar";
            this.btnliberar.Size = new System.Drawing.Size(97, 37);
            this.btnliberar.TabIndex = 35;
            this.btnliberar.Text = "Ativar";
            this.btnliberar.UseVisualStyleBackColor = true;
            this.btnliberar.Click += new System.EventHandler(this.btnliberar_Click);
            // 
            // lblstatuscurso
            // 
            this.lblstatuscurso.AutoSize = true;
            this.lblstatuscurso.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatuscurso.Location = new System.Drawing.Point(12, 129);
            this.lblstatuscurso.Name = "lblstatuscurso";
            this.lblstatuscurso.Size = new System.Drawing.Size(0, 22);
            this.lblstatuscurso.TabIndex = 36;
            this.lblstatuscurso.Visible = false;
            // 
            // cadastroCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1092, 779);
            this.Controls.Add(this.lblstatuscurso);
            this.Controls.Add(this.btnliberar);
            this.Controls.Add(this.btnnovocurso);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnexcluircurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxgraucurso);
            this.Controls.Add(this.btninserircurso);
            this.Controls.Add(this.btnalterarcurso);
            this.Controls.Add(this.txtcodigocurso);
            this.Controls.Add(this.txtcargahorariacurso);
            this.Controls.Add(this.cbxpolocurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnfecharcurso);
            this.Controls.Add(this.cbxcoordenadorcurso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnomecurso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1110, 826);
            this.Name = "cadastroCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de cursos";
            this.Load += new System.EventHandler(this.cadastroCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxcoordenadorcurso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnomecurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnfecharcurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxpolocurso;
        private System.Windows.Forms.TextBox txtcargahorariacurso;
        private System.Windows.Forms.TextBox txtcodigocurso;
        private System.Windows.Forms.Button btninserircurso;
        private System.Windows.Forms.Button btnalterarcurso;
        private System.Windows.Forms.ComboBox cbxgraucurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnexcluircurso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnnovocurso;
        private System.Windows.Forms.Button btnliberar;
        private System.Windows.Forms.Label lblstatuscurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn grau;
        private System.Windows.Forms.DataGridViewTextBoxColumn coordenador;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargahoraria;
        private System.Windows.Forms.DataGridViewTextBoxColumn polo;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstatuscurso;
    }
}