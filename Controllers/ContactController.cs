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
        public IActionResult Messages()
        {
            var values = _context.Messages.OrderByDescending(x => x.SendDate).ToList();
            return View(values);
        }
        public IActionResult ChangeMessageStatus(int id)
        {
            var value = _context.Messages.Find(id);
            if (value != null)
            {
                value.IsRead = !value.IsRead;
                _context.SaveChanges();
            }
            return RedirectToAction("Messages");
        }
        public IActionResult DeleteMessage(int id)
        {
            var value = _context.Messages.Find(id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("Messages");
        }
    }
}
