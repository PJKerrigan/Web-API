// System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Custom
using RESTFirst.Models;

namespace RESTFirst.Services
{
    /// <summary>
    /// Simple persistent repository class used in the Microsoft ASP.NET examples
    /// teaching about developing RESTful web-services.
    /// </summary>
    public class ContactRepository
    {
        private const string CacheKey = "ContactStore";

        /// <summary>
        /// Constructor.
        /// </summary>
        public ContactRepository()
        {
            var context = HttpContext.Current;

            if (context != null)
            {
                if (context.Cache[CacheKey] == null)
                {
                    var contacts = new Contact[]
                    {
                        new Contact
                        {
                            Id = 1,
                            Name = "Glenn Block"
                        },
                        new Contact
                        {
                            Id = 2, 
                            Name = "Dan Roth"
                        }
                    };

                    context.Cache[CacheKey] = contacts;
                }
            }
        }

        /// <summary>
        /// Gets all contacts. Does not, currently, require an SQL database.
        /// </summary>
        /// <returns></returns>
        public Contact[] GetAllContacts()
        {
            var context = HttpContext.Current;

            if (context != null)
            {
                return (Contact[])context.Cache[CacheKey];
            }

            return new Contact[] 
            {
                new Contact 
                {
                    Id = 0,
                    Name = "Place Holder"
                }
            };
        }
    }
}