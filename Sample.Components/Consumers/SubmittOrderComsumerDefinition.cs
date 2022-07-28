using MassTransit;

namespace Sample.Components.Consumers
{
    public class SubmittOrderComsumerDefinition:ConsumerDefinition<SubmitOrderConsumer>
    {

        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<SubmitOrderConsumer> consumerConfigurator)
        {
            //Configuring middlewear
            endpointConfigurator.UseMessageRetry(r => r.Intervals(3,1000));
            endpointConfigurator.UseInMemoryOutbox();
        }

    }
}
