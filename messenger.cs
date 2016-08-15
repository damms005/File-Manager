using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_manager
{
	public partial class messenger : Form
	{
		public DialogResult answer;
		public string query;

		public messenger()
		{
			InitializeComponent();
		}

		private void iTalk_Button_yes_Click( object sender, EventArgs e )
		{
			answer = DialogResult.Yes;
			this.Close();
		}

		private void iTalk_Button_no_Click( object sender, EventArgs e )
		{
			answer = DialogResult.No;
			this.Close();
		}

		private void messenger_Load( object sender, EventArgs e )
		{
			textBox_query.Text = query;
		}
	}
}
