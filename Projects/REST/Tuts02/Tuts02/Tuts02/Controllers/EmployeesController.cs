using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Tuts02.Models;

namespace Tuts02.Controllers
{
    public class EmployeesController : ApiController
    {
        private static IList<Employee> _EmployeeList = new List<Employee>()
        {
            new Employee() { Id = 1, FirstName = "Paul", LastName = "Kerrigan" },
            new Employee() { Id = 2, FirstName = "", LastName = "" },
            new Employee() { Id = 3, FirstName = "", LastName = "" }
        };
    }
}
