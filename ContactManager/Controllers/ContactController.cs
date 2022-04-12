using ContactManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext context { get; set; }

        public ContactController(ContactContext ctx) => context = ctx;

        public IActionResult Index()
        {
            List<Contact> contacts = context.Contacts.OrderBy(i => i.ContactId).ToList();
            return View(contacts);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Contact());
        }

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            ViewBag.Action = "Add";
            if (ModelState.IsValid)
            {
                context.Contacts.Add(contact);
                context.SaveChanges();
                return RedirectToAction("Details", "Home");
            }
            else
            {
                return View(contact);
            }
        }

    }
}