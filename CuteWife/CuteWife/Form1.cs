using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuteWife;

namespace CuteWife
{
	public partial class Form1 : Form
	{
		CuteWife wife;

		public Form1()
		{
			wife = new CuteWife("A", "B");

			InitializeComponent();
			Feeling.Text = wife.Feeling();
		}

		private void Control_Click(object sender, EventArgs e)
		{
			Button feeling = (Button)sender;

			switch (feeling.Text)
			{
				case "Hug":
					wife.Hug();
					Feeling.Text = wife.Feeling();
					break;
				case "Kiss":
					wife.Kiss();
					Feeling.Text = wife.Feeling();
					break;
				case "Feed":
					wife.Feed();
					Feeling.Text = wife.Feeling();
					break;
			}
		}

		private void Board_Tick(object sender, EventArgs e)
		{
			wife.GetBoard();
			Feeling.Text = wife.Feeling();
		}
	}
}
