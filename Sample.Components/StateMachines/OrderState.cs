﻿using MassTransit;

namespace Sample.Components.StateMachines
{
    public class OrderState : SagaStateMachineInstance, ISagaVersion
    {
        public Guid CorrelationId { get; set; }
        public string CurrentState { get; set; }
        public string CustomerNumber { get; set; }
        public int Version { get; set; }
        public DateTime? SubmitDate { get; internal set; }
        public DateTime? Updated { get; set; }
    }
}
