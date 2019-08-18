using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitacoraApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BitacoraApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExponencialController : ControllerBase
    {
        private readonly DataContext _context;
        public ExponencialController(DataContext context){
            _context = context;
        }
        // GET api/values
        [HttpGet]
          public async Task<ActionResult> Get()
        {
            var exponencial = await _context.Exponencials.ToListAsync();
            return Ok(exponencial); 
        }
        
        // GET api/values/5
        [HttpGet("{id}")]
      
        public async Task<ActionResult> Get(int id)
        {
         var exponencial = await _context.Exponencials.FirstOrDefaultAsync(i=> i.Id ==id);
         return Ok(exponencial);
          
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string exponencial)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string exponencial)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
