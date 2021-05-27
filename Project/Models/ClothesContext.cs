using System.Data.Entity;

namespace Project.Models
{
    public class ClothesContext:DbContext
    {
        public DbSet<Сategory> Сategories
        {
            get;
            set;
        }

        public DbSet<Kind> Clothes
        {
            get;
            set;
        }
    }
}