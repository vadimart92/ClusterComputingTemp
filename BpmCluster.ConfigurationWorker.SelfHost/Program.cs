using System;

namespace BpmCluster.MessageQueuing.Worker.SelfHost
{

	using System.IO;
	using System.Threading.Tasks;
	using Newtonsoft.Json;
	using Nito.AsyncEx;

	class Program
	{

		static void Main(string[] args) {
			AsyncContext.Run(AsyncMain);
		}

		static async Task AsyncMain() {
			using (var worker = new ConfigurationWorker()) {
				var workerSettings = JsonConvert.DeserializeObject<WorkerSettings>(File.ReadAllText("settings.json"));
				await worker.Connect(workerSettings);
				Console.WriteLine("Worker connected and ready to serve...");
				Console.ReadKey(true);
			}
		}
	}
}
