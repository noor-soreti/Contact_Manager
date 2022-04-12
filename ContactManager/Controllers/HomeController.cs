using Microsoft.AspNetCore.Mvc;
using ContactManager.Models;

namespace ContactManager.Controllers;

public class HomeController : Controller
{
    private  ContactContext context;

    public HomeController(ContactContext ctx) => context = ctx;

    public IActionResult Details(int id)
    {
        ViewBag.Action = "";
        List<Contact> contacts = context.Contacts.OrderBy(i => i.ContactId).ToList();
        return View(contacts);
    }

}

