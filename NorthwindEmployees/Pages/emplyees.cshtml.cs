using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NorthwindEntitiesLib;

namespace NorthwindEmployees.Pages
{
    public class emplyeesModel : PageModel
    {
        private Northwind db;

        public emplyeesModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public IEnumerable<Employee> Employees { get; set; }

        public void OnGet() => Employees = db.Employees.ToArray();
    }
}
