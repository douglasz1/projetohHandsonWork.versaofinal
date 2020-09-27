using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace uniads

{
    public partial class relatorioAlunosMatriculados : Form
    {
        public relatorioAlunosMatriculados()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        //CRIA O MÉTODO DE ATUALIZAR GRID
        private void atualizarGrid()
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = conexaoBD.Abrirconexao();
            try
            {
                command.CommandText = "SELECT a.id, a.nome, b.nome,  c.nome, a.uf, a.logradouro, a.numero, CONCAT( d.id, ' | ' , d.polo, ' | ' , b.nome) from ca_aluno a inner join ca_curso b on b.id = a.curso inner join ca_municipio c on c.id = a.municipio inner join ca_turmas d on a.turma = d.id where a.status in (2)";
         
                MySqlDataReader reader = command.ExecuteReader();
                gridrelatorioalunosmatriculados.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)gridrelatorioalunosmatriculados.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID MAATRICULA
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//CURSO
                    row.Cells[3].Value = reader.GetString(3);//MUNICIPIO
                    row.Cells[4].Value = reader.GetString(4);//UF
                    row.Cells[5].Value = reader.GetString(5);//LOGRADOURO
                    row.Cells[6].Value = reader.GetString(6);//NUMERO
                    row.Cells[7].Value = reader.GetString(7);//NUMERO
                    gridrelatorioalunosmatriculados.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }
                conexaoBD.Fecharconexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                Console.WriteLine(ex.Message);
            }
        }


        //LOAD DO FORMULÁRIO - ATUALIZAGRID
        private void relatorioAlunosMatriculados_Load(object sender, EventArgs e)
        {
                        atualizarGrid();
        }


        //BOTÃO FECHAR - FECHA O FORMULÁRIO E RETORNA PARA O MENU PRINCIPAL
        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

            

        

    
