namespace BpmCluster.MessageQueuing.Worker
{
	public interface IConfigurationWorkerSettings
	{
		string QueueServerConnectionString { get; }
		string EndpointName { get; }
		string ErrorMessagesQueueName { get; }
	}

}