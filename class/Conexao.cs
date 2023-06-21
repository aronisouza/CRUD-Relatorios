using MySql.Data.MySqlClient;

namespace CRUD_Relatorios
{
    class Conexao
    {
        private MySqlConnection conn = null;
        private const string servidor = "localhost";
        private const string banco = "livros";
        private const string user = "filid";
        private const string pass = "p2n2h8n4";


        public MySqlConnection GetConexao()
        {
            Connection();
            return conn;
        }

        private void Connection()
        {

            if (conn == null)
            {
                conn = new MySqlConnection($"server={servidor};database={banco};User Id={user};password={pass}");
            }
        }

    }
}
