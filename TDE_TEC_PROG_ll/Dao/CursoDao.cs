using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TDE_TEC_PROG_ll.Dao
{
    public class CursoDao : Dao
    {
        public bool salvar(Models.Curso curso)
        {
            string query;
            try
            {
                conexao.Open();

                query = "INSERT INTO Curso (nome_curso) VALUES (@nome)";
                comando = new SqlCommand(query, conexao);

                comando.Parameters.Add(new SqlParameter("@nome", curso.Nome_curso));
                comando.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                return false;
            }
            finally
            {
                conexao.Close();
                comando = null;
            }
            return true;
        }
    }
}