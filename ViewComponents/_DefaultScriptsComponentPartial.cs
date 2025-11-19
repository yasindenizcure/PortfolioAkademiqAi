using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents
{
    public class _DefaultScriptsComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
