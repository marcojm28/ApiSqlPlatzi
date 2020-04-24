using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PlatzisqlAzure.Models;

namespace PlatzisqlAzure.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        private readonly ContactContext contactContext;

        public ContactController(ContactContext context)
        {
            contactContext = context;
        }

        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return contactContext.GetContacts.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Contact> Get(int id)
        {
            var SelectedContact = (from c in contactContext.GetContacts
                                  where c.Id == id
                                  select c).FirstOrDefault();
            return SelectedContact;
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Contact value)
        {
            Contact contact = value;
            contactContext.GetContacts.Add(contact);
            contactContext.SaveChanges();
            return Ok("Contacto Agregado");
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        ~ContactController()
        {
            contactContext.Dispose();
        }

    }
}
