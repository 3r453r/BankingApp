using CdcSoftware.Pivotal.Applications.Core.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdDbContext
{
    public class ContextServiceTask : AbstractApplicationServerTask
    {
        public ContextServiceTask()
        {            
        }

        private ContextFactory contextFactory;
        protected Entities Context
        {
            get
            {
                if (contextFactory == null)
                {
                    string edmxConnectionString = $@"metadata=res://*/EdModel.csdl|res://*/EdModel.ssdl|res://*/EdModel.msl;provider=System.Data.SqlClient;provider connection string=""{SystemServer.DatabaseInformation.EDConnectionString}; multipleactiveresultsets = True; application name = EntityFramework""";
                    contextFactory = new ContextFactory(edmxConnectionString);
                }
                return contextFactory.GetContext();
            }
        }

    }
}
