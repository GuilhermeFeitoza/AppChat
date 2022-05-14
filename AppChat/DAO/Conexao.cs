using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AppChat.DAO
{
  public class Conexao
    {
        private static string StringConexao = @"Server=DESKTOP-L0N3OP9\FTZ;Database=AppChat;Trusted_Connection=True;";

        public SqlConnection CriarConexao() {
            try
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = StringConexao;
                conexao.Open();
                return conexao;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
          
        
        
        
        }


    }
}
