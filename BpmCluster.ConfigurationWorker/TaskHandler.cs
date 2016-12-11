using System;
using System.Threading.Tasks;

namespace BpmCluster.MessageQueuing.Worker
{

	using BpmCluster.MessageQueuing.Messages;
	using NServiceBus;
	public class TaskHandler : IHandleMessages<WorkerTask>
	{

		public Task Handle(WorkerTask message, IMessageHandlerContext context) {
			throw new NotImplementedException();
		}

	}
}
