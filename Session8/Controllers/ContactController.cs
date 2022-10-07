using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session8.Interfaces;
using Session8.Models;

namespace Session8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult AllContacts()
        {
            return Ok(_contactService.GetAllContacts());
        }

        [HttpGet]
        public IActionResult GetContact(Guid id)
        {
            Contact contact = _contactService.GetContact(id);
            if (contact != null){
                return Ok(contact);
            }
            return NotFound();
        }
    }
}
