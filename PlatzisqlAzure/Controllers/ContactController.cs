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

        ~ContactController()
        {
            contactContext.Dispose();
        }

    }
}
