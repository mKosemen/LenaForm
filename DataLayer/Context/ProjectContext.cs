using EntityLayer.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataLayer.Context
{
	public class ProjectContext : DbContext
	{
		public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
		{
            
        }

		public DbSet<LoginMember> LoginMembers { get; set; }
		public DbSet<Form> Forms { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

		}
	}
}
