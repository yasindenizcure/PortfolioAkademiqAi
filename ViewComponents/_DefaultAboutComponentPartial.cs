using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents
{
    public class _DefaultAboutComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultAboutComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var aboutlist = _context.Abouts.ToList();
            return View(aboutlist);
        }
    }
}
