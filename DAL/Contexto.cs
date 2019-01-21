using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }


        public Contexto() : base("ConStr")
        {

        }
    }
}
