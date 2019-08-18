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
    public class BitacorasController : ControllerBase
    {
        private readonly DataContext _context;
        public BitacorasController(DataContext context){
            _context = context;
        }
        // GET api/values
        [HttpGet]
          public async Task<ActionResult> Get()
        {
            var bitacoras = await _context.Bitacoras.ToListAsync();
            return Ok(bitacoras); 
        }
        
        // GET api/values/5
        [HttpGet("{id}")]
      
        public async Task<ActionResult> Get(int id)
        {
         var bitacora = await _context.Bitacoras.FirstOrDefaultAsync(i=> i.Id ==id);
         return Ok(bitacora);
          
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string bitacora)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string bitacora)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
