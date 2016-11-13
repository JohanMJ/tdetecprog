using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TDE_TEC_PROG_ll.Dao
{
    public class PeriodoDao : Dao
    {
        public bool salvar(Models.Periodo periodo)
        {
            string query;

            try
            {
                conexao.Open();
                query = "INSERT INTO Periodo (idCurso_fk, numero_periodo) VALUES (@idCurso_fk, @numero)";
                comando = new SqlCommand(query, conexao);

                comando.Parameters.Add(new SqlParameter("@numero", periodo.Numero_periodo));
                comando.Parameters.Add(new SqlParameter("@idCurso_fk", periodo.IdCurso_fk));
                comando.ExecuteNonQuery();
            }
            catch (Exception errror)
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
                query = "SELECT idCurso, nome_curso FROM Curso";
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