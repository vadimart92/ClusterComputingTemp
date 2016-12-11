namespace BpmCluster.MessageQueuing.Client.Tests {

	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.IO;
	using NUnit.Framework;

	[TestFixture]
	public class MessageQueuingClientTestCase {

		private readonly List<Process> _workers = new List<Process>();
		private readonly string _currentDir = Path.GetDirectoryName(new Uri(typeof(MessageQueuingClientTestCase).Assembly.CodeBase).LocalPath);
		private void StartWorker() {
			var startInfo = new ProcessStartInfo("BpmCluster.MessageQueuing.Worker.SelfHost.exe") {
				WorkingDirectory = _currentDir
			};
			Process worker = Process.Start(startInfo);
			_workers.Add(worker);
		}

		[SetUp]
		public void Setup() {
			StartWorker();
		}

		[TearDown]
		public void TearDown() {
			foreach (Process process in _workers) {
				if (!process.HasExited) {
					process.Kill();
				}
			}
		}

		[Test]
		public void Execute_ExecutesCodeOnWorkers() {
			
		}

	}
}
