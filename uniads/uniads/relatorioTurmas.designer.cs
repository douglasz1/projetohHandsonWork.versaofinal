namespace uniads
{
    partial class relatorioTurmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(relatorioTurmas));
            this.gridalunosmatriculados = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnfecharraletorioturmas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridalunosmatriculados)).BeginInit();
            this.SuspendLayout();
            // 
            // gridalunosmatriculados
            // 
            this.gridalunosmatriculados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridalunosmatriculados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridalunosmatriculados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.curso,
            this.professor,
            this.polo});
            this.gridalunosmatriculados.Location = new System.Drawing.Point(9, 10);
            this.gridalunosmatriculados.Margin = new System.Windows.Forms.Padding(2);
            this.gridalunosmatriculados.MaximumSize = new System.Drawing.Size(1330, 650);
            this.gridalunosmatriculados.Name = "gridalunosmatriculados";
            this.gridalunosmatriculados.ReadOnly = true;
            this.gridalunosmatriculados.RowTemplate.Height = 24;
            this.gridalunosmatriculados.Size = new System.Drawing.Size(1330, 650);
            this.gridalunosmatriculados.TabIndex = 22;
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
            // btnfecharraletorioturmas
            // 
            this.btnfecharraletorioturmas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfecharraletorioturmas.Location = new System.Drawing.Point(1266, 670);
            this.btnfecharraletorioturmas.Margin = new System.Windows.Forms.Padding(2);
            this.btnfecharraletorioturmas.Name = "btnfecharraletorioturmas";
            this.btnfecharraletorioturmas.Size = new System.Drawing.Size(73, 30);
            this.btnfecharraletorioturmas.TabIndex = 24;
            this.btnfecharraletorioturmas.Text = "Fechar";
            this.btnfecharraletorioturmas.UseVisualStyleBackColor = true;
            this.btnfecharraletorioturmas.Click += new System.EventHandler(this.btnfecharraletorioturma_Click);
            // 
            // relatorioTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1350, 711);
            this.Controls.Add(this.btnfecharraletorioturmas);
            this.Controls.Add(this.gridalunosmatriculados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1366, 750);
            this.Name = "relatorioTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de turmas ativas";
            this.Load += new System.EventHandler(this.relatorioTurmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridalunosmatriculados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gridalunosmatriculados;
        private System.Windows.Forms.Button btnfecharraletorioturmas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn polo;
    }
}