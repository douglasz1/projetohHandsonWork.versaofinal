using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace uniads
{
    public static class conexaoBD
    {
        public static MySqlConnection Abrirconexao()
        {

            string conexao = "SERVER=localhost; DATABASE=dbuniversidade; UID=root; PWD=; PORT=;";
            MySqlConnection conectar = new MySqlConnection(conexao);
            conectar.Open();
            return conectar;
        }

        public static MySqlConnection Fecharconexao()
        {

            string conexao = "SERVER=localhost; DATABASE=dbuniversidade; UID=root; PWD=; PORT=;";
            MySqlConnection conectar = new MySqlConnection(conexao);
            conectar.Close();
            return conectar;
        }

        public static DataTable dql(string sql)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Abrirconexao();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
             }
               catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
       

    }


