using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents.AdminLayoutViewComponents
{
    public class _AdminLayoutSidebarMessageCountPartial: ViewComponent
    {
        private readonly AppDbContext _context;

        public _AdminLayoutSidebarMessageCountPartial(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var messageCountByIsReadFalse = _context.Messages.Where(x => x.IsRead == false).Count();
            return View(messageCountByIsReadFalse);
        }
    }
}
