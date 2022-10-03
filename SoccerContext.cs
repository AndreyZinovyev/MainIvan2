using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Main
{
    
 
class SoccerContext : DbContext
    {
        public SoccerContext()
        : base("DefaultConnection")
        { }

        public DbSet<docx> docx { get; set; }
       
    }
}
