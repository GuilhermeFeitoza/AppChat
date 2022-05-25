using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChat.DAO
{
    public class Login
    {
        public bool Logar(SqlConnection conn, string Nome, string Senha)
        {
            try
            {

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM tbLogin WHERE NOME=@NOME AND SENHA=@SENHA";
                cmd.Parameters.Add(new SqlParameter("NOME", Nome));
                cmd.Parameters.Add(new SqlParameter("SENHA", Senha));
                int numeroDeUsuarios = Convert.ToInt16(cmd.ExecuteScalar());

                if (numeroDeUsuarios > 0)
                {
                    return true;
                }
                else
                {

                    return false;
                }


            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public void Cadastrar(SqlConnection conn, string Nome, string Senha)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO tbLogin(NOME,SENHA,ATIVO) VALUES(@NOME,@SENHA,'S')";
                cmd.Parameters.Add(new SqlParameter("NOME", Nome));
                cmd.Parameters.Add(new SqlParameter("SENHA", Senha));
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw;
            }



        }


    }
}
