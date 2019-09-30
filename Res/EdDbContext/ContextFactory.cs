using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdDbContext
{
    public class ContextFactory
    {
        private string connectionString;
        public ContextFactory(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Entities GetContext()
        {
            return new Entities(connectionString);
        }
    }
}
