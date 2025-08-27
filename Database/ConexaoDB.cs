using System.Configuration;
using Microsoft.Data.SqlClient;

namespace SistemaAtendimento.Database
{
    public static class ConexaoDB
    {
        public static SqlConnection GetConexao()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SistemaAtendimentoDB"].ConnectionString;
            return new SqlConnection(connectionString);
        
        }
    }
}
