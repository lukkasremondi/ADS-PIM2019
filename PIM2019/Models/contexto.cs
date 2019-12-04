using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PIM2019.Models
{
    public class contexto: DbContext
    {
        public DbSet<Veiculos>Veiculo { get; set; }
    }
}