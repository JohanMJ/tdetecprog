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

        public List<Models.Curso> buscarCurso(string nome)
        {
            Models.Curso curso;
            List<Models.Curso> cursos;
            string query;

            cursos = new List<Models.Curso>();

            try
            {
                conexao.Open();

                query = "SELECT * FROM Curso WHERE curso.nome_curso LIKE @nome";
                comando = new SqlCommand(query, conexao);

                comando.Parameters.Add(new SqlParameter("@nome", nome + "%"));
                leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    curso = new Models.Curso(leitor["nome_curso"].ToString());
                    curso.IdCurso = int.Parse(leitor["idCurso"].ToString());
                    cursos.Add(curso);
                }
            }
            catch(Exception error)
            {
                return null;
            }
            finally
            {
                conexao.Close();
                comando = null;
                leitor = null;
            }
            return cursos;
        }

        public Models.Curso buscarCursoPorId(int idCurso)
        {
            Models.Curso curso;
            string query;

            curso = null;

            try
            {
                conexao.Open();

                query = "SELECT * FROM Curso WHERE curso.idCurso = @idCurso";
                comando = new SqlCommand(query, conexao);

                comando.Parameters.Add(new SqlParameter("@idCurso", idCurso));
                leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    curso = new Models.Curso(leitor["nome_curso"].ToString());
                    curso.IdCurso = int.Parse(leitor["idCurso"].ToString());
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
            return curso;
        }

        public bool atualizarCurso(Models.Curso curso)
        {
            string query;

            try
            {
                conexao.Open();

                query = "UPDATE Curso SET nome_curso = @nome_curso WHERE curso.idCurso = @idCurso";
                comando = new SqlCommand(query, conexao);

                comando.Parameters.Add(new SqlParameter("@nome_curso", curso.Nome_curso));
                comando.Parameters.Add(new SqlParameter("@idCurso", curso.IdCurso));
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