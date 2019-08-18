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
    public class RestasController : ControllerBase
    {
        private readonly DataContext _context;
        public RestasController(DataContext context){
            _context = context;
        }
        // GET api/values
        [HttpGet]
          public async Task<ActionResult> Get()
        {
            var resta = await _context.Restas.ToListAsync();
            return Ok(resta); 
        }
        
        // GET api/values/5
        [HttpGet("{id}")]
      
        public async Task<ActionResult> Get(int id)
        {
         var resta = await _context.Restas.FirstOrDefaultAsync(i=> i.Id ==id);
         return Ok(resta);
          
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string resta)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string resta)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
