using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TDE_TEC_PROG_ll.Dao;

namespace TDE_TEC_PROG_ll
{
    public partial class DisciplinaDetalhes : System.Web.UI.Page
    {
        private DisciplinaDao disciplinaDao;
        private Models.Disciplina disciplina;
        private int id;

        public DisciplinaDetalhes()
        {
            this.disciplinaDao = new DisciplinaDao();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            this.id = int.Parse(Request.QueryString["id"].ToString());
            this.disciplina = disciplinaDao.buscarDisciplinaPorId(id);
            this.nomeDisciplina.Value = this.disciplina.Nome_disciplina;
            this.numeroAulasPraticas.Value = this.disciplina.Aulas_praticas.ToString();
            this.numeroAulasTeoricas.Value = this.disciplina.Aulas_teoricas.ToString();
            this.horaRelogio.Value = this.disciplina.Hora_relogio.ToString();
            this.numeroCredito.Value = this.disciplina.Numero_credito.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AtualizarDisciplina_Click(object sender, EventArgs e)
        {
            Models.Disciplina disciplina;

            string nome = this.nomeDisciplina.Value;
            int aulasTeoricas = int.Parse(this.numeroAulasTeoricas.Value);
            int aulasPraticas = int.Parse(this.numeroAulasPraticas.Value);
            int horaRelogio = int.Parse(this.horaRelogio.Value);
            int numeroCredito = int.Parse(this.numeroCredito.Value);

            disciplina = new Models.Disciplina(nome, aulasTeoricas, aulasPraticas, horaRelogio, 0);
            disciplina.Numero_credito = numeroCredito;
            disciplina.IdDisciplina = this.id;

            disciplinaDao.atualizarDisciplina(disciplina);
            Response.Redirect("Home.aspx");
        }
    }
}