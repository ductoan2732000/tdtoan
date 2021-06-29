using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDTOAN.Model.Base;

namespace northwind_product.API.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class products : ControllerBase
    {
        [HttpGet("pagging_filter")]
        public service_response Get()
        {

            return new service_response();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
