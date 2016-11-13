using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TDE_TEC_PROG_ll.Dao;

namespace TDE_TEC_PROG_ll
{
    public partial class Periodo : System.Web.UI.UserControl
    {
        private PeriodoDao periodoDao;

        public Periodo()
        {
            this.periodoDao = new PeriodoDao();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlSubject_Load(object sender, EventArgs e)
        {
            DataTable subjects = new DataTable();
            SqlDataAdapter adapter = periodoDao.adapter();

            adapter.Fill(subjects);
            ddlSubject.DataSource = subjects;
            ddlSubject.DataTextField = "nome_curso";
            ddlSubject.DataValueField = "idCurso";
            ddlSubject.DataBind();

            ddlSubject.Items.Insert(0, new ListItem("Disciplinas Disponiveis", "0"));
        }

        protected void adicionarPeriodo_Click(object sender, EventArgs e)
        {
            int numeroPeriodo = int.Parse(this.numeroPeriodo.Value);
            int idCurso_fk = int.Parse(this.ddlSubject.SelectedValue);

            Models.Periodo novoPeriodo = new Models.Periodo(numeroPeriodo, idCurso_fk);

            if (periodoDao.salvar(novoPeriodo))
                Response.Redirect("~/Home.aspx");
        }


    }
}