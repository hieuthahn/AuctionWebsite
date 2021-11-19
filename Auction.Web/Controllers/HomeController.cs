using Auction.Services;
using Auction.Web.ViewsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auction.Web.Controllers
{
    public class HomeController : Controller
    {
        AuctionsService service = new AuctionsService();
        public ActionResult Index()
        {
            AuctionsViewModels vModel = new AuctionsViewModels();

            vModel.PageTitle = "Đấu giá trực tuyến";
            vModel.PageDescription = "This is HomePage";

            vModel.AllAuctions = service.GetAllAuctions();
            vModel.PromotedAuctions = service.GetPromotedAuctions();
           

            return View(vModel);
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