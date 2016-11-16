using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TDE_TEC_PROG_ll.Dao;

namespace TDE_TEC_PROG_ll
{
    public partial class CursoDetalhes : System.Web.UI.Page
    {
        private CursoDao cursoDao;
        private Models.Curso curso;
        private int id;

        public CursoDetalhes()
        {
            this.cursoDao = new CursoDao();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            this.id = int.Parse(Request.QueryString["id"].ToString());
            this.curso = cursoDao.buscarCursoPorId(id);
            this.nomeCurso.Value = this.curso.Nome_curso;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void atualizarCurso_Click(object sender, EventArgs e)
        {
            Models.Curso curso;
            string novoNome;

            novoNome = this.nomeCurso.Value;
            curso = new Models.Curso(novoNome);
            curso.IdCurso = this.id;

            cursoDao.atualizarCurso(curso);
            Response.Redirect("Home.aspx");
        }
    }
}