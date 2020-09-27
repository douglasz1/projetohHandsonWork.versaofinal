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
    public partial class cadastroAluno : Form
    {
        

        public cadastroAluno()
        {
            InitializeComponent();
        }      

        //CRIA O MÉTODO DE ATUALIZAR GRID
        private void atualizarGrid()
        {

            MySqlCommand command = new MySqlCommand();
            command.Connection = conexaoBD.Abrirconexao();
            try
            {
                if (txtmatriculaaluno.Text == string.Empty)
                {
                    btnalteraraluno.Visible = false;
                    btnexcluir.Visible = false;
                    btnliberar.Visible = false;
                }
                else
                {
                    btnalteraraluno.Visible = true;
                    btnexcluir.Visible = true;
                    btnliberar.Visible = true;
                }

                if (txtmatriculaaluno.Text == string.Empty)
                {
                    btninseriraluno.Visible = true;
                }
                else
                {
                    btninseriraluno.Visible = false;
                }

                if (txtnomealuno.Text == string.Empty)
                {
                    btnnovoaluno.Visible = false;
                }
                else
                {
                    btnnovoaluno.Visible = true;
                }

                if (lblstatusaluno.Text == "1")
                {
                    btnliberar.Visible = true;
                }
                else
                {
                    btnliberar.Visible = false;
                }

                if (lblstatusaluno.Text == "2")
                {
                    btnexcluir.Visible = true;
                }
                else
                {
                    btnexcluir.Visible = false;
                }

                command.CommandText = "SELECT a.id, a.nome, c.nome, a.uf, a.logradouro, a.numero, e.id, b.nome , d.nome, a.status, CONCAT( e.id, ' | ' , e.polo, ' | ' , b.nome) from ca_aluno a inner join ca_curso b on b.id = a.curso inner join ca_municipio c on c.id = a.municipio  inner join status d on d.id = a.status inner join ca_turmas e on e.id = a.turma";
                
                MySqlDataReader reader = command.ExecuteReader();
                gridrelatorioalunosmatriculados.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)gridrelatorioalunosmatriculados.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID MAATRICULA
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//MUNICIPIO
                    row.Cells[3].Value = reader.GetString(3);//UF
                    row.Cells[4].Value = reader.GetString(4);//LOGRADOURO
                    row.Cells[5].Value = reader.GetString(5);//NUMERO
                    row.Cells[6].Value = reader.GetInt32(6);//IDTURMA
                    row.Cells[7].Value = reader.GetString(7);//CURSO
                    row.Cells[8].Value = reader.GetString(8);//STATUS
                    row.Cells[9].Value = reader.GetString(9);//IDSTATUS
                    row.Cells[10].Value = reader.GetString(10);//TURMA
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

        //LOAD DO FORMULÁRIO - CARREGA COMBOBOX, ATUALIZAGRID E LMPA OS CAMPOS
        private void cadastroAluno_Load(object sender, EventArgs e)
        {
            atualizarGrid();
            limparCampos();

            string municipioaluno = @"select '0' id, ' ' nome from ca_municipio union select id, nome from ca_municipio where status in (2)";
            cbxmunicipioaluno.Items.Clear();
            cbxmunicipioaluno.DataSource = conexaoBD.dql(municipioaluno);
            cbxmunicipioaluno.DisplayMember = "nome";
            cbxmunicipioaluno.ValueMember = "id";

            string UF = @"select ' ' uf from ca_municipio union select distinct uf from ca_municipio where status in (2)";
            cbxufaluno.Items.Clear();
            cbxufaluno.DataSource = conexaoBD.dql(UF);
            cbxufaluno.DisplayMember = "UF";

            string cursoaluno = @"select '0' id, ' ' nome from ca_curso union select id, nome from ca_curso where status in (2)";
            cbxcursoaluno.Items.Clear();
            cbxcursoaluno.DataSource = conexaoBD.dql(cursoaluno);
            cbxcursoaluno.DisplayMember = "nome";
            cbxcursoaluno.ValueMember = "id";

            string turmaaluno = @"select 0 id, ' ' turma from ca_turmas union select a.id as id, CONCAT( a.id, ' | ' , a.polo, ' | ' , b.nome) as turma from ca_turmas a inner join ca_curso b on b.id = a.curso  where a.status in (2)";
            cbxturmaaluno.Items.Clear();
            cbxturmaaluno.DataSource = conexaoBD.dql(turmaaluno);
            cbxturmaaluno.DisplayMember = "turma";
            cbxturmaaluno.ValueMember = "id";
            
        }
                         

        //CRIA MÉTODO DE LIMPAR CAMPOS DO FURMULÁRIO
        private void limparCampos()
        {

            txtnomealuno.Clear();

            cbxmunicipioaluno.Text = " ";
            txtlogradouroaluno.Text = " ";
            cbxufaluno.Text = " ";
            txtmatriculaaluno.Clear();
            txtnumeroenderecoaluno.Clear();
            cbxturmaaluno.Text = " ";
            cbxcursoaluno.Text = " ";
            lblstatusaluno.Text = " ";

        }

        //PREENCHE OS TEXTBOX E COMBOBOX COM AS CÉLULAS DA LINHA DO GRID SELECIONADA
        private void gridrelatorioalunosmatriculados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                gridrelatorioalunosmatriculados.CurrentRow.Selected = true;

                txtmatriculaaluno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["matricula"].FormattedValue.ToString();
                txtnomealuno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["nome"].FormattedValue.ToString();
                cbxmunicipioaluno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["municipio"].FormattedValue.ToString();
                cbxufaluno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["UF"].FormattedValue.ToString();
                txtlogradouroaluno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["logradouro"].FormattedValue.ToString();
                txtnumeroenderecoaluno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["numero"].FormattedValue.ToString();
                cbxcursoaluno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["curso"].FormattedValue.ToString();
                cbxturmaaluno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["turma"].FormattedValue.ToString();
                lblstatusaluno.Text = gridrelatorioalunosmatriculados.Rows[e.RowIndex].Cells["idstatusaluno"].FormattedValue.ToString();
            }

            if (txtmatriculaaluno.Text == string.Empty)
            {
                btnalteraraluno.Visible = false;
                btnexcluir.Visible = false;
                btnliberar.Visible = false;
            }
            else
            {
                btnalteraraluno.Visible = true;
                btnexcluir.Visible = true;
                btnliberar.Visible = true;
            }

            if (txtmatriculaaluno.Text == string.Empty)
            {
                btninseriraluno.Visible = true;
            }
            else
            {
                btninseriraluno.Visible = false;
            }

            if (txtnomealuno.Text == string.Empty)
            {
                btnnovoaluno.Visible = false;
            }
            else
            {
                btnnovoaluno.Visible = true;
            }

            if (lblstatusaluno.Text == "1")
            {
                btnliberar.Visible = true;
            }
            else
            {
                btnliberar.Visible = false;
            }

            if (lblstatusaluno.Text == "2")
            {
                btnexcluir.Visible = true;
            }
            else
            {
                btnexcluir.Visible = false;
            }

        }


        //BOTÃO NOVO - LIMPA OS CAMPOS PARA UM NOVO CADASTRO
        private void btnnovoaluno_Click(object sender, EventArgs e)
        {
            limparCampos();
            atualizarGrid();
        }


        //BOTÃO INSERIR - GRAVA UM NOVO CADASTRO
        private void btninseriraluno_Click_1(object sender, EventArgs e)
        {

            if (txtnomealuno.Text == string.Empty || cbxmunicipioaluno.Text == " " || cbxufaluno.Text == " " || txtlogradouroaluno.Text == string.Empty || txtnumeroenderecoaluno.Text == string.Empty || cbxturmaaluno.Text == " " || cbxcursoaluno.Text == " ")
            {
                MessageBox.Show("Existem campos não preenchidos!");
            }
            else
            {

                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conexaoBD.Abrirconexao();
                    command.CommandText = "INSERT INTO CA_aLUNO (NOME, UF, MUNICIPIO, LOGRADOURO, NUMERO, CURSO, TURMA, STATUS)" +
                     "VALUES ('" + txtnomealuno.Text + "', '" + cbxufaluno.Text + "', " + cbxmunicipioaluno.SelectedValue + ",'" + txtlogradouroaluno.Text + "'," +
                    "'" + txtnumeroenderecoaluno.Text + "', " + cbxcursoaluno.SelectedValue + ", " + cbxturmaaluno.SelectedValue + ", 2)";

                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Aluno cadastrado com sucesso!");

                    limparCampos();
                    atualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                    Console.WriteLine(ex.Message);
                }
                  
            } 
        }
        

        //BOTÃO ALTERAR - ALTERA UM REGISTRO NO BANCO
        private void btnalteraraluno_Click(object sender, EventArgs e)
        {
            if (txtnomealuno.Text == string.Empty || cbxmunicipioaluno.Text == " " || cbxufaluno.Text == " " || txtlogradouroaluno.Text == string.Empty || txtnumeroenderecoaluno.Text == string.Empty || cbxturmaaluno.Text == " " || cbxcursoaluno.Text == " ")
            {
                MessageBox.Show("Existem campos não preenchidos!");
            }
            else
            {

                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conexaoBD.Abrirconexao();
                    command.CommandText = "UPDATE ca_aluno SET NOME = '" + txtnomealuno.Text + "' , " +
                        "UF = '" + cbxufaluno.Text + "', MUNICIPIO = " + cbxmunicipioaluno.SelectedValue + " , CURSO = " + cbxcursoaluno.SelectedValue + "  , " +
                        "LOGRADOURO = '" + txtlogradouroaluno.Text + "', TURMA = " + cbxturmaaluno.SelectedValue + ", NUMERO = '" + txtnumeroenderecoaluno.Text + "' WHERE id in ('" + txtmatriculaaluno.Text + "')";



                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Aluno alterado com sucesso!");

                    limparCampos();
                    atualizarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                    Console.WriteLine(ex.Message);
                }

            }
        }


        //BOTÃO CANCELAR - ALTERA O STATUS DO REGISTRO NO BANCO PARA CANCELADO
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "UPDATE ca_aluno SET STATUS = 1 WHERE id in ('" + txtmatriculaaluno.Text + "')"; 

                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Aluno Cancelado com sucesso!");

                limparCampos();
                atualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                Console.WriteLine(ex.Message);
            }
        }


        //BOTÃO FECHAR - FECHA O FORMULÁRIO E RETORNA PARA O MENU PRINCIPAL
        private void btnfecharaluno_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //BOTÃO ATIVAR - ALTERA O STATUS DO REGISTRO NO BANCO PARA ATIVADO
        private void btnliberar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "UPDATE ca_aluno SET STATUS = 2 WHERE id in ('" + txtmatriculaaluno.Text + "')";

                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Aluno Ativado com sucesso!");

                limparCampos();
                atualizarGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel abrir a conexão! " + ex);
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}

