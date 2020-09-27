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
    public partial class cadastroCurso : Form
    {
        public cadastroCurso()
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
                if (txtcodigocurso.Text == string.Empty)
                {
                    btnalterarcurso.Visible = false;
                    btnexcluircurso.Visible = false;
                    btnliberar.Visible = false;
                }
                else
                {
                    btnalterarcurso.Visible = true;
                    btnexcluircurso.Visible = true;
                    btnliberar.Visible = true;
                }

                if (txtcodigocurso.Text == string.Empty)
                {
                    btninserircurso.Visible = true;
                }
                else
                {
                    btninserircurso.Visible = false;
                }


                if (txtnomecurso.Text == string.Empty)
                {
                    btnnovocurso.Visible = false;
                }
                else
                {
                    btnnovocurso.Visible = true;
                }

                if (lblstatuscurso.Text == "1")
                {
                    btnliberar.Visible = true;
                }
                else
                {
                    btnliberar.Visible = false;
                }

                if (lblstatuscurso.Text == "2")
                {
                    btnexcluircurso.Visible = true;
                }
                else
                {
                    btnexcluircurso.Visible = false;
                }

                command.CommandText = "SELECT a.id, a.nome, a.grau, a.coordenador, a.cargahoraria, a.polo, b.nome, a.status from ca_curso a inner join status b on a.status = b.id";
                  

                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//GRAU
                    row.Cells[3].Value = reader.GetString(3);//COORDENADOR
                    row.Cells[4].Value = reader.GetString(4);//CARGAHORARIA
                    row.Cells[5].Value = reader.GetString(5);//POLO
                    row.Cells[6].Value = reader.GetString(6);//STATUS
                    row.Cells[7].Value = reader.GetString(7);//IDSTATUS
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


        //LOAD DO FORMULÁRIO - ATUALIZAGRID E LMPA OS CAMPOS
        private void cadastroCurso_Load(object sender, EventArgs e)
        {
            atualizarGrid();
            limparCampos();


            string polocurso = @"select distinct '0' id, ' ' nome from ca_municipio union all select distinct distinct id, CONCAT(nome, ' | ' , uf) as nome from ca_municipio where status in (2)";
            cbxpolocurso.Items.Clear();
            cbxpolocurso.DataSource = conexaoBD.dql(polocurso);
            cbxpolocurso.DisplayMember = "nome";
            cbxpolocurso.ValueMember = "id";
        }



        //CRIA MÉTODO DE LIMPAR CAMPOS DO FURMULÁRIO
        private void limparCampos()
        {
            txtnomecurso.Clear();
            cbxgraucurso.Text = " ";
            cbxcoordenadorcurso.Text = " ";
            cbxpolocurso.Text = " ";
            txtcargahorariacurso.Clear();
            txtcodigocurso.Clear();
            lblstatuscurso.Text = " ";
        }



        //PREENCHE OS TEXTBOX E COMBOBOX COM AS CÉLULAS DA LINHA DO GRID SELECIONADA
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;

                txtcodigocurso.Text = dataGridView1.Rows[e.RowIndex].Cells["codigo"].FormattedValue.ToString();
                txtnomecurso.Text = dataGridView1.Rows[e.RowIndex].Cells["nome"].FormattedValue.ToString();
                cbxgraucurso.Text = dataGridView1.Rows[e.RowIndex].Cells["grau"].FormattedValue.ToString();
                cbxcoordenadorcurso.Text = dataGridView1.Rows[e.RowIndex].Cells["coordenador"].FormattedValue.ToString();
                txtcargahorariacurso.Text = dataGridView1.Rows[e.RowIndex].Cells["cargahoraria"].FormattedValue.ToString();
                cbxpolocurso.Text = dataGridView1.Rows[e.RowIndex].Cells["polo"].FormattedValue.ToString();
                lblstatuscurso.Text = dataGridView1.Rows[e.RowIndex].Cells["idstatuscurso"].FormattedValue.ToString();
            }

            if (txtcodigocurso.Text == string.Empty)
            {
                btnalterarcurso.Visible = false;
                btnexcluircurso.Visible = false;
                btnliberar.Visible = false;
            }
            else
            {
                btnalterarcurso.Visible = true;
                btnexcluircurso.Visible = true;
                btnliberar.Visible = true;
            }

            if (txtcodigocurso.Text == string.Empty)
            {
                btninserircurso.Visible = true;
            }
            else
            {
                btninserircurso.Visible = false;
            }


            if (txtnomecurso.Text == string.Empty)
            {
                btnnovocurso.Visible = false;
            }
            else
            {
                btnnovocurso.Visible = true;
            }

            if (lblstatuscurso.Text == "1")
            {
                btnliberar.Visible = true;
            }
            else
            {
                btnliberar.Visible = false;
            }

            if (lblstatuscurso.Text == "2")
            {
                btnexcluircurso.Visible = true;
            }
            else
            {
                btnexcluircurso.Visible = false;
            }
        }


        //BOTÃO NOVO - LIMPA OS CAMPOS PARA UM NOVO CADASTRO
        private void btnnovocurso_Click(object sender, EventArgs e)
        {
            limparCampos();
            atualizarGrid();
        }


        //BOTÃO INSERIR - GRAVA UM NOVO CADASTRO
        private void btninserircurso_Click(object sender, EventArgs e)              
        {
            if (txtnomecurso.Text == " " || cbxgraucurso.Text == " " || cbxcoordenadorcurso.Text == " " || cbxpolocurso.Text == " " || txtcargahorariacurso.Text == string.Empty)
            {


                MessageBox.Show("Existem campos não preenchidos!");
            }
            else
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conexaoBD.Abrirconexao();
                    command.CommandText = "INSERT INTO `ca_curso`(`NOME`, `COORDENADOR`, `POLO`, `GRAU`, CARGAHORARIA, STATUS) " +
                    "VALUES ('" + txtnomecurso.Text + "','" + cbxcoordenadorcurso.Text + "', '" + cbxpolocurso.Text + "',  '" + cbxgraucurso.Text + "','" + txtcargahorariacurso.Text + "', 2)";

                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Curso cadastrado com sucesso!");

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
        private void btnalterarcurso_Click(object sender, EventArgs e)
        {

            if (txtnomecurso.Text == " " || cbxgraucurso.Text == " " || cbxcoordenadorcurso.Text == " " || cbxpolocurso.Text == " " || txtcargahorariacurso.Text == string.Empty)
            {


                MessageBox.Show("Existem campos não preenchidos!");
            }
            else
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conexaoBD.Abrirconexao();
                    command.CommandText = "UPDATE ca_curso SET NOME = '" + txtnomecurso.Text + "' , COORDENADOR = '" + cbxcoordenadorcurso.Text + "', " +
                        "POLO = '" + cbxpolocurso.Text + "', GRAU = '" + cbxgraucurso.Text + "', CARGAHORARIA = '" + txtcargahorariacurso.Text + "'  WHERE id in ('" + txtcodigocurso.Text + "')";

                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Curso alterado com sucesso!");

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


        //BOTÃO CANCELAR - ALTERA O REGISTRO PARA O SATUS CANCELADO
        private void btnexcluircurso_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "UPDATE ca_curso SET STATUS = 1  WHERE id in ('" + txtcodigocurso.Text + "')";

                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Curso cancelado com sucesso!");

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
        private void btnfecharcurso_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //BOTÃO ATIVAR - ALTERA O REGISTRO PARA O SATUS ATIVO
        private void btnliberar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "UPDATE ca_curso SET STATUS = 2  WHERE id in ('" + txtcodigocurso.Text + "')";

                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Curso Ativo com sucesso!");

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

        

      
    

      
    
