namespace SEVENTH_DAY_PRACTICE_WINDOWS_FORM
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click( object sender, System.EventArgs e )
		{
			Message.MessageBox.ShowMessage(text: "پیام من",caption:"تست پنجره پیغام",
				buttons:Message.MessageBoxButtons.OkCancle,
				icons: Message.MessageBoxIcons.Information);
		}

		private void button1_Click( object sender, System.EventArgs e )
		{
			System.Windows.Forms.MessageBox.Show(text: "Sytem Message", caption: "Show Message",
				buttons: System.Windows.Forms.MessageBoxButtons.OKCancel,
				icon: System.Windows.Forms.MessageBoxIcon.Information);
		}
	}
}
