namespace BpmCluster.MessageQueuing.Worker.SelfHost
{

	public class WorkerSettings : IConfigurationWorkerSettings
	{

		public string QueueServerConnectionString { get; set;}

		public string EndpointName { get; set; }

		public string ErrorMessagesQueueName { get; set; }

	}

}