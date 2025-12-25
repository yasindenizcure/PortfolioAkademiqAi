using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents
{
    public class _DefaultPortfolioComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultPortfolioComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Projects.OrderByDescending(x=>x.ProjectId).ToList();
            return View(values);
        }
    }
}
