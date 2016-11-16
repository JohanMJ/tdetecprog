using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TDE_TEC_PROG_ll.Dao;

namespace TDE_TEC_PROG_ll
{
    public partial class CursoBuscar : System.Web.UI.UserControl
    {
        private CursoDao cursoDao;
        protected List<Models.Curso> cursos;

        public CursoBuscar()
        {
            this.cursoDao = new CursoDao();
            this.cursos = new List<Models.Curso>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buscarCurso_Click(object sender, EventArgs e)
        {
            string nome = this.nomeCurso.Value;
            cursos = cursoDao.buscarCurso(nome);

            foreach (Models.Curso c in cursos)
            {
                TextBox t = new TextBox();
                HyperLink l = new HyperLink();

                t.Text = c.Nome_curso;
                t.ReadOnly = true;
                t.CssClass = "form-control";
                l.Text = "Detalhes";
                l.CssClass = "form-control";
                l.NavigateUrl = "CursoDetalhes.aspx?id=" + c.IdCurso.ToString();

                this.cursosEncontrados.Controls.Add(t);
                this.cursosEncontrados.Controls.Add(l);
            }
        }
    }
}