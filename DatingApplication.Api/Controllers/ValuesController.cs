using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApplication.Api.Data;
using DatingApplication.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;

        }
        [HttpPost]
        public async Task<IActionResult> SaveValues()
        {
            var NewEntity = new Value() { Name = "Kayode"};
              await _context.AddAsync(NewEntity);
                _context.SaveChanges();
            
             var AnotherEntity = new Value() { Name = "Oluwaseun"};
              await _context.AddAsync(AnotherEntity);
                _context.SaveChanges();
            return Ok();
        }  

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
           var entity = await _context.Values.ToListAsync();
           return Ok(entity);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        // [HttpPost]
        // public void Post([FromBody] string value)
        // {
        // }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
