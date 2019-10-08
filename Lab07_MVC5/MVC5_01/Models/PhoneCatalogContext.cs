using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC5_01.Models
{
    public class PhoneCatalogContext : DbContext
    {        
            public DbSet<PhoneCatalog> PhoneCatalogs { get; set; }

    }
}