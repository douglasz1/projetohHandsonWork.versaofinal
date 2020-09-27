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
    public partial class cadastroMunicipio : Form
    {
        public cadastroMunicipio()
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
                if (txtidmunicipio.Text == string.Empty)
                {
                    btnalterarmunicipio.Visible = false;
                    btnexcluirmunicipio.Visible = false;
                    btnliberar.Visible = false;
                }
                else
                {
                    btnalterarmunicipio.Visible = true;
                    btnexcluirmunicipio.Visible = true;
                    btnliberar.Visible = true;
                }

                if (txtidmunicipio.Text == string.Empty)
                {
                    btninserirmunicipio.Visible = true;
                }
                else
                {
                    btninserirmunicipio.Visible = false;
                }

                if (txtnomemunicipio.Text == string.Empty)
                {
                    btnnovomunicipio.Visible = false;
                }
                else
                {
                    btnnovomunicipio.Visible = true;
                }

                if (lblstatusmunicipio.Text == "1")
                {
                    btnliberar.Visible = true;
                }
                else
                {
                    btnliberar.Visible = false;
                }

                if (lblstatusmunicipio.Text == "2")
                {
                    btnexcluirmunicipio.Visible = true;
                }
                else
                {
                    btnexcluirmunicipio.Visible = false;
                }

                command.CommandText = "SELECT a.id, a.nome, a.uf, a.codigoibge, b.nome, a.status FROM ca_municipio a inner join status b on a.status = b.id";

                MySqlDataReader reader = command.ExecuteReader();
                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID 
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//UF
                    row.Cells[3].Value = reader.GetString(3);//CODIGOIBGE
                    row.Cells[4].Value = reader.GetString(4);//STATUS
                    row.Cells[5].Value = reader.GetString(5);//IDSTATUS
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
        private void cadastroMunicipio_Load(object sender, EventArgs e)
        {
            atualizarGrid();
            limparCampos();
        }


        //CRIA MÉTODO DE LIMPAR CAMPOS DO FURMULÁRIO
        private void limparCampos()
        {
            txtnomemunicipio.Clear();
            cbxufmunicipio.Text = " ";
            txtcodigoibgemunicipio.Clear();
            txtidmunicipio.Clear();
            lblstatusmunicipio.Text = " ";
        }


        //PREENCHE OS TEXTBOX E COMBOBOX COM AS CÉLULAS DA LINHA DO GRID SELECIONADA
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;

                txtidmunicipio.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                txtnomemunicipio.Text = dataGridView1.Rows[e.RowIndex].Cells["nome"].FormattedValue.ToString();
                cbxufmunicipio.Text = dataGridView1.Rows[e.RowIndex].Cells["uf"].FormattedValue.ToString();
                txtcodigoibgemunicipio.Text = dataGridView1.Rows[e.RowIndex].Cells["codigoibge"].FormattedValue.ToString();
                lblstatusmunicipio.Text = dataGridView1.Rows[e.RowIndex].Cells["idstatusmunicipio"].FormattedValue.ToString();
            }

            if (txtidmunicipio.Text == string.Empty)
            {
                btnalterarmunicipio.Visible = false;
                btnexcluirmunicipio.Visible = false;
                btnliberar.Visible = false;
            }
            else
            {
                btnalterarmunicipio.Visible = true;
                btnexcluirmunicipio.Visible = true;
                btnliberar.Visible = true;
            }

            if (txtidmunicipio.Text == string.Empty)
            {
                btninserirmunicipio.Visible = true;
            }
            else
            {
                btninserirmunicipio.Visible = false;
            }

            if (txtnomemunicipio.Text == string.Empty)
            {
                btnnovomunicipio.Visible = false;
            }
            else
            {
                btnnovomunicipio.Visible = true;
            }

            if (lblstatusmunicipio.Text == "1")
            {
                btnliberar.Visible = true;
            }
            else
            {
                btnliberar.Visible = false;
            }

            if (lblstatusmunicipio.Text == "2")
            {
                btnexcluirmunicipio.Visible = true;
            }
            else
            {
                btnexcluirmunicipio.Visible = false;
            }
        }


        //BOTÃO NOVO - LIMPA OS CAMPOS PARA UM NOVO CADASTRO
        private void btnnovomunicipio_Click(object sender, EventArgs e)
        {
            limparCampos();
            atualizarGrid();
        }


        //BOTÃO INSERIR - GRAVA UM NOVO CADASTRO
        private void btninserirmunicipio_Click(object sender, EventArgs e)
        {
            if (txtnomemunicipio.Text == string.Empty || cbxufmunicipio.Text == " " || txtcodigoibgemunicipio.Text == string.Empty)
            {


                MessageBox.Show("Existem campos não preenchidos!");
            }
            else
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conexaoBD.Abrirconexao();
                    command.CommandText = "INSERT INTO `ca_municipio`(`NOME`, `UF`, CODIGOIBGE, STATUS) " +
                        "VALUES ('" + txtnomemunicipio.Text + "','" + cbxufmunicipio.Text + "', '" + txtcodigoibgemunicipio.Text + "', 2)";

                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Município cadastrado com sucesso!");

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
        private void btnalterarmunicipio_Click(object sender, EventArgs e)
        {
            if (txtnomemunicipio.Text == string.Empty || cbxufmunicipio.Text == " " || txtcodigoibgemunicipio.Text == string.Empty)
            {


                MessageBox.Show("Existem campos não preenchidos!");
            }
            else
            {
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conexaoBD.Abrirconexao();
                    command.CommandText = "UPDATE ca_municipio SET NOME = '" + txtnomemunicipio.Text + "', UF = '" + cbxufmunicipio.Text + "', CODIGOIBGE = '" + txtcodigoibgemunicipio.Text + "'   " +
                        "WHERE id in ('" + txtidmunicipio.Text + "')";

                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Município alterado com sucesso!");

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


        //BOTÃO CANCELAR - ALTERAR O STATUS PARA CANCELADO
        private void btnexcluirmunicipio_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "UPDATE ca_municipio SET STATUS = 1 WHERE id in ('" + txtidmunicipio.Text + "')";

                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Município Cancelado com sucesso!");

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
        private void btnfecharmunicipio_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //BOTÃO ATIVAR - ALTERAR O STATUS PARA ATIVO
        private void btnliberar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = conexaoBD.Abrirconexao();
                command.CommandText = "UPDATE ca_municipio SET STATUS = 2 WHERE id in ('" + txtidmunicipio.Text + "')";

                command.ExecuteNonQuery();
                command.Connection.Close();
                MessageBox.Show("Município Ativo com sucesso!");

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