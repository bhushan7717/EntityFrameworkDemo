using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.Data
{
	class MyConfiguration : DbConfiguration
	{
		public MyConfiguration()
		{
			SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
			SetDefaultConnectionFactory(new LocalDbConnectionFactory("mssqllocaldb"));
		}
	}
}
