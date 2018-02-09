using System;
using System.Data.Entity;
using Tutort.Web.Database.Cakes;
using Tutort.Web.Database.Cakes.Biscuit;
using Tutort.Web.Database.Cakes.Honey;
using Tutort.Web.Database.Zefir;

namespace Tutort.Web.Identity
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext()
			: base("DefaultConnection")
		{
		}

		#region Cakes

		public virtual DbSet<Cake> Cakes { get; set; }

		#region Biscuit Cakes

		public virtual DbSet<BiscuitType> BiscuitTypes { get; set; }
		public virtual DbSet<BiscuitCreamType> BiscuitCreamTypes { get; set; }
		public virtual DbSet<BiscuitFillingType> BiscuitFillingTypes { get; set; }
		public virtual DbSet<BiscuitCake> BiscuitCakes { get; set; }

		#endregion

		public virtual DbSet<HoneyCake> HoneyCakes { get; set; }

		#endregion

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			this.OnCakesCreating(modelBuilder);
			this.OnZefirCreating(modelBuilder);
		}

		private void OnCakesCreating(DbModelBuilder modelBuilder)
		{
			#region Biscuit Cakes

			modelBuilder.Entity<BiscuitCake>().HasRequired(x => x.Cake)
				.WithRequiredPrincipal(x => x.BiscuitCake);

			modelBuilder.Entity<BiscuitCake>().HasMany(x => x.BiscuitTypes).WithMany(x => x.BiscuitCakes);
			modelBuilder.Entity<BiscuitCake>().HasMany(x => x.BiscuitCreamTypes).WithMany(x => x.BiscuitCakes);
			modelBuilder.Entity<BiscuitCake>().HasMany(x => x.BiscuitFillingTypes).WithMany(x => x.BiscuitCakes);

			#endregion

			#region Honey Cakes

			modelBuilder.Entity<HoneyCake>().HasRequired(x => x.Cake)
				.WithRequiredPrincipal(x => x.HoneyCake);

			#endregion
		}

		private void OnZefirCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Zefir>().HasRequired(x => x.Tasty).WithMany(x => x.ZefirCollection);
		}
	}
}