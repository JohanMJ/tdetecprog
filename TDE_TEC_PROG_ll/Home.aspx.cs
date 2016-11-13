using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TDE_TEC_PROG_ll
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void homeCadastrarPeriodo_Click(object sender, EventArgs e)
        {
            closeOthers();
            Periodo.Visible = !(Periodo.Visible);         
        }

        protected void homeCadastrarCurso_Click(object sender, EventArgs e)
        {
            closeOthers();
            Curso.Visible = !(Curso.Visible);
        }

        protected void homeCadastrarDisciplina_Click(object sender, EventArgs e)
        {
            closeOthers();
            Disciplina.Visible = !(Disciplina.Visible);
        }


        protected void homeGradeCurricular_Click(object sender, EventArgs e)
        {
            closeOthers();
            GradeCurricular.Visible = !(this.GradeCurricular.Visible);
        }

        private void closeOthers()
        {
            if (Periodo.Visible) Periodo.Visible = false;
            if (Curso.Visible) Curso.Visible = false;
            if (Disciplina.Visible) Disciplina.Visible = false;
            if (GradeCurricular.Visible) GradeCurricular.Visible = false;
        }
    }
}