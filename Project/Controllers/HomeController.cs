using Project.Models;
using System.Linq;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        // создаем поле - контекст данных
        ClothesContext db = new ClothesContext();

        public ActionResult Index()
        {
            return View(db.Сategories);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [HttpGet]
        public ActionResult Kind(int id)
        {
            var allkind = db.Clothes.Where(k => k.CategoryId == id).ToList();
            if (allkind.Count <= 0)
            {
                return HttpNotFound();
            }
            return PartialView(allkind);
        }
    }
}