using System;
using System.Threading.Tasks;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Transfer.Domain.EventsHandler
{
    public class TransferEventHanlder : IEventHandler<TransferCreatedEvent>
    {
        public TransferEventHanlder()
        {
        }

        public Task Handle(TransferCreatedEvent @event)
        {
            return Task.CompletedTask;
        }
    }
}
