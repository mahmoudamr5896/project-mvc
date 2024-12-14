using Demo.Models;
using Demo.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace Demo.Controllers
{
    public class DepartmentController : Controller

    {      //  ITI_ENTITY context = new ITI_ENTITY();
        IDepartmentRepository Departments= new DepartmentRepository();

        [Authorize]
        public IActionResult index()
        {
            List<Department> departments = Departments.Getall();
            return View("index",departments);
        }
    }
}
