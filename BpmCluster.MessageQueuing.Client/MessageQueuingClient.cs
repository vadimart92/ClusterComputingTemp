namespace BpmCluster.MessageQueuing.Client
{
	using Messages.Common;

	public class MessageQueuingClient : IMessageQueuingClient {

		public void Execute<TResult>(ICommand<TResult> command) where TResult : ICommandResult {
			
		}

		public void Publish(IEvent e) {}
	}

}
