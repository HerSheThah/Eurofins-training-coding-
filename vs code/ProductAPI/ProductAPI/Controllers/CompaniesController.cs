using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstAPIProj.Models;

namespace FirstAPIProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly companyContext _context;

        public CompaniesController(companyContext context)
        {
            _context = context;
        }

        // GET: api/Companies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeTable>>> GetEmployeeTables()
        {
            return await _context.EmployeeTables.ToListAsync();
        }

        // GET: api/Companies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeTable>> GetEmployeeTable(int id)
        {
            var employeeTable = await _context.EmployeeTables.FindAsync(id);

            if (employeeTable == null)
            {
                return NotFound();
            }

            return employeeTable;
        }

        // PUT: api/Companies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeTable(int id, EmployeeTable employeeTable)
        {
            if (id != employeeTable.Empid)
            {
                return BadRequest();
            }

            _context.Entry(employeeTable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeTableExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(employeeTable);
        }

        // POST: api/Companies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmployeeTable>> PostEmployeeTable(EmployeeTable employeeTable)
        {
            _context.EmployeeTables.Add(employeeTable);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmployeeTableExists(employeeTable.Empid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmployeeTable", new { id = employeeTable.Empid }, employeeTable);
        }

        // DELETE: api/Companies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeTable(int id)
        {
            var employeeTable = await _context.EmployeeTables.FindAsync(id);
            if (employeeTable == null)
            {
                return NotFound();
            }

            _context.EmployeeTables.Remove(employeeTable);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeTableExists(int id)
        {
            return _context.EmployeeTables.Any(e => e.Empid == id);
        }
    }
}
