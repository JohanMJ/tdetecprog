    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDE_TEC_PROG_ll.Models
{
    public class Disciplina
    {
        private int idDisciplina;
        private string nome_disciplina;
        private int aulas_teoricas;
        private int aulas_praticas;
        private int hora_relogio;
        private int numero_credito;
        private int idPeriodo_fk;

        public Disciplina(string nome_disciplina, int aulas_teoricas, int aulas_praticas,
            int hora_relogio, int idPeriodo_fk)
        {
            this.Nome_disciplina = nome_disciplina;
            this.Aulas_teoricas = aulas_teoricas;
            this.Aulas_praticas = aulas_praticas;
            this.Hora_relogio = hora_relogio;
            this.IdPeriodo_fk = idPeriodo_fk;
        }

        public int IdDisciplina
        {
            get
            {
                return idDisciplina;
            }

            set
            {
                idDisciplina = value;
            }
        }

        public string Nome_disciplina
        {
            get
            {
                return nome_disciplina;
            }

            set
            {
                nome_disciplina = value;
            }
        }

        public int Aulas_teoricas
        {
            get
            {
                return aulas_teoricas;
            }

            set
            {
                aulas_teoricas = value;
            }
        }

        public int Aulas_praticas
        {
            get
            {
                return aulas_praticas;
            }

            set
            {
                aulas_praticas = value;
            }
        }

        public int Hora_relogio
        {
            get
            {
                return hora_relogio;
            }

            set
            {
                hora_relogio = value;
            }
        }

        public int IdPeriodo_fk
        {
            get
            {
                return idPeriodo_fk;
            }

            set
            {
                idPeriodo_fk = value;
            }
        }

        public int Numero_credito
        {
            get
            {
                return numero_credito;
            }

            set
            {
                numero_credito = value;
            }
        }
    }
}