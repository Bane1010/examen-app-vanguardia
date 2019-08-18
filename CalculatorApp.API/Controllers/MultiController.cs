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
    public class MultiController : ControllerBase
    {
        private readonly DataContext _context;
        public MultiController(DataContext context){
            _context = context;
        }
        // GET api/values
        [HttpGet]
          public async Task<ActionResult> Get()
        {
            var multi = await _context.Multis.ToListAsync();
            return Ok(multi); 
        }
        
        // GET api/values/5
        [HttpGet("{id}")]
      
        public async Task<ActionResult> Get(int id)
        {
         var multi = await _context.Multis.FirstOrDefaultAsync(i=> i.Id ==id);
         return Ok(multi);
          
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string multi)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string multi)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
