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
    public partial class Periodo : System.Web.UI.UserControl
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
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT idDisciplina, nome_disciplina FROM tde_tec_prog_II.dbo.Disciplina", con);
                    adapter.Fill(subjects);

                    ddlSubject.DataSource = subjects;
                    ddlSubject.DataTextField = "nome_disciplina";
                    ddlSubject.DataValueField = "idDisciplina";
                    ddlSubject.DataBind();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            ddlSubject.Items.Insert(0, new ListItem("Disciplinas Disponiveis", "0"));
        }

        protected void adicionarPeriodo_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(strConexao);
            try
            {
                conexao.Open();
                String insert = "INSERT INTO Periodo (idDisciplina, numero_periodo) VALUES (@idDisciplina, @numero)";
                SqlCommand comando = new SqlCommand(insert, conexao);
                comando.Parameters.Add(new SqlParameter("@idDisciplina", ddlSubject.SelectedValue));
                comando.Parameters.Add(new SqlParameter("@numero", numeroPeriodo.Value));

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