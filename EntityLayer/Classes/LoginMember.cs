using EntityLayer.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLayer.Classes
{
	public class LoginMember : Member
	{
		[Display(Name = "Kullanıcı Adı")]
		public string UserName { get; set; }

		[Display(Name = "Parola")]
		public string Password { get; set; }
	}
}
