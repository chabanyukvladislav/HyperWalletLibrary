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
        private readonly IDatabaseWorker<User> _databaseWorker;
        private readonly IApiWorker<User> _apiWorker;

        private bool Stoped { get; set; }

        public UpdateDatabaseTask()
        {
            string connectionString = @"Data Source=VLAD191100\VLAD191100;Database=HyperWallet;User ID=vlad191100;Password=Vlad18201111;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DbContextOptionsBuilder<Context> options = new DbContextOptionsBuilder<Context>();
            options.UseSqlServer(connectionString);
            Context context = new Context(options.Options);
            _databaseWorker = new UserDatabaseWorker(context);
            _apiWorker = new UserApiWorker();
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
            List<User> api = await _apiWorker.GetAsync();
            List<User> database = await _databaseWorker.GetAsync();
            foreach (User user in api)
            {
                User search = database.FirstOrDefault(el => el.Token == user.Token);
                if (search == null)
                {
                    await _databaseWorker.PostAsync(user);
                    continue;
                }

                await _databaseWorker.PutAsync(search.Id, user);
            }
        }
    }
}
