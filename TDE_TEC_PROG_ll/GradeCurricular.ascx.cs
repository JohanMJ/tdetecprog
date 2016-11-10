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
    public partial class GradeCurricular : System.Web.UI.UserControl
    {
        string strConexao = @"Data Source=DESKTOP-PP69BLK\SQLEXPRESS; Initial Catalog=parcial_ii; Integrated Security=true;";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridView();
            }
        }

        private void BindGridView()
        {

           /* DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(strConexao);
            
            try
            {
                connection.Open();
                string sqlStatement = "SELECT c.nome_curso, p.numero_periodo, d.nome_disciplina, (SUM(d.aulas_teoricas)) total FROM Curso c INNER JOIN Periodo p ON " +
                                       " c.idPeriodo = p.idPeriodo " +
                                       "INNER JOIN Disciplina d ON d.idDisciplina = p.idDisciplina " +
                                       "GROUP BY  c.nome_curso, p.numero_periodo, d.nome_disciplina, c.total";

                SqlCommand sqlCmd = new SqlCommand(sqlStatement, connection);
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
                sqlDa.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Fetch Error:";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                connection.Close();
            }*/
        } 
    }
}