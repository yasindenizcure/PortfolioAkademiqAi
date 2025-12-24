using AkademiQPortfolio.Data;
using AkademiQPortfolio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult SendMessage(Message m)
        {   
            m.SendDate = DateTime.Now;
            _context.Messages.Add(m);
            _context.SaveChanges();

            return RedirectToAction("Index", "Default");
        }
    }
}
