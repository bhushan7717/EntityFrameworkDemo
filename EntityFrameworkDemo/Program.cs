using EntityFrameworkDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			PerformDatabaseOperation();
			Console.WriteLine("Quote of the day");
			Console.WriteLine(" Don't worry about the world coming to an end today... ");
			Console.WriteLine(" It's already tomorrow in Australia.");

			Console.WriteLine();
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		public static void PerformDatabaseOperation()
		{
			using(var db = new BloggingContext())
			{
				db.Blogs.Add(new Blog()
				{
					BlogId = (db.Blogs.Count() + 1),
					Name = "Test Blog " + (db.Blogs.Count() + 1)
				});

				Console.WriteLine("Calling save changes.");
				db.SaveChanges();
				Console.WriteLine("Save changes completed.");

				Console.WriteLine("Executing query.");

				var blogs = (from b in db.Blogs
							 orderby b.BlogId
							 select b).ToList();

				Console.WriteLine("Query completed with following results.");

				foreach (var item in blogs)
				{
					Console.WriteLine(" " + item.Name);
				}
			}
		}
	}
}
