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
    public class RaizController : ControllerBase
    {
        private readonly DataContext _context;
        public RaizController(DataContext context){
            _context = context;
        }
        // GET api/values
        [HttpGet]
          public async Task<ActionResult> Get()
        {
            var raiz = await _context.Raiz_.ToListAsync();
            return Ok(raiz); 
        }
        
        // GET api/values/5
        [HttpGet("{id}")]
      
        public async Task<ActionResult> Get(int id)
        {
         var raiz = await _context.Raiz_.FirstOrDefaultAsync(i=> i.Id ==id);
         return Ok(raiz);
          
        }


        // POST api/values
        [HttpPost]
        public void Post([FromBody] string raiz)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string raiz)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
