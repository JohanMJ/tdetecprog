using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TDE_TEC_PROG_ll.Dao
{
    public class DisciplinaDao : Dao
    {
        public bool salvar(Models.Disciplina disciplina)
        {
            String query;

            try
            {
                conexao.Open();

                query = "INSERT INTO Disciplina (nome_disciplina, aulas_teoricas, aulas_praticas, " +
                    "hora_relogio, numero_credito, idPeriodo_fk) VALUES (@nome, @aulas_teoricas, @aulas_praticas, " +
                    "@hora_relogio, @numero_credito, @idPeriodo_fk)";
                comando = new SqlCommand(query, conexao);

                comando.Parameters.Add(new SqlParameter("@nome", disciplina.Nome_disciplina));
                comando.Parameters.Add(new SqlParameter("@aulas_teoricas", disciplina.Aulas_teoricas));
                comando.Parameters.Add(new SqlParameter("@aulas_praticas", disciplina.Aulas_praticas));
                comando.Parameters.Add(new SqlParameter("@hora_relogio", disciplina.Hora_relogio));
                comando.Parameters.Add(new SqlParameter("@numero_credito", disciplina.Numero_credito));
                comando.Parameters.Add(new SqlParameter("@idPeriodo_fk", disciplina.IdPeriodo_fk));
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

        public SqlDataAdapter adapter()
        {
            SqlDataAdapter adapter;
            string query;

            try
            {
                query = "SELECT idPeriodo, numero_periodo FROM Periodo";
                adapter = new SqlDataAdapter(query, conexao);

                return adapter;
            }
            catch (Exception error)
            {
                return null;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}