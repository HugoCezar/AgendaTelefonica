using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_Telefonica.Models
{
    public class ConectarBancoDeDados
    {
        private static string strconexao = @"Data Source=NOTE-HUGO\sqlexpress;Initial Catalog=Agenda;Integrated Security=True";
        
        public static SqlConnection conectarBanco()
        {
            SqlConnection connection = new SqlConnection(strconexao);
            return connection;
        }
    }
}
