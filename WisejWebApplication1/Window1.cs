
using System;
using Wisej.Web;

namespace WisejWebApplication1
{
	/// <summary>
	/// A visible Window in the browser.
	/// </summary>
	public partial class MainWindow : Form
	{
		public MainWindow()
		{ 
			InitializeComponent();
		}

		// event handler for Form / Window initialization.
		private void Window1_Load(object sender, EventArgs e)
		{
			// create a new TextBox with a label.
			var textBox = new TextBox { LabelText = "Enter your email" };

			// create a new Button with some text.
			var button = new Button { Text = "Sign up" };

			// create a "success" label.
			var label = new Label();

			// attach to the button's click event.
			button.Click += (se, ev) =>
			{
				label.Text = $"Welcome: {textBox.Text}";
			};

			// add the controls to the view.
			this.flexLayoutPanel.Controls.AddRange(new Control[] { textBox, button, label });
		}
	}
}
