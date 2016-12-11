using System;

namespace BpmCluster.MessageQueuing.Worker
{

	using System.Threading.Tasks;
	using NServiceBus;

	public class ConfigurationWorker: IDisposable
	{

		private IEndpointInstance _endpointInstance;

		public async Task Connect(IConfigurationWorkerSettings settings) {
			var endpointConfiguration = new EndpointConfiguration(settings.EndpointName);
			var transport = endpointConfiguration.UseTransport<RabbitMQTransport>();
			transport.ConnectionString(settings.QueueServerConnectionString);
			transport.PrefetchCount(1);

			endpointConfiguration.SendFailedMessagesTo(settings.ErrorMessagesQueueName);
			endpointConfiguration.UseSerialization<JsonSerializer>();
			endpointConfiguration.EnableInstallers();
			endpointConfiguration.UsePersistence<InMemoryPersistence>();

			_endpointInstance = await Endpoint.Start(endpointConfiguration).ConfigureAwait(false);
		}

		public void Dispose() {
			_endpointInstance.Stop().Wait();
		}

	}
}
