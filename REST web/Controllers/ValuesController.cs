﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_web_app.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {
        //GET api/values
        public IEnumerable<string> Get() {
            return new string[] { "value1", "value2" };
        }
        //Get api/values/5
        public string Get(int id) {
            return "value";
        }
        //POST api/values
        public void Post([FromBody] string value) {

        }
        //PUT api/values/5
        public void Put(int id, [FromBody] string value) {

        }
        //DELETE api/values/5
        public void Delete(int id) {

        }
    }
}
