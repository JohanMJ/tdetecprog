using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TDE_TEC_PROG_ll.Dao
{
    public abstract class Dao
    {
        protected SqlConnection conexao;
        protected SqlDataReader leitor;
        protected SqlCommand comando;

        public Dao()
        {
            this.conexao = new SqlConnection(@"Data Source=DESKTOP-PP69BLK\SQLEXPRESS; " +
                                        "Initial Catalog=parcial_ii; Integrated Security=true;");
        }
    }
}