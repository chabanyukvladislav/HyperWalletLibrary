using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Server.Api;
using Server.Database.DatabaseContext;
using Server.Database.Model;

namespace Server.Database
{
    public class UpdateDatabaseTask : IHostedService
    {
        private const int SLEEP = 60 * 60 * 1000;
        private readonly IDatabaseWorker<User> _databaseUserWorker;
        private readonly IDatabaseWorker<Payment> _databasePaymentWorker;
        private readonly IApiWorker<User> _apiUserWorker;
        private readonly IApiWorker<Payment> _apiPaymentWorker;

        private bool Stoped { get; set; }

        public UpdateDatabaseTask()
        {
            string connectionString = @"Data Source=VLAD191100\VLAD191100;Database=HyperWallet;User ID=vlad191100;Password=Vlad18201111;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DbContextOptionsBuilder<Context> options = new DbContextOptionsBuilder<Context>();
            options.UseSqlServer(connectionString);
            Context context = new Context(options.Options);
            _databaseUserWorker = new UserDatabaseWorker(context);
            _apiUserWorker = new UserApiWorker();
            _databasePaymentWorker = new PaymentDatabaseWorker(context);
            _apiPaymentWorker = new PaymentApiWorker();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Stoped = false;
                while (!Stoped)
                {
                    UpdateDatabase();
                    Thread.Sleep(SLEEP);
                }
            });
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Stoped = true;
            });
        }

        private async void UpdateDatabase()
        {
            List<User> userApi = await _apiUserWorker.GetAsync();
            List<Payment> paymentApi = await _apiPaymentWorker.GetAsync();
            List<User> userDatabase = await _databaseUserWorker.GetAsync();
            List<Payment> paymentDatabase = await _databasePaymentWorker.GetAsync();
            foreach (User user in userApi)
            {
                User search = userDatabase.FirstOrDefault(el => el.Token == user.Token);
                if (search == null)
                {
                    await _databaseUserWorker.PostAsync(user);
                    continue;
                }

                await _databaseUserWorker.PutAsync(search.Id, user);
            }
            foreach (Payment user in paymentApi)
            {
                Payment search = paymentDatabase.FirstOrDefault(el => el.Token == user.Token);
                if (search == null)
                    await _databasePaymentWorker.PostAsync(user);
            }
        }
    }
}
