// System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
// Custom
using RESTFirst.Models;
using RESTFirst.Services;

namespace RESTFirst.Controllers
{
    public class ContactController : ApiController
    {
        protected ContactRepository _ContactRepository;

        public ContactController()
        {
            this._ContactRepository = new ContactRepository();
        }

        public Contact[] Get()
        {
            return this._ContactRepository.GetAllContacts();
        }
    }
}
