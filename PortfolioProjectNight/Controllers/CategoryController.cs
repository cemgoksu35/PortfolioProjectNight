using System.Web;
using System.Web.Mvc;

namespace PortfolioProjectNight.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public int MyProperty { get; set; }
        

        public ActionResult CategoryList()
        {
             
            return View();
        }
        public ActionResult CreateCategory()
        {
            return View();
        }


    }
}