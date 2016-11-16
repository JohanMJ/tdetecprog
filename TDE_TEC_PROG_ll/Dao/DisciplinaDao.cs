using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TDE_TEC_PROG_ll.Dao
{
    public class DisciplinaDao : Dao
    {
        public List<Models.Disciplina> buscarDisciplinaCurso(string nome_disciplina, int idCurso_fk)
        {
            List<Models.Disciplina> disciplinas;
            Models.Disciplina disciplina;
            String query;

            disciplinas = new List<Models.Disciplina>();

            try
            {
                conexao.Open();

                query = "SELECT * FROM Disciplina AS d INNER JOIN Periodo AS p " +
                        "ON d.nome_disciplina LIKE @nome_disciplina AND " +
                        "p.idPeriodo = d.idPeriodo_fk INNER JOIN Curso AS c " +
                        "ON c.idCurso = p.idCurso_fk AND c.idCurso = @idCurso_fk";
                comando = new SqlCommand(query, conexao);

                comando.Parameters.Add(new SqlParameter("@nome_disciplina", nome_disciplina + "%"));
                comando.Parameters.Add(new SqlParameter("@idCurso_fk", idCurso_fk));
                leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    disciplina = new Models.Disciplina(leitor["nome_disciplina"].ToString(), 
                        int.Parse(leitor["aulas_teoricas"].ToString()), 
                        int.Parse(leitor["aulas_praticas"].ToString()), 
                        int.Parse(leitor["hora_relogio"].ToString()), 
                        int.Parse(leitor["idPeriodo_fk"].ToString()));
                    disciplina.IdDisciplina = int.Parse(leitor["idDisciplina"].ToString());
                    disciplinas.Add(disciplina);
                }
            }
            catch (Exception error)
            {
                throw new Exception();
            }
            finally
            {
                conexao.Close();
                comando = null;
                leitor = null;
            }
            return disciplinas;
        }

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

        public Models.Disciplina buscarDisciplinaPorId(int idDisciplina)
        {
            Models.Disciplina disciplina;
            string query;

            disciplina = null;

            try
            {
                conexao.Open();

                query = "SELECT * FROM Disciplina WHERE disciplina.idDisciplina = @idDisciplina";
                comando = new SqlCommand(query, conexao);

                comando.Parameters.Add(new SqlParameter("@idDisciplina", idDisciplina));
                leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    disciplina = new Models.Disciplina(leitor["nome_disciplina"].ToString(),
                        int.Parse(leitor["aulas_teoricas"].ToString()),
                        int.Parse(leitor["aulas_praticas"].ToString()),
                        int.Parse(leitor["hora_relogio"].ToString()),
                        int.Parse(leitor["idPeriodo_fk"].ToString()));
                    disciplina.Numero_credito = int.Parse(leitor["numero_credito"].ToString());
                    disciplina.IdDisciplina = int.Parse(leitor["idDisciplina"].ToString());
                }
            }
            catch (Exception error)
            {
                return null;
            }
            finally
            {
                conexao.Close();
                comando = null;
                leitor = null;
            }
            return disciplina;
        }

        public bool atualizarDisciplina(Models.Disciplina disciplina)
        {
            string query;

            try
            {
                conexao.Open();

                query = "UPDATE Disciplina SET nome_disciplina = @nome_disciplina, " +
                        "aulas_teoricas = @aulas_teoricas, aulas_praticas = @aulas_praticas, " +
                        "hora_relogio = @hora_relogio, numero_credito = @numero_credito " +
                        "WHERE disciplina.idDisciplina = @idDisciplina";
                comando = new SqlCommand(query, conexao);

                comando.Parameters.Add(new SqlParameter("@nome_disciplina", disciplina.Nome_disciplina));
                comando.Parameters.Add(new SqlParameter("@aulas_teoricas", disciplina.Aulas_teoricas));
                comando.Parameters.Add(new SqlParameter("@aulas_praticas", disciplina.Aulas_praticas));
                comando.Parameters.Add(new SqlParameter("@hora_relogio", disciplina.Hora_relogio));
                comando.Parameters.Add(new SqlParameter("@numero_credito", disciplina.Numero_credito));
                comando.Parameters.Add(new SqlParameter("@idDisciplina", disciplina.IdDisciplina));
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