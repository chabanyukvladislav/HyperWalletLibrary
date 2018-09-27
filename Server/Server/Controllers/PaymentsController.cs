using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Database.DatabaseContext;
using Server.Database.Model;
using Server.Service;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PaymentsController : ControllerBase
    {
        private readonly IApiService<Payment> _service;

        public PaymentsController(Context context)
        {
            _service = new PaymentService(context);
        }

        [HttpGet]
        public async Task<List<Payment>> Get()
        {
            return await _service.Get();
        }
        
        [HttpGet("{id}")]
        public async Task<Payment> Get(string id)
        {
            return await _service.Get(id);
        }
        
        [HttpPost]
        public async Task<bool> Post([FromBody] Payment value)
        {
            return await _service.Post(value);
        }
    }
}
