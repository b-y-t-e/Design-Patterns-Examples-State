using System;
using System.Collections.Generic;
using System.Text;
using TheProcessManager.Events;

namespace State_PM.Commands
{
    public class InsertCard : IProcessManagerEvent
    {
        public Guid ID { get; set; }
        public Card Card { get; set; }
    }
}
