namespace Project.Models
{
    public class Kind
    {
        public int Id
        {
            get;
            set;
        }
        public int CategoryId
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        //свойство навигации
        public virtual Сategory Category
        {
            get;
            set;
        }
    }
}