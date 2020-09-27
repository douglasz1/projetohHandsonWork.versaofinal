using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uniads
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }



        //ABRE O FORMULARIO DE CADASTRO DE ALUNO
        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroAluno abrirCadastroAluno = new cadastroAluno();
            abrirCadastroAluno.ShowDialog();
        }


        //ABRE O FORMULARIO DE CADASTRO DE PROFESSOR
        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroProfessor abrircadastroProfessor = new cadastroProfessor();
            abrircadastroProfessor.ShowDialog();
        }


        //ABRE O FORMULARIO DE CADASTRO DE MUNICIPIO
        private void municípioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroMunicipio abrircadastroMunicipio = new cadastroMunicipio();
            abrircadastroMunicipio.ShowDialog();
        }


        //ABRE O FORMULARIO DE CADASTRO DE CURSO
        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroCurso abrircadastroCurso = new cadastroCurso();
            abrircadastroCurso.ShowDialog();
        }


        //ABRE O FORMULARIO DE CADASTRO DE TURMAS
        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastroTurmas abrircadastroTurmas = new cadastroTurmas();
            abrircadastroTurmas.ShowDialog();
        }


        //ABRE RELATORIO DE ALUNOS MATRICULADOS
        private void alunosMatriculadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorioAlunosMatriculados abrirrelatorioAlunosMatriculados = new relatorioAlunosMatriculados();
            abrirrelatorioAlunosMatriculados.ShowDialog();
        }


        //ABRE RELATORIO DE CURSOS
        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorioCurso abrirrelatorioCurso = new relatorioCurso();
            abrirrelatorioCurso.ShowDialog();         
        }


        //ABRE RELATORIO DE PROFESSORES
        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorioProfessor abrirrelatorioProfessor = new relatorioProfessor();
            abrirrelatorioProfessor.ShowDialog();
        }


        //ABRE RELATORIO DE TURMAS
        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorioTurmas abrirrelatorioTurmas = new relatorioTurmas();
            abrirrelatorioTurmas.ShowDialog();
        }


        //FECHA A APLICACAO
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
