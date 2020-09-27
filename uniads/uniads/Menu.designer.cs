namespace uniads
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.municípioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosMatriculadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçãoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçãoToolStripMenuItem
            // 
            this.opçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.opçãoToolStripMenuItem.Name = "opçãoToolStripMenuItem";
            this.opçãoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.opçãoToolStripMenuItem.Text = "Opção";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.professorToolStripMenuItem,
            this.municípioToolStripMenuItem,
            this.cursoToolStripMenuItem,
            this.turmaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.ShowShortcutKeys = false;
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.professorToolStripMenuItem.Text = "Curso";
            this.professorToolStripMenuItem.Click += new System.EventHandler(this.professorToolStripMenuItem_Click);
            // 
            // municípioToolStripMenuItem
            // 
            this.municípioToolStripMenuItem.Name = "municípioToolStripMenuItem";
            this.municípioToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.municípioToolStripMenuItem.Text = "Município";
            this.municípioToolStripMenuItem.Click += new System.EventHandler(this.municípioToolStripMenuItem_Click);
            // 
            // cursoToolStripMenuItem
            // 
            this.cursoToolStripMenuItem.Name = "cursoToolStripMenuItem";
            this.cursoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.cursoToolStripMenuItem.Text = "Professor";
            this.cursoToolStripMenuItem.Click += new System.EventHandler(this.cursoToolStripMenuItem_Click);
            // 
            // turmaToolStripMenuItem
            // 
            this.turmaToolStripMenuItem.Name = "turmaToolStripMenuItem";
            this.turmaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.turmaToolStripMenuItem.Text = "Turma";
            this.turmaToolStripMenuItem.Click += new System.EventHandler(this.turmaToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosMatriculadosToolStripMenuItem,
            this.professoresToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.turmasToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // alunosMatriculadosToolStripMenuItem
            // 
            this.alunosMatriculadosToolStripMenuItem.Name = "alunosMatriculadosToolStripMenuItem";
            this.alunosMatriculadosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.alunosMatriculadosToolStripMenuItem.Text = "Alunos matriculados";
            this.alunosMatriculadosToolStripMenuItem.Click += new System.EventHandler(this.alunosMatriculadosToolStripMenuItem_Click);
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.professoresToolStripMenuItem.Text = "Cursos ativos";
            this.professoresToolStripMenuItem.Click += new System.EventHandler(this.professoresToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cursosToolStripMenuItem.Text = "Professores por curso";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // turmasToolStripMenuItem
            // 
            this.turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            this.turmasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.turmasToolStripMenuItem.Text = "Turmas ativas";
            this.turmasToolStripMenuItem.Click += new System.EventHandler(this.turmasToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::uniads.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1366, 768);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "UniADS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem municípioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosMatriculadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turmasToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem turmaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

