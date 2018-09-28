using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Server.Database.DatabaseContext;
using Server.Database.Model;
using Server.Hubs;
using Server.Service;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PaymentsController : ControllerBase
    {
        private readonly IApiService<Payment> _service;
        private readonly IHubContext<NotificationHub> _hub;

        public PaymentsController(Context context, IHubContext<NotificationHub> hub)
        {
            _service = new PaymentService(context);
            _hub = hub;
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
            bool result = await _service.Post(value);
            if (result)
                await _hub.Clients.All.SendAsync("PaymentPost", value);
            return result;
        }
    }
}
