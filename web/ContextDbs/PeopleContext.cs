using System;
using System.Data.Entity;
using web.Models;
using MySql.Data.Entity;
using System.Data.Common; // For DbConnection - add ref System.Data

namespace web.ContextDbs
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class PeopleContext : DbContext 
	{
		public PeopleContext ()  : base("connStr")
		{
		}

		public PeopleContext (DbConnection existingConnection, bool contextOwnsConnection)
			: base(existingConnection, contextOwnsConnection)
		{

		}


		public DbSet <Person> People { get; set;}
	}
}

