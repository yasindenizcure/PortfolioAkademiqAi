using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents
{
    public class _DefaultContactComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultContactComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Contacts.FirstOrDefault();
            return View(values);
        }
    }
}
