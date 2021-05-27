using System.Collections.Generic;

namespace Project.Models
{
    public class Сategory
    {
        public int Id
        {
            get;
            set;
        }

        public string ClothingCategory
        {
            get;
            set;
        }

        //свойство навигации
        public virtual IEnumerable<Kind> kindOfClothes
        {
            get;
            set;
        }
    }
}