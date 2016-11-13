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
    public partial class Disciplina : System.Web.UI.UserControl
    {
        private DisciplinaDao disciplinaDao;

        public Disciplina()
        {
            this.disciplinaDao = new DisciplinaDao();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AdicionarDisciplina_Click(object sender, EventArgs e)
        {
            string nomeDisciplina = this.nomeDisciplina.Value;
            int aulasTeoricas = int.Parse(this.numeroAulasTeoricas.Value);
            int aulasPraticas = int.Parse(this.numeroAulasPraticas.Value);
            int horaRelogio = int.Parse(this.horaRelogio.Value);
            int idPeriodo_fk = int.Parse(this.ddlSubject.SelectedValue);

            Models.Disciplina novaDisciplina = new Models.Disciplina(nomeDisciplina, aulasTeoricas, 
                                                                        aulasPraticas, horaRelogio, 
                                                                        idPeriodo_fk);
            if (disciplinaDao.salvar(novaDisciplina))
                Response.Redirect("~/Home.aspx");
        }

        protected void ddlSubject_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter;
            DataTable subjects = new DataTable();

            adapter = disciplinaDao.adapter();

            adapter.Fill(subjects);
            ddlSubject.DataSource = subjects;
            ddlSubject.DataTextField = "numero_periodo";
            ddlSubject.DataValueField = "idPeriodo";
            ddlSubject.DataBind();
 
            ddlSubject.Items.Insert(0, new ListItem("Periodos Disponiveis", "0"));
        }
    }
}