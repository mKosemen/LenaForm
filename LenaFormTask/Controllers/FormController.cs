using DataLayer.Context;
using EntityLayer.Classes;
using LenaFormTask.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace LenaFormTask.Controllers
{
	public class FormController : Controller
	{
		private readonly ProjectContext _projectContext;

		public FormController(ProjectContext projectContext)
		{
			_projectContext = projectContext;
		}


		public async Task<IActionResult> Main()
		{
			List<Form> forms = _projectContext.Forms.ToList();
			List<LoginMember> loginMembers = _projectContext.LoginMembers.ToList();
			ViewData["forms"] = forms;
			TempData["member"] = loginMembers;

			return View();
		}

		[HttpPost]
		public ActionResult AddForm(Form form)
		{
			if (form.Name != null)
			{
				form.CreatedAt = DateTime.Now;
				form.CreatedBy = (int)TempData["Id"];
				_projectContext.Add(form);
				_projectContext.SaveChanges();
				return RedirectToAction("Main");
			}

			return RedirectToAction("Main");
		}


		public IActionResult DeleteForm(Guid id)
		{
			var form = _projectContext.Forms.Find(id);
			return View(form);
		}

		[HttpPost]
		public async Task<IActionResult> DeleteForm(Form form)
		{
			var updateform = _projectContext.Forms.Find(form.Id);

			_projectContext.Forms.Remove(updateform);
			_projectContext.SaveChanges();
			return RedirectToAction("Main");
		}

		public IActionResult UpdateForm(Guid id)
		{
			var form = _projectContext.Forms.Find(id);
			return View(form);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateForm(Form form)
		{
			var updateform = _projectContext.Forms.Find(form.Id);

			updateform.Name = form.Name;
			updateform.Description = form.Description;
			updateform.CreatedAt = DateTime.Now;

			_projectContext.Forms.Update(updateform);
			_projectContext.SaveChanges();

			return RedirectToAction("Main");
		}

	}
}
