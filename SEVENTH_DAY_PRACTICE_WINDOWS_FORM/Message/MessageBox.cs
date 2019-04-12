namespace SEVENTH_DAY_PRACTICE_WINDOWS_FORM.Message
{
	/// <summary>
	/// The class of the message I made.
	/// </summary>
	public static class MessageBox
	{

		#region Show Message by 1 parametr
		/// <summary>
		/// Message display method with 1 input parameter
		/// </summary>
		/// <param name="text">Text message</param>
		public static void ShowMessage( string text )
		{
			Program.MessageBoxForm.messageBoxLabel.Text = text;

			Program.MessageBoxForm.button1.Hide();
			Program.MessageBoxForm.button2.Text = "Ok";
			Program.MessageBoxForm.button3.Hide();

			Program.MessageBoxForm.ShowDialog();
		}
		#endregion /Show Message by 1 parametr


		#region Show Message by 2 parametr
		/// <summary>
		/// Message display method with 2 input parameter
		/// </summary>
		/// <param name="text">Text message</param>
		/// <param name="caption">Title text</param>
		public static void ShowMessage( string text, string caption )
		{
			Program.MessageBoxForm.messageBoxLabel.Text = text;

			Program.MessageBoxForm.button1.Hide();
			Program.MessageBoxForm.button2.Text = "Ok";
			Program.MessageBoxForm.button3.Hide();



			Program.MessageBoxForm.Text = caption;
			Program.MessageBoxForm.ShowDialog();
		}
		#endregion /Show Message by 2 parametr


		#region Show Message by 3 parametr
		/// <summary>
		/// Message display method with 3 input parameter
		/// </summary>
		/// <param name="text">Text message</param>
		/// <param name="caption">Titel text</param>
		/// <param name="button">The buttons used in the message</param>
		public static void ShowMessage( string text, string caption, Message.MessageBoxButtons buttons )
		{
			Program.MessageBoxForm.messageBoxLabel.Text = text;

			#region Button
			if (buttons == MessageBoxButtons.AbortRetryIgnore)
			{
				Program.MessageBoxForm.button1.Text = "Abort";
				Program.MessageBoxForm.button2.Text = "Retry";
				Program.MessageBoxForm.button3.Text = "Ignor";
			}
			else if (buttons == MessageBoxButtons.Ok)
			{
				Program.MessageBoxForm.button1.Hide();
				Program.MessageBoxForm.button2.Text = "Ok";
				Program.MessageBoxForm.button3.Hide();
			}
			else if (buttons == MessageBoxButtons.OkCancle)
			{
				Program.MessageBoxForm.button1.Text = "Ok";
				Program.MessageBoxForm.button2.Hide();
				Program.MessageBoxForm.button3.Text = "Cancle";
			}
			else if (buttons == MessageBoxButtons.RetryCancel)
			{
				Program.MessageBoxForm.button1.Text = "Retry";
				Program.MessageBoxForm.button2.Hide();
				Program.MessageBoxForm.button3.Text = "Cancle";
			}
			else if (buttons == MessageBoxButtons.YesNo)
			{
				Program.MessageBoxForm.button1.Text = "Yes";
				Program.MessageBoxForm.button2.Hide();
				Program.MessageBoxForm.button3.Text = "No";
			}
			else if (buttons == MessageBoxButtons.YesNoCancle)
			{
				Program.MessageBoxForm.button1.Text = "Yes";
				Program.MessageBoxForm.button2.Text = "No";
				Program.MessageBoxForm.button3.Text = "Cancle";
			}
			#endregion /Button

			Program.MessageBoxForm.Text = caption;
			Program.MessageBoxForm.ShowDialog();
		}
		#endregion /Show Message by 3 parametr


		#region Show Message by 4 parametr
		/// <summary>
		/// Message display method with 4 input parameter
		/// </summary>
		/// <param name="text">Text message</param>
		/// <param name="caption">Titel text</param>
		/// <param name="button">The buttons used in the message</param>
		/// <param name="information">Icon to display the status of the message</param>
		public static void ShowMessage( string text, string caption, Message.MessageBoxButtons buttons, Message.MessageBoxIcons icons )
		{
			Program.MessageBoxForm.messageBoxLabel.Text = text;

			#region Button
			if (buttons == MessageBoxButtons.AbortRetryIgnore)
			{
				Program.MessageBoxForm.button1.Text = "Abort";
				Program.MessageBoxForm.button2.Text = "Retry";
				Program.MessageBoxForm.button3.Text = "Ignor";
			}
			else if (buttons == MessageBoxButtons.Ok)
			{
				Program.MessageBoxForm.button1.Hide();
				Program.MessageBoxForm.button2.Text = "Ok";
				Program.MessageBoxForm.button3.Hide();
			}
			else if (buttons == MessageBoxButtons.OkCancle)
			{
				Program.MessageBoxForm.button1.Text = "Ok";
				Program.MessageBoxForm.button2.Hide();
				Program.MessageBoxForm.button3.Text = "Cancle";
			}
			else if (buttons == MessageBoxButtons.RetryCancel)
			{
				Program.MessageBoxForm.button1.Text = "Retry";
				Program.MessageBoxForm.button2.Hide();
				Program.MessageBoxForm.button3.Text = "Cancle";
			}
			else if (buttons == MessageBoxButtons.YesNo)
			{
				Program.MessageBoxForm.button1.Text = "Yes";
				Program.MessageBoxForm.button2.Hide();
				Program.MessageBoxForm.button3.Text = "No";
			}
			else if (buttons == MessageBoxButtons.YesNoCancle)
			{
				Program.MessageBoxForm.button1.Text = "Yes";
				Program.MessageBoxForm.button2.Text = "No";
				Program.MessageBoxForm.button3.Text = "Cancle";
			}
			#endregion /Button

			#region Icon
			if (icons == MessageBoxIcons.Error)
			{
				Program.MessageBoxForm.iconPictureBox.Image =
					SEVENTH_DAY_PRACTICE_WINDOWS_FORM.Properties.Resources.icons8_error_100;
			}
			else if (icons == MessageBoxIcons.Information)
			{
				Program.MessageBoxForm.iconPictureBox.Image =
					SEVENTH_DAY_PRACTICE_WINDOWS_FORM.Properties.Resources.icons8_info_100;
			}
			else if (icons == MessageBoxIcons.Question)
			{
				Program.MessageBoxForm.iconPictureBox.Image =
					SEVENTH_DAY_PRACTICE_WINDOWS_FORM.Properties.Resources.icons8_help_100;
			}
			else if (icons == MessageBoxIcons.Stop)
			{
				Program.MessageBoxForm.iconPictureBox.Image =
					SEVENTH_DAY_PRACTICE_WINDOWS_FORM.Properties.Resources.icons8_private_100;
			}
			else if (icons == MessageBoxIcons.Warning)
			{
				Program.MessageBoxForm.iconPictureBox.Image =
					SEVENTH_DAY_PRACTICE_WINDOWS_FORM.Properties.Resources.icons8_box_important_100;
			}
			else if (icons == MessageBoxIcons.Prohibited)
			{
				Program.MessageBoxForm.iconPictureBox.Image =
					SEVENTH_DAY_PRACTICE_WINDOWS_FORM.Properties.Resources.icons8_no_entry_100;
			}
			#endregion /Icon

			Program.MessageBoxForm.Text = caption;
			Program.MessageBoxForm.ShowDialog();
		}
		#endregion /Show Message by 4 parametr
	}
}