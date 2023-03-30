using DataLayer.Context;
using EntityLayer.Classes;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayer.SeedData
{
	public class DataSeeding
	{

		public static void Seed(IApplicationBuilder app)
		{
			using (var serviceScope = app.ApplicationServices.CreateScope())
			{
				var context = serviceScope.ServiceProvider.GetService<ProjectContext>();
				context.Database.EnsureCreated();

				if (!context.LoginMembers.Any())
				{
					context.LoginMembers.AddRange(
						new List<LoginMember>() {
						 new LoginMember() { Name="Murat", Surname="Kösemen", Age = 30, UserName = "mKosemen", Password = "kosemen54" },
						 new LoginMember() { Name="Elif", Surname="Kösemen", Age = 29, UserName = "eKosemen", Password = "kosemen33" },
						 new LoginMember() { Name="Ahmet", Surname="Sağıroğlu", Age = 29, UserName = "aSagir", Password = "sagir38" },
						 new LoginMember() { Name="Selim", Surname="Yalman", Age = 31, UserName = "sYalman", Password = "yalman16" },
						 new LoginMember() { Name="Meltem", Surname="Yalman", Age = 29, UserName = "mYalman", Password = "yalman44" }
						});
					context.SaveChanges();
				}

				if (!context.Forms.Any())
				{
					context.Forms.AddRange(
						new List<Form>() {
						 new Form() { Name="SeedForm1", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 1},
						 new Form() { Name="SeedForm2", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 2},
						 new Form() { Name="SeedForm3", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 3},
						 new Form() { Name="SeedForm4", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 4},
						 new Form() { Name="SeedForm5", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 5},
						 new Form() { Name="SeedForm6", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 1},
						 new Form() { Name="SeedForm7", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 2},
						 new Form() { Name="SeedForm8", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 3},
						 new Form() { Name="SeedForm9", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 4},
						 new Form() { Name="SeedForm10", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 5},
						 new Form() { Name="SeedForm11", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 1},
						 new Form() { Name="SeedForm12", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 2},
						 new Form() { Name="SeedForm13", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 3},
						 new Form() { Name="SeedForm14", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 4},
						 new Form() { Name="SeedForm15", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 5},
						 new Form() { Name="SeedForm16", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 1},
						 new Form() { Name="SeedForm17", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 2},
						 new Form() { Name="SeedForm18", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 3},
						 new Form() { Name="SeedForm19", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 4},
						 new Form() { Name="SeedForm20", Description="Bu Form SeedData olarak oluşturuldu.", CreatedAt = DateTime.Now, CreatedBy = 5}
						});
					context.SaveChanges();
				}

			}
		}
	}
}

