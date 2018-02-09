using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tutort.Web.Models.Security;

namespace Tutort.Web.Database
{
	public class User : DbEntity
	{
		public string Login { get; set; }
		public string Password { get; set; }

		public string Name { get; set; }
		public string Surname { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }

		public Roles Role { get; set; }
	}
}