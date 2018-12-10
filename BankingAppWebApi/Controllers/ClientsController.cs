using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingApp.Classes;
using BankingApp.Data;
using BankingApp.UI;
using Microsoft.AspNetCore.Mvc;

namespace BankingAppWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        // GET api/clients
        [HttpGet]
        public ActionResult<IEnumerable<Client>> Get()
        {
            return new Client[0];
        }

        // GET api/clients/5
        [HttpGet("{id}")]
        public ActionResult<Client> Get(long id)
        {
            var data = new ClientData();
            data.clientId = id;
            return new EmployeeActions().FindIndividualClient(data);
        }

        // POST api/clients
        [HttpPost]
        public long Post([FromBody] PersonData data)
        {
           return new EmployeeActions().CreateIndividualClient(data).ClientId;
        }

        // PUT api/clients/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/clients/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
