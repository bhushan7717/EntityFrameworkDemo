using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.Data
{
	
	class BloggingContext : DbContext
	{
		public BloggingContext() : base("BlogConn")
		{

		}


		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Post> Posts { get; set; }

		public DbSet<User> users { get; set; }
		public DbSet<Passport> passports { get; set; }

		public DbSet<Department> departments { get; set; }
	}

	public class Blog
	{
		public int BlogId { get; set; }
		public string Name { get; set; }
		public string Url { get; set; }

		public string Auther { get; set; }

		public virtual List<Post> Posts { get; set; }
	}

	public class Post
	{
		public int PostId { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }

		public int BlogId { get; set; }

		public virtual Blog Blog { get; set; }
	}

	public class User
	{
		[Key]
		public string UserName { get; set; }
		public string Password { get; set; }
	}

	public class Passport
	{
		[Key]
		[Column(Order = 1)]
		public int PassportNumber { get; set; }
		[Key]
		[Column(Order = 2)]
		public string IssuingCountry { get; set; }
		public DateTime IssuedDate { get; set; }
		public DateTime Expires { get; set; }
	}
	// use of enum
	public enum DepartmentNames
	{
		English,
		Maths,
		Economics
	}

	public class Department
	{
		[Key]
	     public int DeptId { get; set; }
		public DepartmentNames departmentNames { get; set; }
		public decimal budget { get; set; }
	}

}
