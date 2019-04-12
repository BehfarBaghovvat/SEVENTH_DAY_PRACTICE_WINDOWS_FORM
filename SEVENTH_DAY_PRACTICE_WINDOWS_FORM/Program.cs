using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEVENTH_DAY_PRACTICE_WINDOWS_FORM
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>

		public static Message.MessagesBoxForm MessageBoxForm;
		public static Form1 Form1;

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			MessageBoxForm = new Message.MessagesBoxForm();
			Form1 = new Form1();

			Application.Run(new Form1());
		}
	}
}
