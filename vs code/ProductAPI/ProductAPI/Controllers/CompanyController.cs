using FirstAPIProj.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstAPIProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly companyContext _db;
        public CompanyController(companyContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeTable>>> getEmployeeDetails()
        {
            return Ok(await _db.EmployeeTables.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeTable>> getEmployee(int id)
        {
            return  await _db.EmployeeTables.FindAsync(id);

        }


        [HttpPost]
        public async Task<ActionResult> AddEmployee([FromBody] EmployeeTable E)
        {
            if (ModelState.IsValid)
            {
                _db.EmployeeTables.Add(E);
                await _db.SaveChangesAsync();
            }
            if (E == null)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> EditEmployee(int id, EmployeeTable e)
        {
            _db.EmployeeTables.Update(e);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteEmployee(int? id)
        {
            if (id == null)
                return NotFound();
            EmployeeTable e = await _db.EmployeeTables.FindAsync(id);
            _db.Remove(e);
            _db.SaveChanges();
            return Ok();
        }
    }
}
