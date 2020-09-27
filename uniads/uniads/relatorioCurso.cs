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
    public partial class relatorioCurso : Form
    {
        public relatorioCurso()
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
                command.CommandText = "SELECT a.id, a.nome, a.grau, a.coordenador, a.cargahoraria, a.polo from ca_curso a where a.status in (2) ";

                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//CURSO
                    row.Cells[2].Value = reader.GetString(2);//GRAU
                    row.Cells[3].Value = reader.GetString(3);//COORDENADOR
                    row.Cells[4].Value = reader.GetString(4);//CARGAHORARIA
                    row.Cells[5].Value = reader.GetString(5);//POLO
                    dataGridView1.Rows.Add(row);//ADICIONO A LINHA NA TABELA
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
        private void relatorioCurso_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }


        //BOTÃO FECHAR - FECHA O FORMULÁRIO E RETORNA PARA O MENU PRINCIPAL
        private void btnfecharrelatoriocursos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
