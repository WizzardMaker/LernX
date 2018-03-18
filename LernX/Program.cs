using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace LernX {
	class Program {
		[STAThread]
		public static void Main() {
			Timing.ForcePrepare(DateTime.Today.AddHours(16), null);

			Application.EnableVisualStyles();
			Application.Run(new QuizMain());
		}
	}
}
