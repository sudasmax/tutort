using System.Data.Entity.Migrations;
using System.Linq;
using Tutort.Web.Database;
using Tutort.Web.Database.Cakes.Biscuit;

namespace Tutort.Web.Identity
{
	internal sealed class Migration : DbMigrationsConfiguration<ApplicationDbContext>
	{
		public Migration()
		{
			AutomaticMigrationsEnabled = true;
			AutomaticMigrationDataLossAllowed = true;

			ContextKey = "Tutort.Web.Identity.DatabaseContext";
		}

		protected override void Seed(ApplicationDbContext context)
		{
			base.Seed(context);

			this.CakesSeed(context);

			// Cultures
			//context.Cultures.RemoveRange(context.Cultures);
			//context.Cultures.AddOrUpdate(x => x.Id,
			//	new Culture { Value = "ru" },
			//	new Culture { Value = "en"});

			//context.SaveChanges();

			//var ruId = context.Cultures.First(x => x.Value == "ru").Id;

			//context.CultureStrings.RemoveRange(context.CultureStrings);
			//context.CultureStrings.AddOrUpdate(x => x.Id,
			//	new CultureString { CultureId = ruId, Value = "Тестовое значение" });
		}

		private void CakesSeed(ApplicationDbContext context)
		{
			this.BiscuitCakeSeed(context);
		}

		private void BiscuitCakeSeed(ApplicationDbContext context)
		{
			context.BiscuitTypes.RemoveRange(context.BiscuitTypes);
			context.BiscuitTypes.AddOrUpdate(x => x.Id,
				new BiscuitType { Name = "Классический" },
				new BiscuitType { Name = "Ванильный" },
				new BiscuitType { Name = "Шоколадный" },
				new BiscuitType { Name = "\"Красный бархат\"" },
				new BiscuitType { Name = "Пряная морковь" },
				new BiscuitType { Name = "Лимонный" },
				new BiscuitType { Name = "Кокосовый" },
				new BiscuitType { Name = "Ореховый" },
				new BiscuitType { Name = "Маковый" },
				new BiscuitType { Name = "Медовый" });

			context.BiscuitCreamTypes.RemoveRange(context.BiscuitCreamTypes);
			context.BiscuitCreamTypes.AddOrUpdate(x => x.Id,
				new BiscuitCreamType { Name = "Сливочно-сырный крем", Description = "Сливочно-сырный крем на основе сливок и растительного сыра" },
				new BiscuitCreamType { Name = "Шоколадно-сырный крем", Description = "Шоколадно-сырный крем на основе темного шоколада" },
				new BiscuitCreamType { Name = "Шоколадный ганаш" },
				new BiscuitCreamType { Name = "Крем-пломбир" });

			context.BiscuitFillingTypes.RemoveRange(context.BiscuitFillingTypes);
			context.BiscuitFillingTypes.AddOrUpdate(x => x.Id,
				new BiscuitFillingType { Name = "" },
				new BiscuitFillingType { Name = "" },
				new BiscuitFillingType { Name = "" },
				new BiscuitFillingType { Name = "" },
				new BiscuitFillingType { Name = "" },
				new BiscuitFillingType { Name = "" },
				new BiscuitFillingType { Name = "" });

		}
	}
}