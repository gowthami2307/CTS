using Microsoft.AspNetCore.Mvc;
using _2_WebApi_Handson.Models;

namespace _2_WebApi_Handson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Rahul", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Sneha", Department = "HR", Salary = 45000 }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult Post(Employee emp)
        {
            employees.Add(emp);
            return Ok("Employee Added Successfully");
        }
    }
}