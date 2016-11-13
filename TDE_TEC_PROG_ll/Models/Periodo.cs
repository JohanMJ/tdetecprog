using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TDE_TEC_PROG_ll.Models
{
    public class Periodo
    {
        private int idPeriodo;
        private int numero_periodo;
        private int idCurso_fk;

        public Periodo(int numero_periodo, int idCurso_fk)
        {
            this.Numero_periodo = numero_periodo;
            this.IdCurso_fk = idCurso_fk;
        }

        public int IdPeriodo
        {
            get
            {
                return idPeriodo;
            }

            set
            {
                idPeriodo = value;
            }
        }

        public int Numero_periodo
        {
            get
            {
                return numero_periodo;
            }

            set
            {
                numero_periodo = value;
            }
        }

        public int IdCurso_fk
        {
            get
            {
                return idCurso_fk;
            }

            set
            {
                idCurso_fk = value;
            }
        }
    }
}