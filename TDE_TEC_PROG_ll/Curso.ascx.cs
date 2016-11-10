using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TDE_TEC_PROG_ll
{
    public partial class Curso : System.Web.UI.UserControl
    {
        string strConexao = @"Data Source=DESKTOP-PP69BLK\SQLEXPRESS; Initial Catalog=parcial_ii; Integrated Security=true;";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adicionarCurso_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {

                conexao.Open();
                String insert = "INSERT INTO Curso (nome_curso) VALUES (@nome)";
                SqlCommand comando = new SqlCommand(insert, conexao);
                comando.Parameters.Add(new SqlParameter("@nome", nomeCurso.Value));

                int i = comando.ExecuteNonQuery();
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