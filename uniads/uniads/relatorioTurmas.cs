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
    public partial class relatorioTurmas : Form
    {
        public relatorioTurmas()
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
                command.CommandText = "SELECT a.id, c.nome, d.nome, c.polo" +
                    " from ca_turmas a inner join ca_curso c on c.id = a.curso inner join ca_professor d on d.id = a.professor " +
                    "Where a.status in (2) ";

                MySqlDataReader reader = command.ExecuteReader();
                gridalunosmatriculados.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)gridalunosmatriculados.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID TURMA
                    row.Cells[1].Value = reader.GetString(1);//CURSO
                    row.Cells[2].Value = reader.GetString(2);//PROFESSOR
                    row.Cells[3].Value = reader.GetString(3);//POLO
                    gridalunosmatriculados.Rows.Add(row);//ADICIONO A LINHA NA TABELA
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
        private void relatorioTurmas_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        //BOTÃO FECHAR - FECHA O FORMULÁRIO E RETORNA PARA O MENU PRINCIPAL
        private void btnfecharraletorioturma_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
