namespace BpmCluster.MessageQueuing.Client {

	using BpmCluster.MessageQueuing.Messages.Common;

	public interface IMessageQueuingClient {

		void Execute<TResult>(ICommand<TResult> command) where TResult : ICommandResult;

		void Publish(IEvent e);

	}

}