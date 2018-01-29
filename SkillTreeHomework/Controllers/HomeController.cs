using SkillTreeHomework.Models;
using SkillTreeHomework.Repositories;
using SkillTreeHomework.ViewModels.Home;
using System.Linq;
using System.Web.Mvc;

namespace SkillTreeHomework.Controllers
{
    public class HomeController : Controller
    {
        private readonly AccountBookService _serviceAccountBook;

        public HomeController()
        {
            var unitOfWork = new EFUnitOfWork();
            _serviceAccountBook = new AccountBookService(unitOfWork);
        }

        public ActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();

            _serviceAccountBook.LookUp().ToList().ForEach(x =>
            {
                model.BillingDatas.Add(new BillingData()
                {
                    Type = (Type)(x.Categoryyy + 1),
                    Date = x.Dateee,
                    Amount = x.Amounttt
                });
            });

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}