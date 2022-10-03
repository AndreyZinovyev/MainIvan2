using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Main
{
  class TestConnect: DbContext
    {
        public TestConnect()
        : base("Test")
        { }

        public DbSet<Test>Test { get; set; }
    }
}
