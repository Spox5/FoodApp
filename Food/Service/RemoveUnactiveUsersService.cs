using Food.Data.Repositories;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Food.Service
{
    public class RemoveUnactiveUsersService : IHostedService, IDisposable
    {
        private Timer timer;
        private UserRepository userRepository;

        public RemoveUnactiveUsersService(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void Dispose()
        {
            timer.Dispose();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            timer = new Timer(RemoveUnactiveUsers, null, TimeSpan.FromMinutes(1), TimeSpan.FromHours(1));

            return Task.CompletedTask;
        }

        public void RemoveUnactiveUsers(object state)
        {
            var sevenDaysBeforeDate = DateTime.UtcNow.AddDays(-7);

            userRepository.RemoveUnactiveAndOlderThan(sevenDaysBeforeDate);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            timer.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }
    }
}
