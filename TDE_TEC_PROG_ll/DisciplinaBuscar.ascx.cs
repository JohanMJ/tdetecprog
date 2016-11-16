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
    public partial class DisciplinaBuscar : System.Web.UI.UserControl
    {
        private DisciplinaDao disciplinaDao;
        private CursoDao cursoDao;
        protected List<Models.Disciplina> disciplinas;

        public DisciplinaBuscar()
        {
            this.disciplinaDao = new DisciplinaDao();
            this.cursoDao = new CursoDao();
            this.disciplinas = new List<Models.Disciplina>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buscarDisciplina_Click(object sender, EventArgs e)
        {
            string nome = this.nomeDisciplina.Value;
            int idCurso_fk = int.Parse(ddlSubject.SelectedValue);
            disciplinas = disciplinaDao.buscarDisciplinaCurso(nome, idCurso_fk);

            foreach (Models.Disciplina d in disciplinas)
            {
                TextBox t = new TextBox();
                HyperLink l = new HyperLink();

                t.Text = d.Nome_disciplina;
                t.ReadOnly = true;
                t.CssClass = "form-control";
                l.Text = "Detalhes";
                l.CssClass = "form-control";
                l.NavigateUrl = "DisciplinaDetalhes.aspx?id=" + d.IdDisciplina.ToString();

                this.disciplinasEncontradas.Controls.Add(t);
                this.disciplinasEncontradas.Controls.Add(l);
            }
        }

        protected void ddlSubject_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter;
            DataTable subjects = new DataTable();

            adapter = cursoDao.adapter();

            adapter.Fill(subjects);
            ddlSubject.DataSource = subjects;
            ddlSubject.DataTextField = "nome_curso";
            ddlSubject.DataValueField = "idCurso";
            ddlSubject.DataBind();

            ddlSubject.Items.Insert(0, new ListItem("Cursos Disponiveis", "0"));
        }
    }
}