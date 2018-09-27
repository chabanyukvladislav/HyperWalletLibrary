using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.Database.DatabaseContext;
using Server.Database.Model;

namespace Server.Database
{
    public class PaymentDatabaseWorker : IDatabaseWorker<Payment>
    {
        private readonly Context _context;

        public PaymentDatabaseWorker(Context context)
        {
            _context = context;
        }

        public async Task<List<Payment>> GetAsync()
        {
            return await Task.Run(() =>
            {
                try
                {
                    return _context.Payments?.ToList();
                }
                catch (Exception)
                {
                    return null;
                }
            });
        }

        public async Task<Payment> GetAsync(string id)
        {
            return await Task.Run(() =>
            {
                try
                {
                    return _context.Payments?.FirstOrDefault(el => el.Id == id);
                }
                catch (Exception)
                {
                    return null;
                }
            });
        }

        public async Task<bool> PostAsync(Payment item)
        {
            return await Task.Run(() =>
            {
                try
                {
                    _context.Payments.Add(item);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            });
        }

        public Task<bool> PutAsync(string id, Payment value)
        {
            return null;
        }
    }
}
