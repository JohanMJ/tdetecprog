using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDE_TEC_PROG_ll.Models
{
    public class Curso
    {
        private int idCurso;
        private string nome_curso;

        public Curso(string nome_curso)
        {
            this.Nome_curso = nome_curso;
        }

        public int IdCurso
        {
            get
            {
                return idCurso;
            }

            set
            {
                idCurso = value;
            }
        }

        public string Nome_curso
        {
            get
            {
                return nome_curso;
            }

            set
            {
                nome_curso = value;
            }
        }
    }
}