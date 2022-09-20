using Microsoft.Extensions.DependencyInjection;
using State_PM.Commands;
using System;
using System.Threading.Tasks;
using TheProcessManager;
using TheProcessManager.Coordinators;
using TheProcessManager.Models;

namespace State_PM
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            services.AddProcessManager();
            var sp = services.BuildServiceProvider();

            var coordinator = sp.GetRequiredService<IProcessManagerCoordinator>();
            var cashMashine = await coordinator.Publish(new CreateCashMashine() { AvailableCash = 2000 });

            var cashMashineId = cashMashine.Data.ID;

            var card = new Card
            {
                ID = Guid.NewGuid(),
                Pin = "1111"
            };

            /*await coordinator.Publish(new EjectCard()
            {
                ID = cashMashineId
            });

            await coordinator.Publish(new InsertCard()
            {
                Card = card,
                ID = cashMashineId
            });

            await coordinator.Publish(new InsertPin()
            {
                Pin = "8888",
                ID = cashMashineId
            });*/

            await coordinator.Publish(new InsertCard()
            {
                Card = card,
                ID = cashMashineId
            });

            await coordinator.Publish(new InsertPin()
            {
                Pin = "1111",
                ID = cashMashineId
            });

            await coordinator.Publish(new WithdrawCash()
            {
                Amount = 2000,
                ID = cashMashineId
            });

            /*await coordinator.Publish(new EjectCard()
            {
                ID = cashMashineId
            });*/

        }


    }
}
