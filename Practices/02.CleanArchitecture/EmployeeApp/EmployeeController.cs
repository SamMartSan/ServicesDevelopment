using Microsoft.AspNetCore.Mvc;
using Employee.DAL.Context;
using Employee.BL.BusinessLogic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeBL employeeBL;

        public EmployeesController(AppDbContext dbContext)
        {
            employeeBL = new EmployeeBL(dbContext);
        }
        // GET: api/<EmployeesController>
        [HttpGet]
        public IEnumerable<Entities.Models.Employee> Get()
        {
            return employeeBL.Get();
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public Entities.Models.Employee Get(int id)
        {
            return employeeBL.GetById(id);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public void Post([FromBody] Entities.Models.Employee entity)
        {
            employeeBL.Add(entity);

        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Entities.Models.Employee entity)
        {
            employeeBL.Update(id, entity);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            employeeBL.Delete(id);
        }
    }
}