using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TDE_TEC_PROG_ll
{
    public partial class Disciplina : System.Web.UI.UserControl
    {
        string strConexao = @"Data Source=JOHAN-PC\SQLEXPRESS; Initial Catalog=tde_tec_prog_II; Integrated Security=true;";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AdicionarDisciplina_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                String insert = "INSERT INTO Disciplina (nome_disciplina, aulas_teoricas, aulas_praticas, hora_relogio, numero_credito) VALUES (@nome, @aulas_teoricas, @aulas_praticas, @hora_relogio, @numero_credito)";
                SqlCommand comando = new SqlCommand(insert, conexao);
                comando.Parameters.Add(new SqlParameter("@nome", nomeDisciplina.Value));
                comando.Parameters.Add(new SqlParameter("@aulas_teoricas", numeroAulasTeoricas.Value));
                comando.Parameters.Add(new SqlParameter("@aulas_praticas", numeroAulasPraticas.Value));
                comando.Parameters.Add(new SqlParameter("@hora_relogio", horaRelogio.Value));
                comando.Parameters.Add(new SqlParameter("@numero_credito", numeroCredito.Value));
                int i = comando.ExecuteNonQuery();
                if (i != 0)
                {
                    Console.WriteLine("Correto!");

                }
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }
            finally
            {
                conexao.Close();
                Response.Redirect("~/Home.aspx");
            }
        }
    }
}