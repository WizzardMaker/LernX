using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LernX {
	static class Timing {
		public class AlertEventArgs : EventArgs{
			public bool didAbort = false;

			public AlertEventArgs(bool didAbort) {
				this.didAbort = didAbort;
			}
		}

		public class TickStateCheck {
			private DateTime lastIntervall;

			public void Set() {
				lastIntervall = DateTime.Now;
			}

			public bool HasMissedTime(DateTime goal) {
				return lastIntervall < goal && lastIntervall < DateTime.Now && goal < DateTime.Now;
			}
		}

		public delegate void OnNextAlert(AlertEventArgs args);
	
		static DateTime nextAlert;
		public static OnNextAlert onNextAlert;

		static void ResetAlert(AlertEventArgs args) {
			nextAlert = nextAlert.AddDays(1);
		}

		public static void Prepare(DateTime nextDueTime, OnNextAlert alert) {
			if(nextDueTime < DateTime.Now) {
				throw (new ArgumentException($"nextDueTime can not be in the past! nextDueTime {nextDueTime} < {DateTime.Now}"));
			}
			nextAlert = nextDueTime;

			Timer t = new Timer(Tick,new TickStateCheck(),0,1000);
			onNextAlert += ResetAlert;
			onNextAlert += alert;
		}

		public static void ForcePrepare(DateTime nextDueTime, OnNextAlert alert) {
			if (nextDueTime < DateTime.Now) {
				nextDueTime = nextDueTime.AddDays(1);
			}

			Prepare(nextDueTime, alert);
		}

		private static void Tick(object state) {
			TickStateCheck tick = (TickStateCheck)state;

			if (tick.HasMissedTime(nextAlert) && DateTime.Now.Second == nextAlert.Second) {
				onNextAlert?.Invoke(new AlertEventArgs(false));
			}

			tick.Set();
		}
	}
}
