using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTSearch.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTSearch.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly BloggingContext _context;
        public ValuesController(BloggingContext context)
        {
               _context = context;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            _context.Blogs.Add(new Blog
            {
                Url = "sa"
            });
            _context.SaveChanges();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
