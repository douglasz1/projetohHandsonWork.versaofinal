using MySql.Data.MySqlClient;
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
     public partial class cadastroProfessor : Form
    {
        public cadastroProfessor()
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
                if (txtidprofessor.Text == string.Empty)
                {
                    btnalterarprofessor.Visible = false;
                    btnexcluirprofessor.Visible = false;
                    btnliberar.Visible = false;
                }
                else
                {
                    btnalterarprofessor.Visible = true;
                    btnexcluirprofessor.Visible = true;
                    btnliberar.Visible = true;
                }

                if (txtidprofessor.Text == string.Empty)
                {
                    btninserirprofessor.Visible = true;
                }
                else
                {
                    btninserirprofessor.Visible = false;
                }

                if (txtnomeprofessor.Text == string.Empty)
                {
                    btnnovoprofessor.Visible = false;
                }
                else
                {
                    btnnovoprofessor.Visible = true;
                }

                if (lblstatusprofessor.Text == "1")
                {
                    btnliberar.Visible = true;
                }
                else
                {
                    btnliberar.Visible = false;
                }


                if (lblstatusprofessor.Text == "2")
                {
                    btnexcluirprofessor.Visible = true;
                }
                else
                {
                    btnexcluirprofessor.Visible = false;
                }


                command.CommandText = "SELECT a.id, a.nome, a.formacao, b.nome, b.uf, a.logradouro, a.numero, c.nome, a.status from ca_professor a inner join ca_municipio b on a.municipio = b.id inner join status c on c.id = a.status";

                MySqlDataReader reader = command.ExecuteReader();
                gridprofessor.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)gridprofessor.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID 
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//FORMACAO
                    row.Cells[3].Value = reader.GetString(3);//MUNICIPIO
                    row.Cells[4].Value = reader.GetString(4);//UF
                    row.Cells[5].Value = reader.GetString(5);//LOGRADOURO
                    row.Cells[6].Value = reader.GetInt32(6);//NUMERO
                    row.Cells[7].Value = reader.GetString(7);//STATUS
                    row.Cells[8].Value = reader.GetString(8);//IDSTATUS
                    gridprofessor.Rows.Add(row);//ADICIONO A LINHA NA TABELA
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
        private void cadastroProfessor_Load(object sender, EventArgs e)
        {
           
            string municipioprofessor = @"select '0' id, ' ' nome from ca_municipio union select id, nome from ca_municipio where status in (2)";
            cbxmunicipioprofessor.Items.Clear();
            cbxmunicipioprofessor.DataSource = conexaoBD.dql(municipioprofessor);
            cbxmunicipioprofessor.DisplayMember = "nome";
            cbxmunicipioprofessor.ValueMember = "id";

            string UF = @"select ' 'uf from ca_municipio union select distinct uf from ca_municipio where status in (2)";
            cbxufprofessor.Items.Clear();
            cbxufprofessor.DataSource = conexaoBD.dql(UF);
            cbxufprofessor.DisplayMember = "UF";

            atualizarGrid();
            limparCampos();
        }



        //CRIA MÉTODO DE LIMPAR CAMPOS DO FURMULÁRIO
        private void limparCampos()
         {

            txtidprofessor.Clear();
            txtnomeprofessor.Clear();
            cbxformacaoprofessor.Text = " ";
            cbxmunicipioprofessor.Text = " ";
            cbxufprofessor.Text = " ";
            txtlogradouroprofessor.Clear();
            txtnumeroenderecoprofessor.Clear();
            lblstatusprofessor.Text = " ";
        }



        //PREENCHE OS TEXTBOX E COMBOBOX COM AS CÉLULAS DA LINHA DO GRID SELECIONADA
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridprofessor.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                gridprofessor.CurrentRow.Selected = true;

                txtidprofessor.Text = gridprofessor.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                txtnomeprofessor.Text = gridprofessor.Rows[e.RowIndex].Cells["nome"].FormattedValue.ToString();
                cbxformacaoprofessor.Text = gridprofessor.Rows[e.RowIndex].Cells["formacao"].FormattedValue.ToString();
                cbxmunicipioprofessor.Text = gridprofessor.Rows[e.RowIndex].Cells["municipio"].FormattedValue.ToString();
                cbxufprofessor.Text = gridprofessor.Rows[e.RowIndex].Cells["UF"].FormattedValue.ToString();
                txtlogradouroprofessor.Text = gridprofessor.Rows[e.RowIndex].Cells["logradouro"].FormattedValue.ToString();
                txtnumeroenderecoprofessor.Text = gridprofessor.Rows[e.RowIndex].Cells["numero"].FormattedValue.ToString();
                lblstatusprofessor.Text = gridprofessor.Rows[e.RowIndex].Cells["idstatusprofessor"].FormattedValue.ToString();
            }

            if (txtidprofessor.Text == string.Empty)
            {
                btnalterarprofessor.Visible = false;
                btnexcluirprofessor.Visible = false;
                btnliberar.Visible = false;
            }
            else
            {
                btnalterarprofessor.Visible = true;
                btnexcluirprofessor.Visible = true;
                btnliberar.Visible = true;
            }

            if (txtidprofessor.Text == string.Empty)
            {
                btninserirprofessor.Visible = true;
            }
            else
            {
                btninserirprofessor.Visible = false;
            }

            if (txtnomeprofessor.Text == string.Empty)
            {
                btnnovoprofessor.Visible = false;
            }
            else
            {
                btnnovoprofessor.Visible = true;
            }

            if (lblstatusprofessor.Text == "1")
            {
                btnliberar.Visible = true;
            }
            else
            {             
                btnliberar.Visible = false;
            }


            if (lblstatusprofessor.Text == "2")
            {
                btnexcluirprofessor.Visible = true;
            }
            else
            {
                btnexcluirprofessor.Visible = false;
            }       
            
        }



        //BOTÃO NOVO - LIMPA OS CAMPOS PARA UM NOVO CADASTRO
        private void btnnovoprofessor_Click(object sender, EventArgs e)
        {
            limparCampos();
            atualizarGrid();
        }



        //BOTÃO INSERIR - GRAVA UM NOVO CADASTRO
        private void btninserirprofessor_Click(object sender, EventArgs e)
        {
            if (txtnomeprofessor.Text == string.Empty || cbxformacaoprofessor.Text == " " || cbxmunicipioprofessor.Text == " " || cbxufprofessor.Text == " " || txtlogradouroprofessor.Text == string.Empty || txtnumeroenderecoprofessor.Text == string.Empty)
            {


                MessageBox.Show("Existem campos não preenchidos!");
            }
            else
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conexaoBD.Abrirconexao();
                    command.CommandText = "INSERT INTO `ca_professor`(`NOME`, `FORMACAO`,  `LOGRADOURO`, NUMERO, MUNICIPIO, STATUS) " +
                        "VALUES ('" + txtnomeprofessor.Text + "','" + cbxformacaoprofessor.Text + "', '" + txtlogradouroprofessor.Text + "', '" + txtnumeroenderecoprofessor.Text + "', " + cbxmunicipioprofessor.SelectedValue + ", 2)";

                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Professor cadastrado com sucesso!");

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
        private void btnalterarprofessor_Click(object sender, EventArgs e)
        {
            if (txtnomeprofessor.Text == string.Empty || cbxformacaoprofessor.Text == " " || cbxmunicipioprofessor.Text == " " || cbxufprofessor.Text == " " || txtlogradouroprofessor.Text == string.Empty || txtnumeroenderecoprofessor.Text == string.Empty)
            {


                MessageBox.Show("Existem campos não preenchidos!");
            }
            else
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conexaoBD.Abrirconexao();
                    command.CommandText = "UPDATE ca_professor SET NOME = '" + txtnomeprofessor.Text + "' , FORMACAO = '" + cbxformacaoprofessor.Text + "', " +
                    "MUNICIPIO = " + cbxmunicipioprofessor.SelectedValue + " , " +
                    "LOGRADOURO = '" + txtlogradouroprofessor.Text + "', NUMERO = '" + txtnumeroenderecoprofessor.Text + "' WHERE id in ('" + txtidprofessor.Text + "')";

                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Professor alterado com sucesso!");

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
        private void btnexcluirprofessor_Click(object sender, EventArgs e)
        {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conexaoBD.Abrirconexao();
                    command.CommandText = "UPDATE ca_professor SET STATUS = 1 WHERE id in ('" + txtidprofessor.Text + "')";

                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Professor Cancelado com sucesso!");

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
        private void btnfecharprofessor_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //BOTÃO ATIVAR - ALTERA STATUS PARA ATIVA
        private void btnliberar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "UPDATE ca_professor SET STATUS = 2 WHERE id in ('" + txtidprofessor.Text + "')";

                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Professor Ativo com sucesso!");

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
