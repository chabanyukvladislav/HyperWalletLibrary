using System.Collections.Generic;
using System.Threading.Tasks;
using Server.Api;
using Server.Database;
using Server.Database.DatabaseContext;
using Server.Database.Model;

namespace Server.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IDatabaseWorker<Payment> _databaseWorker;
        private readonly IApiWorker<Payment> _apiWorker;

        public PaymentService(Context context)
        {
            _databaseWorker = new PaymentDatabaseWorker(context);
            _apiWorker = new PaymentApiWorker();
        }

        public async Task<List<Payment>> Get()
        {
            List<Payment> list = await _databaseWorker.GetAsync();
            return list;
        }

        public async Task<Payment> Get(string id)
        {
            Payment payment = await _databaseWorker.GetAsync(id);
            return payment;
        }

        public async Task<bool> Post(Payment value)
        {
            Payment payment = await _apiWorker.PostAsync(value);
            if (payment == null)
                return false;
            bool result = await _databaseWorker.PostAsync(payment);
            return result;
        }
    }
}
