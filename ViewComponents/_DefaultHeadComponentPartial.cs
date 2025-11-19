using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents
{
    public class _DefaultHeadComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
