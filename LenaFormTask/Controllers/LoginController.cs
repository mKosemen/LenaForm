using DataLayer.Context;
using EntityLayer.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Web;

namespace LenaFormTask.Controllers
{
	public class LoginController : Controller
	{
		private readonly ProjectContext _projectContext;

		public LoginController(ProjectContext projectContext)
		{
			_projectContext = projectContext;
		}

		const string SessionUser = "_Name";
		const string SessionUserId = "_Id";

		[HttpGet]
		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(LoginMember user)
		{
			if (user.UserName == null || user.Password == null)
			{
				ModelState.AddModelError("", "Kullanıcı adı ve parola alanları boş bırakılamaz.");
				return View(user);
			}

			var loginUser = _projectContext.LoginMembers.FirstOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);
			if (loginUser != null)
			{
				HttpContext.Session.SetString(SessionUser, loginUser.Name+" "+loginUser.Surname);
				HttpContext.Session.SetInt32(SessionUserId, loginUser.Id);

				return RedirectToAction("Main", "Form");
			}
			else
			{
				ModelState.AddModelError("", "Kullanıcı adınız ya da parolanız hatalı.");
				return View(user);
			}
		}

		public ActionResult Logout()
		{
			//HttpContext.Session.Clear();
			return RedirectToAction("Login", "Login");
		}
	}
}