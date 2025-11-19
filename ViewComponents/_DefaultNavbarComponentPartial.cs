using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents
{
    public class _DefaultNavbarComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
