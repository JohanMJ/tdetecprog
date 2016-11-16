using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TDE_TEC_PROG_ll.Dao;

namespace TDE_TEC_PROG_ll
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void homeCadastrarPeriodo_Click(object sender, EventArgs e)
        {
            Periodo.Visible = !(Periodo.Visible);         
        }

        protected void homeCadastrarCurso_Click(object sender, EventArgs e)
        {
            Curso.Visible = !(Curso.Visible);
            if (CursoBuscar.Visible) CursoBuscar.Visible = false; 
        }

        protected void homeBuscarCurso_Click(object sender, EventArgs e)
        {
            CursoBuscar.Visible = true;
            if (Curso.Visible) Curso.Visible = false;
        }

        protected void homeCadastrarDisciplina_Click(object sender, EventArgs e)
        {
            Disciplina.Visible = !(Disciplina.Visible);
        }

        protected void homeBuscarDisciplina_Click(object sender, EventArgs e)
        {
            DisciplinaBuscar.Visible = true;
            if (Disciplina.Visible) Disciplina.Visible = false;
        }

        protected void homeGradeCurricular_Click(object sender, EventArgs e)
        {
            GradeCurricular.Visible = !(this.GradeCurricular.Visible);
        }

        private void closeOthers()
        {
            if (periodoBloco.Visible)
            {
                periodoBloco.Visible = false;
                Periodo.Visible = false;
            }
            if (cursoBloco.Visible)
            {
                cursoBloco.Visible = false;
                Curso.Visible = false;
            }
            if (disciplinaBloco.Visible)
            {
                disciplinaBloco.Visible = false;
                Disciplina.Visible = false;
            }
            if (GradeCurricular.Visible) GradeCurricular.Visible = false;
        }

        protected void homeCursoBloco_Click(object sender, EventArgs e)
        {
            if (cursoBloco.Visible)
            {
                cursoBloco.Visible = false;
                Curso.Visible = false;
            }
            else
            {
                closeOthers();
                cursoBloco.Visible = true;
            }
        }

        protected void homePeriodoBloco_Click(object sender, EventArgs e)
        {
            if (periodoBloco.Visible)
            {
                periodoBloco.Visible = false;
                Periodo.Visible = false;
            }
            else
            {
                closeOthers();
                periodoBloco.Visible = true;
            }
        }

        protected void homeDisciplinaBloco_Click(object sender, EventArgs e)
        {
            if (disciplinaBloco.Visible)
            {
                disciplinaBloco.Visible = false;
                Disciplina.Visible = false;
            }
            else
            {
                closeOthers();
                disciplinaBloco.Visible = true;
            }
        }
    }
}