using BusinessLayer.Concreate;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebCV.Viewcomponents.Home
{
    public class Portfolio: ViewComponent
    {

        PortfolioManager portfolioManager = new PortfolioManager(new EFPortfolioDAL());

        public IViewComponentResult Invoke()
        {
            var list = portfolioManager.TGetAllCount(12);

            return View(list);
        }
    }
}
