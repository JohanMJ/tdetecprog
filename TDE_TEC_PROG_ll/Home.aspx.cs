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
            Periodo.Visible = true;
        }

        protected void homeCadastrarCurso_Click(object sender, EventArgs e)
        {
            Curso.Visible = true;
        }

        protected void homeCadastrarDisciplina_Click(object sender, EventArgs e)
        {
            Disciplina.Visible = true;
        }


        protected void homeGradeCurricular_Click(object sender, EventArgs e)
        {
            GradeCurricular.Visible = true;
        }
    }
}