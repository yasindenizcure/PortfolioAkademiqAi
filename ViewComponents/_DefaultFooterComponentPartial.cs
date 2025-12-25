using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public _DefaultFooterComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Contacts.ToList();
            return View(values);
        }
    }
}
