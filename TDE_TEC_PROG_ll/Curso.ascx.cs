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
    public partial class Curso : System.Web.UI.UserControl
    {
        private CursoDao cursoDao;

        public Curso()
        {
            this.cursoDao = new CursoDao();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adicionarCurso_Click(object sender, EventArgs e)
        {
            Models.Curso novoCurso = new Models.Curso(nomeCurso.Value);

            if (cursoDao.salvar(novoCurso))
                Response.Redirect("~/Home.aspx");  
        }
    }
}