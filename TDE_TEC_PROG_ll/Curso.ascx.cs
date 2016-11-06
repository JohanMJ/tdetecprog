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
        string strConexao = @"Data Source=JOHAN-PC\SQLEXPRESS; Initial Catalog=tde_tec_prog_II; Integrated Security=true;";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void ddlSubject_Load(object sender, EventArgs e)
        {

            DataTable subjects = new DataTable();

            using (SqlConnection con = new SqlConnection(strConexao))
            {

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT idPeriodo, numero_periodo FROM tde_tec_prog_II.dbo.Periodo", con);

                    adapter.Fill(subjects);


                    ddlSubject.DataSource = subjects;
                    ddlSubject.DataTextField = "numero_periodo";
                    ddlSubject.DataValueField = "idPeriodo";
                    ddlSubject.DataBind();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }
            ddlSubject.Items.Insert(0, new ListItem("Periodos Disponiveis", "0"));

        }

        protected void adicionarCurso_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {

                conexao.Open();
                String insert = "INSERT INTO Curso (idPeriodo, nome_curso) VALUES (@idPeriodo, @nome)";
                SqlCommand comando = new SqlCommand(insert, conexao);
                comando.Parameters.Add(new SqlParameter("@idPeriodo", ddlSubject.SelectedValue));
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