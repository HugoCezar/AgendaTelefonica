using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Agenda_Telefonica.Models
{
    public static class ContatoDao
    {
        public static void IncluirContato(Contato contato)
        {
            using (SqlConnection connection =
                        ConectarBancoDeDados.conectarBanco())
            {
                string queryString = @"insert into Contato(Nome,Apelido,Tel_residencial,Tel_celular,Tel_comercial) 
                                    values (@nome, @apelido, @tel_res, @tel_cel, @tel_coml)";

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@nome", contato.Nome);
                command.Parameters.AddWithValue("@apelido", contato.Apelido);
                command.Parameters.AddWithValue("@tel_res", contato.Tel_res);
                command.Parameters.AddWithValue("@tel_cel", contato.Tel_cel);
                command.Parameters.AddWithValue("@tel_coml", contato.Tel_coml);

                try
                {
                    connection.Open();
                    int valor = command.ExecuteNonQuery();

                    if (valor <= 0)
                    {
                        throw new Exception("Não foi possivel inserir o contato");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

        }

        public static List<Contato> ListaContatos()
        {
            using (SqlConnection connection = ConectarBancoDeDados.conectarBanco())
            using (SqlCommand command = new SqlCommand("Select * From Contato", connection))
                try
                {
                    connection.Open();
                    List<Contato> listaContatos = new List<Contato>();
                    using (SqlDataReader sqlDataReader = command.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            Contato contato = new Contato();
                            contato.Nome = sqlDataReader["Nome"].ToString();
                            contato.Apelido = sqlDataReader["Apelido"].ToString();
                            contato.Tel_res = sqlDataReader["Tel_residencial"].ToString();
                            contato.Tel_cel = sqlDataReader["Tel_celular"].ToString();
                            contato.Tel_coml = sqlDataReader["Tel_comercial"].ToString();
                            listaContatos.Add(contato);
                        }
                    }
                    return listaContatos;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
        }

        public static void AtualizarContato(Contato contato)
        {

        }

        public static void ExcluirContato(Contato contato)
        {

        }        
    }
}
