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
    public partial class cadastroTurmas : Form
    {
        public cadastroTurmas()
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

                if (txtidturma.Text == string.Empty)
                {
                    btnalterarturma.Visible = false;
                    btnexcluir.Visible = false;
                    btnliberar.Visible = false;
                }
                else
                {
                    btnalterarturma.Visible = true;
                    btnexcluir.Visible = true;
                    btnliberar.Visible = true;
                }

                if (txtidturma.Text == string.Empty)
                {
                    btninserirturma.Visible = true;
                }
                else
                {
                    btninserirturma.Visible = false;
                }

                if (txtidturma.Text == string.Empty)
                {
                    btnnovoturma.Visible = false;
                }
                else
                {
                    btnnovoturma.Visible = true;
                }

                if (lblstatusturmas.Text == "1")
                {
                    btnliberar.Visible = true;
                }
                else
                {
                    btnliberar.Visible = false;
                }

                if (lblstatusturmas.Text == "2")
                {
                    btnexcluir.Visible = true;
                }
                else
                {
                    btnexcluir.Visible = false;
                }

                command.CommandText = "SELECT a.id, c.nome, d.nome, a.polo, e.nome, a.status" +
                    " from ca_turmas a inner join ca_curso c on c.id = a.curso inner join ca_professor d on d.id = a.professor inner join status e on e.id = a.status";

                MySqlDataReader reader = command.ExecuteReader();
                gridalunosmatriculados.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)gridalunosmatriculados.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//CURSO
                    row.Cells[2].Value = reader.GetString(2);//PROFESSOR
                    row.Cells[3].Value = reader.GetString(3);//POLO
                    row.Cells[4].Value = reader.GetString(4);//STATUS
                    row.Cells[5].Value = reader.GetString(5);//IDSTATUS
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



        //LOAD DO FORMULÁRIO - CARREGA COMBOBOX, ATUALIZAGRID E LMPA OS CAMPOS
        private void cadastroTurmas_Load(object sender, EventArgs e)
        {
            atualizarGrid();
            limparCampos();

            string cursoturma = @"select distinct '0' id, ' ' nome from ca_curso union select distinct id, nome from ca_curso where status in (2)";
            cbxcursoturma.Items.Clear();
            cbxcursoturma.DataSource = conexaoBD.dql(cursoturma);
            cbxcursoturma.DisplayMember = "nome";
            cbxcursoturma.ValueMember = "id";


            string professorturma = @"select '0' id, ' ' nome from ca_professor union select id, nome from ca_professor where status = 2";
            cbxprofessorturma.Items.Clear();
            cbxprofessorturma.DataSource = conexaoBD.dql(professorturma);
            cbxprofessorturma.DisplayMember = "nome";
            cbxprofessorturma.ValueMember = "id";

            string poloturma = @"select  ' ' POLO from ca_curso union select distinct POLO from ca_curso where status in (2)";
            cbxpoloturma.Items.Clear();
            cbxpoloturma.DataSource = conexaoBD.dql(poloturma);
            cbxpoloturma.DisplayMember = "polo";
            
        }



        //CRIA MÉTODO DE LIMPAR CAMPOS DO FURMULÁRIO
        private void limparCampos()
        {
            txtidturma.Clear();
            cbxpoloturma.Text = " ";
            cbxcursoturma.Text = " ";
            cbxprofessorturma.Text = " ";
            lblstatusturmas.Text = " ";
        }



        //PREENCHE OS TEXTBOX E COMBOBOX COM AS CÉLULAS DA LINHA DO GRID SELECIONADA
        private void gridalunosmatriculados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (gridalunosmatriculados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    gridalunosmatriculados.CurrentRow.Selected = true;

                    txtidturma.Text = gridalunosmatriculados.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                    cbxpoloturma.Text = gridalunosmatriculados.Rows[e.RowIndex].Cells["polo"].FormattedValue.ToString();
                    cbxcursoturma.Text = gridalunosmatriculados.Rows[e.RowIndex].Cells["curso"].FormattedValue.ToString();
                    cbxprofessorturma.Text = gridalunosmatriculados.Rows[e.RowIndex].Cells["professor"].FormattedValue.ToString();
                    lblstatusturmas.Text = gridalunosmatriculados.Rows[e.RowIndex].Cells["idstatusturma"].FormattedValue.ToString();
                }
            }

            if (txtidturma.Text == string.Empty)
            {
                btnalterarturma.Visible = false;
                btnexcluir.Visible = false;
                btnliberar.Visible = false;
            }
            else
            {
                btnalterarturma.Visible = true;
                btnexcluir.Visible = true;
                btnliberar.Visible = true;
            }

            if (txtidturma.Text == string.Empty)
            {
                btninserirturma.Visible = true;
            }
            else
            {
                btninserirturma.Visible = false;
            }

            if (txtidturma.Text == string.Empty)
            {
                btnnovoturma.Visible = false;
            }
            else
            {
                btnnovoturma.Visible = true;
            }

            if (lblstatusturmas.Text == "1")
            {
                btnliberar.Visible = true;
            }
            else
            {
                btnliberar.Visible = false;
            }

            if (lblstatusturmas.Text == "2")
            {
                btnexcluir.Visible = true;
            }
            else
            {
                btnexcluir.Visible = false;
            }
        }



        //BOTÃO NOVO - LIMPA OS CAMPOS PARA UM NOVO CADASTRO
        private void btnnovoturma_Click(object sender, EventArgs e)
        {
            limparCampos();
            atualizarGrid();
        }



        //BOTÃO INSERIR - GRAVA UM NOVO CADASTRO
        private void btninserirturma_Click(object sender, EventArgs e)
        {
            if (cbxpoloturma.Text == " " || cbxcursoturma.Text == " " || cbxprofessorturma.Text == " ")
            {


                MessageBox.Show("Existem campos não preenchidos!");
            }
            else
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conexaoBD.Abrirconexao();
                    command.CommandText = "INSERT INTO CA_TURMAS (POLO, CURSO, PROFESSOR, STATUS) " +
                      "VALUES ('" + cbxpoloturma.Text + "', " + cbxcursoturma.SelectedValue + ", " + cbxprofessorturma.SelectedValue + ", '2')";

                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Turma cadastrada com sucesso!");
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
        private void btnalterarturma_Click(object sender, EventArgs e)
        {
            if (cbxpoloturma.Text == " " || cbxcursoturma.Text == " " || cbxprofessorturma.Text == " ")
            {


                MessageBox.Show("Existem campos não preenchidos!");
            }
            else
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conexaoBD.Abrirconexao();
                    command.CommandText = "UPDATE ca_turmas SET polo = '" + cbxpoloturma.Text + "', CURSO = " + cbxcursoturma.SelectedValue + " , PROFESSOR = " + cbxprofessorturma.SelectedValue + "  WHERE id in ('" + txtidturma.Text + "') ";

                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Turma alterada com sucesso!");

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



        //BOTÃO CANCELAR - ALTERA STATUS PARA CANCELADO
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "UPDATE `ca_turmas` SET STATUS = 1 WHERE `ca_turmas`.`ID` =" + txtidturma.Text;

                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Turma alterada com sucesso!");

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
        private void btnfecharturma_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //BOTÃO ATIVAR - ALTERA STATUS PARA ATIVO
        private void btnliberar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "UPDATE `ca_turmas` SET STATUS = 2 WHERE `ca_turmas`.`ID` =" + txtidturma.Text;

                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Turma alterada com sucesso!");

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
