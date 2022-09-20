using System;
using TheProcessManager.Events;

namespace State_PM.Commands
{
    public class EjectCard : IProcessManagerEvent
    {
        public Guid ID { get; set; }
    }
}
