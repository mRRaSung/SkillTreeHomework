using SkillTreeHomework.ViewModels.Home;
using System;
using System.Web.Mvc;

namespace SkillTreeHomework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();

            Random random = new Random();
            ViewModels.Home.Type type;
            int amount = 0;
            DateTime date = new DateTime(2015, 8, 24);

            for(int idx = 0; idx < 100; idx++)
            {
                type = (ViewModels.Home.Type)random.Next(1, 3);
                amount = random.Next(1, 99999);
                date = date.AddDays(random.Next(30));

                model.BillingDatas.Add(new BillingData() {
                    Type = type,
                    Date = date,
                    Amount = amount });
            }

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